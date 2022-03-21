using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            FlyttNavigasjonsPanel(btnLoggInn.Height, btnLoggInn.Top);

            btnLoggInn.BackColor = knapp_trykket;

            this.PnlFormLoader.Controls.Clear();
            frm_S_LoggInn frm_S_LoggInn_vrb = new frm_S_LoggInn() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_S_LoggInn_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_S_LoggInn_vrb);
            frm_S_LoggInn_vrb.Show();

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            //ClientSize = new Size(Form1.Windubrede,Form1.WinduHøyde);
        }
        private void btnTilbake_Click(object sender, EventArgs e)
        {
            PnlFormLoader.Controls.Clear();

            Form1.instance.Show();
            this.Close(); 
        }

        void AlleKnapperTilStandarfarge()
        {
            Color StandarFarge = Color.FromArgb(24, 30, 54);

            btnLoggInn.BackColor = StandarFarge;
            btnStartPosisjon.BackColor = StandarFarge;
            btnLeggTilBilde.BackColor = StandarFarge;
            btnEndreBilde.BackColor = StandarFarge;
            btnBrukerInfo.BackColor = StandarFarge;
            btnDatabaseView.BackColor = StandarFarge;
            btnEkstra.BackColor = StandarFarge;
        }

        private void btnLoggInn_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnLoggInn.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnLoggInn.Height, btnLoggInn.Top);

            this.PnlFormLoader.Controls.Clear();
            frm_S_LoggInn frm_S_LoggInn_vrb = new frm_S_LoggInn() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_S_LoggInn_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_S_LoggInn_vrb);
            frm_S_LoggInn_vrb.Show();
        }

        private void btnStartPosisjon_Click(object sender, EventArgs e)
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

        private void btnLeggTilBilde_Click(object sender, EventArgs e)
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

        private void btnEndreBilde_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnEndreBilde.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnEndreBilde.Height, btnEndreBilde.Top);

            this.PnlFormLoader.Controls.Clear();
            frm_S_EndreLagretBilde frm_S_EndreLagretBilde_vrb = new frm_S_EndreLagretBilde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_S_EndreLagretBilde_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_S_EndreLagretBilde_vrb);
            frm_S_EndreLagretBilde_vrb.Show();
        }


        private void btnBrukerInfo_Click(object sender, EventArgs e)
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

        private void btnEkstra_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnEkstra.BackColor = knapp_trykket;

            //pnlNav.Left = btnEkstra.Left;
            FlyttNavigasjonsPanel(btnEkstra.Height, btnEkstra.Top);
        }



        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnDatabaseView_Click(object sender, EventArgs e)
        {
            PnlFormLoader.Controls.Clear();
            this.Close();
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
            pnlNav.Left = btnLoggInn.Left;
        }
    }
}
