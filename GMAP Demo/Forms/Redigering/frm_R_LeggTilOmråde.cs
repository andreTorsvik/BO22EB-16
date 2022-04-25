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
            LastInnTags();
            LastInnFargerMuligheter();

            InitializepointLatLngs();
            lbPunkter.DataSource = pointLatLngs;
            //lbPunkter.DisplayMember = "Kategorinavn";
        }

        private void LastInnTags()
        {
            if (lbTilgjengeligeTags.Items.Count > 0) lbTilgjengeligeTags.Items.Clear();

            HashSet<string> AlleTags = FellesMetoder.FåAlleTags();

            foreach (var item in AlleTags)
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

        private void btnLeggTilOmrådeIDb_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text;
            string sikkerhetsklarering = txtSikkerhetsklarering.Text;
            string Kommentar = txtKommentar.Text;
            string Farge = txtfarge.Text;
            int antallPunkter = pointLatLngs.Count;
            int antallTags = lbValgtTags.Items.Count;

            List<string> Tags = new List<string>();
            foreach (var item in lbValgtTags.Items)
            {
                Tags.Add(item.ToString());
            }

            string SjekkFeil = LeggTilOmrådet(navn, sikkerhetsklarering, Kommentar, Farge, antallPunkter, antallTags, Tags);

            if (SjekkFeil != string.Empty) MessageBox.Show(SjekkFeil);

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
                    DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
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

        private string LeggTilOmrådet(string navn, string sikkerhetsklarering, string Kommentar, string Farge, int AntallPunkter, int AntallTags, List<string> Tags)
        {
            string feilmelding = string.Empty;

            string utFyllingsmangler = Tekstbehandling.SjekkInntastetData_Område(navn, sikkerhetsklarering, Kommentar, Farge, AntallPunkter, AntallTags);

            if (utFyllingsmangler == string.Empty)
            {
                string FeilTallSjekk = Tekstbehandling.sjekkSikkerhetsKlarering(sikkerhetsklarering);

                if (FeilTallSjekk == string.Empty)
                {
                    //Hentløpenummer
                    var løpenummer = DBComOmråde.GetLøpenummer_område();
                    int Løpenummer_område = Convert.ToInt32(løpenummer[0]);

                    //Laste opp området til database
                    try
                    {
                        DBComOmråde.InsertOmrådeToDb(Løpenummer_område, navn, InnloggetBruker.BrukernavnInnlogget, Convert.ToInt32(sikkerhetsklarering), Kommentar, Farge);
                    }
                    catch (Exception feil) 
                    {
                        feilmelding += feil.Message;
                    }

                    //Legge til hvert punkt
                    try
                    {
                        int rekkefølge = 0;
                        foreach (var item in pointLatLngs)
                        {
                            float lat = Convert.ToSingle(item.Lat);
                            float lang = Convert.ToSingle(item.Lng);
                            DBComPunkter_område.InsertPunkter_områdetToDb(Løpenummer_område, lat, lang, rekkefølge);
                            rekkefølge++;
                        }
                    }
                    catch (Exception feil) 
                    {
                        feilmelding += feil.Message;
                    }

                    //Legge til hver tag tags
                    try
                    {
                        foreach (var item in Tags)
                        {
                            DBComTag_Område.InsertTag_OmrådeToDb(item.ToString(), Løpenummer_område);
                        }
                    }
                    catch (Exception feil ) 
                    {
                        feilmelding += feil.Message;
                    }


                    //Slete innhold
                    TømeTekstfeltOgLister();

                    //fjerne "hjelpe" markører 
                    Kart.FjernAlleMarkører_redigier("MarkørForOmråde");

                    //legge til de nye området på kartet 
                    Kart.OppdaterListe_området();
                    Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
                }
                else MessageBox.Show(FeilTallSjekk);
            }
            else MessageBox.Show(utFyllingsmangler);

            return feilmelding;
        }
        private void TømeTekstfeltOgLister()
        {
            //tekstfelt
            txtNavn.Text = "";
            txtSikkerhetsklarering.Text = "";
            txtKommentar.Text = "";
            txtfarge.Text = "";
            txtLat.Text = "Dobbelklikk på kartet + \"legg til\"";
            txtLong.Text = "Dobbelklikk på kartet + \"legg til\"";

            //lister
            lbValgtTags.Items.Clear();
            lbTilgjengeligeTags.Items.Clear();
            LastInnTags();
            pointLatLngs.Clear();
            txtNrPunkt.Text = pointLatLngs.Count.ToString();
        }
    }
}
