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
        private static Color knapp_trykket;
        public frmRediger()
        {
            InitializeComponent();
            knapp_trykket = Color.FromArgb(46, 51, 73);

            //sette oransjePanelet til Posisjonknapp
            FlyttNavigasjonsPanel(btnObjekt.Height, btnObjekt.Top);
            btnObjekt.BackColor = knapp_trykket;

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
            PointLatLng point = Form1.Punkt_fra_forrige_kart;
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
            Form1.Punkt_fra_forrige_kart = map.Position;
            PnlFormLoader.Controls.Clear();
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        void AlleKnapperTilStandarfarge()
        {
            Color StandarFarge = Color.FromArgb(24, 30, 54);

            btnObjekt.BackColor = StandarFarge;
            btnOmråde.BackColor = StandarFarge;
            btnRediger_obj_områ.BackColor = StandarFarge;
            btnFjern_obj_områ.BackColor = StandarFarge;
        }

        private void btnObjekt_Click(object sender, EventArgs e)
        {

            AlleKnapperTilStandarfarge();
            btnObjekt.BackColor = knapp_trykket;

            //Flytte oransjePanelet til rett plass
            FlyttNavigasjonsPanel(btnObjekt.Height, btnObjekt.Top);

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
            btnOmråde.BackColor = knapp_trykket;
            //Flytte oransjePanelet til rett plass
            FlyttNavigasjonsPanel(btnOmråde.Height, btnOmråde.Top);

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
            btnRediger_obj_områ.BackColor = knapp_trykket;
            //Flytte oransjePanelet til rett plass
            FlyttNavigasjonsPanel(btnRediger_obj_områ.Height, btnRediger_obj_områ.Top);
            

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
            btnFjern_obj_områ.BackColor = knapp_trykket;
            //Flytte oransjePanelet til rett plass

            FlyttNavigasjonsPanel(btnFjern_obj_områ.Height, btnFjern_obj_områ.Top);
           


            //legge inn rett form i panelet
            this.PnlFormLoader.Controls.Clear();
            frm_R_FjernObjektOmråde frm_R_FjernObjektOmråde_vrb = new frm_R_FjernObjektOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_FjernObjektOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_R_FjernObjektOmråde_vrb);
            frm_R_FjernObjektOmråde_vrb.Show();
        }



        private void frmRediger_FormClosing(object sender, FormClosingEventArgs e)
        {
            //uten denne funskjone vil programmet forsatt være i debugging 
            //når man trykker "X"
            Application.Exit();

        }

        public void FlyttNavigasjonsPanel(int høyde, int top)
        {
            //henter Høyde på knapp og hvor toppen er plassert 
            pnlNav.Height = høyde;
            pnlNav.Top = top;
            //Denne trenger kun å bli utført en gang, men er med forsikkerhetskyld 
            pnlNav.Left = btnObjekt.Left;
        }

    }
}
