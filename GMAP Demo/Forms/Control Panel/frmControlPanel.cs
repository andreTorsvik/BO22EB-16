using System;
using System.Drawing;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class FrmControlPanel : Form
    {
        public static FrmControlPanel instance;
        //private Color knapp_trykket;
        public double lng;
        public double lat;
        public FrmControlPanel()
        {
            InitializeComponent();
            instance = this;

            //sette Blåpanel til vesntre for Posisjonknapp 
            FlyttNavigasjonsPanel(btnLoggUt.Height, btnLoggUt.Top);

            

            PnlFormLoader.Controls.Clear();
            Frm_CP_LoggUt frm_S_LoggInn_vrb = new Frm_CP_LoggUt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_S_LoggInn_vrb.FormBorderStyle = FormBorderStyle.None;
            PnlFormLoader.Controls.Add(frm_S_LoggInn_vrb);
            frm_S_LoggInn_vrb.Show();

            SetTheme();

            btnLoggUt.BackColor = Globalekonstanter.knapp_trykket;
        }

        internal void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;

            pnlMenu.BackColor = ThemeDesign.colorSecondaryBackground;
            btnLoggUt.ForeColor = ThemeDesign.colorPurple;
            btnLoggUt.BackColor = ThemeDesign.colorSecondaryGroupedBackground;
            btnStartPosisjon.ForeColor = ThemeDesign.colorPurple;
            btnStartPosisjon.BackColor = ThemeDesign.colorSecondaryBackground;
            btnAdmin.ForeColor = ThemeDesign.colorPurple;
            btnAdmin.BackColor = ThemeDesign.colorSecondaryBackground;
            btnFjernKategori.ForeColor = ThemeDesign.colorPurple;
            btnFjernKategori.BackColor = ThemeDesign.colorSecondaryBackground;
            btnTilbake.ForeColor = ThemeDesign.colorPurple;
            btnTilbake.BackColor = ThemeDesign.colorSecondaryBackground;

            PnlFormLoader.BackColor = ThemeDesign.colorSecondaryBackground;
        }

        private void BtnTilbake_Click(object sender, EventArgs e)
        {
            Close();
            //frmsettings_FormClosing blir utført 
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            //PnlFormLoader.Controls.Clear();
            if (frmVisning.instance != null)
                frmVisning.instance.Show();

            if (instance != null)
                instance = null;
        }

        internal void AlleKnapperTilStandardFargeCP()
        {
            Color StandarFarge = Globalekonstanter.StandardFargeKnapp;

            btnLoggUt.BackColor = StandarFarge;
            btnStartPosisjon.BackColor = StandarFarge;
            btnAdmin.BackColor = StandarFarge;
            btnFjernKategori.BackColor = StandarFarge;
            btnChangeTheme.BackColor = StandarFarge;

        }

        private void BtnLoggInn_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnLoggUt.Top)
            {
                AlleKnapperTilStandardFargeCP();
                btnLoggUt.BackColor = Globalekonstanter.knapp_trykket;

                FlyttNavigasjonsPanel(btnLoggUt.Height, btnLoggUt.Top);

                PnlFormLoader.Controls.Clear();
                Frm_CP_LoggUt frm_S_LoggInn_vrb = new Frm_CP_LoggUt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_S_LoggInn_vrb.FormBorderStyle = FormBorderStyle.None;
                PnlFormLoader.Controls.Add(frm_S_LoggInn_vrb);
                frm_S_LoggInn_vrb.Show();
            }
        }

        private void BtnStartPosisjon_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnStartPosisjon.Top)
            {
                AlleKnapperTilStandardFargeCP();
                btnStartPosisjon.BackColor = Globalekonstanter.knapp_trykket;

                FlyttNavigasjonsPanel(btnStartPosisjon.Height, btnStartPosisjon.Top);

                PnlFormLoader.Controls.Clear();
                Frm_CP_StartPosisjon frm_S_StartPosisjon_vrb = new Frm_CP_StartPosisjon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_S_StartPosisjon_vrb.FormBorderStyle = FormBorderStyle.None;
                PnlFormLoader.Controls.Add(frm_S_StartPosisjon_vrb);
                frm_S_StartPosisjon_vrb.Show();
            }
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnAdmin.Top)
            {
                AlleKnapperTilStandardFargeCP();
                btnAdmin.BackColor = Globalekonstanter.knapp_trykket;

                FlyttNavigasjonsPanel(btnAdmin.Height, btnAdmin.Top);

                PnlFormLoader.Controls.Clear();
                Frm_CP_Admin frm_S_Admin_vrb = new Frm_CP_Admin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_S_Admin_vrb.FormBorderStyle = FormBorderStyle.None;
                PnlFormLoader.Controls.Add(frm_S_Admin_vrb);
                frm_S_Admin_vrb.Show();
            }
        }

        private void BtnFjernKategori_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnFjernKategori.Top)
            {
                AlleKnapperTilStandardFargeCP();
                btnFjernKategori.BackColor = Globalekonstanter.knapp_trykket;

                FlyttNavigasjonsPanel(btnFjernKategori.Height, btnFjernKategori.Top);

                PnlFormLoader.Controls.Clear();
                Frm_CP_FjernKategori frm_S_BrukerInfo_vrb = new Frm_CP_FjernKategori() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_S_BrukerInfo_vrb.FormBorderStyle = FormBorderStyle.None;
                PnlFormLoader.Controls.Add(frm_S_BrukerInfo_vrb);
                frm_S_BrukerInfo_vrb.Show();
            }
        }

        public void FlyttNavigasjonsPanel(int høyde, int top)
        {
            //Henter Høyde på knapp og hvor toppen er plassert.
            pnlNav.Height = høyde;
            pnlNav.Top = top;
            //Denne trenger kun å bli utført en gang.
            pnlNav.Left = btnLoggUt.Left;
        }

        private void BtnChangeTheme_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnChangeTheme.Top)
            {
                AlleKnapperTilStandardFargeCP();
                btnChangeTheme.BackColor = Globalekonstanter.knapp_trykket;

                FlyttNavigasjonsPanel(btnChangeTheme.Height, btnChangeTheme.Top);

                PnlFormLoader.Controls.Clear();
                Frm_CP_EndreUtseende frm_CP_EndeUtseende_vrb = new Frm_CP_EndreUtseende() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_CP_EndeUtseende_vrb.FormBorderStyle = FormBorderStyle.None;
                PnlFormLoader.Controls.Add(frm_CP_EndeUtseende_vrb);
                frm_CP_EndeUtseende_vrb.Show();
            }
        }

        private void FrmControlPanel_Load(object sender, EventArgs e)
        {
            MinimumSize = new System.Drawing.Size(1000, 750);
        }

        public void OppdaterThemeKnapp()
        {
            instance.AlleKnapperTilStandardFargeCP();
            btnChangeTheme.BackColor = Globalekonstanter.knapp_trykket;
        }
    }
}
