using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace GMAP_Demo
{
    public partial class frmRediger : Form
    {
        //log
        //DatabaseCommunication.LogFeil(typeof(classname).Name,System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message); // hvis static 
        //DatabaseCommunication.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message); 

        private Color knapp_trykket;
        public PointLatLng DoubleClick_punkt; //tror denne kan bli flyttet inn i metoedn 
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
            Kart.Setup(Kart.MuligKart.Redigering, Kart.PunktFraForrige);

            Kart.OppdaterKart(Kart.MuligKart.Redigering, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
            //Kart.LeggTilRessurs(GlobaleLister.LRessurs, Kart.MuligKart.Redigering);
            //Kart.LeggTilOmråde(GlobaleLister.LOmråde, Kart.MuligKart.Redigering);

            Kart.reff(Kart.MuligKart.Redigering);
        }

        private void btnTilbake_Click(object sender, EventArgs e)
        {
            frmVisning.instance.map.Position = map.Position;
            frmVisning.instance.map.Zoom = map.Zoom;

            this.Close();
        }
        void AlleKnapperTilStandarfarge()
        {
            Color StandarFarge = Color.FromArgb(24, 30, 54);

            btnLeggTilBilde.BackColor = StandarFarge;
            btnObjekt.BackColor = StandarFarge;
            btnOmråde.BackColor = StandarFarge;
            btnRediger_objekt.BackColor = StandarFarge;
            btnRedigerOmråde.BackColor = StandarFarge;
            btnFjern.BackColor = StandarFarge;
        }

        private void btnObjekt_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnObjekt.Top)
            {
                AlleKnapperTilStandarfarge();
                btnObjekt.BackColor = knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnObjekt.Height, btnObjekt.Top);

                SlettHjelpeMarkører();

                //legge inn rett forms i panelet
                this.PnlFormLoader.Controls.Clear();
                frm_R_LeggTilObjekt frm_R_LeggTilObjekt_vrb = new frm_R_LeggTilObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_R_LeggTilObjekt_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_R_LeggTilObjekt_vrb);
                frm_R_LeggTilObjekt_vrb.Show();
            }
        }
        private void btnOmråde_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnOmråde.Top)
            {
                AlleKnapperTilStandarfarge();
                btnOmråde.BackColor = knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnOmråde.Height, btnOmråde.Top);

                SlettHjelpeMarkører();

                //legge inn rett form i panelet
                this.PnlFormLoader.Controls.Clear();
                frm_R_LeggTilOmråde frm_R_LeggTilOmråde_vrb = new frm_R_LeggTilOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_R_LeggTilOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_R_LeggTilOmråde_vrb);
                frm_R_LeggTilOmråde_vrb.Show();
            }
        }

        private void btnRediger_objekt_Click(object sender, EventArgs e)
        {
            ÅpneRediger_objektForm();
        }
        private void ÅpneRediger_objektForm()
        {
            if (pnlNav.Top != btnRediger_objekt.Top)
            {
                AlleKnapperTilStandarfarge();
                btnRediger_objekt.BackColor = knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnRediger_objekt.Height, btnRediger_objekt.Top);

                SlettHjelpeMarkører();

                //legge inn rett form i panelet
                this.PnlFormLoader.Controls.Clear();
                frm_R_RedigerObjekt frm_R_RedigerObjektOmråde_vrb = new frm_R_RedigerObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_R_RedigerObjektOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_R_RedigerObjektOmråde_vrb);
                frm_R_RedigerObjektOmråde_vrb.Show();
            }
        }

        private void btnRedigerOmråde_Click(object sender, EventArgs e)
        {
            ÅpneRediger_områdeForm();
        }
        private void ÅpneRediger_områdeForm()
        {
            if (pnlNav.Top != btnRedigerOmråde.Top)
            {
                AlleKnapperTilStandarfarge();
                btnRedigerOmråde.BackColor = knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnRedigerOmråde.Height, btnRedigerOmråde.Top);

                SlettHjelpeMarkører();

                //legge inn rett form i panelet
                this.PnlFormLoader.Controls.Clear();
                frm_R_RedigerOmråde frm_R_RedigerOmråde_vrb = new frm_R_RedigerOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_R_RedigerOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_R_RedigerOmråde_vrb);
                frm_R_RedigerOmråde_vrb.Show();
            }
        }

        private void btnLeggTilBilde_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnLeggTilBilde.Top)
            {
                AlleKnapperTilStandarfarge();
                btnLeggTilBilde.BackColor = knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnLeggTilBilde.Height, btnLeggTilBilde.Top);

                SlettHjelpeMarkører();

                //legge inn rett form i panelet
                this.PnlFormLoader.Controls.Clear();
                frm_R_EndreObjektsymbol frm_R_LeggTilBilde_vrb = new frm_R_EndreObjektsymbol() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_R_LeggTilBilde_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_R_LeggTilBilde_vrb);
                frm_R_LeggTilBilde_vrb.Show();
            }
        }

        private void btnFjern_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnFjern.Top)
            {
                AlleKnapperTilStandarfarge();
                btnFjern.BackColor = knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnFjern.Height, btnFjern.Top);

                SlettHjelpeMarkører();

                //legge inn rett form i panelet
                this.PnlFormLoader.Controls.Clear();
                frm_R_FjernObjektOmråde frm_R_FjernObjektOmråde_vrb = new frm_R_FjernObjektOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_R_FjernObjektOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_R_FjernObjektOmråde_vrb);
                frm_R_FjernObjektOmråde_vrb.Show();
            }
        }

        private void frmRediger_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
            frmVisning.instance.Show();
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
                //List<PointLatLng> Lpunkt = new List<PointLatLng>();
                //Lpunkt.Add(DoubleClick_punkt);

                double lat = DoubleClick_punkt.Lat;
                double lang = DoubleClick_punkt.Lng;

                Kart.FjernAlleMarkører_redigier("HjelpeMarkør");
                Kart.LeggtilMarkør(Kart.MuligKart.Redigering, new PointLatLng(lat, lang), -1, "HjelpeMarkør");
                Kart.reff(Kart.MuligKart.Redigering);

                if (frm_R_LeggTilObjekt.instance != null)
                {
                    frm_R_LeggTilObjekt.instance.FyllKoordinater(lat, lang);
                }
                if (frm_R_LeggTilOmråde.instance != null)
                {
                    frm_R_LeggTilOmråde.instance.FyllKoordinater(lat, lang);
                }
                if (frm_R_RedigerObjekt.instance != null)
                {
                    frm_R_RedigerObjekt.instance.FyllKoordinater(lat, lang);
                }
                if (frm_R_RedigerOmråde.instance != null)
                {
                    frm_R_RedigerOmråde.instance.FyllKoordinater(lat, lang);
                }
            }
        }

        public void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            //skal ikke åpne redigeringform hvis den er på fjerne
            if (pnlNav.Top != btnFjern.Top)
            {
                ÅpneRediger_objektForm();
            }

            //if (frm_R_LeggTilOmråde.instance != null)
            //{

            //}
            if (frm_R_FjernObjektOmråde.instance != null)
            {
                frm_R_FjernObjektOmråde.instance.fyllInfoObjekt(Convert.ToInt32(item.Tag));
            }
            if (frm_R_RedigerObjekt.instance != null)
            {

                frm_R_RedigerObjekt.instance.FyllInfoObjekt(Convert.ToInt32(item.Tag));
            }
        }

        private void map_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            //skal ikke åpne redigeringform hvis den er på fjerne
            if (pnlNav.Top != btnFjern.Top)
            {
                ÅpneRediger_områdeForm();
            }

            if (frm_R_RedigerOmråde.instance != null)
            {
                frm_R_RedigerOmråde.instance.FyllInfoOmråde(Convert.ToInt32(item.Tag));
            }
            if (frm_R_FjernObjektOmråde.instance != null)
            {
                frm_R_FjernObjektOmråde.instance.fyllInfoOmråde(Convert.ToInt32(item.Tag));
            }

        }

        private void btnZoomPluss_Click(object sender, EventArgs e)
        {
            map.Zoom++;
        }

        private void btnZoomMinus_Click(object sender, EventArgs e)
        {
            map.Zoom--;
        }

        private void SlettHjelpeMarkører()
        {
            foreach (var item in map.Overlays)
            {
                if (item.Id == "MarkørForOmråde")
                {
                    Kart.FjernAlleMarkører_redigier("MarkørForOmråde");
                    break;
                }
            }
            foreach (var item in map.Overlays)
            {
                if (item.Id == "HjelpeMarkør")
                {
                    Kart.FjernAlleMarkører_redigier("HjelpeMarkør");
                    break;
                }
            }
        }
    }
}
