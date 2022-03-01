using GMAP_Demo.Database.DataTypes;
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
    public partial class frmDatabaseView : Form
    {
        List<Bruker> brukerList = new List<Bruker>();
        List<Kategorier_Bilde> kategorier_BildeList = new List<Kategorier_Bilde>();
        List<Måling> målingList = new List<Måling>();
        List<Overlay_Område> overlay_OmrådeList = new List<Overlay_Område>();
        List<Overlay_Ressurs> overlay_RessursList = new List<Overlay_Ressurs>();
        List<Punkter_område> punkter_områdeList = new List<Punkter_område>();
        List<Ressurs> ressursListe = new List<Ressurs>();



        public frmDatabaseView()
        {
            InitializeComponent();
            //label1.Text = CnnVal().ToString();
        }

        private void UpdateBinding()
        {
            listBoxDatabaseView.DataSource = ressursListe;
            listBoxDatabaseView.DisplayMember = "ressursDataTypeToString";
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
        private void btnTilbake_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSettings frmSettings = new frmSettings(); // instance 
            frmSettings.Show();
        }

        void AlleKnapperTilStandarfarge()
        {
            btnDbBrukerView.BackColor = Color.FromArgb(24, 30, 54);
            btnDbKategorier_BildeView.BackColor = Color.FromArgb(24, 30, 54);
            btnDbMålingView.BackColor = Color.FromArgb(24, 30, 54);
            btnDbOverlay_OmrådeView.BackColor = Color.FromArgb(24, 30, 54);
            btnDbOverlay_RessursView.BackColor = Color.FromArgb(24, 30, 54);
            btnDbPunkter_områdeView.BackColor = Color.FromArgb(24, 30, 54);
            btnDbRessursView.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDbBrukerView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            pnlNav.Height = btnDbBrukerView.Height;
            pnlNav.Top = btnDbBrukerView.Top;
            btnDbBrukerView.BackColor = Color.FromArgb(46, 51, 73);

            DatabaseCommunication db = new DatabaseCommunication();
            brukerList = db.ListAllBrukerFromDb();
            listBoxDatabaseView.DataSource = brukerList;
            listBoxDatabaseView.DisplayMember = "brukerDataTypeToString";
        }

        private void btnDbKategorier_BildeView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            pnlNav.Height = btnDbKategorier_BildeView.Height;
            pnlNav.Top = btnDbKategorier_BildeView.Top;
            btnDbKategorier_BildeView.BackColor = Color.FromArgb(46, 51, 73);

            DatabaseCommunication db = new DatabaseCommunication();
            kategorier_BildeList = db.ListAllKategorier_BildeFromDb();
            listBoxDatabaseView.DataSource = kategorier_BildeList;
            listBoxDatabaseView.DisplayMember = "kategorier_BildeDataTypeToString";
        }

        private void btnDbMålingView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            pnlNav.Height = btnDbMålingView.Height;
            pnlNav.Top = btnDbMålingView.Top;
            btnDbMålingView.BackColor = Color.FromArgb(46, 51, 73);

            DatabaseCommunication db = new DatabaseCommunication();
            målingList = db.ListAllMålingFromDb();
            listBoxDatabaseView.DataSource = målingList;
            listBoxDatabaseView.DisplayMember = "målingDataTypeToString";
        }

        private void btnDbOverlay_OmrådeView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            pnlNav.Height = btnDbOverlay_OmrådeView.Height;
            pnlNav.Top = btnDbOverlay_OmrådeView.Top;
            btnDbOverlay_OmrådeView.BackColor = Color.FromArgb(46, 51, 73);

            DatabaseCommunication db = new DatabaseCommunication();
            overlay_OmrådeList = db.ListAllOverlay_OmrådeFromDb();
            listBoxDatabaseView.DataSource = overlay_OmrådeList;
            listBoxDatabaseView.DisplayMember = "overlay_OmrådeDataTypeToString";
        }

        private void btnDbOverlay_RessursView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            pnlNav.Height = btnDbOverlay_RessursView.Height;
            pnlNav.Top = btnDbOverlay_RessursView.Top;
            btnDbOverlay_RessursView.BackColor = Color.FromArgb(46, 51, 73);

            DatabaseCommunication db = new DatabaseCommunication();
            overlay_RessursList = db.ListAllOverlay_RessursFromDb();
            listBoxDatabaseView.DataSource = overlay_RessursList;
            listBoxDatabaseView.DisplayMember = "overlay_RessursDataTypeToString";
        }

        private void btnDbPunkter_områdeView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            pnlNav.Height = btnDbPunkter_områdeView.Height;
            pnlNav.Top = btnDbPunkter_områdeView.Top;
            btnDbPunkter_områdeView.BackColor = Color.FromArgb(46, 51, 73);

            DatabaseCommunication db = new DatabaseCommunication();
            punkter_områdeList = db.ListAllPunkter_områdeFromDb();
            listBoxDatabaseView.DataSource = punkter_områdeList;
            listBoxDatabaseView.DisplayMember = "punkter_områdeDataTypeToString";
        }

        private void btnDbRessursView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();

            pnlNav.Height = btnDbRessursView.Height;
            pnlNav.Top = btnDbRessursView.Top;
            btnDbRessursView.BackColor = Color.FromArgb(46, 51, 73);

            DatabaseCommunication db = new DatabaseCommunication();
            ressursListe = db.ListAllRessursFromDb();
            listBoxDatabaseView.DataSource = ressursListe;
            listBoxDatabaseView.DisplayMember = "ressursDataTypeToString";
        }
    }
}
