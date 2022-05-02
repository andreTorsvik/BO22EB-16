using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// Test test
namespace GMAP_Demo
{
    public partial class frmVisning : Form
    {
        //log
        //DatabaseCommunication.LogFeil(typeof(classname).Name,System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message); // hvis static 
        //DatabaseCommunication.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message); 
        

       
        public static frmVisning instance;

        public frmVisning()
        {
            GMapProviders.GoogleMap.ApiKey = "AIzaSyCX2Zw8uHqIpPr8wCYEdXu5I8udus5P8fM"; // flytte og oppdatere 
            InitializeComponent();
            instance = this;

           startup();
        }

        public void startup()
        {
            // Viser innlogget bruker
            lblUserName.Text = InnloggetBruker.BrukernavnInnlogget;

            // Første gang programmet starter etter innlogging så vises vinduet i midten av skjermen.
            this.CenterToScreen();

            //endre farge
            btnFilter.BackColor = Globalekonstanter.knapp_trykket;

            //sette Blåpanel til vesntre for Posisjonknapp 
            FlyttNavigasjonsPanel(btnFilter.Height, btnFilter.Top);

            SetTheme();

            //start form filter
            this.PnlFormLoader.Controls.Clear();
            frmFilter frmFilter_vrb = new frmFilter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmFilter_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmFilter_vrb);
            frmFilter_vrb.Show();

            

           
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

            // KategoriListen  på kartet 
            Kart.InitializekategoriListeVises();
            Kart.InitializekategoriListeSkjult();

            // TagListene på kartet
            Kart.InitializeTag_RessursListeVises();
            Kart.InitializeTag_RessursListeSkjult();

            //legget til alle ressurser i lister 
            Kart.OppdaterListe_ressurs();
            Kart.OppdaterListe_området();

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
                frmPosisjon frmPosisjon_vrb = new frmPosisjon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
                //test
                //Kun for å hindre at områdene kommer fram hvis de ikke allreder er der
                bool polygon = false;
                bool objekt = false;

                foreach (var item in map.Overlays)
                {
                    if(item.Id == Globalekonstanter.NavnOmråde && !polygon) //"Polygons"
                    {
                        Kart.OppdaterListe_området();
                        polygon = true;
                    }
                    if (item.Id == Globalekonstanter.NavnObjekter && !objekt) //"Objekter"
                    {
                        Kart.OppdaterListe_ressurs();
                        objekt = true;
                        
                    }

                    if(polygon && objekt) // har oppdater begge listene 
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
            frmControlPanel frmSettings = new frmControlPanel(); // instance 
            frmSettings.Size = this.Size;
            frmSettings.Location = this.Location;

            //til startpoisjon formen 
            frmControlPanel.instance.lat = map.Position.Lat;
            frmControlPanel.instance.lng = map.Position.Lng;

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
            btnFilter.BackColor = Globalekonstanter.StandarFargeKnapp;
            btnPosisjon.BackColor = Globalekonstanter.StandarFargeKnapp;
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
            pnlNav.Left = btnFilter.Left; //Denne trenger kun å bli utført en gang, men er med forsikkerhetskyld 
        }

        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            ÅpneFilterForm();

            if (frmFilter.instance != null)
            {
                frmFilter.instance.FyllInfoObjekt(Convert.ToInt32(item.Tag));
            }
        }

        private void map_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            ÅpneFilterForm();

            if (frmFilter.instance != null)
            {
                frmFilter.instance.FyllInfoOmråde(Convert.ToInt32(item.Tag));
            }
        }

        private void map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointLatLng DoubleClick_punkt = map.FromLocalToLatLng(e.X, e.Y);

                double lat = DoubleClick_punkt.Lat;
                double lang = DoubleClick_punkt.Lng;

                if(frmPosisjon.instance != null)
                {
                    frmPosisjon.instance.FyllKoordinater(lat, lang);
                }         
            }
        }

        bool ZoomInvervall = false;
        public bool KartOppdatere = false; //Hindrer at kart.reff() påvirker denne metoden 
        private void map_OnMapZoomChanged()
        {
            const int ZoomLevel = Globalekonstanter.ZoomLevel; // zoom = 16

            //metoden blir ikke påvirket av kart.reff(). 
            //den metoen zoomer ut og inn for å oppdatere kartet 
            if(!KartOppdatere) 
            {
                if (map.Zoom < ZoomLevel && !ZoomInvervall)
                {
                    //fjerner alle overlays utenom rute 
                    for (int i = 0; i < map.Overlays.Count; i++)
                    {
                        if (map.Overlays[i].Id != Globalekonstanter.NavnRute)
                        {
                            map.Overlays.RemoveAt(i);
                            i--;
                        }
                    }

                    ZoomInvervall = true;
                }
                else if (map.Zoom >= ZoomLevel && ZoomInvervall)
                {
                   
                    if(map.Overlays.Count == 0) // det finnes ingen rute på kartet 
                    {
                        Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
                        ZoomInvervall = false;
                    }
                    else // finnes en rute 
                    {
                        //legger til alle rutene på kartet i en liste
                        List<GMapOverlay> Lroutes = new List<GMapOverlay>();
                        for (int i = 0; i < map.Overlays.Count; i++)
                        {
                            if (map.Overlays[i].Id == Globalekonstanter.NavnRute)
                            {
                                Lroutes.Add(map.Overlays[i]);

                            }
                        }

                        //Opptatere kartet (alt blir fjernet med denne metoden og lagt til utenom ruter) 
                        Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
                        ZoomInvervall = false;

                        //må legge til ruten igjen 
                        foreach (var item in Lroutes)
                        {
                            map.Overlays.Add(item);
                        }
                        
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
