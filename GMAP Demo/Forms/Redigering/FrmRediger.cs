using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;


namespace GMAP_Demo
{
    public partial class FrmRediger : Form
    {
        //log
        //DatabaseCommunication.LogFeil(typeof(classname).Name,System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message); // hvis static 
        //DatabaseCommunication.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message); 
        public static FrmRediger instance;
        public static bool OmrådeKlikkBar = true;
       public static PointLatLng DoubleClick_punkt;

        public FrmRediger()
        {
            InitializeComponent();
            instance = this;

            //sette oransjePanelet til Posisjonknapp
            FlyttNavigasjonsPanel(btnLeggTilObjekt.Height, btnLeggTilObjekt.Top);
            btnLeggTilObjekt.BackColor = Globalekonstanter.knapp_trykket;

            // Viser innlogget bruker
            lblUserName.Text = InnloggetBruker.BrukernavnInnlogget;

            PnlFormLoader.Controls.Clear();
            Frm_R_LeggTilObjekt frm_R_LeggTilObjekt_vrb = new Frm_R_LeggTilObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_LeggTilObjekt_vrb.FormBorderStyle = FormBorderStyle.None;
            PnlFormLoader.Controls.Add(frm_R_LeggTilObjekt_vrb);
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
            btnRedigerObjekt.ForeColor = ThemeDesign.colorOrange;
            btnRedigerObjekt.BackColor = ThemeDesign.colorSecondaryBackground;
            btnRedigerOmråde.ForeColor = ThemeDesign.colorOrange;
            btnRedigerOmråde.BackColor = ThemeDesign.colorSecondaryBackground;
            btnLeggTilBilde.ForeColor = ThemeDesign.colorOrange;
            btnLeggTilBilde.BackColor = ThemeDesign.colorSecondaryBackground;
            btnFjernObjektOmråde.ForeColor = ThemeDesign.colorOrange;
            btnFjernObjektOmråde.BackColor = ThemeDesign.colorSecondaryBackground;
            btnTilbake.ForeColor = ThemeDesign.colorOrange;
            btnTilbake.BackColor = ThemeDesign.colorSecondaryBackground;

            PnlFormLoader.BackColor = ThemeDesign.colorTertiaryBackground;

            btnZoomPluss.ForeColor = ThemeDesign.colorOrange;
            btnZoomPluss.BackColor = ThemeDesign.colorBackground;
            btnZoomMinus.ForeColor = ThemeDesign.colorOrange;
            btnZoomMinus.BackColor = ThemeDesign.colorBackground;
        }

        private void FrmRediger_Load(object sender, EventArgs e)
        {
            Kart.Setup(Kart.MuligKart.Redigering, Kart.PunktFraForrige);

            Kart.OppdaterKart(Kart.MuligKart.Redigering, GlobaleLister.LRessurs, GlobaleLister.LOmråde);

            MinimumSize = Globalekonstanter.frmWithMenuMinimumSize;
        }

        private void BtnTilbake_Click(object sender, EventArgs e)
        {
            Close();
        }
        void AlleKnapperTilStandardFargeR()
        {
            Color StandardFarge = Globalekonstanter.StandardFargeKnapp;

            btnLeggTilBilde.BackColor = StandardFarge;
            btnLeggTilObjekt.BackColor = StandardFarge;
            btnLeggTilOmråde.BackColor = StandardFarge;
            btnRedigerObjekt.BackColor = StandardFarge;
            btnRedigerOmråde.BackColor = StandardFarge;
            btnFjernObjektOmråde.BackColor = StandardFarge;
        }

        private void ÅpneFormFraMenyknapp(Button sender, EventArgs e, Form target)
        {
            if (pnlNav.Top != sender.Top)
            {
                AlleKnapperTilStandardFargeR();
                sender.BackColor = Globalekonstanter.knapp_trykket;

                FlyttNavigasjonsPanel(sender.Height, sender.Top);

                SlettHjelpeMarkørerOgOmråder();

                OmrådeKlikkbare();

                ResettLøpenummerTilRedigering();

                //legge inn rett form i panelet
                PnlFormLoader.Controls.Clear();

                target.FormBorderStyle = FormBorderStyle.None;
                PnlFormLoader.Controls.Add(target);
                target.Show();
            }
        }

        private void BtnObjekt_Click(object sender, EventArgs e)
        {
            Frm_R_LeggTilObjekt frm_R_LeggTilObjekt_vrb = new Frm_R_LeggTilObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ÅpneFormFraMenyknapp((Button)sender, e, frm_R_LeggTilObjekt_vrb);
        }
        private void BtnOmråde_Click(object sender, EventArgs e)
        {
            Frm_R_LeggTilOmråde frm_R_LeggTilOmråde_vrb = new Frm_R_LeggTilOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ÅpneFormFraMenyknapp((Button)sender, e, frm_R_LeggTilOmråde_vrb);
        }

