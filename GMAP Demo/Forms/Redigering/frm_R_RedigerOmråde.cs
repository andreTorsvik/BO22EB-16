using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;

namespace GMAP_Demo
{
    public partial class frm_R_RedigerOmråde : Form
    {
        public static frm_R_RedigerOmråde instance;
        public int Løpenummer_til_redigering;
        public frm_R_RedigerOmråde()
        {
            InitializeComponent();
            instance = this;
        }
        public BindingList<PointLatLng> pointLatLngs;
        private void InitializepointLatLngs()
        {
            // Create the new BindingList of Part type.
            pointLatLngs = new BindingList<PointLatLng>();

            // Allow new parts to be added, but not removed once committed.        
            pointLatLngs.AllowNew = true;
            pointLatLngs.AllowRemove = true;

            // Raise ListChanged events when new parts are added.
            pointLatLngs.RaiseListChangedEvents = true;
        }

        private void frm_R_RedigerOmråde_Load(object sender, EventArgs e)
        {
            LastInnOverlays();
            LastInnFargerMulighet();
            InitializepointLatLngs();
            lbPunkter.DataSource = pointLatLngs;

            LabelSikkerhetsklarering.Text = string.Format("Sikkerhetsklarering(1-{0})", frmVisning.instance.MaxSikkerhetsklarering);
        }

        private void LastInnOverlays()
        {
            HashSet<string> AlleOverlay = new HashSet<string>();

            var OverlayOListe = DatabaseCommunication.ListAllOverlay_OmrådeFromDb();

            foreach (var item in OverlayOListe)
            {
                AlleOverlay.Add(item.Kategori.ToString());
            }

            var OverlayRListe = DatabaseCommunication.ListAllOverlay_RessursFromDb();

            foreach (var item in OverlayRListe)
            {
                AlleOverlay.Add(item.Kategori.ToString());
            }

            foreach (var item in AlleOverlay)
            {
                lbTilgjengeligeOverlays.Items.Add(item);
            }
            lbTilgjengeligeOverlays.Sorted = true;
        }
        private void LastInnFargerMulighet()
        {
            foreach (var val in Enum.GetValues(typeof(Kart.MuligeFarger)))
            {
                lbTilgjengligFarge.Items.Add(val);
            }
            lbTilgjengligFarge.Sorted = true;
        }

        private void lbTilgjengeligeOverlays_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengeligeOverlays.SelectedItem.ToString();

            lbValgtOverlays.Items.Add(selectedItemtext);

            lbTilgjengeligeOverlays.Items.Remove(selectedItemtext);

            lbValgtOverlays.Sorted = true;
        }

        private void lbValgtOverlays_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbValgtOverlays.SelectedItem.ToString();

            lbTilgjengeligeOverlays.Items.Add(selectedItemtext);

