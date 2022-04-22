using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class frm_R_RedigerObjekt : Form
    {

        public static frm_R_RedigerObjekt instance;
        public int Løpenummer_til_redigering;
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
            HashSet<string> AlleTag = new HashSet<string>();

            var TagOListe = DatabaseCommunication.ListAllTag_OmrådeFromDb();

            foreach (var item in TagOListe)
            {
                AlleTag.Add(item.Tag.ToString());
            }

            var TagRListe = DatabaseCommunication.ListAllTag_RessursFromDb();

            foreach (var item in TagRListe)
            {
                AlleTag.Add(item.Tag.ToString());
            }

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
                var d = DatabaseCommunication.ListRessursFromDb(Løpenummer_til_redigering);
                string FeilTallSjekk = Tekstbehandling.sjekkGyldigTallData_objekt(sikkerhetsklarering, lat, lang);
                if (FeilTallSjekk == string.Empty)
                {
                    string Endring = Tekstbehandling.SjekkEndringerObjekt(d, navn, kategori, sikkerhetsklarering, Kommentar, lat, lang, antall);
                    if (Endring != string.Empty)
                    {
                        string caption = "Vil du lagre disse endringene ";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        // Displays the MessageBox.
                        result = MessageBox.Show(Endring, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            DatabaseCommunication.UpdateRessurs(Løpenummer_til_redigering, txtNavn.Text, txtKategori.Text, Convert.ToInt32(txtSikkerhetsklarering.Text), txtKommentar.Text, Convert.ToSingle(txtLat.Text), Convert.ToSingle(txtLong.Text));
                            //SLETTE ALLE TAGS KNYTTET TIL RESSURS 

                            //LEGGE TIL NYE

                            //Oppdatere Liste med ressurser 
                            Løpenummer_til_redigering = -1;
                            txtNavn.Text = "";
                            txtKategori.Text = "";
                            txtKommentar.Text = "";
                            txtSikkerhetsklarering.Text = "";
                            txtLat.Text = "Dobbelklikk på kartet";
                            txtLong.Text = "Dobbelklikk på kartet";

                            Kart.OppdaterListe_ressurs();
                            Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LRessurs, GlobaleLister.LOmråde);

                        }
                    }
                    else MessageBox.Show("Ingen Endring");
                }
                else MessageBox.Show(FeilTallSjekk);
            }
            else MessageBox.Show(utFyllingsmangler);
        }
    }
}