        private void BtnRediger_objekt_Click(object sender, EventArgs e)
        {
            Frm_R_RedigerObjekt frm_R_RedigerObjekt_vrb = new Frm_R_RedigerObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ÅpneFormFraMenyknapp((Button)sender, e, frm_R_RedigerObjekt_vrb);
        }

        //private void ÅpneRediger_objektForm()
        //{
        //    if (pnlNav.Top != btnRedigerObjekt.Top)
        //    {
        //        AlleKnapperTilStandardFargeR();
        //        btnRedigerObjekt.BackColor = Globalekonstanter.knapp_trykket;

        //        //Flytte oransjePanelet til rett plass
        //        FlyttNavigasjonsPanel(btnRedigerObjekt.Height, btnRedigerObjekt.Top);

        //        SlettHjelpeMarkørerOgOmråder();

        //        OmrådeKlikkbare();

        //        ResettLøpenummerTilRedigering();

        //        //legge inn rett form i panelet
        //        PnlFormLoader.Controls.Clear();

        //        frm_R_RedigerObjekt frm_R_RedigerObjektOmråde_vrb = new frm_R_RedigerObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //        frm_R_RedigerObjektOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
        //        PnlFormLoader.Controls.Add(frm_R_RedigerObjektOmråde_vrb);
        //        frm_R_RedigerObjektOmråde_vrb.Show();
        //    }
        //}

        private void BtnRedigerOmråde_Click(object sender, EventArgs e)
        {
            Frm_R_RedigerOmråde frm_R_RedigerOmråde_vrb = new Frm_R_RedigerOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ÅpneFormFraMenyknapp((Button)sender, e, frm_R_RedigerOmråde_vrb);
            //ÅpneRediger_områdeForm();
        }
        //private void ÅpneRediger_områdeForm()
        //{
        //    if (pnlNav.Top != btnRedigerOmråde.Top)
        //    {
        //        AlleKnapperTilStandardFargeR();
        //        btnRedigerOmråde.BackColor = Globalekonstanter.knapp_trykket;

        //        //Flytte oransjePanelet til rett plass
        //        FlyttNavigasjonsPanel(btnRedigerOmråde.Height, btnRedigerOmråde.Top);

        //        SlettHjelpeMarkørerOgOmråder();

        //        OmrådeKlikkbare();

        //        ResettLøpenummerTilRedigering();

        //        //legge inn rett form i panelet
        //        PnlFormLoader.Controls.Clear();
        //        frm_R_RedigerOmråde frm_R_RedigerOmråde_vrb = new frm_R_RedigerOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //        frm_R_RedigerOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
        //        PnlFormLoader.Controls.Add(frm_R_RedigerOmråde_vrb);
        //        frm_R_RedigerOmråde_vrb.Show();
        //    }
        //}

        private void BtnEndreObjektsymbol_Click(object sender, EventArgs e)
        {
            Frm_R_EndreObjektsymbol frm_R_EndreObjektsymbol_vrb = new Frm_R_EndreObjektsymbol() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ÅpneFormFraMenyknapp((Button)sender, e, frm_R_EndreObjektsymbol_vrb);
            //if (pnlNav.Top != btnLeggTilBilde.Top)
            //{
            //    AlleKnapperTilStandardFargeR();
            //    btnLeggTilBilde.BackColor = Globalekonstanter.knapp_trykket;

            //    //Flytte oransjePanelet til rett plass
            //    FlyttNavigasjonsPanel(btnLeggTilBilde.Height, btnLeggTilBilde.Top);

            //    SlettHjelpeMarkørerOgOmråder();

            //    OmrådeKlikkbare();

            //    ResettLøpenummerTilRedigering();

            //    //legge inn rett form i panelet
            //    PnlFormLoader.Controls.Clear();
            //    frm_R_EndreObjektsymbol frm_R_LeggTilBilde_vrb = new frm_R_EndreObjektsymbol() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //    frm_R_LeggTilBilde_vrb.FormBorderStyle = FormBorderStyle.None;
            //    PnlFormLoader.Controls.Add(frm_R_LeggTilBilde_vrb);
            //    frm_R_LeggTilBilde_vrb.Show();
            //}
        }

