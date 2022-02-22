using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace GMAP_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlNav.Hide();
            
            //start form
            this.PnlFormLoader.Controls.Clear();
            frmPosisjon frmPosisjon_vrb = new frmPosisjon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPosisjon_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmPosisjon_vrb);
            frmPosisjon_vrb.Show();

            //start posisjon kart
            map.MapProvider = GMapProviders.OpenStreetMap;
            PointLatLng point = new PointLatLng(60.36893643470203, 5.350878781967968);
            map.Position = point;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //kode for å få runde kanter

            //settings for kart
            map.MinZoom = 0; // min zoom level
            map.MaxZoom = 27; // maximum
            map.Zoom = 17;
            map.DragButton = MouseButtons.Left;
            map.ShowCenter = true; // false om man vil ha den bort
        }

        private void btnPoisjon_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnPoisjon.Height;
            pnlNav.Top = btnPoisjon.Top;
            pnlNav.Left = btnPoisjon.Left;
            btnPoisjon.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            frmPosisjon frmPosisjon_vrb = new frmPosisjon() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPosisjon_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmPosisjon_vrb);
            frmPosisjon_vrb.Show();

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnFilter.Height;
            pnlNav.Top = btnFilter.Top;
            btnFilter.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            frmFilter frmPosisjon_vrb = new frmFilter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmPosisjon_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frmPosisjon_vrb);
            frmPosisjon_vrb.Show();

        }

        private void btnOppdater_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnOppdater.Height;
            pnlNav.Top = btnOppdater.Top;
            btnOppdater.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnRediger_Click(object sender, EventArgs e)
        {
            pnlNav.Show();
            pnlNav.Height = btnRediger.Height;
            pnlNav.Top = btnRediger.Top;
            btnRediger.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
           
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnPoisjon_Leave(object sender, EventArgs e)
        {
            btnPoisjon.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnFilter_Leave(object sender, EventArgs e)
        {
            btnFilter.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnOppdater_Leave(object sender, EventArgs e)
        {
            btnOppdater.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnRediger_Leave(object sender, EventArgs e)
        {
            btnRediger.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