            lbValgtOverlays.Items.Remove(selectedItemtext);
        }

        private void lbTilgjengligFarge_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengligFarge.SelectedItem.ToString();

            txtfarge.Text = selectedItemtext;
        }

        private void btnLeggTilOverlay_Click(object sender, EventArgs e)
        {
            string NyOverlay = "";
            NyOverlay = txtNyOverlay.Text;

            if (!string.IsNullOrEmpty(NyOverlay))
            {

            }
        }

        private void btnLagreEndring_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text;
            string sikkerhetsklarering = txtSikkerhetsklarering.Text;
            string Kommentar = txtKommentar.Text;
            string Farge = txtfarge.Text;
            int antallPunkter = pointLatLngs.Count;
            int antallOverlays = lbValgtOverlays.Items.Count;

            string utFyllingsmangler = Tekstbehandling.SjekkInntastetData_Område(navn, sikkerhetsklarering, Kommentar, Farge, antallPunkter, antallOverlays);

            if (utFyllingsmangler == string.Empty)
            {
                var Lområde = DatabaseCommunication.ListOmrådeFromDb(Løpenummer_til_redigering);
                string FeilTallSjekk = Tekstbehandling.sjekkSikkerhetsKlarering(sikkerhetsklarering);

                if (FeilTallSjekk == string.Empty)
                {
                    //legge til alle punktene 
                    List<PointLatLng> pList = new List<PointLatLng>();
                    foreach (var item in pointLatLngs)
                    {
                        pList.Add(item);
                    }

                    string Endring = Tekstbehandling.SjekkEndringerOmråde(Lområde, navn, sikkerhetsklarering, Kommentar, Farge,pList,antallOverlays);
                    string enderingIPunkter = Tekstbehandling.sammenlignPunkter(Lområde, pList);
                    if (Endring != string.Empty)
                    {
                        string caption = "Vil du lagre disse endringene ";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        result = MessageBox.Show(Endring, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            //Oppdtaer info 
                            DatabaseCommunication.UpdateOmråde(Løpenummer_til_redigering, navn, Convert.ToInt32(sikkerhetsklarering), Kommentar,Farge);

                            
                            if (enderingIPunkter != string.Empty)
                            {
                                //SLETTE ALLE punlter KNYTTET TIL området 
                                DatabaseCommunication.DeletePunkter_området(Løpenummer_til_redigering);
                                //LEGGE TIL NYE punkter
                                int rekkefølge = 0;
                                foreach (var item in pList)
                                {
                                    float lat = Convert.ToSingle(item.Lat);
                                    float lang = Convert.ToSingle(item.Lng);
                                    DatabaseCommunication.InsertPunkter_områdetToDb(Løpenummer_til_redigering, lat, lang, rekkefølge);
                                    rekkefølge++;
                                }
                            }

                            //Oppdatere Liste med ressurser 
                            Løpenummer_til_redigering = -1;
                            txtNavn.Text = "";
                            //txtKategori.Text = "";
                            txtKommentar.Text = "";
                            txtfarge.Text = "";
                            txtSikkerhetsklarering.Text = "";
                            txtLat.Text = "Dobbelklikk på kartet";
                            txtLong.Text = "Dobbelklikk på kartet";
                            txtNrPunkt.Text = "0";
                            Kart.OppdaterListe_området();
                            Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LRessurs, GlobaleLister.LOmråde);

                        }
                    }
                    else MessageBox.Show("Ingen Endring");
                }
                else MessageBox.Show(FeilTallSjekk);
            }
            else MessageBox.Show(utFyllingsmangler);
        }

        private void btnLeggTilPunkt_Click(object sender, EventArgs e)
        {
            if ((txtLat.Text != null) && (txtLong.Text != null) && (txtLat.Text != "Dobbelklikk på kartet + \"legg til\""))
            {
                try
                {
                    double lat = Convert.ToDouble(txtLat.Text);
                    double lng = Convert.ToDouble(txtLong.Text);
                    int rekkefølge = pointLatLngs.Count;
                    PointLatLng point = new PointLatLng(lat, lng);

                    pointLatLngs.Add(point);

                    Kart.LeggtilMarkør(Kart.MuligKart.Redigering, point, rekkefølge, "MarkørForOmråde");
                    Kart.FjernAlleMarkører_redigier("HjelpeMarkør");
                    Kart.reff(Kart.MuligKart.Redigering);

                    txtLat.Text = "Dobbelklikk på kartet + \"legg til\"";
                    txtLong.Text = "Dobbelklikk på kartet + \"legg til\"";
                    txtNrPunkt.Text = (pointLatLngs.Count).ToString();
                }
                catch (Exception feilmelding)
                {
                    DatabaseCommunication.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                }
            }
        }

        private void btnFjernPunktIListe_Click(object sender, EventArgs e)
        {
            if (pointLatLngs.Count > 0)
            {
                Kart.FjernAlleMarkører_redigier("MarkørForOmråde");
                pointLatLngs.Clear();
                txtNrPunkt.Text = "0";
            }
        }
    }
}
