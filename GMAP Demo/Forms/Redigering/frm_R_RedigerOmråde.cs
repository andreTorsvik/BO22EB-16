using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class frm_R_RedigerOmråde : Form
    {
        public static frm_R_RedigerOmråde instance;
        public int Løpenummer_til_redigering = -1;
        public List<string> LGamleTag = new List<string>();


        public frm_R_RedigerOmråde()
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
            txtFarge.ForeColor = ThemeDesign.colorLabel;
            txtFarge.BackColor = ThemeDesign.colorGray4;
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

            btnLagreEndring.ForeColor = ThemeDesign.colorLabel;
            btnLagreEndring.BackColor = ThemeDesign.colorGray;
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

            lblSikkerhetsklarering.Text = string.Format("Sikkerhetsklarering(1-{0})", Globalekonstanter.MaxSikkerhetsklarering);
        }

        private void LastInnTags()
        {
            if (lbTilgjengeligeTags.Items.Count > 0) lbTilgjengeligeTags.Items.Clear();

            HashSet<string> AlleTag = FellesMetoder.FåAlleTags();

            foreach (var item in AlleTag)
            {
                lbTilgjengeligeTags.Items.Add(item);
            }

            
        }

        private void LastInnFargerMulighet()
        {
            foreach (var val in Enum.GetValues(typeof(Kart.MuligeFarger)))
            {
                lbTilgjengligFarge.Items.Add(val);
            }
        }

        private void lbTilgjengeligeTags_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbTilgjengeligeTags.SelectedIndex != -1)
            {
                string selectedItemtext = lbTilgjengeligeTags.SelectedItem.ToString();

                lbValgtTags.Items.Add(selectedItemtext);

                lbTilgjengeligeTags.Items.Remove(selectedItemtext);

            }

        }

        private void lbValgtTags_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbValgtTags.SelectedIndex != -1)
            {
                string selectedItemtext = lbValgtTags.SelectedItem.ToString();

                lbTilgjengeligeTags.Items.Add(selectedItemtext);

                lbValgtTags.Items.Remove(selectedItemtext);
            }

        }

        private void lbTilgjengligFarge_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbTilgjengligFarge.SelectedIndex != -1)
            {
                string selectedItemtext = lbTilgjengligFarge.SelectedItem.ToString();

                txtFarge.Text = selectedItemtext;
            }
        }

        private void btnLeggTilTag_Click(object sender, EventArgs e)
        {
            string NyTag = "";
            NyTag = txtNyTag.Text;

            if (!string.IsNullOrEmpty(NyTag))
            {
                lbTilgjengeligeTags.Items.Add(NyTag);
                txtNyTag.Text = "";
            }
        }

        public void FyllKoordinater(double lat, double lang)
        {
            txtLat.Text = lat.ToString();
            txtLong.Text = lang.ToString();


        }

        public void FyllInfoOmråde(int Tag)
        {
            //løpenummer
            Løpenummer_til_redigering = GlobaleLister.LOmråde[Tag].Løpenummer_område;
            //info
            txtNavn.Text = GlobaleLister.LOmråde[Tag].Navn;
            txtSikkerhetsklarering.Text = GlobaleLister.LOmråde[Tag].Sikkerhetsklarering.ToString();
            txtKommentar.Text = GlobaleLister.LOmråde[Tag].Kommentar;
            txtFarge.Text = GlobaleLister.LOmråde[Tag].Farge;

            //punkt liste
            FyllPunktListe(Løpenummer_til_redigering);


            //Sletting av lister
            if (lbValgtTags.Items.Count > 0) lbValgtTags.Items.Clear();
            if (lbTilgjengeligeTags.Items.Count > 0) lbTilgjengeligeTags.Items.Clear();
            if (LGamleTag.Count > 0) LGamleTag.Clear();

            //tags
            var TagListeTilRessurs = GlobaleLister.LOmråde[Tag].hentTags();
            var AlleTags = FellesMetoder.FåAlleTags();
            var GjenværendeTag = AlleTags.Except(TagListeTilRessurs);

            //sortering av tags 
            foreach (var tags in TagListeTilRessurs)
            {
                lbValgtTags.Items.Add(tags);
                LGamleTag.Add(tags);
            }
            foreach (var tags in GjenværendeTag)
            {
                lbTilgjengeligeTags.Items.Add(tags);
            }
        }

        private void FyllPunktListe(int Løpenummer)
        {
            if (lbPunkter.Items.Count > 0) pointLatLngs.Clear();

            var Punktliste = DBComPunkter_område.GetPunkter_området(Løpenummer);
            Punktliste = Punktliste.OrderBy(x => x.Rekkefølge_punkter).ToList();
            foreach (var item1 in Punktliste)
            {
                PointLatLng point = new PointLatLng(item1.Lat, item1.Lang);
                pointLatLngs.Add(point);
            }
            txtNrPunkt.Text = Punktliste.Count.ToString();
        }

        private void btnLagreEndring_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text;
            string sikkerhetsklarering = txtSikkerhetsklarering.Text;
            string Kommentar = txtKommentar.Text;
            string Farge = txtFarge.Text;
            int antallPunkter = pointLatLngs.Count;
            int antallTags = lbValgtTags.Items.Count;
            List<string> NyTags = lbValgtTags.Items.Cast<string>().ToList();

            // Legger til, om alt stemmer 
            string SjekkFeil = RedigerOmrådet(Løpenummer_til_redigering, navn, sikkerhetsklarering, Kommentar, Farge, antallPunkter, antallTags, LGamleTag, NyTags);

            if (SjekkFeil != string.Empty) MessageBox.Show(SjekkFeil);

            FellesMetoder.OppdaterTag_Liste();
        }

        private void btnLeggTilPunkt_Click(object sender, EventArgs e)
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

                        // Legger til Punktet i listen
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
                        txtNrPunkt.Text = pointLatLngs.Count.ToString();
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
                    MessageBox.Show("Punktet ble ikke lagret, sjekk instatset data");
                }
            }
        }

        private void btnFjernAlle_Click(object sender, EventArgs e)
        {

            if (pointLatLngs.Count > 0)
            {
                // Kan nå klikke på områder/polygon uten at de hopper in redigeringsformen
                FrmRediger.instance.cbOmråde.Checked = false;

                // Fjerner hjelpområdet og markører 
                Kart.FjernHjelpeOmråde();
                Kart.FjernAlleMarkører_redigier(Globalekonstanter.NavnHjelpeOmråde);

                // Tømmer listen og oppdarer antall
                pointLatLngs.Clear();
                txtNrPunkt.Text = pointLatLngs.Count.ToString();
            }

        }

        private void btnFjernSistepunkt_Click(object sender, EventArgs e)
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
                    Kart.LeggtilMarkør(Kart.MuligKart.Redigering, PunktListe[i], i, Globalekonstanter.NavnMarkørForOmråde); 
                }

                // Oppdatere kartet  
                Kart.reff(Kart.MuligKart.Redigering);

            }



        }

        private string RedigerOmrådet(int Løpenummer, string navn, string sikkerhetsklarering, string Kommentar, string Farge, int AntallPunkter, int AntallTags, List<string> GamleTags, List<string> NyTags)
        {
            if (Løpenummer >= 0)
            {
                string feilmelding = string.Empty;

                string utFyllingsmangler = Tekstbehandling.AltUtfylt_Område(navn, sikkerhetsklarering, Kommentar, Farge, AntallPunkter, AntallTags);

                if (utFyllingsmangler == string.Empty)
                {
                    
                    string FeilTallSjekk = Tekstbehandling.sjekkSikkerhetsKlarering(sikkerhetsklarering);

                    if (FeilTallSjekk == string.Empty)
                    {
                        //Henter område fra database 
                        var Lområde = DBComOmråde.ListOmrådeFromDb(Løpenummer);

                        // Legge til alle punktene 
                        List<PointLatLng> pList = new List<PointLatLng>();
                        foreach (var item in pointLatLngs)
                        {
                            pList.Add(item);
                        }

                        //Sjekker endringene i forhold til før 
                        string Endring = Tekstbehandling.SjekkEndringer_Område(Lområde, navn, sikkerhetsklarering, Kommentar, Farge, pList, LGamleTag, NyTags);

                        //sjekk endring i punktnene
                        string enderingIPunkter = Tekstbehandling.sammenlignPunkter(Lområde, pList);

                        if (Endring != string.Empty)
                        {
                            string Tittel = "Vil du lagre disse endringene ";

                            bool LagreEndring = FellesMetoder.MeldingsboksYesNo(Tittel, Endring);

                            if (LagreEndring)
                            {
                                try
                                {
                                    //Oppdtaer info 
                                    DBComOmråde.UpdateOmråde(Løpenummer_til_redigering, navn, Convert.ToInt32(sikkerhetsklarering), Kommentar, Farge);

                                    //Punktene 
                                    if (enderingIPunkter != string.Empty)
                                    {
                                        // SLETTE ALLE punktene KNYTTET TIL området 
                                        DBComPunkter_område.DeletePunkter_området(Løpenummer_til_redigering);

                                        // Legger til de nye punktene
                                        int rekkefølge = 0;
                                        foreach (var item in pList)
                                        {
                                            float lat = Convert.ToSingle(item.Lat);
                                            float lang = Convert.ToSingle(item.Lng);
                                            DBComPunkter_område.InsertPunkter_områdetToDb(Løpenummer_til_redigering, lat, lang, rekkefølge);
                                            rekkefølge++;
                                        }
                                    }

                                    //tags
                                    List<string> SjekkOmNye1 = NyTags.Except(GamleTags).ToList();
                                    List<string> SjekkOmNye2 = GamleTags.Except(NyTags).ToList();

                                    if (SjekkOmNye1.Count != 0 || SjekkOmNye2.Count != 0) // Hvis begge "SjekkOmNye" er 0,er det ingen nye  
                                    {
                                        // SLETTE ALLE TAGS KNYTTET TIL RESSURS 
                                        DBComTag_Område.DeleteTags_Område(Løpenummer_til_redigering);
                                        // Legger til de nye
                                        foreach (var item in lbValgtTags.Items)
                                        {
                                            DBComTag_Område.InsertTag_OmrådeToDb(item.ToString(), Løpenummer_til_redigering);
                                        }
                                    }
                                    // Da har alt gått igjennom og endringene lagret 

                                }
                                catch (Exception Feilmelding)
                                {
                                    feilmelding = Feilmelding.Message;
                                }

                                //Oppdatere Liste med ressurser 
                                Løpenummer_til_redigering = -1;

                                TømeTekstFeltOgLister();


                                FellesMetoder.OppdaterListe_området();
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
            else
            {
                return String.Format("Klikk på område du ønsker å endre");
            }
        }

        private void TømeTekstFeltOgLister()
        {
            //tekstfelt
            txtNavn.Text = "";
            txtKommentar.Text = "";
            txtFarge.Text = "";
            txtSikkerhetsklarering.Text = "";
            txtLat.Text = Globalekonstanter.tekstLatLong_område;
            txtLong.Text = Globalekonstanter.tekstLatLong_område;

            //lister
            lbValgtTags.Items.Clear();
            lbTilgjengeligeTags.Items.Clear();
            LastInnTags();
            pointLatLngs.Clear();

            txtNrPunkt.Text = pointLatLngs.Count.ToString();
        }


    }

}
