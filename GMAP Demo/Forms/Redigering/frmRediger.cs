using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;


namespace GMAP_Demo
{
    public partial class frmRediger : Form
    {
        //log
        //DatabaseCommunication.LogFeil(typeof(classname).Name,System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message); // hvis static 
        //DatabaseCommunication.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message); 
        public static frmRediger instance;
        public static bool OmrådeKlikkBar = true;
       public static PointLatLng DoubleClick_punkt;

        public frmRediger()
        {
            InitializeComponent();
            instance = this;

            //sette oransjePanelet til Posisjonknapp
            FlyttNavigasjonsPanel(btnLeggTilObjekt.Height, btnLeggTilObjekt.Top);
            btnLeggTilObjekt.BackColor = Globalekonstanter.knapp_trykket;

            // Viser innlogget bruker
            lblUserName.Text = InnloggetBruker.BrukernavnInnlogget;

            this.PnlFormLoader.Controls.Clear();
            frm_R_LeggTilObjekt frm_R_LeggTilObjekt_vrb = new frm_R_LeggTilObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_LeggTilObjekt_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_R_LeggTilObjekt_vrb);
            frm_R_LeggTilObjekt_vrb.Show();

            SetTheme();

            btnLeggTilObjekt.BackColor = Globalekonstanter.knapp_trykket;
        }

        private void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;
            pnlUser.BackColor = ThemeDesign.colorSecondaryBackground;
            lblUserName.ForeColor = ThemeDesign.colorOrange;
            lblUserName.BackColor = ThemeDesign.colorSecondaryBackground;
            cbOmråde.ForeColor = ThemeDesign.colorGreen;

            pnlMenu.BackColor = ThemeDesign.colorSecondaryBackground;
            btnLeggTilObjekt.ForeColor = ThemeDesign.colorOrange;
            btnLeggTilObjekt.BackColor = ThemeDesign.colorSecondaryBackground;
            btnLeggTilOmråde.ForeColor = ThemeDesign.colorOrange;
            btnLeggTilOmråde.BackColor = ThemeDesign.colorSecondaryBackground;
            btnRediger_objekt.ForeColor = ThemeDesign.colorOrange;
            btnRediger_objekt.BackColor = ThemeDesign.colorSecondaryBackground;
            btnRedigerOmråde.ForeColor = ThemeDesign.colorOrange;
            btnRedigerOmråde.BackColor = ThemeDesign.colorSecondaryBackground;
            btnLeggTilBilde.ForeColor = ThemeDesign.colorOrange;
            btnLeggTilBilde.BackColor = ThemeDesign.colorSecondaryBackground;
            btnFjern.ForeColor = ThemeDesign.colorOrange;
            btnFjern.BackColor = ThemeDesign.colorSecondaryBackground;
            btnTilbake.ForeColor = ThemeDesign.colorOrange;
            btnTilbake.BackColor = ThemeDesign.colorSecondaryBackground;

            PnlFormLoader.BackColor = ThemeDesign.colorTertiaryBackground;

