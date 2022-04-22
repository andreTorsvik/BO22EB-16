using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace GMAP_Demo
{
    public partial class frm_R_LeggTilObjekt : Form
    {

        public static frm_R_LeggTilObjekt instance;
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
                lbTilgjengligKategori.Items.Add(NyTag);
                lbTilgjengligKategori.Sorted = true;
                txtNyTag.Text = "";

                //Kart.OppdaterKategoriListe();
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
            int antall = lbValgtTags.Items.Count;


            string utFyllingsmangler = Tekstbehandling.SjekkInntastetData_Objekt(navn, kategori, sikkerhetsklarering, Kommentar, lat, lang, antall);

            if (utFyllingsmangler == string.Empty)
            {
                string feilMelding = Tekstbehandling.sjekkGyldigTallData_objekt(sikkerhetsklarering, lat, lang);
                if (feilMelding == string.Empty)
                {
                    //løpenummer 
                    var løpenummer = DatabaseCommunication.GetLøpenummer_område();
                    int Løpenummer_Ressurs = Convert.ToInt32(løpenummer[0]);

                    //laste opp ressurs 
                    try
                    {
                        if (Løpenummer_Ressurs > 0)
                            DatabaseCommunication.InsertRessursToDb(Løpenummer_Ressurs, navn, kategori, InnloggetBruker.BrukernavnInnlogget, Convert.ToInt32(sikkerhetsklarering), Kommentar, Convert.ToSingle(lat), Convert.ToSingle(lang));

                    }
                    catch (Exception)
                    {

                    }

                    //fylle in overlays 
                    try
                    { 
                        foreach (var item in lbValgtTags.Items)
                        {
                            DatabaseCommunication.InsertTag_RessursToDb(item.ToString(), Løpenummer_Ressurs);
                        }

                    }
                    catch (Exception)
                    {

                    }

                    txtNavn.Text = "";
                    txtKategori.Text = "";
                    txtKommentar.Text = "";
                    txtSikkerhetsklarering.Text = "";
                    txtLat.Text = "Dobbelklikk på kart";
                    txtLong.Text = "Dobbelklikk på kart";

                    lbValgtTags.Items.Clear();
                    LastInnTags();
                    Kart.OppdaterListe_ressurs();
                    Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
                }
                else MessageBox.Show(feilMelding);
            }
            else MessageBox.Show(utFyllingsmangler);

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
                    DatabaseCommunication.InsertKategorier_BildeToDb(nyKategori);
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
            var KategoriListe = DatabaseCommunication.ListAllKategorier_BildeFromDb();

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
            
            HashSet<string> AlleTags = new HashSet<string>();

            //alle tags fra Området
            var TagOListe = DatabaseCommunication.ListAllTag_OmrådeFromDb();
            foreach (var item in TagOListe)
            {
                AlleTags.Add(item.Tag.ToString());
            }

            //alle tags fra Resusrs 
            var TagRListe = DatabaseCommunication.ListAllTag_RessursFromDb();
            foreach (var item in TagRListe)
            {
                AlleTags.Add(item.Tag.ToString());
            }

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
    }
}
