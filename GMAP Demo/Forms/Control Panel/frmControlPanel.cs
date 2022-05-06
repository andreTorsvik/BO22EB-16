using System;
using System.Drawing;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class FrmControlPanel : Form
    {
        public static FrmControlPanel instance;

        public double lng;
        public double lat;
        public FrmControlPanel()
        {
            InitializeComponent();
            instance = this;

            SetTheme();

            Frm_CP_LoggUt frm_S_LoggInn_vrb = new Frm_CP_LoggUt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ÅpneFormFraMenyknapp(btnLoggUt, frm_S_LoggInn_vrb);
        }

        private void FrmControlPanel_Load(object sender, EventArgs e)
        {
            MinimumSize = Globalekonstanter.frmWithMenuMinimumSize;
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

        private void BtnLoggInn_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Top != pnlNav.Top)
            {
                Frm_CP_LoggUt frm_CP_LoggUt_vrb = new Frm_CP_LoggUt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                ÅpneFormFraMenyknapp((Button)sender, frm_CP_LoggUt_vrb);
            }
        }

        private void BtnStartPosisjon_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Top != pnlNav.Top)
            {
                Frm_CP_StartPosisjon frm_CP_StartPosisjon_vrb = new Frm_CP_StartPosisjon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                ÅpneFormFraMenyknapp((Button)sender, frm_CP_StartPosisjon_vrb);
            }
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Top != pnlNav.Top)
            {
                Frm_CP_Admin frm_CP_Admin_vrb = new Frm_CP_Admin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                ÅpneFormFraMenyknapp((Button)sender, frm_CP_Admin_vrb);
            }
        }

        private void BtnFjernKategori_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Top != pnlNav.Top)
            {
                Frm_CP_FjernKategori frm_CP_FjernKategori_vrb = new Frm_CP_FjernKategori() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                ÅpneFormFraMenyknapp((Button)sender, frm_CP_FjernKategori_vrb);
            }
        }

        private void BtnChangeTheme_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Top != pnlNav.Top)
            {
                Frm_CP_EndreUtseende frm_CP_EndeUtseende_vrb = new Frm_CP_EndreUtseende() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                ÅpneFormFraMenyknapp((Button)sender, frm_CP_EndeUtseende_vrb);
            }
        }

        private void ÅpneFormFraMenyknapp(Button sender, Form target)
        {
            if (pnlNav.Top != sender.Top)
            {
                // Endrer fargen på alle knapper  
                AlleKnapperTilStandardFargeCP();

                // Ender fargen på knappen som har blitt trykket 
                sender.BackColor = Globalekonstanter.knapp_trykket;

                // Flyter navigasjonspanel til riktig knapp 
                FlyttNavigasjonsPanel(sender.Height, sender.Top);

                // Tømmer panelet for innhold
                PnlFormLoader.Controls.Clear();

                // Legg til formen med riktig instillinger 
                target.FormBorderStyle = FormBorderStyle.None;
                PnlFormLoader.Controls.Add(target);
                target.Show();
            }
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

        internal void FlyttNavigasjonsPanel(int høyde, int top)
        {
            // Henter Høyde på knapp og hvor toppen er plassert.
            pnlNav.Height = høyde;
            pnlNav.Top = top;

            // Denne trenger kun å bli utført en gang.
            pnlNav.Left = btnLoggUt.Left;
        }
        
        internal void OppdaterThemeKnapp()
        {
            instance.AlleKnapperTilStandardFargeCP();
            btnChangeTheme.BackColor = Globalekonstanter.knapp_trykket;
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            //PnlFormLoader.Controls.Clear();
            if (FrmVisning.instance != null)
                FrmVisning.instance.Show();

            if (instance != null)
                instance = null;
        }


    }
}
