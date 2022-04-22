using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace GMAP_Demo
{
    public partial class frmVisning : Form
    {
        //log
        //DatabaseCommunication.LogFeil(typeof(classname).Name,System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message); // hvis static 
        //DatabaseCommunication.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message); 

        private Color knapp_trykket = Color.FromArgb(46, 51, 73);
        
        public PointLatLng DoubleClick_punkt;
        public static frmVisning instance;

        public int MaxSikkerhetsklarering = 3;

        public frmVisning()
        {
            GMapProviders.GoogleMap.ApiKey = "AIzaSyCX2Zw8uHqIpPr8wCYEdXu5I8udus5P8fM";
            InitializeComponent();
            instance = this;

            //start form Posisjon
            this.PnlFormLoader.Controls.Clear();
            frmFilter frmFilter_vrb = new frmFilter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFilter_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmFilter_vrb);
            frmFilter_vrb.Show();

            //sette Blåpanel til vesntre for Posisjonknapp 
            FlyttNavigasjonsPanel(btnFilter.Height, btnFilter.Top);

            //endre farge
            btnFilter.BackColor = knapp_trykket;

            // Viser innlogget bruker
            lblUserName.Text = InnloggetBruker.BrukernavnInnlogget;

            // Første gang programmet starter etter innlogging så vises vinduet i midten av skjermen.
            this.CenterToScreen();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //midtstille brukernavn iforhold til "bilde"
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;

            Kart.PunktFraForrige = FilBehandeling.GiStartPosisjon("StartPosisjon.txt");
            Kart.Setup(Kart.MuligKart.Visning, Kart.PunktFraForrige);

            // KategoriListen  på kartet 
            Kart.InitializekategoriListeVises();
            Kart.InitializekategoriListeSkjult();

            //legget til alle ressurser i lister 
            Kart.OppdaterListe_ressurs();
            Kart.OppdaterListe_området();

            //tegner alt på karet
            Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
        }

        private void btnPosisjon_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnPosisjon.Top)
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
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnFilter.Top)
            {
                AlleKnapperTilStandarfarge();
                btnFilter.BackColor = knapp_trykket;

                FlyttNavigasjonsPanel(btnFilter.Height, btnFilter.Top);

                this.PnlFormLoader.Controls.Clear();
                frmFilter frmPosisjon_vrb = new frmFilter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmPosisjon_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frmPosisjon_vrb);
                frmPosisjon_vrb.Show();
            }
        }

        private void btnOppdater_Click(object sender, EventArgs e)
        {
            if (instance.map.Overlays.Count > 0)
            {
                instance.map.Overlays.Clear();

                //Oppdater listene 

                //kun for å hindre at områdene kommer fram hvis de ikke allreder er der 
                foreach (var item in map.Overlays)
                {
                    if(item.Id == "Polygons")
                    {
                        Kart.OppdaterListe_området();
                    }
                    else if (item.Id == "Objekter")
                    {
                        Kart.OppdaterListe_ressurs();
                    }
                }

                //Kart.OppdaterListe_området();
                //Kart.OppdaterListe_ressurs();

                //Oppdatere kart basert på listene 
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
            }

        }

        private void btnRediger_Click(object sender, EventArgs e)
        {
            //for å sende posisjonen til neste kart
            Kart.PunktFraForrige = map.Position;

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

            frmSettings.instance.lat = map.Position.Lat;
            frmSettings.instance.lng = map.Position.Lng;

            frmSettings.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHjelp frmHjelp = new frmHjelp();

            frmHjelp.Location = this.Location;
            frmHjelp.Size = this.Size;
            frmHjelp.TopMost = true;
            frmHjelp.Show();

        }

        void AlleKnapperTilStandarfarge()
        {
            //setter alle nødvendige knappen til standarfarge
            btnFilter.BackColor = Color.FromArgb(24, 30, 54);
            btnPosisjon.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void FlyttNavigasjonsPanel(int høyde, int top)
        {
            //henter Høyde på knapp og hvor toppen er plassert 
            pnlNav.Height = høyde;
            pnlNav.Top = top;
            //Denne trenger kun å bli utført en gang, men er med forsikkerhetskyld 
            pnlNav.Left = btnFilter.Left;
        }



        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (frmFilter.instance != null)
            {
                frmFilter.instance.txtNavn.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Navn;
                frmFilter.instance.txtKategori.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Kategori;
                frmFilter.instance.txtDato_opprettet.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Dato_opprettet;
                frmFilter.instance.txtOpprettetAvBruker.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Opprettet_av_bruker;
                frmFilter.instance.txtSikkerhetsklarering.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Sikkerhetsklarering.ToString();
                frmFilter.instance.txtKommentar.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Kommentar;
            }
        }
        private void map_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            if (frmFilter.instance != null)
            {
                frmFilter.instance.txtNavn.Text = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].Navn;
                frmFilter.instance.txtKategori.Text = "";
                frmFilter.instance.txtDato_opprettet.Text = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].Dato_opprettet;
                frmFilter.instance.txtOpprettetAvBruker.Text = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].Opprettet_av_bruker;
                frmFilter.instance.txtSikkerhetsklarering.Text = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].Sikkerhetsklarering.ToString();
                frmFilter.instance.txtKommentar.Text = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].Kommentar;
            }
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

        private void map_OnMapZoomChanged()
        {

        }

        

        private void btnZoomPluss_Click(object sender, EventArgs e)
        {
            instance.map.Zoom++;
        }

        private void btnZoomMinus_Click(object sender, EventArgs e)
        {
            instance.map.Zoom--;
        }





        //public void OppdaterKart()
        //{
        //    instance.map.Overlays.Clear();
        //    frmFilter.instance.OppdaterRessursListe();
        //    frmFilter.instance.OppdaterOmrådeListe();
        //    reff();
        //}
    }
}
