using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;

namespace GMAP_Demo
{
    public partial class frm_R_LeggTilOmråde : Form
    {
        public static frm_R_LeggTilOmråde instance;
        public frm_R_LeggTilOmråde()
        {
            InitializeComponent();
            instance = this;
        }
        // Opprette liste av punkter for område
        BindingList<PointLatLng> pointLatLngs;
        private void InitializepointLatLngs()
        {
            // Create the new BindingList of Part type.
            pointLatLngs = new BindingList<PointLatLng>();

            // Allow new parts to be added, but not removed once committed.        
            pointLatLngs.AllowNew = true;
            pointLatLngs.AllowRemove = true;

            // Raise ListChanged events when new parts are added.
            pointLatLngs.RaiseListChangedEvents = true;
        }

        private void frm_R_LeggTilOmråde_Load(object sender, EventArgs e)
        {
            LastInnOverlays();
            LastInnFargerMuligheter();

            InitializepointLatLngs();
            lbPunkter.DataSource = pointLatLngs;
            //lbPunkter.DisplayMember = "Kategorinavn";
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

        private void LastInnFargerMuligheter()
        {
            foreach (var val in Enum.GetValues(typeof(frmFilter.MuligeFarger)))
            {
                lbTilgjengligFarge.Items.Add(val);
            }
            lbTilgjengligFarge.Sorted = true;
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

        private void lbTilgjengligFarge_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengligFarge.SelectedItem.ToString();

            txtfarge.Text = selectedItemtext;
        }

        private void lbTilgjengligFarge_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txtSikkerhetsklarering_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLeggTilOmrådeIDb_Click(object sender, EventArgs e)
        {
            bool altUtfylt = true;
            string utFyllingsmangler = "Du mangler:";
            //kode for sjekk at alle felten er utfylt
            if (string.IsNullOrWhiteSpace(txtNavn.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Navn";
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
            if (string.IsNullOrWhiteSpace(txtfarge.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Farge";
            }
            if (pointLatLngs.Count > 2)
            {
                altUtfylt = false;
                utFyllingsmangler += " Tilstrekkelige punkter (>2) til å tegne et område";
            }
            if (lbValgtOverlays.Items.Count > 0)
            {
                altUtfylt = false;
                utFyllingsmangler += " Overlay";
            }

            if (altUtfylt)
            {
                DatabaseCommunication db = new DatabaseCommunication();

                // må tilpasses område

                // må opprette metode for område


                db.InsertRessursToDb(txtNavn.Text.ToString(), txtfarge.Text.ToString(), InnloggetBruker.BrukernavnInnlogget, Convert.ToInt32(txtSikkerhetsklarering.Text), txtKommentar.Text.ToString(), Convert.ToSingle(txtLat.Text), Convert.ToSingle(txtLong.Text));

                txtNavn.Text = "";
                txtSikkerhetsklarering.Text = "";
                txtKommentar.Text = "";
                txtfarge.Text = "";
                txtLat.Text = "";
                txtLong.Text = "";
            }
            else MessageBox.Show(utFyllingsmangler);
        }

        private void btnLeggTilPunktIListe_Click(object sender, EventArgs e)
        {
            if ((txtLat != null) && (txtLong != null))
            {
                pointLatLngs.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)));
                
                if (pointLatLngs.Count > 2)
                {
                    // tegn område
                }
            }
        }

        private void btnFjernPunktIListe_Click(object sender, EventArgs e)
        {
            pointLatLngs.Remove((PointLatLng)lbPunkter.SelectedItem);
        }
    }
}
