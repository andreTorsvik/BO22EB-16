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
            LastInnOverlays();
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

        private void LastInnOverlays()
        {
            if (lbTilgjengeligeTags.Items.Count > 0) lbTilgjengeligeTags.Items.Clear();

            HashSet<string> AlleOverlay = FellesMetoder.FåAlleTags();

            foreach (var item in AlleOverlay)
            {
                lbTilgjengeligeTags.Items.Add(item);
            }
            lbTilgjengeligeTags.Sorted = true;
        }

        private void lbTilgjengeligeOverlays_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengeligeTags.SelectedItem.ToString();

            lbValgtTags.Items.Add(selectedItemtext);

            lbTilgjengeligeTags.Items.Remove(selectedItemtext);

            lbValgtTags.Sorted = true;
        }

        private void lbValgtOverlays_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbValgtTags.SelectedItem.ToString();

            lbTilgjengeligeTags.Items.Add(selectedItemtext);

            lbValgtTags.Items.Remove(selectedItemtext);
        }

        private void lbTilgjengeligeOverlays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLeggTilOverlay_Click(object sender, EventArgs e)
        {
            string NyOverlay = "";
            NyOverlay = txtNyTags.Text;

            if (!string.IsNullOrEmpty(NyOverlay))
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
                            //SLETTE ALLE OVERLAY KNYTTET TIL RESSURS 

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
