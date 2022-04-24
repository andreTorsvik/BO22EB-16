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
        public List<string> LGamleTag = new List<string>();
        string tekstLatLong = "Dobbelklikk på kartet + \"legg til\"";

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
            LastInnTags();
            LastInnFargerMulighet();
            InitializepointLatLngs();
            lbPunkter.DataSource = pointLatLngs;

            LabelSikkerhetsklarering.Text = string.Format("Sikkerhetsklarering(1-{0})", frmVisning.instance.MaxSikkerhetsklarering);
        }

        private void LastInnTags()
        {
            if (lbTilgjengeligeTags.Items.Count > 0) lbTilgjengeligeTags.Items.Clear();

            HashSet<string> AlleTag = FellesMetoder.FåAlleTags();

            foreach (var item in AlleTag)
            {
                lbTilgjengeligeTags.Items.Add(item);
            }

            lbTilgjengeligeTags.Sorted = true;
        }
        private void LastInnFargerMulighet()
        {
            foreach (var val in Enum.GetValues(typeof(Kart.MuligeFarger)))
            {
                lbTilgjengligFarge.Items.Add(val);
            }

            lbTilgjengligFarge.Sorted = true;
        }

        private void lbTilgjengeligeTags_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengeligeTags.SelectedItem.ToString();

            lbValgtTags.Items.Add(selectedItemtext);

            lbTilgjengeligeTags.Items.Remove(selectedItemtext);

            lbValgtTags.Sorted = true;
        }

        private void lbValgtTags_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbValgtTags.SelectedItem.ToString();

            lbTilgjengeligeTags.Items.Add(selectedItemtext);

            lbValgtTags.Items.Remove(selectedItemtext);
        }

        private void lbTilgjengligFarge_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengligFarge.SelectedItem.ToString();

            txtfarge.Text = selectedItemtext;
        }

        private void btnLeggTilTag_Click(object sender, EventArgs e)
        {
            string NyTag = "";
            NyTag = txtNyTag.Text;

            if (!string.IsNullOrEmpty(NyTag))
            {
                lbTilgjengeligeTags.Items.Add(NyTag);
                lbTilgjengeligeTags.Sorted = true;
                txtNyTag.Text = "";
            }
        }

        private void btnLagreEndring_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text;
            string sikkerhetsklarering = txtSikkerhetsklarering.Text;
            string Kommentar = txtKommentar.Text;
            string Farge = txtfarge.Text;
            int antallPunkter = pointLatLngs.Count;
            int antallTags = lbValgtTags.Items.Count;

            List<string> NyTags = new List<string>();
            foreach (var item in lbValgtTags.Items)
            {
                NyTags.Add(item.ToString());
            }

            string SjekkFeil = RedigerOmrådet(Løpenummer_til_redigering, navn, sikkerhetsklarering, Kommentar, Farge, antallPunkter, antallTags, LGamleTag, NyTags);

            if (SjekkFeil != string.Empty) MessageBox.Show(SjekkFeil);
        }

        private void btnLeggTilPunkt_Click(object sender, EventArgs e)
        {
            if ((txtLat.Text != null) && (txtLong.Text != null) && (txtLat.Text != tekstLatLong))
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

                    txtLat.Text = tekstLatLong;
                    txtLong.Text = tekstLatLong;
                    txtNrPunkt.Text = pointLatLngs.Count.ToString();
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
                txtNrPunkt.Text = pointLatLngs.Count.ToString();
            }
        }

        private string RedigerOmrådet(int Løpenummer,string navn, string sikkerhetsklarering, string Kommentar, string Farge, int AntallPunkter, int AntallTags, List<string> GamleTags, List<string> NyTags)
        {
            string feilmelding = string.Empty;

            string utFyllingsmangler = Tekstbehandling.SjekkInntastetData_Område(navn, sikkerhetsklarering, Kommentar, Farge, AntallPunkter, AntallTags);

            if (utFyllingsmangler == string.Empty)
            {
                var Lområde = DatabaseCommunication.ListOmrådeFromDb(Løpenummer);
                string FeilTallSjekk = Tekstbehandling.sjekkSikkerhetsKlarering(sikkerhetsklarering);

                if (FeilTallSjekk == string.Empty)
                {
                    //legge til alle punktene 
                    List<PointLatLng> pList = new List<PointLatLng>();
                    foreach (var item in pointLatLngs)
                    {
                        pList.Add(item);
                    }

                    string Endring = Tekstbehandling.SjekkEndringerOmråde(Lområde, navn, sikkerhetsklarering, Kommentar, Farge, pList, LGamleTag, NyTags);
                    string enderingIPunkter = Tekstbehandling.sammenlignPunkter(Lområde, pList);
                    if (Endring != string.Empty)
                    {
                        string caption = "Vil du lagre disse endringene ";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        result = MessageBox.Show(Endring, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                //Oppdtaer info 
                                DatabaseCommunication.UpdateOmråde(Løpenummer_til_redigering, navn, Convert.ToInt32(sikkerhetsklarering), Kommentar, Farge);


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

                                List<string> SjekkOmNye1 = NyTags.Except(LGamleTag).ToList();
                                List<string> SjekkOmNye2 = LGamleTag.Except(NyTags).ToList();

                                if (SjekkOmNye1.Count != 0 || SjekkOmNye2.Count != 0)
                                {
                                    //SLETTE ALLE TAGS KNYTTET TIL RESSURS 
                                    DatabaseCommunication.DeleteTags_Område(Løpenummer_til_redigering);
                                    //LEGGE TIL NYE
                                    foreach (var item in lbValgtTags.Items)
                                    {
                                        DatabaseCommunication.InsertTag_OmrådeToDb(item.ToString(), Løpenummer_til_redigering);
                                    }
                                }
                                //Da har alt gått igjennom og endringene lagret 
                                
                            }
                            catch (Exception Feilmelding)
                            {
                                feilmelding = Feilmelding.Message;
                            }

                            //Oppdatere Liste med ressurser 
                            Løpenummer_til_redigering = -1;

                            TømeTekstFeltOgLister();


                            Kart.OppdaterListe_området();
                            Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
                        }
                    }
                    else MessageBox.Show("Ingen Endring");
                }
                else MessageBox.Show(FeilTallSjekk);
            }
            else MessageBox.Show(utFyllingsmangler);

            return feilmelding;
        }

        private void TømeTekstFeltOgLister()
        {   
            //tekstfelt
            txtNavn.Text = "";
            txtKommentar.Text = "";
            txtfarge.Text = "";
            txtSikkerhetsklarering.Text = "";
            txtLat.Text = tekstLatLong;
            txtLong.Text = tekstLatLong;

            //lister
            lbValgtTags.Items.Clear();
            lbTilgjengeligeTags.Items.Clear();
            LastInnTags();
            pointLatLngs.Clear();
            txtNrPunkt.Text = pointLatLngs.Count.ToString(); 
        }
    }
        
}
