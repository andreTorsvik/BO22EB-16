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



            //sette oransjePanelet til Posisjonknapp
            pnlNav.Height = btnObjekt.Height;
            pnlNav.Top = btnObjekt.Top;
            pnlNav.Left = btnObjekt.Left;
            btnObjekt.BackColor = Color.FromArgb(46, 51, 73);

            this.PnlFormLoader.Controls.Clear();
            frm_R_LeggTilObjekt frm_R_LeggTilObjekt_vrb = new frm_R_LeggTilObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_LeggTilObjekt_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_R_LeggTilObjekt_vrb);
            frm_R_LeggTilObjekt_vrb.Show();
        }

        private void frmRediger_Load(object sender, EventArgs e)
        {
            SetupKart();
            
        }

        void SetupKart()
        {
            //start posisjon kart
            map.MapProvider = GMapProviders.OpenStreetMap;
            PointLatLng point = Form1.Punkt_til_neste_kart;
            map.Position = point;

            //settings for kart
            map.MinZoom = 0; // min zoom level
            map.MaxZoom = 27; // maximum
            map.Zoom = 17;
            map.DragButton = MouseButtons.Left;
            map.ShowCenter = true; // false om man vil ha den bort
        }
        private void btnTilbake_Click(object sender, EventArgs e)
        {
            Form1.Punkt_til_neste_kart = map.Position;
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        void AlleKnapperTilStandarfarge()
        {
            btnObjekt.BackColor = Color.FromArgb(24, 30, 54);
            btnOmråde.BackColor = Color.FromArgb(24, 30, 54);
            btnRediger_obj_områ.BackColor = Color.FromArgb(24, 30, 54);
            btnFjern_obj_områ.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnObjekt_Click(object sender, EventArgs e)
        {

            AlleKnapperTilStandarfarge();

            //Flytte oransjePanelet til rett plass
            pnlNav.Height = btnObjekt.Height;
            pnlNav.Top = btnObjekt.Top;
            btnObjekt.BackColor = Color.FromArgb(46, 51, 73);

            //legge inn rett forms i panelet
            this.PnlFormLoader.Controls.Clear();
            frm_R_LeggTilObjekt frm_R_LeggTilObjekt_vrb = new frm_R_LeggTilObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_LeggTilObjekt_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_R_LeggTilObjekt_vrb);
            frm_R_LeggTilObjekt_vrb.Show();
        }

        private void btnOmråde_Click(object sender, EventArgs e)
        {

            AlleKnapperTilStandarfarge();

            //Flytte oransjePanelet til rett plass
            pnlNav.Height = btnOmråde.Height;
            pnlNav.Top = btnOmråde.Top;
            btnOmråde.BackColor = Color.FromArgb(46, 51, 73);

            //legge inn rett form i panelet
            this.PnlFormLoader.Controls.Clear();
            frm_R_LeggTilOmråde frm_R_LeggTilOmråde_vrb = new frm_R_LeggTilOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_LeggTilOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_R_LeggTilOmråde_vrb);
            frm_R_LeggTilOmråde_vrb.Show();
        }

        private void btnRediger_obj_områ_Click(object sender, EventArgs e)
        {

            AlleKnapperTilStandarfarge();

            //Flytte oransjePanelet til rett plass
            pnlNav.Height = btnRediger_obj_områ.Height;
            pnlNav.Top = btnRediger_obj_områ.Top;

            btnRediger_obj_områ.BackColor = Color.FromArgb(46, 51, 73);

            //legge inn rett form i panelet
            this.PnlFormLoader.Controls.Clear();
            frm_R_RedigerObjektOmråde frm_R_RedigerObjektOmråde_vrb = new frm_R_RedigerObjektOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_RedigerObjektOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_R_RedigerObjektOmråde_vrb);
            frm_R_RedigerObjektOmråde_vrb.Show();
        }

        private void btnFjern_obj_områ_Click(object sender, EventArgs e)
        {

            AlleKnapperTilStandarfarge();

            //Flytte oransjePanelet til rett plass
            pnlNav.Height = btnFjern_obj_områ.Height;
            pnlNav.Top = btnFjern_obj_områ.Top;
            //pnlNav.Left = btnFjern_obj_områ.Left;
            btnFjern_obj_områ.BackColor = Color.FromArgb(46, 51, 73);

            //legge inn rett form i panelet
            this.PnlFormLoader.Controls.Clear();
            frm_R_FjernObjektOmråde frm_R_FjernObjektOmråde_vrb = new frm_R_FjernObjektOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_FjernObjektOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_R_FjernObjektOmråde_vrb);
            frm_R_FjernObjektOmråde_vrb.Show();
        }



        private void frmRediger_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            //uten denne funskjone vil programmet forsatt være i debugging 
            //når man trykker "X"
        }


    }
}
