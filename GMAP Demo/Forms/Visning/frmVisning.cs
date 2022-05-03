using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

// Test test
namespace GMAP_Demo
{
    public partial class FrmVisning : Form
    {
        //log
        //DatabaseCommunication.LogFeil(typeof(classname).Name,System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message); // hvis static 
        //DatabaseCommunication.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message); 



        public static FrmVisning instance;

        public FrmVisning()
        {
            GMapProviders.GoogleMap.ApiKey = Properties.Settings.Default.GoogleMapApiKey;
            InitializeComponent();
            instance = this;

            // Viser innlogget bruker
            lblUserName.Text = InnloggetBruker.BrukernavnInnlogget;

            // Første gang programmet starter etter innlogging så vises vinduet i midten av skjermen.
            this.CenterToScreen();

            SetTheme();

            FlyttNavigasjonsPanel(btnFilter.Height, btnFilter.Top);

            this.PnlFormLoader.Controls.Clear();
            Frm_V_Filter frmFilter_vrb = new Frm_V_Filter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFilter_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmFilter_vrb);
            frmFilter_vrb.Show();

        }

        public void ByttetTheme()
        {
            //bytter theme og åpner filter 
            //må åpne filter igjen, for å få formen med nye farger 

            SetTheme();

            AlleKnapperTilStandarfarge();
            btnFilter.BackColor = Globalekonstanter.knapp_trykket;

            FlyttNavigasjonsPanel(btnFilter.Height, btnFilter.Top);

            this.PnlFormLoader.Controls.Clear();
            Frm_V_Filter frmPosisjon_vrb = new Frm_V_Filter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPosisjon_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmPosisjon_vrb);
            frmPosisjon_vrb.Show();

        }

        public void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;

            pnlUser.BackColor = ThemeDesign.colorSecondaryBackground;
            btnHelp.ForeColor = ThemeDesign.colorBlue;
            btnHelp.BackColor = ThemeDesign.colorSecondaryGroupedBackground;
            lblUserName.ForeColor = ThemeDesign.colorBlue;
            lblUserName.BackColor = ThemeDesign.colorSecondaryBackground;

            pnlMenu.BackColor = ThemeDesign.colorSecondaryBackground;
            btnFilter.ForeColor = ThemeDesign.colorBlue;
            btnFilter.BackColor = ThemeDesign.colorSecondaryBackground;
            btnPosisjon.ForeColor = ThemeDesign.colorBlue;
            btnPosisjon.BackColor = ThemeDesign.colorSecondaryBackground;
            btnOppdater.ForeColor = ThemeDesign.colorBlue;
            btnOppdater.BackColor = ThemeDesign.colorSecondaryBackground;
            btnRediger.ForeColor = ThemeDesign.colorBlue;
            btnRediger.BackColor = ThemeDesign.colorSecondaryBackground;
            btnControlPanel.ForeColor = ThemeDesign.colorBlue;
            btnControlPanel.BackColor = ThemeDesign.colorSecondaryBackground;


            btnZoomPluss.ForeColor = ThemeDesign.colorBlue;
            btnZoomPluss.BackColor = ThemeDesign.colorBackground;
            btnZoomMinus.ForeColor = ThemeDesign.colorBlue;
            btnZoomMinus.BackColor = ThemeDesign.colorBackground;

            PnlFormLoader.BackColor = ThemeDesign.colorTertiaryBackground;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //midtstille brukernavn iforhold til "bilde"
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;

            //Startpoisjon og setup av kart 
            Kart.PunktFraForrige = FilBehandeling.HentStartPosisjon(Globalekonstanter.filStartPosisjon);
            Kart.Setup(Kart.MuligKart.Visning, Kart.PunktFraForrige);

            // KategoriListen på kartet 
            GlobaleLister.InitializekategoriListeVises();
            GlobaleLister.InitializekategoriListeSkjult();

            // TagListene på kartet
            GlobaleLister.InitializeTag_RessursListeVises();
            GlobaleLister.InitializeTag_RessursListeSkjult();

            //legget til alle ressurser i lister 
            FellesMetoder.OppdaterListe_ressurs();
            FellesMetoder.OppdaterListe_området();

            //tegner alt på karet
            Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);

            this.Size = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
        }

        private void btnPosisjon_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnPosisjon.Top)
            {
                AlleKnapperTilStandarfarge();
                btnPosisjon.BackColor = Globalekonstanter.knapp_trykket;

                FlyttNavigasjonsPanel(btnPosisjon.Height, btnPosisjon.Top);

                this.PnlFormLoader.Controls.Clear();
                Frm_V_Posisjon frmPosisjon_vrb = new Frm_V_Posisjon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frmPosisjon_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frmPosisjon_vrb);
                frmPosisjon_vrb.Show();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ÅpneFilterForm();
        }
        private void ÅpneFilterForm()
        {
            if (pnlNav.Top != btnFilter.Top)
            {
                AlleKnapperTilStandarfarge();
                btnFilter.BackColor = Globalekonstanter.knapp_trykket;

                FlyttNavigasjonsPanel(btnFilter.Height, btnFilter.Top);

                this.PnlFormLoader.Controls.Clear();
                Frm_V_Filter frmPosisjon_vrb = new Frm_V_Filter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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

                bool polygon = false;
                bool objekt = false;

                foreach (var item in map.Overlays)
                {
                    if (item.Id == Globalekonstanter.NavnOmråde && !polygon) //"Områder/Polygons"
                    {
                        FellesMetoder.OppdaterListe_området();
                        polygon = true;
                    }
                    if (item.Id == Globalekonstanter.NavnObjekter && !objekt) //"Objekter"
                    {
                        FellesMetoder.OppdaterListe_ressurs();
                        objekt = true;

                    }

                    if (polygon && objekt) // har oppdater begge listene 
                    {
                        break;
                    }
                }

                //Oppdatere kart basert på listene 
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
            }

        }

        private void btnRediger_Click(object sender, EventArgs e)
        {
            // For å sende posisjonen til neste kart
            Kart.PunktFraForrige = map.Position;

            // Åpner redigerings formen
            this.Hide();
            FrmRediger frmRediger = new FrmRediger(); // instance 
            frmRediger.Size = this.Size;
            frmRediger.Location = this.Location;
            frmRediger.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Åpner ControlPanel formen
            this.Hide();
            FrmControlPanel FrmControlPanel = new FrmControlPanel(); // instance 
            FrmControlPanel.Size = this.Size;
            FrmControlPanel.Location = this.Location;

            // Til startpoisjon formen 
            FrmControlPanel.instance.lat = map.Position.Lat;
            FrmControlPanel.instance.lng = map.Position.Lng;

            FrmControlPanel.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Frm_V_Hjelp frmHjelp = new Frm_V_Hjelp();

            frmHjelp.Location = this.Location;
            frmHjelp.Size = this.Size;
            frmHjelp.TopMost = true;
            frmHjelp.Show();
        }

        void AlleKnapperTilStandarfarge()
        {
            // Setter alle nødvendige knappen til standarfarge
            btnFilter.BackColor = Globalekonstanter.StandardFargeKnapp;
            btnPosisjon.BackColor = Globalekonstanter.StandardFargeKnapp;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
            map = null;

            Environment.Exit(1);
        }

        public void FlyttNavigasjonsPanel(int høyde, int top)
        {
            //Henter høyde til knappen og hvor toppen er plassert 
            pnlNav.Height = høyde;
            pnlNav.Top = top;

            //Denne trenger kun å bli utført en gang, men er med forsikkerhetskyld 
            pnlNav.Left = btnFilter.Left; 
        }

        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            // Åpner filter hvis du er en annen plass 
            if (pnlNav.Top != btnFilter.Top)
            {
                ÅpneFilterForm();
            }

            if (Frm_V_Filter.instance != null)
            {
                // Fyller inn info om Objektet 
                Frm_V_Filter.instance.FyllInfoObjekt(Convert.ToInt32(item.Tag));
            }
        }

        private void map_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            // Åpner filter hvis du er en annen plass 
            if (pnlNav.Top != btnFilter.Top)
            {
                ÅpneFilterForm();
            }

            if (Frm_V_Filter.instance != null)
            {
                // Fyller inn info om Polygonet 
                Frm_V_Filter.instance.FyllInfoOmråde(Convert.ToInt32(item.Tag));
            }
        }

        private void map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointLatLng DoubleClick_punkt = map.FromLocalToLatLng(e.X, e.Y);

                double lat = DoubleClick_punkt.Lat;
                double lang = DoubleClick_punkt.Lng;

                if (Frm_V_Posisjon.instance != null)
                {
                    //fyller inn kordinatene, basert på hvor du klikket 
                    Frm_V_Posisjon.instance.FyllKoordinater(lat, lang);
                }
            }
        }


        bool RutePåKartet = false;
        public bool KartOppdatere = false; //Hindrer at kart.reff() påvirker denne metoden 
        private void map_OnMapZoomChanged()
        {
            const int ZoomLevel = Globalekonstanter.ZoomLevel; // zoom = 16

            //metoden blir ikke påvirket av kart.reff(). 
            //den metoen zoomer ut og inn for å oppdatere kartet 
            if (!KartOppdatere)
            {
                if (map.Zoom < ZoomLevel && !Globalekonstanter.UtenforZoomGrense)
                {
                    // Fjerner objekt overlays 
                    for (int i = 0; i < map.Overlays.Count; i++)
                    {
                        if (map.Overlays[i].Id == Globalekonstanter.NavnRute)
                        {
                            RutePåKartet = true;
                        }
                        if (map.Overlays[i].Id == Globalekonstanter.NavnObjekter)
                        {
                            map.Overlays.RemoveAt(i);
                            i--;
                        }
                    }

                    Globalekonstanter.UtenforZoomGrense = true;
                }
                else if (map.Zoom >= ZoomLevel && Globalekonstanter.UtenforZoomGrense)
                {

                    if (!RutePåKartet) // Det finnes ingen rute på kartet 
                    {
                        Globalekonstanter.UtenforZoomGrense = false;
                        Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
                        
                    }
                    else // Finnes minst en rute 
                    {
                        // Legger til alle rutene på kartet i en liste
                        List<GMapOverlay> Lroutes = new List<GMapOverlay>();
                        for (int i = 0; i < map.Overlays.Count; i++)
                        {
                            if (map.Overlays[i].Id == Globalekonstanter.NavnRute)
                            {
                                Lroutes.Add(map.Overlays[i]);

                            }
                        }

                        // Opptatere kartet (alt (uten om rute) blir fjernet med denne metoden og lagt til) 
                        Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);

                        // Må legge til ruten igjen 
                        foreach (var item in Lroutes)
                        {
                            map.Overlays.Add(item);
                        }

                        Globalekonstanter.UtenforZoomGrense = false;
                        RutePåKartet = false;
                    }

                }
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
