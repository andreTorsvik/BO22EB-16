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
        public int FjernMakør;
        public List<Markør> lMakør = new List<Markør>();
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
            if (lbTilgjengeligeOverlays.Items.Count > 0) lbTilgjengeligeOverlays.Items.Clear();

            HashSet<string> AlleOverlay = new HashSet<string>();
            var OverlayOListe = DatabaseCommunication.ListAllOverlay_OmrådeFromDb();
            foreach (var item in OverlayOListe)
            {
                AlleOverlay.Add(item.Kategori.ToString());
            }
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

        private void LastInnFargerMuligheter()
        {
            foreach (var val in Enum.GetValues(typeof(Kart.MuligeFarger)))
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
            if (pointLatLngs.Count < 2)
            {
                altUtfylt = false;
                utFyllingsmangler += " Tilstrekkelige punkter (>2) til å tegne et område";
            }
            if (lbValgtOverlays.Items.Count <= 0)
            {
                altUtfylt = false;
                utFyllingsmangler += " Overlay";
            }

            if (altUtfylt)
            {
                //hentløpenummer
                var løpenummer = DatabaseCommunication.GetLøpenummer_område();
                int Løpenummer_område = Convert.ToInt32(løpenummer[0]);
                // må tilpasses område

                // må opprette metode for område
                DatabaseCommunication.InsertOmrådeToDb(Løpenummer_område, txtNavn.Text.ToString(), txtfarge.Text.ToString(), InnloggetBruker.BrukernavnInnlogget, Convert.ToInt32(txtSikkerhetsklarering.Text), txtKommentar.Text.ToString(), txtfarge.Text);

                //legge til hvert punkt
                int rekkefølge = 0;
                foreach (var item in pointLatLngs)
                {  
                    float lat = Convert.ToSingle(item.Lat);
                    float lang = Convert.ToSingle( item.Lng);
                    DatabaseCommunication.InsertPunkter_områdetToDb(Løpenummer_område, lat, lang, rekkefølge);
                    rekkefølge++;
                }
                
                //Convert.ToSingle(txtLat.Text), Convert.ToSingle(txtLong.Text);
                txtNavn.Text = "";
                txtSikkerhetsklarering.Text = "";
                txtKommentar.Text = "";
                txtfarge.Text = "";
                txtLat.Text = "";
                txtLong.Text = "";
                lbValgtOverlays.Items.Clear();
                lbTilgjengeligeOverlays.Items.Clear();

                LastInnOverlays();
                //lbPunkter.Items.Clear();
                pointLatLngs.Clear();
                txtNrPunkt.Text = "0";

                foreach (var item in frmRediger.instance.map.Overlays)
                {
                    if (item.Id == "MarkørForOmråde")
                    {
                        Kart.FjernAlleMarkører_redigier();
                        instance.lMakør.Clear();
                        break;
                    }
                }
                Kart.OppdaterListe();
                Kart.OppdaterKart(Kart.MuligKart.Begge, frmVisning.instance.LRessurs, frmVisning.instance.LOmråde);


            }
            else MessageBox.Show(utFyllingsmangler);
        }

        private void btnLeggTilPunktIListe_Click(object sender, EventArgs e)
        {
            if ((txtLat.Text != null) && (txtLong.Text != null))
            {
                
                PointLatLng punkt;
                try
                {
                    Markør m = new Markør();
                    m.lat = Convert.ToDouble(txtLat.Text);
                    m.lang = Convert.ToDouble(txtLong.Text);
                    pointLatLngs.Add(m.giPunkt());
                    m.Rekkefølge = pointLatLngs.Count -1 ;
                    //m.Rekkefølge = Convert.ToInt32(txtNrPunkt.Text);
                    lMakør.Add(m);

                    Kart.FjernAlleMarkører_redigier();

                    //tegne på nytt
                    Kart.LeggtilMarkør(lMakør,Kart.MuligKart.Redigering);
                    Kart.reff(Kart.MuligKart.Redigering);
                    txtLat.Text = "Klikk på kartet";
                    txtLong.Text = "Klikk på kartet";
                    txtNrPunkt.Text = (m.Rekkefølge + 1).ToString();
                }
                catch (Exception)
                {
                }

                //pointLatLngs.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)));
                

                if (pointLatLngs.Count > 2)
                {
                    // tegn område

                }
            }
        }

        private void btnFjernPunktIListe_Click(object sender, EventArgs e)
        {
            int fjernNr = lbPunkter.SelectedIndex;
            pointLatLngs.Remove((PointLatLng)lbPunkter.SelectedItem);
            lMakør.RemoveAt(fjernNr);
            Kart.FjernAlleMarkører_redigier();

            foreach (var item in lMakør)
            {
                if (item.Rekkefølge > fjernNr) item.Rekkefølge--;
            }

            Kart.LeggtilMarkør(lMakør, Kart.MuligKart.Redigering);
            Kart.reff(Kart.MuligKart.Redigering);

        }
    }
}
