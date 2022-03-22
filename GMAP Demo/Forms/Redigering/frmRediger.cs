using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using GMap.NET.MapProviders;
using GMAP_Demo.Database.DataTypes;


namespace GMAP_Demo
{
    public partial class frmRediger : Form
    {
        private Color knapp_trykket;
        public  PointLatLng DoubleClick_punkt;
        public static frmRediger instance;
        public frmRediger()
        {
            InitializeComponent();
            instance = this;
            knapp_trykket = Color.FromArgb(46, 51, 73);

            //sette oransjePanelet til Posisjonknapp
            FlyttNavigasjonsPanel(btnObjekt.Height, btnObjekt.Top);
            btnObjekt.BackColor = knapp_trykket;


            // Viser innlogget bruker
            lblUserName.Text = InnloggetBruker.BrukernavnInnlogget;

            this.PnlFormLoader.Controls.Clear();
            frm_R_LeggTilObjekt frm_R_LeggTilObjekt_vrb = new frm_R_LeggTilObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_LeggTilObjekt_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_R_LeggTilObjekt_vrb);
            frm_R_LeggTilObjekt_vrb.Show();
        }

        private void frmRediger_Load(object sender, EventArgs e)
        {
            SetupKart();
            VisRessurser();
            VisOmråder();
        }

        void SetupKart()
        {
            //start posisjon kart
            map.MapProvider = GMapProviders.OpenStreetMap;
            PointLatLng point = Form1.instance.Punkt_fra_forrige_kart;
            map.Position = point;

            //settings for kart
            map.MinZoom = 0; // min zoom level
            map.MaxZoom = 27; // maximum
            map.Zoom = 17;
            map.DragButton = MouseButtons.Left;
            map.ShowCenter = true; // false om man vil ha den bort
        }
        private void btnTilbake_Click(object sender, EventArgs e)
        {
            Form1.instance.Punkt_fra_forrige_kart = map.Position;

            this.Close();
        }

        void AlleKnapperTilStandarfarge()
        {
            Color StandarFarge = Color.FromArgb(24, 30, 54);

            btnObjekt.BackColor = StandarFarge;
            btnOmråde.BackColor = StandarFarge;
            btnRediger_obj_områ.BackColor = StandarFarge;
            btnRedigerOmråde.BackColor = StandarFarge;
            btnFjern_obj_områ.BackColor = StandarFarge;
        }

        private void btnObjekt_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnObjekt.BackColor = knapp_trykket;

            //Flytte oransjePanelet til rett plass
            FlyttNavigasjonsPanel(btnObjekt.Height, btnObjekt.Top);

