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
                string feilMelding = Tekstbehandling.sjekkGyldigTallData_objekt(txtSikkerhetsklarering.Text, txtLat.Text, txtLong.Text);
                if (feilMelding == string.Empty)
                {
                    DatabaseCommunication.InsertRessursToDb(txtNavn.Text.ToString(), txtKategori.Text.ToString(), InnloggetBruker.BrukernavnInnlogget, Convert.ToInt32(txtSikkerhetsklarering.Text), txtKommentar.Text.ToString(), Convert.ToSingle(txtLat.Text), Convert.ToSingle(txtLong.Text));
                    //fylle in tags 

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
            lbTilgjengeligeOverlays.Items.Clear();
            
            HashSet<string> AlleOverlay = new HashSet<string>();

            //alle overlays fra Området
            var OverlayOListe = DatabaseCommunication.ListAllOverlay_OmrådeFromDb();
            foreach (var item in OverlayOListe)
            {
                AlleOverlay.Add(item.Kategori.ToString());
            }

            //alle overlays fra Resusrs 
            var OverlayRListe = DatabaseCommunication.ListAllOverlay_RessursFromDb();
            foreach (var item in OverlayRListe)
            {
                AlleOverlay.Add(item.Kategori.ToString());
            }

            foreach (var item in AlleTags)
            {
                lbTilgjengeligeTags.Items.Add(item);
            }
            lbTilgjengeligeOverlays.Sorted = true;
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
