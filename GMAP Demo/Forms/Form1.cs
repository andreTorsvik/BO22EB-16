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
    public partial class Form1 : Form
    {
        public static PointLatLng Punkt_fra_forrige_kart;
        private static bool KjørEnGang = true;
        private static Color knapp_trykket;
        public static List<Ressurs> LRessurs;
        public static int WinduHøyde;
        public static int Windubrede;

        public Form1()
        {
            if (KjørEnGang) OpprettingAvGlobaleVariabler();
            InitializeComponent();

            //start form Posisjon
            this.PnlFormLoader.Controls.Clear();
            frmPosisjon frmPosisjon_vrb = new frmPosisjon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPosisjon_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmPosisjon_vrb);
            frmPosisjon_vrb.Show();

            //sette Blåpanel til vesntre for Posisjonknapp 
            FlyttNavigasjonsPanel(btnPosisjon.Height, btnPosisjon.Top);
            

            //endre farge
            btnPosisjon.BackColor = knapp_trykket;


        }

        private void OpprettingAvGlobaleVariabler()
        {
            // må legge inn start posisjon
            Punkt_fra_forrige_kart = new PointLatLng(60.36893643470203, 5.350878781967968);
            knapp_trykket = Color.FromArgb(46, 51, 73);
            KjørEnGang = false;
            LRessurs = new List<Ressurs>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Setupkart();
        }

        private void Setupkart()
        {
            //start posisjon kart
            map.MapProvider = GMapProviders.OpenStreetMap;
            
            map.Position = Punkt_fra_forrige_kart; //PointLatLng(60.36893643470203, 5.350878781967968);

            //settings for kart
            map.MinZoom = 0; // min zoom level
            map.MaxZoom = 27; // maximum
            map.Zoom = 17; // Behagelig Zoom level 
            map.DragButton = MouseButtons.Left;
        }

        private void btnPoisjon_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnPosisjon.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnPosisjon.Height, btnPosisjon.Top);

            

            this.PnlFormLoader.Controls.Clear();
            frmPosisjon frmPosisjon_vrb = new frmPosisjon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPosisjon_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmPosisjon_vrb);
            frmPosisjon_vrb.Show();

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //Endre farge
            AlleKnapperTilStandarfarge();
            btnFilter.BackColor = knapp_trykket;

            //Flytte panelet til rett posisjon
            FlyttNavigasjonsPanel(btnFilter.Height, btnFilter.Top);

            this.PnlFormLoader.Controls.Clear();
            frmFilter frmPosisjon_vrb = new frmFilter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPosisjon_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmPosisjon_vrb);
            frmPosisjon_vrb.Show();

        }

        private void btnOppdater_Click(object sender, EventArgs e)
        {
            //kode for  å oppdatere overlays på kartet 

        }

        private void btnRediger_Click(object sender, EventArgs e)
        {
            //for å sende posisjonen til neste kart
            Punkt_fra_forrige_kart = map.Position;

            //for å åpne Fjern/rediger form
            PnlFormLoader.Controls.Clear(); // usiker om denne trengs 
            this.Hide();
            frmRediger frmRediger = new frmRediger(); // instance 
            frmRediger.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            WinduHøyde = ClientSize.Height;
            Windubrede = ClientSize.Width;
            PnlFormLoader.Controls.Clear(); // usikker om denne trengs 
            this.Hide();
            frmSettings frmSettings = new frmSettings(); // instance 
            frmSettings.Show();
        }

        

        void AlleKnapperTilStandarfarge()
        {
            //setter alle nødvendige knappen til standarfarge
            btnPosisjon.BackColor = Color.FromArgb(24, 30, 54);
            btnFilter.BackColor = Color.FromArgb(24, 30, 54);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //uten denne funskjone vil programmet forsatt være i debugging 
            //når man trykker "X"
            Application.Exit();
        }

        public void FlyttNavigasjonsPanel(int høyde, int top)
        {
            //henter Høyde på knapp og hvor toppen er plassert 
            pnlNav.Height = høyde;
            pnlNav.Top = top;
            //Denne trenger kun å bli utført en gang, men er med forsikkerhetskyld 
            pnlNav.Left = btnPosisjon.Left;
        }

        private void map_Load(object sender, EventArgs e)
        {

        }

        public static void LeggTilRessursPåKart(List<Ressurs> LRessurs)
        {
            int tag = 0;
            GMapMarker marker;
            foreach (var item in LRessurs)
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
                map.Overlays.Add(markers);
            }
            reff();
        }
        public static void reff()
        {
            map.Zoom++;
            map.Zoom--;
        }

        public static void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            frmFilter.txtInfo.Text = LRessurs[Convert.ToInt32(item.Tag)].ressursDataTypeToString;
        }
    }
}
