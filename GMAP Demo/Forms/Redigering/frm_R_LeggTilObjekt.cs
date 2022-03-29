﻿using System;
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
            LastInnOverlays();
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
            if (lbValgtOverlays.Items.Count > 0)
            {
                altUtfylt = false;
                utFyllingsmangler += " Overlay";
            }

            if (altUtfylt)
            {
                DatabaseCommunication db = new DatabaseCommunication();
                db.InsertRessursToDb(txtNavn.Text.ToString(), txtKategori.Text.ToString(), InnloggetBruker.BrukernavnInnlogget, Convert.ToInt32(txtSikkerhetsklarering.Text), txtKommentar.Text.ToString(), Convert.ToSingle(txtLat.Text), Convert.ToSingle(txtLong.Text));

                txtNavn.Text = "";
                txtKategori.Text = "";
                txtKommentar.Text = "";
                txtSikkerhetsklarering.Text = "";
                txtLat.Text = "";
                txtLong.Text = "";
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
                DatabaseCommunication db = new DatabaseCommunication();

                db.InsertKategorier_BildeToDb(nyKategori);

                lbTilgjengligKategori.Items.Add(nyKategori);
                lbTilgjengligKategori.Sorted = true;
                txtNyKategori.Text = "";
            }
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

        private void lbTilgjengelige_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void txtSikkerhetsklarering_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }     
        }

    }
}
