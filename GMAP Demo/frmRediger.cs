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
using GMap.NET;
using GMap.NET.MapProviders;

namespace GMAP_Demo
{
    public partial class frmRediger : Form
    {
        public frmRediger()
        {
            InitializeComponent();



            //sette OransjePanelet til Posisjonknapp
            pnlNav.Height = btnObjekt.Height;
            pnlNav.Top = btnObjekt.Top;
            pnlNav.Left = btnObjekt.Left;
            btnObjekt.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void frmRediger_Load(object sender, EventArgs e)
        {
            SetupKart();
            
        }
    

        private void btnTilbake_Click(object sender, EventArgs e)
        {
            Form1.Punkt_til_neste_kart = map.Position;
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        void KnappefargeTilStandar()
        {
            btnObjekt.BackColor = Color.FromArgb(24, 30, 54);
            btnOmråde.BackColor = Color.FromArgb(24, 30, 54);
            btnRediger_obj_områ.BackColor = Color.FromArgb(24, 30, 54);
            btnFjern_obj_områ.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnObjekt_Click(object sender, EventArgs e)
        {

            KnappefargeTilStandar();


            pnlNav.Height = btnObjekt.Height;
            pnlNav.Top = btnObjekt.Top;
            pnlNav.Left = btnObjekt.Left;
            btnObjekt.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnOmråde_Click(object sender, EventArgs e)
        {

            KnappefargeTilStandar();


            pnlNav.Height = btnOmråde.Height;
            pnlNav.Top = btnOmråde.Top;
            pnlNav.Left = btnOmråde.Left;
            btnOmråde.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnRediger_obj_områ_Click(object sender, EventArgs e)
        {

            KnappefargeTilStandar();


            pnlNav.Height = btnRediger_obj_områ.Height;
            pnlNav.Top = btnRediger_obj_områ.Top;
            pnlNav.Left = btnRediger_obj_områ.Left;
            btnRediger_obj_områ.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnFjern_obj_områ_Click(object sender, EventArgs e)
        {

            KnappefargeTilStandar();


            pnlNav.Height = btnFjern_obj_områ.Height;
            pnlNav.Top = btnFjern_obj_områ.Top;
            pnlNav.Left = btnFjern_obj_områ.Left;
            btnFjern_obj_områ.BackColor = Color.FromArgb(46, 51, 73);
        }

        void SetupKart()
        {
            //start posisjon kart
            map.MapProvider = GMapProviders.OpenStreetMap;
            //PointLatLng point = new PointLatLng(60.36893643470203, 5.350878781967968);
            PointLatLng point = Form1.Punkt_til_neste_kart;
            map.Position = point;

            //settings for kart
            map.MinZoom = 0; // min zoom level
            map.MaxZoom = 27; // maximum
            map.Zoom = 17;
            map.DragButton = MouseButtons.Left;
            map.ShowCenter = true; // false om man vil ha den bort
        }

        private void frmRediger_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            //uten denne funskjone vil programmet forsatt være i debugging 
            //når man trykker "X"
        }
    }
}
