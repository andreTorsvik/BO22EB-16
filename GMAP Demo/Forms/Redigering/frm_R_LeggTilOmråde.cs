using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class Frm_R_LeggTilOmråde : Form
    {
        public int fjernMakør;
        public static Frm_R_LeggTilOmråde instance;

        public Frm_R_LeggTilOmråde()
        {
            InitializeComponent();
            instance = this;
            SetTheme();
        }

        private void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;

            lblTitle.ForeColor = ThemeDesign.colorOrange;

            gbOmråde.ForeColor = ThemeDesign.colorLabel;
            gbOmråde.BackColor = ThemeDesign.colorBackground;
            lblNavn.ForeColor = ThemeDesign.colorLabel;
            lblSikkerhetsklarering.ForeColor = ThemeDesign.colorLabel;
            lblKommentar.ForeColor = ThemeDesign.colorLabel;
            lblFarge.ForeColor = ThemeDesign.colorLabel;
            lblLat.ForeColor = ThemeDesign.colorLabel;
            lblLong.ForeColor = ThemeDesign.colorLabel;
            txtNavn.ForeColor = ThemeDesign.colorLabel;
            txtNavn.BackColor = ThemeDesign.colorGray;
            txtSikkerhetsklarering.ForeColor = ThemeDesign.colorLabel;
            txtSikkerhetsklarering.BackColor = ThemeDesign.colorGray;
            txtKommentar.ForeColor = ThemeDesign.colorLabel;
            txtKommentar.BackColor = ThemeDesign.colorGray;
            txtfarge.ForeColor = ThemeDesign.colorLabel;
            txtfarge.BackColor = ThemeDesign.colorGray4;
            txtLat.ForeColor = ThemeDesign.colorLabel;
            txtLat.BackColor = ThemeDesign.colorGray;
            txtLong.ForeColor = ThemeDesign.colorLabel;
            txtLong.BackColor = ThemeDesign.colorGray;
            txtNrPunkt.ForeColor = ThemeDesign.colorLabel;
            txtNrPunkt.BackColor = ThemeDesign.colorGray4;
            lbTilgjengligFarge.ForeColor = ThemeDesign.colorLabel;
            lbTilgjengligFarge.BackColor = ThemeDesign.colorGray;
            lbPunkter.ForeColor = ThemeDesign.colorLabel;
            lbPunkter.BackColor = ThemeDesign.colorGray4;
            btnLeggTilPunkt.ForeColor = ThemeDesign.colorLabel;
            btnLeggTilPunkt.BackColor = ThemeDesign.colorGray;
            btnFjernSistepunkt.ForeColor = ThemeDesign.colorLabel;
            btnFjernSistepunkt.BackColor = ThemeDesign.colorGray;
            btnFjernAlle.ForeColor = ThemeDesign.colorLabel;
            btnFjernAlle.BackColor = ThemeDesign.colorGray;

            gbTag.ForeColor = ThemeDesign.colorLabel;
            gbTag.BackColor = ThemeDesign.colorBackground;
            lblVelgTags.ForeColor = ThemeDesign.colorLabel;
            lblEksisterende.ForeColor = ThemeDesign.colorLabel;
            lblValgtForDetteObjektet.ForeColor = ThemeDesign.colorLabel;
            lblNyTag.ForeColor = ThemeDesign.colorLabel;
            lbTilgjengeligeTags.ForeColor = ThemeDesign.colorLabel;
            lbTilgjengeligeTags.BackColor = ThemeDesign.colorGray;
            lbValgtTags.ForeColor = ThemeDesign.colorLabel;
            lbValgtTags.BackColor = ThemeDesign.colorGray;
            txtNyTag.ForeColor = ThemeDesign.colorLabel;
            txtNyTag.BackColor = ThemeDesign.colorGray;
            btnLeggTilTag.ForeColor = ThemeDesign.colorLabel;
            btnLeggTilTag.BackColor = ThemeDesign.colorGray;

            btnLeggTilOmrådetIDb.ForeColor = ThemeDesign.colorLabel;
            btnLeggTilOmrådetIDb.BackColor = ThemeDesign.colorGray;
        }

        // Opprette liste av punkter for område
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

        private void Frm_R_LeggTilOmråde_Load(object sender, EventArgs e)
        {
            LastInnTags();
            LastInnFargerMuligheter();

            InitializepointLatLngs();
            lbPunkter.DataSource = pointLatLngs;
        }

        private void LastInnTags()
        {
            if (lbTilgjengeligeTags.Items.Count > 0) lbTilgjengeligeTags.Items.Clear();

            HashSet<string> AlleTags = FellesMetoder.FåAlleTags();

            foreach (var item in AlleTags)
            {
                lbTilgjengeligeTags.Items.Add(item);
            }
        }

        private void LastInnFargerMuligheter()
        {
            foreach (var val in Enum.GetValues(typeof(Kart.MuligeFarger)))
            {
                lbTilgjengligFarge.Items.Add(val);
            }
        }

        private void LbTilgjengeligeTags_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbTilgjengeligeTags.SelectedIndex != -1)
            {
                string selectedItemtext = lbTilgjengeligeTags.SelectedItem.ToString();

                lbValgtTags.Items.Add(selectedItemtext);

                lbTilgjengeligeTags.Items.Remove(selectedItemtext);
            }

        }

        private void LbValgtTags_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbValgtTags.SelectedIndex != -1)
            {
                string selectedItemtext = lbValgtTags.SelectedItem.ToString();

                lbTilgjengeligeTags.Items.Add(selectedItemtext);

                lbValgtTags.Items.Remove(selectedItemtext);
            }

        }

        private void LbTilgjengligFarge_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbTilgjengligFarge.SelectedIndex != -1)
            {
                string selectedItemtext = lbTilgjengligFarge.SelectedItem.ToString();

                txtfarge.Text = selectedItemtext;
            }
        }

        private void BtnLeggTilTag_Click(object sender, EventArgs e)
        {
            string nyTag = txtNyTag.Text.Trim();

            if (!string.IsNullOrEmpty(nyTag))
            {
                bool sjekk1 = lbTilgjengeligeTags.Items.Contains(nyTag);
                bool sjekk2 = lbValgtTags.Items.Contains(nyTag);

                // Legger til ny tag, hvis den ikke finnes fra før av
                if (!(sjekk1 || sjekk2))
                {                
                    lbTilgjengeligeTags.Items.Add(nyTag);
                }
                txtNyTag.Text = "";
            }
        }

        public void FyllKoordinater(double lat, double lang)
        {
            txtLat.Text = lat.ToString();
            txtLong.Text = lang.ToString();
        }

        private void BtnLeggTilOmrådeIDb_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text.Trim();
            string sikkerhetsklarering = txtSikkerhetsklarering.Text;
            string Kommentar = txtKommentar.Text.Trim();
            string Farge = txtfarge.Text;
            int antallPunkter = pointLatLngs.Count;
            int antallTags = lbValgtTags.Items.Count;
            HashSet<string> Tags = new HashSet<string>( lbValgtTags.Items.Cast<string>().ToList());
            
            // Legger til, om alt stemmer 
            string SjekkFeil = LeggTilOmrådet(navn, sikkerhetsklarering, Kommentar, Farge, antallPunkter, antallTags, Tags);

            if (SjekkFeil != string.Empty) 
                MessageBox.Show(SjekkFeil);


            FellesMetoder.OppdaterTag_Liste();
        }

        private void BtnLeggTilPunktIListe_Click(object sender, EventArgs e)
        {
            if ((txtLat.Text != null) && (txtLong.Text != null) && (txtLat.Text != Globalekonstanter.tekstLatLong_område))
            {
                try
                {
                    // Sjekker om de kan Konverters og returner feilmeldingen hvis ikke
                    string SjekkLat = Tekstbehandling.sjekkLat(txtLat.Text);
                    string SjekkLang = Tekstbehandling.sjekkLong(txtLong.Text);

                    if (SjekkLat == string.Empty && SjekkLang == string.Empty)
                    {
                        // Konverterer
                        double lat = Convert.ToDouble(txtLat.Text);
                        double lng = Convert.ToDouble(txtLong.Text);
                        PointLatLng point = new PointLatLng(lat, lng);

                        // Legger til rekkefølgen
                        int rekkefølge = pointLatLngs.Count;

                        // Legger til punktet i listen 
                        pointLatLngs.Add(point);

                        // Legger til den nye markøren
                        Kart.LeggtilMarkør(Kart.MuligKart.Redigering, point, rekkefølge, Globalekonstanter.NavnMarkørForOmråde);

                        // Fjern den som var på kartet før, hvis den er der
                        Kart.FjernAlleMarkører_redigier(Globalekonstanter.NavnHjelpeMarkør);

                        // Oppdatere kartet
                        Kart.reff(Kart.MuligKart.Redigering);

                        // Tilbakestiller de aktuelle tekstfeltene
                        txtLat.Text = Globalekonstanter.tekstLatLong_område;
                        txtLong.Text = Globalekonstanter.tekstLatLong_område;

                        // Oppdatere antall 
                        txtNrPunkt.Text = (pointLatLngs.Count).ToString();
                    }
                    else
                    {
                        // Viser kun en av feilene, selv hvis det skulle være 2 
                        if (SjekkLang != string.Empty)
                            MessageBox.Show(string.Format("Feil: " + SjekkLang));
                        else
                            MessageBox.Show(string.Format("Feil: " + SjekkLat));
                    }
                }
                catch (Exception feilmelding)
                {
                    DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                }
            }
        }

        private void BtnFjernSistepunkt_Click(object sender, EventArgs e)
        {
            if (pointLatLngs.Count > 0)
            {
                // Kan nå klikke på områder/polygon uten at de hopper in redigeringsformen 
                FrmRediger.instance.cbOmråde.Checked = false;

                // Fjerner Hjelpeområdet og markøren 
                Kart.FjernHjelpeOmråde();
                Kart.FjernAlleMarkører_redigier(Globalekonstanter.NavnMarkørForOmråde);

                // Fjerner punkt fra listen og oppdaterer antall
                pointLatLngs.RemoveAt(pointLatLngs.Count - 1);
                txtNrPunkt.Text = pointLatLngs.Count.ToString();

                List<PointLatLng> PunktListe = pointLatLngs.ToList();

                // Tegner hjelpeområdet på nytt
                if (Kart.SjekkKartHarHjelpemarkør_redigier(Globalekonstanter.NavnHjelpeMarkør))  
                {
                    // Hvis man har dobbeltklikket på kartet
                    Kart.TegnHjelpeOmråde_rediger(FrmRediger.DoubleClick_punkt, PunktListe);
                }
                else 
                {
                    // Hvis man ikke har dobbeltklikket på kartet
                    Kart.TegnHjelpeOmråde_rediger(PunktListe);
                }

                // Markerer hjørnene til området med riktig rekkefølge 
                for (int i = 0; i < (pointLatLngs.Count); i++)
                {
                    Kart.LeggtilMarkør(Kart.MuligKart.Redigering, PunktListe[i], i, Globalekonstanter.NavnMarkørForOmråde); //"MarkørForOmråde"
                }

                // Oppdatere kartet  
                Kart.reff(Kart.MuligKart.Redigering);
            }
        }

        private void BtnFjernAlle_Click(object sender, EventArgs e)
        {
            if (pointLatLngs.Count > 0)
            {
                // Kan nå klikke på områder/polygon uten at de hopper in redigeringsformen 
                FrmRediger.instance.cbOmråde.Checked = false;

                // Fjerner hjelpområdet og markører   
                Kart.FjernHjelpeOmråde();
                Kart.FjernAlleMarkører_redigier(Globalekonstanter.NavnMarkørForOmråde);
                
                // Tømmer listen og oppdarer antall 
                pointLatLngs.Clear();
                txtNrPunkt.Text = pointLatLngs.Count.ToString();
            }
        }

        private string LeggTilOmrådet(string navn, string sikkerhetsklarering, string Kommentar, string Farge, int AntallPunkter, int AntallTags, HashSet<string> Tags)
        {
            string feilmelding = string.Empty;

            string utFyllingsmangler = Tekstbehandling.AltUtfylt_Område(navn, sikkerhetsklarering, Kommentar, Farge, AntallPunkter, AntallTags);

            if (utFyllingsmangler == string.Empty)
            {
                // Sjekker om de er feil med intastet data  
                string FeilTallSjekk = Tekstbehandling.sjekkSikkerhetsKlarering(sikkerhetsklarering);

                if (FeilTallSjekk == string.Empty)
                {
                    // Hent id
                    var id = DBComOmråde.GetIdOmråde();
                    int id_område = Convert.ToInt32(id[0]);

                    // Laste opp området til database
                    try
                    {
                        DBComOmråde.InsertOmrådeToDb(id_område, navn, InnloggetBruker.BrukernavnInnlogget, Convert.ToInt32(sikkerhetsklarering), Kommentar, Farge);
                    }
                    catch (Exception feil)
                    {
                        feilmelding += feil.Message;
                    }

                    // Legge til hvert punkt
                    try
                    {
                        int rekkefølge = 0;
                        foreach (var item in pointLatLngs)
                        {
                            float lat = Convert.ToSingle(item.Lat);
                            float lang = Convert.ToSingle(item.Lng);
                            DBComPunkter_område.InsertPunkter_områdetToDb(id_område, lat, lang, rekkefølge);
                            rekkefølge++;
                        }
                    }
                    catch (Exception feil)
                    {
                        feilmelding += feil.Message;
                    }

                    // Legge til hver tag
                    try
                    {
                        foreach (var item in Tags)
                        {
                            DBComTag_Område.InsertTag_OmrådeToDb(item.ToString(), id_område);
                        }
                    }
                    catch (Exception feil)
                    {
                        feilmelding += feil.Message;
                    }


                    // Slete innhold
                    TømeTekstfeltOgLister();

                    // fjerne "hjelpe" markører 
                    Kart.FjernAlleMarkører_redigier(Globalekonstanter.NavnMarkørForOmråde); // 

                    FrmRediger.OmrådeKlikkbare();

                    // Legge til de nye området på kartet 
                    FellesMetoder.OppdaterListe_området();
                    Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
                }
                else MessageBox.Show(FeilTallSjekk);
            }
            else MessageBox.Show(utFyllingsmangler);

            return feilmelding;
        }
        
        private void TømeTekstfeltOgLister()
        {
            // Tekstfelt
            txtNavn.Text = "";
            txtSikkerhetsklarering.Text = "";
            txtKommentar.Text = "";
            txtfarge.Text = "";
            txtLat.Text = Globalekonstanter.tekstLatLong_område;
            txtLong.Text = Globalekonstanter.tekstLatLong_område;
            
            // Lister
            lbValgtTags.Items.Clear();
            lbTilgjengeligeTags.Items.Clear();
            LastInnTags();
            pointLatLngs.Clear();

            txtNrPunkt.Text = pointLatLngs.Count.ToString();

        }


    }
}
