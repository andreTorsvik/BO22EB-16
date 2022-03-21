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
        public PointLatLng Punkt_fra_forrige_kart;
        private bool KjørEnGang = true;
        private Color knapp_trykket;
        public List<Ressurs> LRessurs;
        public List<Område> LOmråde;
        public List<Kategorier_Bilde> LKategori;
        public PointLatLng DoubleClick_punkt;
        public static Form1 instance;
        
        //hei
        public Form1()
        {
            GMapProviders.GoogleMap.ApiKey = "AIzaSyCX2Zw8uHqIpPr8wCYEdXu5I8udus5P8fM";
            if (KjørEnGang) OpprettingAvGlobaleVariabler();
            InitializeComponent();
            instance = this;
            
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

            // Viser innlogget bruker
            lblUserName.Text = InnloggetBruker.BrukernavnInnlogget;

        }

        private void OpprettingAvGlobaleVariabler()
        {
            // må legge inn start posisjon
            Punkt_fra_forrige_kart = new PointLatLng(60.36893643470203, 5.350878781967968);
            knapp_trykket = Color.FromArgb(46, 51, 73);
            KjørEnGang = false;
            LRessurs = new List<Ressurs>();
            LKategori = new List<Kategorier_Bilde>();
            LOmråde = new List<Område>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
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
            //for å finne målene til winduet
        }

        private void btnRediger_Click(object sender, EventArgs e)
        {
            //for å sende posisjonen til neste kart
            Punkt_fra_forrige_kart = map.Position;

            //Close();
            this.Hide();
            frmRediger frmRediger = new frmRediger(); // instance 
            frmRediger.Size = this.Size;
            frmRediger.Location = this.Location;
            frmRediger.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        { 
            this.Hide();
            frmSettings frmSettings = new frmSettings(); // instance 
            frmSettings.Size = this.Size;
            frmSettings.Location = this.Location;
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

        public static void reff()
        {
            instance.map.Zoom++;
            instance.map.Zoom--;
        }

        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            frmFilter.instance.txtNavn.Text = instance.LRessurs[Convert.ToInt32(item.Tag)].Navn;
            frmFilter.instance.txtKategori.Text = instance.LRessurs[Convert.ToInt32(item.Tag)].Kategori;
            frmFilter.instance.txtDato_opprettet.Text = instance.LRessurs[Convert.ToInt32(item.Tag)].Dato_opprettet;
            frmFilter.instance.txtOpprettetAvBruker.Text = instance.LRessurs[Convert.ToInt32(item.Tag)].Opprettet_av_bruker;
            frmFilter.instance.txtSikkerhetsklarering.Text = instance.LRessurs[Convert.ToInt32(item.Tag)].Sikkerhetsklarering.ToString();
            frmFilter.instance.txtKommentar.Text = instance.LRessurs[Convert.ToInt32(item.Tag)].Kommentar;
        }

        private void map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoubleClick_punkt = map.FromLocalToLatLng(e.X, e.Y);

                double lat = DoubleClick_punkt.Lat;
                double lng = DoubleClick_punkt.Lng;

                frmPosisjon.instance.txtLat.Text = lat.ToString();
                frmPosisjon.instance.txtLong.Text = lng.ToString();
            }
        }

        private void map_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            frmFilter.instance.txtNavn.Text = instance.LOmråde[Convert.ToInt32(item.Tag)].Navn;
            frmFilter.instance.txtKategori.Text = "";
            frmFilter.instance.txtDato_opprettet.Text = instance.LOmråde[Convert.ToInt32(item.Tag)].Dato_opprettet;
            frmFilter.instance.txtOpprettetAvBruker.Text = instance.LOmråde[Convert.ToInt32(item.Tag)].Opprettet_av_bruker;
            frmFilter.instance.txtSikkerhetsklarering.Text = instance.LOmråde[Convert.ToInt32(item.Tag)].Sikkerhetsklarering.ToString();
            frmFilter.instance.txtKommentar.Text = instance.LOmråde[Convert.ToInt32(item.Tag)].Kommentar;
        }

        public static void AdresseTilKart(string Adresse)
        {
            instance.map.SetPositionByKeywords(Adresse);
            //Form1.instance.map.Zoom = 17;
            PointLatLng punkt = instance.map.Position;

            frmPosisjon.instance.txtLat.Text = punkt.Lat.ToString();
            frmPosisjon.instance.txtLong.Text = punkt.Lng.ToString();
        }

        private void map_OnMapZoomChanged()
        {

        }

        public static void LeggTilRute(PointLatLng fra,PointLatLng til)
        {
            //bruker google API 
            //false false
            var route = GoogleMapProvider.Instance.GetRoute(fra, til, false, false, 14);

            var r = new GMapRoute(route.Points, "My rute")
            {
                Stroke = new Pen(Color.Red, 5)
            };
            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            instance.map.Overlays.Add(routes);
            instance.map.Position = fra;
        }

        private void btnZoomPluss_Click(object sender, EventArgs e)
        {
            instance.map.Zoom++;
        }

        private void btnZoomMinus_Click(object sender, EventArgs e)
        {
            instance.map.Zoom--;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHjelp frmHjelp = new frmHjelp();

            frmHjelp.Location = this.Location;
            frmHjelp.Size = this.Size;
            frmHjelp.TopMost = true;
            frmHjelp.Show();

        }

    }
}
