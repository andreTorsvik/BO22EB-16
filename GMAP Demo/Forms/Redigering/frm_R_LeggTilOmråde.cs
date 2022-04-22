using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class frm_R_LeggTilOmråde : Form
    {
        public int FjernMakør;
        //public List<Markør> lMakør = new List<Markør>();
        public static frm_R_LeggTilOmråde instance;
        public frm_R_LeggTilOmråde()
        {
            InitializeComponent();
            instance = this;
        }
        // Opprette liste av punkter for område
        BindingList<PointLatLng> pointLatLngs;
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

        private void frm_R_LeggTilOmråde_Load(object sender, EventArgs e)
        {
            LastInnOverlays();
            LastInnFargerMuligheter();

            InitializepointLatLngs();
            lbPunkter.DataSource = pointLatLngs;
            //lbPunkter.DisplayMember = "Kategorinavn";
        }

        private void LastInnOverlays()
        {
            if (lbTilgjengeligeTags.Items.Count > 0) lbTilgjengeligeTags.Items.Clear();

            HashSet<string> AlleOverlay = new HashSet<string>();
            var OverlayOListe = DatabaseCommunication.ListAllOverlay_OmrådeFromDb();

            foreach (var item in OverlayOListe)
            {
                AlleOverlay.Add(item.Tag.ToString());
            }
            var OverlayRListe = DatabaseCommunication.ListAllOverlay_RessursFromDb();
            foreach (var item in OverlayRListe)
            {
                AlleOverlay.Add(item.Tag.ToString());
            }
            foreach (var item in AlleOverlay)
            {
                lbTilgjengeligeTags.Items.Add(item);
            }
            lbTilgjengeligeTags.Sorted = true;
        }

        private void LastInnFargerMuligheter()
        {
            foreach (var val in Enum.GetValues(typeof(Kart.MuligeFarger)))
            {
                lbTilgjengligFarge.Items.Add(val);
            }
            lbTilgjengligFarge.Sorted = true;
        }
        private void lbTilgjengeligeOverlays_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengeligeTags.SelectedItem.ToString();

            lbValgtTags.Items.Add(selectedItemtext);

            lbTilgjengeligeTags.Items.Remove(selectedItemtext);

            lbValgtTags.Sorted = true;
        }

        private void lbValgtOverlays_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void btnLeggTilOverlay_Click(object sender, EventArgs e)
        {
            string NyOverlay = "";
            NyOverlay = txtNyTag.Text;

            if (!string.IsNullOrEmpty(NyOverlay))
            {

            }
        }

        private void btnLeggTilOmrådeIDb_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text;
            string sikkerhetsklarering = txtSikkerhetsklarering.Text;
            string Kommentar = txtKommentar.Text;
            string Farge = txtfarge.Text;
            int antallPunkter = pointLatLngs.Count;
            int antallOverlays = lbValgtTags.Items.Count;

            string utFyllingsmangler = Tekstbehandling.SjekkInntastetData_Område(navn, sikkerhetsklarering, Kommentar, Farge, antallPunkter, antallOverlays);

            if (utFyllingsmangler == string.Empty)
            {
                //hentløpenummer
                var løpenummer = DatabaseCommunication.GetLøpenummer_område();
                int Løpenummer_område = Convert.ToInt32(løpenummer[0]);

                //laste opp området til database
                try
                {
                    DatabaseCommunication.InsertOmrådeToDb(Løpenummer_område, txtNavn.Text.ToString(), txtfarge.Text.ToString(), InnloggetBruker.BrukernavnInnlogget, Convert.ToInt32(txtSikkerhetsklarering.Text), txtKommentar.Text.ToString(), txtfarge.Text);
                }
                catch (Exception)
                {

                }

                //Legge til hvert punkt
                try
                {
                    int rekkefølge = 0;
                    foreach (var item in pointLatLngs)
                    {
                        float lat = Convert.ToSingle(item.Lat);
                        float lang = Convert.ToSingle(item.Lng);
                        DatabaseCommunication.InsertPunkter_områdetToDb(Løpenummer_område, lat, lang, rekkefølge);
                        rekkefølge++;
                    }
                }
                catch (Exception)
                {


                }

                //Slete innhold
                txtNavn.Text = "";
                txtSikkerhetsklarering.Text = "";
                txtKommentar.Text = "";
                txtfarge.Text = "";
                txtLat.Text = "Dobbelklikk på kartet + \"legg til\"";
                txtLong.Text = "Dobbelklikk på kartet + \"legg til\"";
                lbValgtTags.Items.Clear();
                lbTilgjengeligeTags.Items.Clear();
                LastInnOverlays();
                pointLatLngs.Clear();
                txtNrPunkt.Text = "0";

                //fjerne "hjelpe" markører 
                Kart.FjernAlleMarkører_redigier("MarkørForOmråde");

                //legge til de nye området på kartet 
                Kart.OppdaterListe_området();
                Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
            }
            else MessageBox.Show(utFyllingsmangler);
        }

        private void btnLeggTilPunktIListe_Click(object sender, EventArgs e)
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
