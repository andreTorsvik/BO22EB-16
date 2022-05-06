using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class Frm_R_RedigerObjekt : Form
    {

        public static Frm_R_RedigerObjekt instance;
        public int løpenummer_til_redigering = -1;
        public List<string> LGamleTag = new List<string>();

        public Frm_R_RedigerObjekt()
        {
            InitializeComponent();
            instance = this;
            SetTheme();
        }

        private void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;

            lblTitle.ForeColor = ThemeDesign.colorOrange;

            gbObjekt.ForeColor = ThemeDesign.colorLabel;
            gbObjekt.BackColor = ThemeDesign.colorBackground;
            lblNavn.ForeColor = ThemeDesign.colorLabel;
            lblSikkerhetsklarering.ForeColor = ThemeDesign.colorLabel;
            lblKategori.ForeColor = ThemeDesign.colorLabel;
            lblKommentar.ForeColor = ThemeDesign.colorLabel;
            lblLat.ForeColor = ThemeDesign.colorLabel;
            lblLong.ForeColor = ThemeDesign.colorLabel;
            txtNavn.ForeColor = ThemeDesign.colorLabel;
            txtNavn.BackColor = ThemeDesign.colorGray;
            txtSikkerhetsklarering.ForeColor = ThemeDesign.colorLabel;
            txtSikkerhetsklarering.BackColor = ThemeDesign.colorGray;
            lbTilgjengligKategori.ForeColor = ThemeDesign.colorLabel;
            lbTilgjengligKategori.BackColor = ThemeDesign.colorGray;
            txtKategori.ForeColor = ThemeDesign.colorLabel;
            txtKategori.BackColor = ThemeDesign.colorGray4;
            txtNyKategori.ForeColor = ThemeDesign.colorLabel;
            txtNyKategori.BackColor = ThemeDesign.colorGray;
            txtKommentar.ForeColor = ThemeDesign.colorLabel;
            txtKommentar.BackColor = ThemeDesign.colorGray;
            txtLat.ForeColor = ThemeDesign.colorLabel;
            txtLat.BackColor = ThemeDesign.colorGray;
            txtLong.ForeColor = ThemeDesign.colorLabel;
            txtLong.BackColor = ThemeDesign.colorGray;
            btnLeggTilNyKategori.ForeColor = ThemeDesign.colorLabel;
            btnLeggTilNyKategori.BackColor = ThemeDesign.colorGray;

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

        private void Frm_R_RedigerObjekt_Load(object sender, EventArgs e)
        {
            LastInnKategorier();
            LastInnTags();
            lblSikkerhetsklarering.Text = string.Format("Sikkerhetsklarering(1-{0})", Globalekonstanter.MaxSikkerhetsklarering);
        }


        private void LbTilgjengligKategori_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbTilgjengligKategori.SelectedIndex != -1)
            {
                string selectedItemtext = lbTilgjengligKategori.SelectedItem.ToString();

                txtKategori.Text = selectedItemtext;
            }
        }

        private void LastInnKategorier()
        {
            GlobaleLister.LKategori.Clear();
            var kategoriListe = DBComKategorier_Bilde.ListAllKategorier_BildeFromDb();

            foreach (var item in kategoriListe)
            {
                GlobaleLister.LKategori.Add(item);
                lbTilgjengligKategori.Items.Add(item.Kategorinavn);
            }
        }

        private void BtnLeggTilNyKategori_Click(object sender, EventArgs e)
        {
            string nyKategori = txtNyKategori.Text.Trim();

            if (!string.IsNullOrEmpty(nyKategori))
            {
                try
                {
                    var antall = DBComKategorier_Bilde.GetBildeForKategoriFromDbKategorier_Bilde(nyKategori);
                    if (antall.Count == 0)
                    {
                        DBComKategorier_Bilde.InsertKategorier_BildeToDb(nyKategori);

                        lbTilgjengligKategori.Items.Add(nyKategori);
                        txtKategori.Text = nyKategori;
                    }
                    else
                    {
                        MessageBox.Show("Kategori finnes allerede");
                    }
                    txtNyKategori.Text = "";
                }
                catch (Exception)
                {

                }
                
            }

            FellesMetoder.OppdaterKategoriListe();
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

        public void FyllInfoObjekt(int Tag)
        {
            // Løpenummeret 
            løpenummer_til_redigering = GlobaleLister.LRessurs[Tag].Løpenummer_ressurs;

            // Info 
            txtNavn.Text = GlobaleLister.LRessurs[Tag].Navn;
            txtKategori.Text = GlobaleLister.LRessurs[Tag].Kategori;
            txtSikkerhetsklarering.Text = GlobaleLister.LRessurs[Tag].Sikkerhetsklarering.ToString();
            txtKommentar.Text = GlobaleLister.LRessurs[Tag].Kommentar;
            txtLat.Text = GlobaleLister.LRessurs[Tag].Lat.ToString();
            txtLong.Text = GlobaleLister.LRessurs[Tag].Lang.ToString();


            // Sletting av eksisterende lister
            if (lbValgtTags.Items.Count > 0) lbValgtTags.Items.Clear();
            if (lbTilgjengeligeTags.Items.Count > 0) lbTilgjengeligeTags.Items.Clear();
            if (LGamleTag.Count > 0) LGamleTag.Clear();

            // Tagliste
            var TagListeTilRessurs = GlobaleLister.LRessurs[Tag].hentTags();
            var AlleTags = FellesMetoder.FåAlleTags();
            var GjenværendeTag = AlleTags.Except(TagListeTilRessurs);

            // Sorter Tags
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

        private void BtnLeggTilObjekt_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text.Trim();
            string kategori = txtKategori.Text;
            string sikkerhetsklarering = txtSikkerhetsklarering.Text;
            string kommentar = txtKommentar.Text.Trim();
            string lat = txtLat.Text;
            string lang = txtLong.Text;
            int antallTags = lbValgtTags.Items.Count;
            HashSet<string> nyTags = new HashSet<string>( lbValgtTags.Items.Cast<string>().ToList());

            // Legger til, om alt stemmer
            string SjekkFeil = RedigerObjekt(løpenummer_til_redigering, navn, kategori, sikkerhetsklarering, kommentar, lat, lang, antallTags, LGamleTag, nyTags);

            if (SjekkFeil != string.Empty)
                MessageBox.Show(SjekkFeil);
            else
                FrmRediger.OmrådeKlikkbare();

            FellesMetoder.OppdaterTag_Liste();
        }

        private string RedigerObjekt(int løpenummer, string navn, string kategori, string sikkerhetsklarering, string kommentar, string lat, string lang, int AntallTags, List<string> GamleTags, HashSet<string> nyTags)
        {
            if (løpenummer >= 0)
            {
                string feilmelding = string.Empty;

                string utFyllingsmangler = Tekstbehandling.AltUtfylt_Objekt(navn, kategori, sikkerhetsklarering, kommentar, lat, lang, AntallTags, Globalekonstanter.tekstLatLong_objekt);

                if (utFyllingsmangler == string.Empty)
                {
                    Ressurs OrginaleRessurs = DBComRessurs.RessursFromDb(løpenummer);
                    string FeilTallSjekk = Tekstbehandling.sjekkGyldigTallData_objekt(sikkerhetsklarering, lat, lang);

                    if (FeilTallSjekk == string.Empty)
                    {
                        string Endring = Tekstbehandling.SjekkEndringer_Objekt(OrginaleRessurs, navn, kategori, sikkerhetsklarering, kommentar, lat, lang, GamleTags, nyTags);
                        if (Endring != string.Empty)
                        {
                            string Tittel = "Vil du lagre disse endringene ";
                            bool lagreEndring = FellesMetoder.MeldingsboksYesNo(Tittel, Endring);
                          
                            if (lagreEndring)
                            {
                                try
                                {
                                    //Oppdatere med ny info 
                                    DBComRessurs.UpdateRessurs(løpenummer, navn, kategori, Convert.ToInt32(sikkerhetsklarering), kommentar, Convert.ToSingle(lat), Convert.ToSingle(lang));

                                    // Oppdatere Tags, hvis det er noen nye 
                                    List<string> SjekkOmNye1 = nyTags.Except(GamleTags).ToList();
                                    List<string> SjekkOmNye2 = GamleTags.Except(nyTags).ToList();
                                    if (SjekkOmNye1.Count != 0 || SjekkOmNye2.Count != 0)
                                    {
                                        //SLETTE ALLE TAGS KNYTTET TIL RESSURS 
                                        DBComTag_Ressurs.DeleteTags_Ressurs(løpenummer);
                                        //LEGGE TIL NYE
                                        foreach (var item in nyTags)
                                        {
                                            DBComTag_Ressurs.InsertTag_RessursToDb(item.ToString(), løpenummer);
                                        }
                                    }
                                }
                                catch (Exception Feilmelding)
                                {
                                    feilmelding = Feilmelding.Message;

                                }
                                //tøme tekstfelt og lister 
                                TømeTekstFeltOgLister();

                                //Oppdatere Liste med ressurser 

                                FellesMetoder.OppdaterListe_ressurs();
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
                return String.Format("Klikk på objekt du ønsker å endre");
            }

        }

        private void TømeTekstFeltOgLister()
        {
            //tekstfelt
            løpenummer_til_redigering = -1;
            txtNavn.Text = "";
            txtKategori.Text = "";
            txtKommentar.Text = "";
            txtSikkerhetsklarering.Text = "";
            txtLat.Text = Globalekonstanter.tekstLatLong_objekt;
            txtLong.Text = Globalekonstanter.tekstLatLong_objekt;

            //lister
            lbValgtTags.Items.Clear();
            lbTilgjengeligeTags.Items.Clear();
            LastInnTags();
        }


    }
}
