using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class Frm_R_RedigerOmråde : Form
    {
        public static Frm_R_RedigerOmråde instance;
        public int id_til_redigering = -1;
        public List<string> LGamleTag = new List<string>();


        public Frm_R_RedigerOmråde()
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

        private void Frm_R_RedigerOmråde_Load(object sender, EventArgs e)
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

                txtFarge.Text = selectedItemtext;
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

        public void FyllInfoOmråde(int Tag)
        {
            // Løpenummer
            id_til_redigering = GlobaleLister.LOmråde[Tag].IdOmråde;

            // Info
            txtNavn.Text = GlobaleLister.LOmråde[Tag].Navn;
            txtSikkerhetsklarering.Text = GlobaleLister.LOmråde[Tag].Sikkerhetsklarering.ToString();
            txtKommentar.Text = GlobaleLister.LOmråde[Tag].Kommentar;
            txtFarge.Text = GlobaleLister.LOmråde[Tag].Farge;

            // Punkt liste
            FyllPunktListe(id_til_redigering);


            // Sletting av lister
            if (lbValgtTags.Items.Count > 0) lbValgtTags.Items.Clear();
            if (lbTilgjengeligeTags.Items.Count > 0) lbTilgjengeligeTags.Items.Clear();
            if (LGamleTag.Count > 0) LGamleTag.Clear();

            // Tags
            var tagListeTilRessurs = GlobaleLister.LOmråde[Tag].hentTags();
            var alleTags = FellesMetoder.FåAlleTags();
            var gjenværendeTag = alleTags.Except(tagListeTilRessurs);

            // Sortering av tags 
            foreach (var tags in tagListeTilRessurs)
            {
                lbValgtTags.Items.Add(tags);
                LGamleTag.Add(tags);
            }
            foreach (var tags in gjenværendeTag)
            {
                lbTilgjengeligeTags.Items.Add(tags);
            }
        }

        private void FyllPunktListe(int løpenummer)
        {
            if (lbPunkter.Items.Count > 0) pointLatLngs.Clear();

            var punktliste = DBComPunkter_område.GetPunkter_området(løpenummer);
            punktliste = punktliste.OrderBy(x => x.Rekkefølge_punkter).ToList();
            foreach (var item1 in punktliste)
            {
                PointLatLng point = new PointLatLng(item1.Lat, item1.Lang);
                pointLatLngs.Add(point);
            }
            txtNrPunkt.Text = punktliste.Count.ToString();
        }

        private void BtnLagreEndring_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text.Trim();
            string sikkerhetsklarering = txtSikkerhetsklarering.Text;
            string kommentar = txtKommentar.Text.Trim();
            string farge = txtFarge.Text;
            int antallPunkter = pointLatLngs.Count;
            int antallTags = lbValgtTags.Items.Count;
            HashSet<string> nyTags = new HashSet<string>(lbValgtTags.Items.Cast<string>().ToList());

            // Legger til, om alt stemmer 
            string sjekkFeil = RedigerOmrådet(id_til_redigering, navn, sikkerhetsklarering, kommentar, farge, antallPunkter, antallTags, LGamleTag, nyTags);

            if (sjekkFeil != string.Empty)
            {
                MessageBox.Show(sjekkFeil);
            }
            else
                FrmRediger.OmrådeKlikkbare();

            FellesMetoder.OppdaterTag_Liste();
        }

        private void BtnLeggTilPunkt_Click(object sender, EventArgs e)
        {
            if ((txtLat.Text != null) && (txtLong.Text != null) && (txtLat.Text != Globalekonstanter.tekstLatLong_område) && (txtLong.Text != Globalekonstanter.tekstLatLong_område))
            {
                if (id_til_redigering != -1)
                {
                    try
                    {
                        // Sjekker om de kan Konverters og returner feilmeldingen hvis ikke
                        string sjekkLat = Tekstbehandling.sjekkLat(txtLat.Text);
                        string sjekkLang = Tekstbehandling.sjekkLong(txtLong.Text);

                        if (sjekkLat == string.Empty && sjekkLang == string.Empty)
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
                            if (sjekkLang != string.Empty)
                                MessageBox.Show(string.Format("Feil: " + sjekkLang));
                            else
                                MessageBox.Show(string.Format("Feil: " + sjekkLat));
                        }


                    }
                    catch (Exception feilmelding)
                    {
                        DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                        MessageBox.Show("Punktet ble ikke lagret, sjekk instatset data");
                    }
                }
                else 
                {
                    MessageBox.Show("Klikk på område du ønsker å endre");
                }

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
                Kart.FjernAlleMarkører_redigier(Globalekonstanter.NavnMarkørForOmråde); //Globalekonstanter.NavnHjelpeOmråde

                // Tømmer listen og oppdarer antall
                pointLatLngs.Clear();
                txtNrPunkt.Text = pointLatLngs.Count.ToString();
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

                List<PointLatLng> punktListe = pointLatLngs.ToList();

                // Tegner hjelpeområdet på nytt
                if (Kart.SjekkKartHarHjelpemarkør_redigier(Globalekonstanter.NavnHjelpeMarkør))
                {
                    // Hvis man har dobbeltklikket på kartet
                    Kart.TegnHjelpeOmråde_rediger(FrmRediger.DoubleClick_punkt, punktListe);
                }
                else
                {
                    // Hvis man ikke har dobbeltklikket på kartet
                    Kart.TegnHjelpeOmråde_rediger(punktListe);
                }

                // Markerer hjørnene til området med riktig rekkefølge
                for (int i = 0; i < (pointLatLngs.Count); i++)
                {
                    Kart.LeggtilMarkør(Kart.MuligKart.Redigering, punktListe[i], i, Globalekonstanter.NavnMarkørForOmråde);
                }

                // Oppdatere kartet  
                Kart.reff(Kart.MuligKart.Redigering);

            }



        }

        private string RedigerOmrådet(int id_til_redigering, string navn, string sikkerhetsklarering, string kommentar, string farge, int antallPunkter, int antallTags, List<string> gamleTags, HashSet<string> nyTags)
        {
            if (id_til_redigering >= 0)
            {
                string feilmelding = string.Empty;

                string utFyllingsmangler = Tekstbehandling.AltUtfylt_Område(navn, sikkerhetsklarering, kommentar, farge, antallPunkter, antallTags);

                if (utFyllingsmangler == string.Empty)
                {

                    string FeilTallSjekk = Tekstbehandling.sjekkSikkerhetsKlarering(sikkerhetsklarering);

                    if (FeilTallSjekk == string.Empty)
                    {
                        // Henter område fra database 
                        Område OrginaleOmråde = DBComOmråde.ListOmrådeFromDb(id_til_redigering);

                        // Legge til alle punktene 
                        List<PointLatLng> pList = new List<PointLatLng>();
                        foreach (var item in pointLatLngs)
                        {
                            pList.Add(item);
                        }

                        //Sjekker endringene i forhold til før 
                        string Endring = Tekstbehandling.SjekkEndringer_Område(OrginaleOmråde, navn, sikkerhetsklarering, kommentar, farge, pList, LGamleTag, nyTags);

                        //sjekk endring i punktnene
                        string enderingIPunkter = Tekstbehandling.sammenlignPunkter(OrginaleOmråde, pList);

                        if (Endring != string.Empty)
                        {
                            string Tittel = "Vil du lagre disse endringene ";

                            bool LagreEndring = FellesMetoder.MeldingsboksYesNo(Tittel, Endring);

                            if (LagreEndring)
                            {
                                try
                                {
                                    //Oppdaterer info 
                                    DBComOmråde.UpdateOmråde(this.id_til_redigering, navn, Convert.ToInt32(sikkerhetsklarering), kommentar, farge);

                                    //Punktene 
                                    if (enderingIPunkter != string.Empty)
                                    {
                                        // SLETTE ALLE punktene KNYTTET TIL området 
                                        DBComPunkter_område.DeletePunkter_området(this.id_til_redigering);

                                        // Legger til de nye punktene
                                        int rekkefølge = 0;
                                        foreach (var item in pList)
                                        {
                                            float lat = Convert.ToSingle(item.Lat);
                                            float lang = Convert.ToSingle(item.Lng);
                                            DBComPunkter_område.InsertPunkter_områdetToDb(this.id_til_redigering, lat, lang, rekkefølge);
                                            rekkefølge++;
                                        }
                                    }

                                    // Tags
                                    List<string> sjekkOmNye1 = nyTags.Except(gamleTags).ToList();
                                    List<string> sjekkOmNye2 = gamleTags.Except(nyTags).ToList();

                                    if (sjekkOmNye1.Count != 0 || sjekkOmNye2.Count != 0) // Hvis begge "SjekkOmNye" er 0,er det ingen nye  
                                    {
                                        // SLETTE ALLE TAGS KNYTTET TIL RESSURS 
                                        DBComTag_Område.DeleteTags_Område(this.id_til_redigering);
                                        // Legger til de nye
                                        foreach (var item in lbValgtTags.Items)
                                        {
                                            DBComTag_Område.InsertTag_OmrådeToDb(item.ToString(), this.id_til_redigering);
                                        }
                                    }
                                    // Da har alt gått igjennom og endringene lagret 

                                }
                                catch (Exception Feilmelding)
                                {
                                    feilmelding = Feilmelding.Message;
                                }

                                // Oppdatere Liste med ressurser 
                                this.id_til_redigering = -1;

                                TømeTekstFeltOgLister();


                                FellesMetoder.OppdaterListe_området();
                                Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
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
