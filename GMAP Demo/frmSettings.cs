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
        public frmSettings()
        {
            InitializeComponent();

            //sette Blåpanel til vesntre for Posisjonknapp 
            pnlNav.Height = btnLoggInn.Height;
            pnlNav.Top = btnLoggInn.Top;
            pnlNav.Left = btnLoggInn.Left;
            btnLoggInn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
        private void btnTilbake_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        void AlleKnapperTilStandarfarge()
        {
            btnLoggInn.BackColor = Color.FromArgb(24, 30, 54);
            btnStartPosisjon.BackColor = Color.FromArgb(24, 30, 54);
            btnLeggTilBilde.BackColor = Color.FromArgb(24, 30, 54);
            btnEndreBilde.BackColor = Color.FromArgb(24, 30, 54);
            btnDatabase.BackColor = Color.FromArgb(24, 30, 54);
            btnBrukerInfo.BackColor = Color.FromArgb(24, 30, 54);
            btnEkstra.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnLoggInn_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            pnlNav.Height = btnLoggInn.Height;
            pnlNav.Top = btnLoggInn.Top;
            pnlNav.Left = btnLoggInn.Left;
            btnLoggInn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnStartPosisjon_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            pnlNav.Height = btnStartPosisjon.Height;
            pnlNav.Top = btnStartPosisjon.Top;
            pnlNav.Left = btnStartPosisjon.Left;
            btnStartPosisjon.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnLeggTilBilde_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            pnlNav.Height = btnLeggTilBilde.Height;
            pnlNav.Top = btnLeggTilBilde.Top;
            pnlNav.Left = btnLeggTilBilde.Left;
            btnLeggTilBilde.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnEndreBilde_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            pnlNav.Height = btnEndreBilde.Height;
            pnlNav.Top = btnEndreBilde.Top;
            pnlNav.Left = btnEndreBilde.Left;
            btnEndreBilde.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            pnlNav.Height = btnDatabase.Height;
            pnlNav.Top = btnDatabase.Top;
            pnlNav.Left = btnDatabase.Left;
            btnDatabase.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnBrukerInfo_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            pnlNav.Height = btnBrukerInfo.Height;
            pnlNav.Top = btnBrukerInfo.Top;
            pnlNav.Left = btnBrukerInfo.Left;
            btnBrukerInfo.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnEkstra_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            pnlNav.Height = btnEkstra.Height;
            pnlNav.Top = btnEkstra.Top;
            pnlNav.Left = btnEkstra.Left;
            btnEkstra.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
