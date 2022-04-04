using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMAP_Demo.Database.DataTypes;

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
        }

        private void lbTilgjengligKategori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengligKategori.SelectedItem.ToString();

            txtKategori.Text = selectedItemtext;
        }

        private void LastInnKategorier()
        {
            Form1.instance.LKategori.Clear();
            DatabaseCommunication db = new DatabaseCommunication();
            var KategoriListe = db.ListAllKategorier_BildeFromDb();

            foreach (var item in KategoriListe)
            {
                Form1.instance.LKategori.Add(item);
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
                DatabaseCommunication db = new DatabaseCommunication();

                db.InsertKategorier_BildeToDb(nyKategori);

                lbTilgjengligKategori.Items.Add(nyKategori);
                lbTilgjengligKategori.Sorted = true;
                txtNyKategori.Text = "";
            }       
        }

        private void LastInnOverlays()
        {
            HashSet<string> AlleOverlay = new HashSet<string>();

            DatabaseCommunication db = new DatabaseCommunication();
            var OverlayOListe = db.ListAllOverlay_OmrådeFromDb();

            foreach (var item in OverlayOListe)
            {
                AlleOverlay.Add(item.Kategori.ToString());
            }

            var OverlayRListe = db.ListAllOverlay_RessursFromDb();

            foreach (var item in OverlayRListe)
            {
                AlleOverlay.Add(item.Kategori.ToString());
            }

            foreach (var item in AlleOverlay)
            {
                lbTilgjengeligeOverlays.Items.Add(item);
            }
            lbTilgjengeligeOverlays.Sorted = true;
        }

        private void lbTilgjengeligeOverlays_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengeligeOverlays.SelectedItem.ToString();

            lbValgtOverlays.Items.Add(selectedItemtext);

            lbTilgjengeligeOverlays.Items.Remove(selectedItemtext);

            lbValgtOverlays.Sorted = true;
        }

        private void lbValgtOverlays_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbValgtOverlays.SelectedItem.ToString();

            lbTilgjengeligeOverlays.Items.Add(selectedItemtext);

            lbValgtOverlays.Items.Remove(selectedItemtext);
        }

        private void lbTilgjengeligeOverlays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLeggTilOverlay_Click(object sender, EventArgs e)
        {
            string NyOverlay = "";
            NyOverlay = txtNyOverlay.Text;

            if (!string.IsNullOrEmpty(NyOverlay))
            {

            }
        }

        

        private void btnLeggTilObjekt_Click(object sender, EventArgs e)
        {
            bool altUtfylt = true;
            string utFyllingsmangler = "Du mangler:";
            //kode for sjekk at alle felten er utfylt
            if (string.IsNullOrWhiteSpace(txtNavn.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Navn";
            }
            if (string.IsNullOrWhiteSpace(txtKategori.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Kategori";
            }
            if (string.IsNullOrWhiteSpace(txtSikkerhetsklarering.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Sikkerhetsklarering";
            }
            if (string.IsNullOrWhiteSpace(txtKommentar.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Kommentar";
            }
            if (string.IsNullOrWhiteSpace(txtLat.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " lat";
            }
            if (string.IsNullOrWhiteSpace(txtLong.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " long";
            }
            if (lbValgtOverlays.Items.Count <= 0)
            {
                altUtfylt = false;
                utFyllingsmangler += " Overlay";
            }

            if (altUtfylt)
            {
                DatabaseCommunication db = new DatabaseCommunication();
                var d = db.ListRessursFromDb(Løpenummer_til_redigering);

                bool sjekk = SjekkEndringer(d);

                if(sjekk)
                {
                    //LAGGRE EMDRING RESSURS
                    db.UpdateRessurs(Løpenummer_til_redigering, txtNavn.Text, txtKategori.Text, Convert.ToInt32(txtSikkerhetsklarering.Text), txtKommentar.Text, Convert.ToSingle(txtLat.Text), Convert.ToSingle(txtLong.Text));
                    //SLETTE ALLE OVERLAY KNYTTET TIL RESSURS 

                    //LEGGE TIL NYE

                    //Oppdatere Liste med ressurser 

                }
                else
                {

                }
                    

            }
            else MessageBox.Show(utFyllingsmangler);


        }

        private bool SjekkEndringer(List<Ressurs> rList)
        {
            bool svar = false;
            bool Endring = false;
            string Endringer = string.Empty;
            string newLine = Environment.NewLine;

            if (rList[0].Navn != txtNavn.Text)
            {
                Endring = true;
                Endringer += string.Format("Navn: {0} -> {1}" + newLine ,rList[0].Navn,txtNavn.Text ) ;
            }
            try
            {
                if (rList[0].Sikkerhetsklarering != Convert.ToInt16( txtSikkerhetsklarering.Text))
                {
                    Endring = true;
                    Endringer += string.Format("Sikkerhetsklarering: {0} -> {1}" + newLine, rList[0].Sikkerhetsklarering, txtSikkerhetsklarering.Text);
                }
            }
            catch (Exception) { }
            if (rList[0].Kategori != txtKategori.Text)
            {
                Endring = true;
                Endringer += string.Format("Kategori: {0} -> {1}" + newLine, rList[0].Kategori, txtKategori.Text);
            }
            if (rList[0].Kommentar != txtKommentar.Text)
            {
                Endring = true;
                Endringer += string.Format("Kommentar: {0} -> {1}" + newLine, rList[0].Kommentar, txtKommentar.Text);
            }
            try
            {
                if (Math.Round(rList[0].Lat,6) != Math.Round(Convert.ToDouble( txtLat.Text),6))
                {
                    Endring = true;
                    Endringer += string.Format("Lat: {0} -> {1}" + newLine, rList[0].Lat, txtLat.Text);
                }
            }
            catch (Exception) {  }

            try
            {
                if (Math.Round( rList[0].Lang,6) != Math.Round(Convert.ToDouble(txtLong.Text),6))
                {
                    Endring = true;
                    Endringer += string.Format("Long: {0} -> {1}" + newLine, rList[0].Lang, txtLong.Text);
                }
            }
            catch (Exception) { }

            //må sjekke om hver overlay er likt 


            if (Endring)
            {
                string caption = "Vil du lagre disse endringene ";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(Endringer, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    svar = true;
                }
            }
            else MessageBox.Show("Ingen endring");
            

            return svar;
        }
    }
}
