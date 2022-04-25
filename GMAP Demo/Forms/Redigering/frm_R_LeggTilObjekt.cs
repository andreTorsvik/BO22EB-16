using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace GMAP_Demo
{
    public partial class frm_R_LeggTilObjekt : Form
    {

        public static frm_R_LeggTilObjekt instance;
        string tekstLatLong = "Dobbelklikk på kartet";
        public frm_R_LeggTilObjekt()
        {
            InitializeComponent();
            instance = this;
        }

        private void frm_R_LeggTilObjekt_Load(object sender, EventArgs e)
        {
            LastInnKategorier();
            LastInnTags();
            LabelSikkerhetsklarering.Text = string.Format("Sikkerhetsklarering(1-{0})", frmVisning.instance.MaxSikkerhetsklarering);
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

        private void btnLeggTilObjekt_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text;
            string kategori = txtKategori.Text;
            string sikkerhetsklarering = txtSikkerhetsklarering.Text;
            string Kommentar = txtKommentar.Text;
            string lat = txtLat.Text;
            string lang = txtLong.Text;
            int AntallTags = lbValgtTags.Items.Count;

            List<string> Tags = new List<string>();
            foreach (var item in lbValgtTags.Items)
            {
                Tags.Add(item.ToString());
            }

            string SjekkFeil = LeggTilObjekt(navn, kategori, sikkerhetsklarering, Kommentar, lat, lang, AntallTags,Tags);

            if (SjekkFeil != string.Empty) MessageBox.Show(SjekkFeil);

        }

        private void lbTilgjengligKategori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengligKategori.SelectedItem.ToString();

            txtKategori.Text = selectedItemtext;
        }

        private void btnLeggTilNyKategori_Click(object sender, EventArgs e)
        {
            string nyKategori = "";

            nyKategori = txtNyKategori.Text;

            if (!string.IsNullOrEmpty(nyKategori))
            {
                try
                {
                    DBComKategorier_Bilde.InsertKategorier_BildeToDb(nyKategori);
                }
                catch (Exception)
                {

                }

                lbTilgjengligKategori.Items.Add(nyKategori);
                lbTilgjengligKategori.Sorted = true;
                txtKategori.Text = nyKategori;
                txtNyKategori.Text = "";
            }
            Kart.OppdaterKategoriListe();
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

            lbTilgjengligKategori.Sorted = true;
        }

        private void LastInnTags()
        {
            lbTilgjengeligeTags.Items.Clear();

            HashSet<string> AlleTags = FellesMetoder.FåAlleTags();

            foreach (var item in AlleTags)
            {
                lbTilgjengeligeTags.Items.Add(item);
            }
            lbTilgjengeligeTags.Sorted = true;

        }

        private void lbTilgjengelige_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void txtSikkerhetsklarering_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string LeggTilObjekt(string navn, string kategori, string sikkerhetsklarering, string Kommentar, string lat, string lang, int AntallTags, List<string> nyTags)
        {
            string feilmelding = string.Empty;

            string utFyllingsmangler = Tekstbehandling.SjekkInntastetData_Objekt(navn, kategori, sikkerhetsklarering, Kommentar, lat, lang, AntallTags);

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
                        foreach (var item in lbValgtTags.Items)
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

                    Kart.OppdaterListe_ressurs();
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
            txtLat.Text = tekstLatLong;
            txtLong.Text = tekstLatLong;

            //lister
            lbValgtTags.Items.Clear();
            lbTilgjengeligeTags.Items.Clear();
            LastInnTags();
        }
    }
}