            btnZoomPluss.ForeColor = ThemeDesign.colorOrange;
            btnZoomPluss.BackColor = ThemeDesign.colorBackground;
            btnZoomMinus.ForeColor = ThemeDesign.colorOrange;
            btnZoomMinus.BackColor = ThemeDesign.colorBackground;
        }

        private void frmRediger_Load(object sender, EventArgs e)
        {
            Kart.Setup(Kart.MuligKart.Redigering, Kart.PunktFraForrige);

            Kart.OppdaterKart(Kart.MuligKart.Redigering, GlobaleLister.LRessurs, GlobaleLister.LOmråde);

            this.MinimumSize = new System.Drawing.Size(1000, 750);
        }

        private void btnTilbake_Click(object sender, EventArgs e)
        {
            frmVisning.instance.map.Position = map.Position;
            frmVisning.instance.map.Zoom = map.Zoom;

            this.Close();
        }
        void AlleKnapperTilStandarfarge()
        {
            Color StandarFarge = Globalekonstanter.StandarFargeKnapp;

            btnLeggTilBilde.BackColor = StandarFarge;
            btnLeggTilObjekt.BackColor = StandarFarge;
            btnLeggTilOmråde.BackColor = StandarFarge;
            btnRediger_objekt.BackColor = StandarFarge;
            btnRedigerOmråde.BackColor = StandarFarge;
            btnFjern.BackColor = StandarFarge;
        }

        private void btnObjekt_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnLeggTilObjekt.Top)
            {
                AlleKnapperTilStandarfarge();
                btnLeggTilObjekt.BackColor = Globalekonstanter.knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnLeggTilObjekt.Height, btnLeggTilObjekt.Top);

                SlettHjelpeMarkørerOgOmråder();

                OmrådeKlikkbare();

                ResettLøpenummerTilRedigering();

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
            if (pnlNav.Top != btnLeggTilOmråde.Top)
            {
                AlleKnapperTilStandarfarge();
                btnLeggTilOmråde.BackColor = Globalekonstanter.knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnLeggTilOmråde.Height, btnLeggTilOmråde.Top);


                SlettHjelpeMarkørerOgOmråder();

                OmrådeKlikkbare();

                ResettLøpenummerTilRedigering();

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
                btnRediger_objekt.BackColor = Globalekonstanter.knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnRediger_objekt.Height, btnRediger_objekt.Top);

                SlettHjelpeMarkørerOgOmråder();

                OmrådeKlikkbare();

                ResettLøpenummerTilRedigering();

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
                btnRedigerOmråde.BackColor = Globalekonstanter.knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnRedigerOmråde.Height, btnRedigerOmråde.Top);

                SlettHjelpeMarkørerOgOmråder();

                OmrådeKlikkbare();

                ResettLøpenummerTilRedigering();

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
                btnLeggTilBilde.BackColor = Globalekonstanter.knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnLeggTilBilde.Height, btnLeggTilBilde.Top);

                SlettHjelpeMarkørerOgOmråder();

                OmrådeKlikkbare();

                ResettLøpenummerTilRedigering();

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
                btnFjern.BackColor = Globalekonstanter.knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnFjern.Height, btnFjern.Top);

                OmrådeKlikkbare();

                SlettHjelpeMarkørerOgOmråder();

                ResettLøpenummerTilRedigering();

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
            frmVisning.instance.Size = this.Size;
            frmVisning.instance.Location = this.Location;
            instanceNull();
            
            this.PnlFormLoader.Controls.Clear();
            frmVisning.instance.Show();
        }

        private void instanceNull()
        {
            if (frm_R_FjernObjektOmråde.instance != null)
                frm_R_FjernObjektOmråde.instance = null;

            if (frm_R_LeggTilObjekt.instance != null)
                frm_R_LeggTilObjekt.instance = null;

            if (frm_R_LeggTilOmråde.instance != null)
                frm_R_LeggTilOmråde.instance = null;

            if (frm_R_RedigerObjekt.instance != null)
                frm_R_RedigerObjekt.instance = null;

            if (frm_R_RedigerOmråde.instance != null)
                frm_R_RedigerOmråde.instance = null;

            if (frmRediger.instance != null)
                frmRediger.instance = null;
        }

        public void FlyttNavigasjonsPanel(int høyde, int top)
        {
            //henter Høyde på knapp og hvor toppen er plassert 
            pnlNav.Height = høyde;
            pnlNav.Top = top;
            //Denne trenger kun å bli utført en gang, men er med forsikkerhetskyld 
            pnlNav.Left = btnLeggTilObjekt.Left;
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

                if (frm_R_LeggTilObjekt.instance != null)
                {
                    frm_R_LeggTilObjekt.instance.FyllKoordinater(lat, lang);
                }
                if (frm_R_LeggTilOmråde.instance != null)
                {
                    frm_R_LeggTilOmråde.instance.FyllKoordinater(lat, lang);

                    if(frm_R_LeggTilOmråde.instance.pointLatLngs.Count >= 1)
                    {
                        Kart.FjernHjelpeOmråde();

                        List<PointLatLng> Punkter = frm_R_LeggTilOmråde.instance.pointLatLngs.ToList();
                        
                        Kart.TegnHjelpeOmråde_rediger(DoubleClick_punkt, Punkter);

                    }
                }
                if (frm_R_RedigerObjekt.instance != null)
                {
                    frm_R_RedigerObjekt.instance.FyllKoordinater(lat, lang);
                }
                if (frm_R_RedigerOmråde.instance != null)
                {
                    frm_R_RedigerOmråde.instance.FyllKoordinater(lat, lang);

                    if (frm_R_RedigerOmråde.instance.Løpenummer_til_redigering != -1) // for å unngå at den tegner hvis den ikke er inni "RedigerOmråde"
                    {
                        
                        if (frm_R_RedigerOmråde.instance.pointLatLngs.Count >= 1) // tegne område underveis 
                        {
                            Kart.FjernHjelpeOmråde();

                            List<PointLatLng> Punkter = frm_R_RedigerOmråde.instance.pointLatLngs.ToList();

                            Kart.TegnHjelpeOmråde_rediger(DoubleClick_punkt, Punkter);

                        }
                    }
                   
                }

                Kart.FjernAlleMarkører_redigier(Globalekonstanter.NavnHjelpeMarkør); //"HjelpeMarkør"
                Kart.LeggtilMarkør(Kart.MuligKart.Redigering, new PointLatLng(lat, lang), -1, Globalekonstanter.NavnHjelpeMarkør); //"HjelpeMarkør"
                Kart.reff(Kart.MuligKart.Redigering);
            }
        }

        public void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if(Convert.ToInt32(item.Tag) != -1)
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
           
        }

        private void map_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            //skal ikke åpne redigeringform hvis den er på fjerne formen
            if (pnlNav.Top != btnFjern.Top)
            {
                ÅpneRediger_områdeForm();
            }

            if (frm_R_RedigerOmråde.instance != null)
            {
                frm_R_RedigerOmråde.instance.FyllInfoOmråde(Convert.ToInt32(item.Tag));

                if (frm_R_RedigerOmråde.instance.pointLatLngs.Count >= 1)
                {
                    //slette hvis noen har allrede 
                    SlettHjelpeMarkørerOgOmråder();

                    //tegn område for valgt
                    List<PointLatLng> PunkteListe = frm_R_RedigerOmråde.instance.pointLatLngs.ToList();

                    if (Kart.SjekkKartHarHjelpemarkør_redigier("HjelpeMarkør"))
                    {
                        Kart.TegnHjelpeOmråde_rediger(frmRediger.DoubleClick_punkt, PunkteListe);
                    }
                    else
                    {
                        Kart.TegnHjelpeOmråde_rediger(PunkteListe);
                    }

                    //sett inn markører i eksisterende områder 
                    for (int i = 0; i < (PunkteListe.Count -1); i++)
                    {
                        Kart.LeggtilMarkør(Kart.MuligKart.Redigering, PunkteListe[i], i, Globalekonstanter.NavnMarkørForOmråde);
                    }

                    Kart.reff(Kart.MuligKart.Redigering);
                    


                }
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

        private void ResettLøpenummerTilRedigering()
        {
            if(frm_R_RedigerObjekt.instance != null)
            {
                frm_R_RedigerObjekt.instance.Løpenummer_til_redigering = -1;
            }       
            if (frm_R_RedigerOmråde.instance != null)
            {
                frm_R_RedigerOmråde.instance.Løpenummer_til_redigering = -1;
            }
        }

        public void OmrådeKlikkbare()
        {
            if(!OmrådeKlikkBar)
            {
                cbOmråde.Checked = true;
            }
        }

        private void SlettHjelpeMarkørerOgOmråder()
        {
            foreach (var item in map.Overlays)
            {
                if (item.Id == Globalekonstanter.NavnMarkørForOmråde) //"MarkørForOmråde"
                {
                    Kart.FjernAlleMarkører_redigier(Globalekonstanter.NavnMarkørForOmråde);//"MarkørForOmråde"
                    break;
                }
            }
            foreach (var item in map.Overlays)
            {
                if (item.Id == Globalekonstanter.NavnHjelpeMarkør) //"HjelpeMarkør"
                {
                    Kart.FjernAlleMarkører_redigier(Globalekonstanter.NavnHjelpeMarkør);
                    break;
                }
            }
            foreach(var item in map.Overlays)
            {
                if (item.Id == Globalekonstanter.NavnHjelpeOmråde) // "HjelpeOmråde"
                {
                    Kart.FjernAlleMarkører_redigier(Globalekonstanter.NavnHjelpeOmråde);
                    break;
                }
            }
        }

        private void cbOmråde_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOmråde.Checked)
            {
                cbOmråde.Text = "Kan klikke på eksisterende område";
                cbOmråde.BackColor = ThemeDesign.colorSecondaryBackground;
                cbOmråde.ForeColor = ThemeDesign.colorGreen;

                frmRediger.OmrådeKlikkBar = true;
                Kart.AlleOmrådeTilgjenlighet(true);
            }
            else
            {
                cbOmråde.Text = "Kan ikke klikke på eksisterende område";
                //cbOmråde.BackColor = ThemeDesign.colorSecondaryBackground;
                //cbOmråde.ForeColor = ThemeDesign.colorRed;
                cbOmråde.BackColor = Color.Red;
                cbOmråde.ForeColor = Color.Black;

                frmRediger.OmrådeKlikkBar = false;
                Kart.AlleOmrådeTilgjenlighet(false);
            }
        }
    }
}
