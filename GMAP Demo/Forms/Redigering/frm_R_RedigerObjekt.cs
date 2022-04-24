using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class frm_R_RedigerObjekt : Form
    {

        public static frm_R_RedigerObjekt instance;
        public int Løpenummer_til_redigering;
        public List<string> LGamleTag = new List<string>();
        string tekstLatLong = "Dobbelklikk på kartet";
        public frm_R_RedigerObjekt()
        {
            InitializeComponent();
            instance = this;
        }
        private void frm_R_RedigerObjekt_Load(object sender, EventArgs e)
        {
            LastInnKategorier();
            LastInnTags();
            LabelSikkerhetsklarering.Text = string.Format("Sikkerhetsklarering(1-{0})", frmVisning.instance.MaxSikkerhetsklarering);
        }

        private void lbTilgjengligKategori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengligKategori.SelectedItem.ToString();

            txtKategori.Text = selectedItemtext;
        }

        private void LastInnKategorier()
        {
            GlobaleLister.LKategori.Clear();
            var KategoriListe = DatabaseCommunication.ListAllKategorier_BildeFromDb();

            foreach (var item in KategoriListe)
            {
                GlobaleLister.LKategori.Add(item);
                lbTilgjengligKategori.Items.Add(item.Kategorinavn);
            }

            lbTilgjengligKategori.Sorted = true;
        }

        private void btnLeggTilNyKategori_Click(object sender, EventArgs e)
        {
            string nyKategori = "";

            nyKategori = txtNyKategori.Text;


            if (!string.IsNullOrEmpty(nyKategori))
            {
                DatabaseCommunication.InsertKategorier_BildeToDb(nyKategori);

                lbTilgjengligKategori.Items.Add(nyKategori);
                lbTilgjengligKategori.Sorted = true;
                txtNyKategori.Text = "";
            }

            Kart.OppdaterKategoriListe();
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

        private void lbTilgjengeligeTags_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            int antallTags = lbValgtTags.Items.Count;
            List<string> NyTags = new List<string>();

            foreach (var item in lbValgtTags.Items)
            {
                NyTags.Add(item.ToString());
            }

            string SjekkFeil = RedigerObjekt(Løpenummer_til_redigering, navn,kategori ,sikkerhetsklarering, Kommentar,lat,lang, antallTags, LGamleTag, NyTags);

            if (SjekkFeil != string.Empty) MessageBox.Show(SjekkFeil);

           
        }

        private string RedigerObjekt(int løpenummer,string navn, string kategori, string sikkerhetsklarering, string kommentar, string lat, string lang, int AntallTags,List<string> GamleTags, List<string> nyTags)
        {
            string feilmelding = string.Empty;

            string utFyllingsmangler = Tekstbehandling.SjekkInntastetData_Objekt(navn, kategori, sikkerhetsklarering, kommentar, lat, lang, AntallTags);

            if (utFyllingsmangler == string.Empty)
            {
                var ressurs = DatabaseCommunication.ListRessursFromDb(løpenummer);
                string FeilTallSjekk = Tekstbehandling.sjekkGyldigTallData_objekt(sikkerhetsklarering, lat, lang);
                if (FeilTallSjekk == string.Empty)
                {
                    string Endring = Tekstbehandling.SjekkEndringerObjekt(ressurs, navn, kategori, sikkerhetsklarering, kommentar, lat, lang, GamleTags, nyTags);
                    if (Endring != string.Empty)
                    {
                        string caption = "Vil du lagre disse endringene ";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        // Displays the MessageBox.
                        result = MessageBox.Show(Endring, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                DatabaseCommunication.UpdateRessurs(løpenummer, navn, kategori, Convert.ToInt32(sikkerhetsklarering), kommentar, Convert.ToSingle(lat), Convert.ToSingle(lang));

                                List<string> SjekkOmNye1 = nyTags.Except(GamleTags).ToList();
                                List<string> SjekkOmNye2 = GamleTags.Except(nyTags).ToList();
                                if (SjekkOmNye1.Count != 0 || SjekkOmNye2.Count != 0)
                                {
                                    //SLETTE ALLE TAGS KNYTTET TIL RESSURS 
                                    DatabaseCommunication.DeleteTags_Ressurs(løpenummer);
                                    //LEGGE TIL NYE
                                    foreach (var item in lbValgtTags.Items)
                                    {
                                        DatabaseCommunication.InsertTag_RessursToDb(item.ToString(), løpenummer);
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
                            
                            Kart.OppdaterListe_ressurs();
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
            Løpenummer_til_redigering = -1;
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