        private void BtnFjernObjektOmråde_Click(object sender, EventArgs e)
        {
            Frm_R_FjernObjektOmråde frm_R_FjernObjektOmråde_vrb = new Frm_R_FjernObjektOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ÅpneFormFraMenyknapp((Button)sender, e, frm_R_FjernObjektOmråde_vrb);
            //if (pnlNav.Top != btnFjernObjektOmråde.Top)
            //{
            //    AlleKnapperTilStandardFargeR();
            //    btnFjernObjektOmråde.BackColor = Globalekonstanter.knapp_trykket;

            //    //Flytte oransjePanelet til rett plass
            //    FlyttNavigasjonsPanel(btnFjernObjektOmråde.Height, btnFjernObjektOmråde.Top);

            //    OmrådeKlikkbare();

            //    SlettHjelpeMarkørerOgOmråder();

            //    ResettLøpenummerTilRedigering();

            //    //legge inn rett form i panelet
            //    this.PnlFormLoader.Controls.Clear();
            //    frm_R_FjernObjektOmråde frm_R_FjernObjektOmråde_vrb = new frm_R_FjernObjektOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //    frm_R_FjernObjektOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
            //    this.PnlFormLoader.Controls.Add(frm_R_FjernObjektOmråde_vrb);
            //    frm_R_FjernObjektOmråde_vrb.Show();
            //}
        }

        private void FrmRediger_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmVisning.instance.Size = Size;
            frmVisning.instance.Location = Location;
            frmVisning.instance.map.Position = map.Position;
            frmVisning.instance.map.Zoom = map.Zoom;


            PnlFormLoader.Controls.Clear();
            InstanceNull();
            
            frmVisning.instance.Show();
        }

        private void InstanceNull()
        {
            if (Frm_R_FjernObjektOmråde.instance != null)
                Frm_R_FjernObjektOmråde.instance = null;

            if (Frm_R_LeggTilObjekt.instance != null)
                Frm_R_LeggTilObjekt.instance = null;

            if (Frm_R_LeggTilOmråde.instance != null)
                Frm_R_LeggTilOmråde.instance = null;

            if (Frm_R_RedigerObjekt.instance != null)
                Frm_R_RedigerObjekt.instance = null;

            if (Frm_R_RedigerOmråde.instance != null)
                Frm_R_RedigerOmråde.instance = null;

            if (Frm_R_EndreObjektsymbol.instance != null)
                Frm_R_EndreObjektsymbol.instance = null;

            if (instance != null)
                instance = null;
        }

        public void FlyttNavigasjonsPanel(int høyde, int top)
        {
            //henter Høyde på knapp og hvor toppen er plassert 
            pnlNav.Height = høyde;
            pnlNav.Top = top;
            //Denne trenger kun å bli utført en gang, men er med forsikkerhetskyld 
            pnlNav.Left = btnLeggTilObjekt.Left;
        }

