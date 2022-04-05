using System;
using System.Drawing;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class frmSettings : Form
    {
        public static frmSettings instance;
        private Color knapp_trykket;
        public frmSettings()
        {
            InitializeComponent();
            instance = this;
            knapp_trykket = Color.FromArgb(46, 51, 73);
            //sette Blåpanel til vesntre for Posisjonknapp 
            FlyttNavigasjonsPanel(btnLoggUt.Height, btnLoggUt.Top);

            btnLoggUt.BackColor = knapp_trykket;

            this.PnlFormLoader.Controls.Clear();
            frm_S_LoggUt frm_S_LoggInn_vrb = new frm_S_LoggUt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_S_LoggInn_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_S_LoggInn_vrb);
            frm_S_LoggInn_vrb.Show();

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
        private void btnTilbake_Click(object sender, EventArgs e)
        {
            this.Close();
            //frmsettings_FormClosing blir utført 
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            PnlFormLoader.Controls.Clear();

            FrmVisning.instance.Show();
        }

        void AlleKnapperTilStandarfarge()
        {
            Color StandarFarge = Color.FromArgb(24, 30, 54);

            btnLoggUt.BackColor = StandarFarge;
            btnStartPosisjon.BackColor = StandarFarge;
            btnLeggTilBilde.BackColor = StandarFarge;
            btnAdmin.BackColor = StandarFarge;
            btnBrukerInfo.BackColor = StandarFarge;
            btnDatabaseView.BackColor = StandarFarge;
            btnEkstra.BackColor = StandarFarge;
        }

        private void btnLoggInn_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnLoggUt.Top)
            {
                AlleKnapperTilStandarfarge();
                btnLoggUt.BackColor = knapp_trykket;

                FlyttNavigasjonsPanel(btnLoggUt.Height, btnLoggUt.Top);

                this.PnlFormLoader.Controls.Clear();
                frm_S_LoggUt frm_S_LoggInn_vrb = new frm_S_LoggUt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_S_LoggInn_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_S_LoggInn_vrb);
                frm_S_LoggInn_vrb.Show();
            }

        }

        private void btnStartPosisjon_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnStartPosisjon.Top)
            {
                AlleKnapperTilStandarfarge();
                btnStartPosisjon.BackColor = knapp_trykket;

                FlyttNavigasjonsPanel(btnStartPosisjon.Height, btnStartPosisjon.Top);

                this.PnlFormLoader.Controls.Clear();
                Frm_S_StartPosisjon frm_S_StartPosisjon_vrb = new Frm_S_StartPosisjon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_S_StartPosisjon_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_S_StartPosisjon_vrb);
                frm_S_StartPosisjon_vrb.Show();
            }

        }

        private void btnLeggTilBilde_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnLeggTilBilde.Top)
            {
                AlleKnapperTilStandarfarge();
                btnLeggTilBilde.BackColor = knapp_trykket;

                FlyttNavigasjonsPanel(btnLeggTilBilde.Height, btnLeggTilBilde.Top);

                this.PnlFormLoader.Controls.Clear();
                frm_S_LeggTilBilde frm_S_LeggTilBilde_vrb = new frm_S_LeggTilBilde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_S_LeggTilBilde_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_S_LeggTilBilde_vrb);
                frm_S_LeggTilBilde_vrb.Show();
            }


        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnAdmin.Top)
            {
                AlleKnapperTilStandarfarge();
                btnAdmin.BackColor = knapp_trykket;

                FlyttNavigasjonsPanel(btnAdmin.Height, btnAdmin.Top);

                this.PnlFormLoader.Controls.Clear();
                frm_S_Admin frm_S_Admin_vrb = new frm_S_Admin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_S_Admin_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_S_Admin_vrb);
                frm_S_Admin_vrb.Show();
            }

        }

        private void btnBrukerInfo_Click(object sender, EventArgs e)
        {

            if (pnlNav.Top != btnBrukerInfo.Top)
            {
                AlleKnapperTilStandarfarge();
                btnBrukerInfo.BackColor = knapp_trykket;

                FlyttNavigasjonsPanel(btnBrukerInfo.Height, btnBrukerInfo.Top);

                this.PnlFormLoader.Controls.Clear();
                frm_S_BrukerInfo frm_S_BrukerInfo_vrb = new frm_S_BrukerInfo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_S_BrukerInfo_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_S_BrukerInfo_vrb);
                frm_S_BrukerInfo_vrb.Show();
            }

        }

        private void btnEkstra_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnEkstra.Top)
            {
                AlleKnapperTilStandarfarge();
                btnEkstra.BackColor = knapp_trykket;

                //pnlNav.Left = btnEkstra.Left;
                FlyttNavigasjonsPanel(btnEkstra.Height, btnEkstra.Top);
            }

        }



        private void btnDatabaseView_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmDatabaseView frmDatabaseView = new frmDatabaseView();
            frmDatabaseView.Size = this.Size;
            frmDatabaseView.Location = this.Location;
            frmDatabaseView.Show();
        }

        public void FlyttNavigasjonsPanel(int høyde, int top)
        {
            //henter Høyde på knapp og hvor toppen er plassert 
            pnlNav.Height = høyde;
            pnlNav.Top = top;
            //Denne trenger kun å bli utført en gang, men er med forsikkerhetskyld 
            pnlNav.Left = btnLoggUt.Left;
        }

       
    }
}
