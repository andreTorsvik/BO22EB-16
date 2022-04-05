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
            LabelSikkerhetsklarering.Text = string.Format("Sikkerhetsklarering(1-{0})", FrmVisning.instance.MaxSikkerhetsklarering);
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
            string navn = txtNavn.Text;
            string kategori = txtKategori.Text;
            string sikkerhetsklarering = txtSikkerhetsklarering.Text;
            string Kommentar = txtKommentar.Text;
            string lat = txtLat.Text;
            string lang = txtLong.Text;
            int antall = lbValgtOverlays.Items.Count;

            
            string utFyllingsmangler = Tekstbehandling.SjekkInntastetDataObjekt(navn, kategori, sikkerhetsklarering, Kommentar, lat, lang, antall);
            
            if (utFyllingsmangler == string.Empty)
            {
                string feilMelding = Tekstbehandling.sjekkGyldigTallData(txtSikkerhetsklarering.Text,txtLat.Text,txtLong.Text);
                if (feilMelding == string.Empty)
                {
                    DatabaseCommunication.InsertRessursToDb(txtNavn.Text.ToString(), txtKategori.Text.ToString(), InnloggetBruker.BrukernavnInnlogget, Convert.ToInt32(txtSikkerhetsklarering.Text), txtKommentar.Text.ToString(), Convert.ToSingle(txtLat.Text), Convert.ToSingle(txtLong.Text));
                    //fylle in overlays 

                    txtNavn.Text = "";
                    txtKategori.Text = "";
                    txtKommentar.Text = "";
                    txtSikkerhetsklarering.Text = "";
                    txtLat.Text = "";
                    txtLong.Text = "";
                    lbValgtOverlays.Items.Clear();
                    LastInnOverlays();
                    Kart.Visning_OppdaterListeOgKart();
                    Kart.Redigering_OppdaterListeOgKart();
                }
                else
                {
                    MessageBox.Show(feilMelding);
                }
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


                DatabaseCommunication.InsertKategorier_BildeToDb(nyKategori);

                lbTilgjengligKategori.Items.Add(nyKategori);
                lbTilgjengligKategori.Sorted = true;
                txtNyKategori.Text = "";
            }
        }
        private void LastInnKategorier()
        {
            FrmVisning.instance.LKategori.Clear();
            var KategoriListe = DatabaseCommunication.ListAllKategorier_BildeFromDb();

            foreach (var item in KategoriListe)
            {
                FrmVisning.instance.LKategori.Add(item);
                lbTilgjengligKategori.Items.Add(item.Kategorinavn);
            }

            lbTilgjengligKategori.Sorted = true;
        }

        private void LastInnOverlays()
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