        private void Map_MouseDoubleClick(PointLatLng pointClick, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoubleClick_punkt = map.FromLocalToLatLng(e.X, e.Y);
                //List<PointLatLng> Lpunkt = new List<PointLatLng>();
                //Lpunkt.Add(DoubleClick_punkt);

                double lat = DoubleClick_punkt.Lat;
                double lang = DoubleClick_punkt.Lng;

                if (Frm_R_LeggTilObjekt.instance != null)
                {
                    Frm_R_LeggTilObjekt.instance.FyllKoordinater(lat, lang);
                }
                if (Frm_R_LeggTilOmråde.instance != null)
                {
                    Frm_R_LeggTilOmråde.instance.FyllKoordinater(lat, lang);

                    //tegner hjelpeområde, med punkt burker har klikket 
                    if(Frm_R_LeggTilOmråde.instance.pointLatLngs.Count >= 1)
                    {
                        Kart.FjernHjelpeOmråde();

                        List<PointLatLng> Punkter = Frm_R_LeggTilOmråde.instance.pointLatLngs.ToList();
                        
                        Kart.TegnHjelpeOmråde_rediger(DoubleClick_punkt, Punkter);

                    }
                }
                if (Frm_R_RedigerObjekt.instance != null)
                {
                    Frm_R_RedigerObjekt.instance.FyllKoordinater(lat, lang);
                }
                if (Frm_R_RedigerOmråde.instance != null)
                {
                    Frm_R_RedigerOmråde.instance.FyllKoordinater(lat, lang);

                    if (Frm_R_RedigerOmråde.instance.løpenummer_til_redigering != -1) // for å unngå at den tegner hvis den ikke er inni "RedigerOmråde"
                    {
                        
                        if (Frm_R_RedigerOmråde.instance.pointLatLngs.Count >= 1) // tegne område underveis 
                        {
                            Kart.FjernHjelpeOmråde();

                            List<PointLatLng> Punkter = Frm_R_RedigerOmråde.instance.pointLatLngs.ToList();

                            Kart.TegnHjelpeOmråde_rediger(DoubleClick_punkt, Punkter);

                        }
                    }
                   
                }

                Kart.FjernAlleMarkører_redigier(Globalekonstanter.NavnHjelpeMarkør); //"HjelpeMarkør"
                Kart.LeggtilMarkør(Kart.MuligKart.Redigering, new PointLatLng(lat, lang), -1, Globalekonstanter.NavnHjelpeMarkør); //"HjelpeMarkør"
                Kart.reff(Kart.MuligKart.Redigering);
            }
        }

        public void Map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if(Convert.ToInt32(item.Tag) != -1)
            {
                //skal ikke åpne redigeringform hvis den er på fjerne eller er der allerede 
                if (pnlNav.Top == btnRedigerObjekt.Top) { }
                else if (pnlNav.Top != btnFjernObjektOmråde.Top)
                {
                    Frm_R_RedigerObjekt frm_R_RedigerObjekt_vrb = new Frm_R_RedigerObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    ÅpneFormFraMenyknapp(btnRedigerObjekt, e, frm_R_RedigerObjekt_vrb);
                }

                if (Frm_R_FjernObjektOmråde.instance != null)
                {
                    Frm_R_FjernObjektOmråde.instance.FyllInfoObjekt(Convert.ToInt32(item.Tag));
                }
                if (Frm_R_RedigerObjekt.instance != null)
                {
                    Frm_R_RedigerObjekt.instance.FyllInfoObjekt(Convert.ToInt32(item.Tag));
                }
            }
           
        }

        private void Map_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            //skal ikke åpne redigeringform hvis den er på fjerne eller er der allerede 
            if (pnlNav.Top == btnRedigerOmråde.Top) {  }  
            else if (pnlNav.Top != btnFjernObjektOmråde.Top)
            {
                Frm_R_RedigerOmråde frm_R_RedigerOmråde_vrb = new Frm_R_RedigerOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                ÅpneFormFraMenyknapp(btnRedigerOmråde, e, frm_R_RedigerOmråde_vrb);
                //ÅpneRediger_områdeForm();
            }
            

            if (Frm_R_RedigerOmråde.instance != null)
            {
                Frm_R_RedigerOmråde.instance.FyllInfoOmråde(Convert.ToInt32(item.Tag));

                if (Frm_R_RedigerOmråde.instance.pointLatLngs.Count >= 1)
                {
                    //slette hvis noen har allrede 
                    SlettHjelpeMarkørerOgOmråder();

                    //tegn område for valgt
                    List<PointLatLng> PunkteListe = Frm_R_RedigerOmråde.instance.pointLatLngs.ToList();

                    if (Kart.SjekkKartHarHjelpemarkør_redigier("HjelpeMarkør"))
                    {
                        Kart.TegnHjelpeOmråde_rediger(FrmRediger.DoubleClick_punkt, PunkteListe);
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
            if (Frm_R_FjernObjektOmråde.instance != null)
            {
                Frm_R_FjernObjektOmråde.instance.FyllInfoOmråde(Convert.ToInt32(item.Tag));
            }

        }

        private void BtnZoomPluss_Click(object sender, EventArgs e)
        {
            map.Zoom++;
        }

        private void BtnZoomMinus_Click(object sender, EventArgs e)
        {
            map.Zoom--;
        }

        private void ResettLøpenummerTilRedigering()
        {
            if(Frm_R_RedigerObjekt.instance != null)
            {
                Frm_R_RedigerObjekt.instance.løpenummer_til_redigering = -1;
            }       
            if (Frm_R_RedigerOmråde.instance != null)
            {
                Frm_R_RedigerOmråde.instance.løpenummer_til_redigering = -1;
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

        private void CbOmråde_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOmråde.Checked)
            {
                cbOmråde.Text = "Kan klikke på eksisterende område";
                cbOmråde.BackColor = ThemeDesign.colorSecondaryBackground;
                cbOmråde.ForeColor = ThemeDesign.colorGreen;

                FrmRediger.OmrådeKlikkBar = true;
                Kart.AlleOmrådeTilgjenlighet(true);
            }
            else
            {
                cbOmråde.Text = "Kan ikke klikke på eksisterende område";
                //cbOmråde.BackColor = ThemeDesign.colorSecondaryBackground;
                //cbOmråde.ForeColor = ThemeDesign.colorRed;
                cbOmråde.BackColor = Color.Red;
                cbOmråde.ForeColor = Color.Black;

                FrmRediger.OmrådeKlikkBar = false;
                Kart.AlleOmrådeTilgjenlighet(false);
            }
        }
    }
}
