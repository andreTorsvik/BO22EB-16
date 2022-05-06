using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Diagnostics;
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

            //FlyttNavigasjonsPanel(btnFilter.Height, btnFilter.Top);
            //btnFilter.BackColor = Globalekonstanter.knapp_trykket;

            //this.PnlFormLoader.Controls.Clear();
            Frm_V_Filter frmFilter_vrb = new Frm_V_Filter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //frmFilter_vrb.FormBorderStyle = FormBorderStyle.None;
            //this.PnlFormLoader.Controls.Add(frmFilter_vrb);
            //frmFilter_vrb.Show();

            ÅpneFormFraMenyknapp(btnFilter, frmFilter_vrb);

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

            Size = Globalekonstanter.frmWithMenuMinimumSize;
            MinimumSize = Globalekonstanter.frmWithMenuMinimumSize;
        }

        public void ByttetTheme()
        {
            // Bytter theme og åpner filter 
            // Må åpne filter igjen, for å få formen med nye farger 

            SetTheme();

            // Må flytte Navigasjonspanelet (hvis panelet er på filter) for å få lov til å bruke "ÅpneFormFraMenyknapp"
            // panelet blir flyttet på rett plass i "ÅpneFormFraMenyknapp"
            FlyttNavigasjonsPanel(btnOppdater.Height, btnOppdater.Top);

            Frm_V_Filter frmFilter_vrb = new Frm_V_Filter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ÅpneFormFraMenyknapp(btnFilter, frmFilter_vrb);
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
   
        private void BtnPosisjon_Click(object sender, EventArgs e)
        {
            Frm_V_Posisjon frmPosisjon_vrb = new Frm_V_Posisjon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ÅpneFormFraMenyknapp((Button)sender,  frmPosisjon_vrb);

        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            Frm_V_Filter frm_V_Filter_vrb = new Frm_V_Filter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ÅpneFormFraMenyknapp((Button)sender, frm_V_Filter_vrb);
        }

        private void ÅpneFormFraMenyknapp(Button sender, Form target)
        {
            if (pnlNav.Top != sender.Top)
            {
                AlleKnapperTilStandarfargeV();
                sender.BackColor = Globalekonstanter.knapp_trykket;

                FlyttNavigasjonsPanel(sender.Height, sender.Top);

                //legge inn rett form i panelet
                PnlFormLoader.Controls.Clear();

                target.FormBorderStyle = FormBorderStyle.None;
                PnlFormLoader.Controls.Add(target);
                target.Show();
            }
        }

        public void FlyttNavigasjonsPanel(int høyde, int top)
        {
            //Henter høyde til knappen og hvor toppen er plassert 
            pnlNav.Height = høyde;
            pnlNav.Top = top;

            //Denne trenger kun å bli utført en gang, men er med forsikkerhetskyld 
            pnlNav.Left = btnFilter.Left;
        }

        private void BtnOppdater_Click(object sender, EventArgs e)
        {
            if (instance.map.Overlays.Count > 0)
            {
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

        private void BtnRediger_Click(object sender, EventArgs e)
        {
            // For å sende posisjonen til neste kart
            Kart.PunktFraForrige = map.Position;

            // Åpner redigerings formen
            Hide();
            FrmRediger frmRediger = new FrmRediger(); // instance 
            frmRediger.Size = Size;
            frmRediger.Location = Location;
            frmRediger.Show();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            // Åpner ControlPanel formen
            Hide();
            FrmControlPanel frmControlPanel = new FrmControlPanel(); // instance 
            frmControlPanel.Size = Size;
            frmControlPanel.Location = Location;

            // Til startpoisjon formen 
            FrmControlPanel.instance.lat = map.Position.Lat;
            FrmControlPanel.instance.lng = map.Position.Lng;

            frmControlPanel.Show();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            Frm_V_Hjelp frm_V_Hjelp = new Frm_V_Hjelp();

            frm_V_Hjelp.Location = Location;
            frm_V_Hjelp.Size = Size;
            frm_V_Hjelp.TopMost = true;
            frm_V_Hjelp.Show();
        }

        void AlleKnapperTilStandarfargeV()
        {
            // Setter alle nødvendige knappen til standarfarge
            btnFilter.BackColor = Globalekonstanter.StandardFargeKnapp;
            btnPosisjon.BackColor = Globalekonstanter.StandardFargeKnapp;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
            map = null;

            if(GlobaleVariabler.LoggUt)
            {
                Application.ExitThread();
                Application.Exit();
            }
            else
            {
                Environment.Exit(0);
            }
        }
 
        private void Map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            // Åpner filter hvis du er en annen plass 
            if (pnlNav.Top != btnFilter.Top)
            {
                Frm_V_Filter frm_V_Filter_vrb = new Frm_V_Filter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                ÅpneFormFraMenyknapp(btnPosisjon,  frm_V_Filter_vrb);
            }

            if (Frm_V_Filter.instance != null)
            {
                // Fyller inn info om Objektet 
                Frm_V_Filter.instance.FyllInfoObjekt(Convert.ToInt32(item.Tag));
            }
        }

        private void Map_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            // Åpner filter hvis du er en annen plass 
            if (pnlNav.Top != btnFilter.Top)
            {
                Frm_V_Filter frm_V_Filter_vrb = new Frm_V_Filter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                ÅpneFormFraMenyknapp(btnFilter,  frm_V_Filter_vrb);
            }

            if (Frm_V_Filter.instance != null)
            {
                // Fyller inn info om Polygonet 
                Frm_V_Filter.instance.FyllInfoOmråde(Convert.ToInt32(item.Tag));
            }
        }

        private void Map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointLatLng DoubleClick_punkt = map.FromLocalToLatLng(e.X, e.Y);

                double lat = DoubleClick_punkt.Lat;
                double lang = DoubleClick_punkt.Lng;

                if (Frm_V_Posisjon.instance != null)
                {
                    // Fyller inn kordinatene, basert på hvor du klikket 
                    Frm_V_Posisjon.instance.FyllKoordinater(lat, lang);
                }
            }
        }

        private void map_OnMapZoomChanged()
        {
            // Metoden blir ikke påvirket av kart.reff(), på grunn av "GlobaleVariabler.KartOppdatere". 
            // kart.reff() zoomer ut og inn for å oppdatere kartet

            const int ZoomLevel = Globalekonstanter.ZoomGrense; // zoom = 16

            if (!GlobaleVariabler.KartOppdatere)
            {
                if (map.Zoom < ZoomLevel && !GlobaleVariabler.UtenforZoomGrense)
                {
                    // Fjerner objekt overlays 
                    for (int i = 0; i < map.Overlays.Count; i++)
                    {
                        if (map.Overlays[i].Id == Globalekonstanter.NavnObjekter)
                        {
                            map.Overlays.RemoveAt(i);
                            i--;
                        }
                    }

                    GlobaleVariabler.UtenforZoomGrense = true;
                }
                else if (map.Zoom >= ZoomLevel && GlobaleVariabler.UtenforZoomGrense)
                {
                    GlobaleVariabler.UtenforZoomGrense = false;
                    Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);

                }
            }

        }

        private void BtnZoomPluss_Click(object sender, EventArgs e)
        {
            instance.map.Zoom++;
        }

        private void BtnZoomMinus_Click(object sender, EventArgs e)
        {
            instance.map.Zoom--;
        }

    }
}
