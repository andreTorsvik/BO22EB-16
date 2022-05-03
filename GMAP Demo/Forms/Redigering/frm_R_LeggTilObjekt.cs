using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace GMAP_Demo
{
    public partial class Frm_R_LeggTilObjekt : Form
    {

        public static Frm_R_LeggTilObjekt instance;
       
        public Frm_R_LeggTilObjekt()
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
            btnLeggTilNyKategori.BackColor =  ThemeDesign.colorGray;
            
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
            btnLeggTilTag.BackColor =  ThemeDesign.colorGray;
            
            btnLeggTilObjekt.ForeColor = ThemeDesign.colorLabel;
            btnLeggTilObjekt.BackColor =  ThemeDesign.colorGray;
        }

        private void Frm_R_LeggTilObjekt_Load(object sender, EventArgs e)
        {
            LastInnKategorier();
            LastInnTags();
            lblSikkerhetsklarering.Text = string.Format("Sikkerhetsklarering(1-{0})", Globalekonstanter.MaxSikkerhetsklarering);
        }

        private void BtnLeggTilTag_Click(object sender, EventArgs e)
        {
            string nyTag = txtNyTag.Text;

            if (!string.IsNullOrEmpty(nyTag))
            {
                lbTilgjengeligeTags.Items.Add(nyTag);
                txtNyTag.Text = "";

            }
        }

        public void FyllKoordinater(double lat, double lang)
        {
            txtLat.Text = lat.ToString();
            txtLong.Text = lang.ToString();
        }
        private void BtnLeggTilObjekt_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text;
            string kategori = txtKategori.Text;
            string sikkerhetsklarering = txtSikkerhetsklarering.Text;
            string kommentar = txtKommentar.Text;
            string lat = txtLat.Text;
            string lang = txtLong.Text;
            int antallTags = lbValgtTags.Items.Count;
            List<string> Tags = lbValgtTags.Items.Cast<string>().ToList();

            string sjekkFeil = LeggTilObjekt(navn, kategori, sikkerhetsklarering, kommentar, lat, lang, antallTags, Tags);

            if (sjekkFeil != string.Empty) MessageBox.Show(sjekkFeil);

            FellesMetoder.OppdaterTag_Liste();
        }

        private void LbTilgjengligKategori_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbTilgjengligKategori.SelectedIndex != -1)
            {
                string selectedItemtext = lbTilgjengligKategori.SelectedItem.ToString();

                txtKategori.Text = selectedItemtext;
            }
        }

        private void BtnLeggTilNyKategori_Click(object sender, EventArgs e)
        {
            string nyKategori = txtNyKategori.Text;

            if (!string.IsNullOrEmpty(nyKategori))
            {
                try
                {
                    DBComKategorier_Bilde.InsertKategorier_BildeToDb(nyKategori);
                    lbTilgjengligKategori.Items.Add(nyKategori);
                    txtKategori.Text = nyKategori;
                }
                catch (Exception)
                {

                }
                txtNyKategori.Text = "";
            }
            FellesMetoder.OppdaterKategoriListe();
        }

        private void LastInnKategorier()
        {
            GlobaleLister.LKategori.Clear();
            var KategoriListe = DBComKategorier_Bilde.ListAllKategorier_BildeFromDb();

            foreach (var item in KategoriListe)
            {
                GlobaleLister.LKategori.Add(item);
                lbTilgjengligKategori.Items.Add(item.Kategorinavn);
            }
        }

        private void LastInnTags()
        {
            lbTilgjengeligeTags.Items.Clear();

            HashSet<string> AlleTags = FellesMetoder.FåAlleTags();

            foreach (var item in AlleTags)
            {
                lbTilgjengeligeTags.Items.Add(item);
            }

        }

        private void LbTilgjengelige_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbTilgjengeligeTags.SelectedIndex != -1)
            {
                string selectedItemtext = lbTilgjengeligeTags.SelectedItem.ToString();

                lbValgtTags.Items.Add(selectedItemtext);

                lbTilgjengeligeTags.Items.Remove(selectedItemtext);

                lbValgtTags.Sorted = true;
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

        private void TbSikkerhetsklarering_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string LeggTilObjekt(string navn, string kategori, string sikkerhetsklarering, string Kommentar, string lat, string lang, int AntallTags, List<string> nyTags)
        {
            string feilmelding = string.Empty;

            string utFyllingsmangler = Tekstbehandling.AltUtfylt_Objekt(navn, kategori, sikkerhetsklarering, Kommentar, lat, lang, AntallTags, Globalekonstanter.tekstLatLong_objekt);

            if (utFyllingsmangler == string.Empty)
            {
                string feilMelding = Tekstbehandling.sjekkGyldigTallData_objekt(sikkerhetsklarering, lat, lang);
                if (feilMelding == string.Empty)
                {
                    //løpenummer 
                    var løpenummer = DBComRessurs.GetLøpenummer_Ressurs();
                    int Løpenummer_Ressurs = Convert.ToInt32(løpenummer[0]);

                    //laste opp ressurs 
                    try
                    {
                        if (Løpenummer_Ressurs > 0)
                            DBComRessurs.InsertRessursToDb(Løpenummer_Ressurs, navn, kategori, InnloggetBruker.BrukernavnInnlogget, Convert.ToInt32(sikkerhetsklarering), Kommentar, Convert.ToSingle(lat), Convert.ToSingle(lang));

                    }
                    catch (Exception feil)
                    {
                        feilmelding += feil.Message;
                    }

                    //fylle in tags 
                    try
                    {
                        foreach (var item in nyTags)
                        {
                            DBComTag_Ressurs.InsertTag_RessursToDb(item.ToString(), Løpenummer_Ressurs);
                        }

                    }
                    catch (Exception feil)
                    {
                        feilmelding += feil.Message;
                    }
                    //tøme tekstfelt og lister 
                    TømeTekstFeltOgLister();

                    FellesMetoder.OppdaterListe_ressurs();
                    Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
                }
                else MessageBox.Show(feilMelding);
            }
            else MessageBox.Show(utFyllingsmangler);

            return feilmelding;
        }

        private void TømeTekstFeltOgLister()
        {
            //tekstfelt
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