            //legge inn rett forms i panelet
            this.PnlFormLoader.Controls.Clear();
            frm_R_LeggTilObjekt frm_R_LeggTilObjekt_vrb = new frm_R_LeggTilObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_LeggTilObjekt_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_R_LeggTilObjekt_vrb);
            frm_R_LeggTilObjekt_vrb.Show();
        }

        private void btnOmråde_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnOmråde.BackColor = knapp_trykket;

            //Flytte oransjePanelet til rett plass
            FlyttNavigasjonsPanel(btnOmråde.Height, btnOmråde.Top);

            //legge inn rett form i panelet
            this.PnlFormLoader.Controls.Clear();
            frm_R_LeggTilOmråde frm_R_LeggTilOmråde_vrb = new frm_R_LeggTilOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_LeggTilOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_R_LeggTilOmråde_vrb);
            frm_R_LeggTilOmråde_vrb.Show();
        }

        private void btnRediger_obj_områ_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnRediger_obj_områ.BackColor = knapp_trykket;

            //Flytte oransjePanelet til rett plass
            FlyttNavigasjonsPanel(btnRediger_obj_områ.Height, btnRediger_obj_områ.Top);
            
            //legge inn rett form i panelet
            this.PnlFormLoader.Controls.Clear();
            frm_R_RedigerObjekt frm_R_RedigerObjektOmråde_vrb = new frm_R_RedigerObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_RedigerObjektOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_R_RedigerObjektOmråde_vrb);
            frm_R_RedigerObjektOmråde_vrb.Show();
        }

        private void btnFjern_obj_områ_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnFjern_obj_områ.BackColor = knapp_trykket;

            //Flytte oransjePanelet til rett plass
            FlyttNavigasjonsPanel(btnFjern_obj_områ.Height, btnFjern_obj_områ.Top);
           
            //legge inn rett form i panelet
            this.PnlFormLoader.Controls.Clear();
            frm_R_FjernObjektOmråde frm_R_FjernObjektOmråde_vrb = new frm_R_FjernObjektOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_FjernObjektOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_R_FjernObjektOmråde_vrb);
            frm_R_FjernObjektOmråde_vrb.Show();
        }



        private void frmRediger_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
            Form1.instance.Show();
        }

        public void FlyttNavigasjonsPanel(int høyde, int top)
        {
            //henter Høyde på knapp og hvor toppen er plassert 
            pnlNav.Height = høyde;
            pnlNav.Top = top;
            //Denne trenger kun å bli utført en gang, men er med forsikkerhetskyld 
            pnlNav.Left = btnObjekt.Left;
        }

        private void map_MouseDoubleClick(PointLatLng pointClick, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoubleClick_punkt = map.FromLocalToLatLng(e.X, e.Y);

                double lat = DoubleClick_punkt.Lat;
                double lng = DoubleClick_punkt.Lng;

                if (frm_R_LeggTilObjekt.instance != null)
                {
                    frm_R_LeggTilObjekt.instance.txtLat.Text = lat.ToString();
                    frm_R_LeggTilObjekt.instance.txtLong.Text = lng.ToString();
                }
                if (frm_R_LeggTilOmråde.instance != null)
                {
                    frm_R_LeggTilOmråde.instance.txtLat.Text = lat.ToString();
                    frm_R_LeggTilOmråde.instance.txtLong.Text = lng.ToString();
                }
                if (frm_R_RedigerObjekt.instance != null)
                {
                    frm_R_RedigerObjekt.instance.txtLat.Text = lat.ToString();
                    frm_R_RedigerObjekt.instance.txtLong.Text = lng.ToString();
                }
                if (frm_R_RedigerOmråde.instance != null)
                {
                    frm_R_RedigerOmråde.instance.txtLat.Text = lat.ToString();
                    frm_R_RedigerOmråde.instance.txtLong.Text = lng.ToString();
                }
            }
        }

        private void btnRedigerOmråde_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnRedigerOmråde.BackColor = knapp_trykket;

            //Flytte oransjePanelet til rett plass
            FlyttNavigasjonsPanel(btnRedigerOmråde.Height, btnRedigerOmråde.Top);

            //legge inn rett form i panelet
            this.PnlFormLoader.Controls.Clear();
            frm_R_RedigerOmråde frm_R_RedigerOmråde_vrb = new frm_R_RedigerOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_RedigerOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_R_RedigerOmråde_vrb);
            frm_R_RedigerOmråde_vrb.Show();
        }

        private void VisRessurser()
        {
            if (Form1.instance.LRessurs.Count > 0)
            {
                int tag = 0;
                GMapMarker marker;
                foreach (var item in Form1.instance.LRessurs)
                {
                    PointLatLng punkt = item.GiPunktet();

                    marker = new GMarkerGoogle(punkt, GMarkerGoogleType.green);

                    marker.ToolTipText = String.Format("{0}", item.Navn);
                    marker.ToolTip.Fill = Brushes.Black;
                    marker.ToolTip.Foreground = Brushes.White;
                    marker.ToolTip.Stroke = Pens.Black;
                    marker.ToolTip.TextPadding = new Size(20, 20);
                    marker.Tag = tag;
                    tag++;

                    GMapOverlay markers = new GMapOverlay("test1");
                    markers.Markers.Add(marker);
                    instance.map.Overlays.Add(markers);
                }
                frmRediger.reff();
            }
        }

        private void VisOmråder()
        {
            if (Form1.instance.LOmråde.Count > 0)
            {
                int Tag = 0;
                foreach (var item in Form1.instance.LOmråde)
                {
                    List<PointLatLng> Lpunkter = item.HentPunkter();

                    GMapPolygon polygon = frmFilter.instance.BestemFarge(Lpunkter, item.Farge);

                    polygon.Tag = Tag;
                    Tag++;
                    polygon.IsHitTestVisible = true; // nødvendig for å kunne trykke på Polygonet
                    GMapOverlay polygons = new GMapOverlay("Polygons");
                    polygons.Polygons.Add(polygon);
                    instance.map.Overlays.Add(polygons);
                }
                reff();
            }
            
        }
        public static void reff()
        {
            instance.map.Zoom++;
            instance.map.Zoom--;
        }

        public static void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            
            if (frm_R_RedigerObjekt.instance != null)
            {
                frm_R_RedigerObjekt.instance.txtNavn.Text = Form1.instance.LRessurs[Convert.ToInt32(item.Tag)].Navn;
                frm_R_RedigerObjekt.instance.txtKategori.Text = Form1.instance.LRessurs[Convert.ToInt32(item.Tag)].Kategori;
                frm_R_RedigerObjekt.instance.txtSikkerhetsklarering.Text = Form1.instance.LRessurs[Convert.ToInt32(item.Tag)].Sikkerhetsklarering.ToString();
                frm_R_RedigerObjekt.instance.txtKommentar.Text = Form1.instance.LRessurs[Convert.ToInt32(item.Tag)].Kommentar;
                frm_R_RedigerObjekt.instance.txtLat.Text = Form1.instance.LRessurs[Convert.ToInt32(item.Tag)].Lat.ToString();
                frm_R_RedigerObjekt.instance.txtLong.Text = Form1.instance.LRessurs[Convert.ToInt32(item.Tag)].Lang.ToString();
                frm_R_RedigerObjekt.instance.Løpenummer_til_redigering = Form1.instance.LRessurs[Convert.ToInt32(item.Tag)].Løpenummer_ressurs;
            }
            
        }

        private void map_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            if (frm_R_RedigerOmråde.instance != null)
            {
                frm_R_RedigerOmråde.instance.txtNavn.Text = Form1.instance.LOmråde[Convert.ToInt32(item.Tag)].Navn;
                frm_R_RedigerOmråde.instance.txtSikkerhetsklarering.Text = Form1.instance.LOmråde[Convert.ToInt32(item.Tag)].Sikkerhetsklarering.ToString();
                frm_R_RedigerOmråde.instance.txtKommentar.Text = Form1.instance.LOmråde[Convert.ToInt32(item.Tag)].Kommentar;
                frm_R_RedigerOmråde.instance.txtfarge.Text = Form1.instance.LOmråde[Convert.ToInt32(item.Tag)].Farge;

            }
            
        }

        private void btnZoomPluss_Click(object sender, EventArgs e)
        {
            instance.map.Zoom++;
        }

        private void btnZoomMinus_Click(object sender, EventArgs e)
        {
            instance.map.Zoom--;
        }
    }
}
