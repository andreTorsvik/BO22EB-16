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
        List<Område> områdeList = new List<Område>();
        List<Overlay_Område> overlay_OmrådeList = new List<Overlay_Område>();
        List<Overlay_Ressurs> overlay_RessursList = new List<Overlay_Ressurs>();
        List<Punkter_område> punkter_områdeList = new List<Punkter_område>();
        List<Ressurs> ressursList = new List<Ressurs>();
        private static Color knapp_trykket;



        public frmDatabaseView()
        {
            InitializeComponent();
            knapp_trykket = Color.FromArgb(46, 51, 73);
            lblDatabasePath.Text = GMAP_Demo.DatabaseCommunication.CnnVal(GMAP_Demo.DatabaseCommunication.bo22eb16DatabasePathUrlLocation).ToString();
        }

        private void UpdateBinding()
        {
            listBoxDatabaseView.DataSource = ressursList;
            listBoxDatabaseView.DisplayMember = "ressursDataTypeToString";
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
        private void btnTilbake_Click(object sender, EventArgs e)
        {
            this.Close();

            
            frmSettings frmSettings = new frmSettings(); // instance 
            frmSettings.Size = this.Size;
            frmSettings.Location = this.Location;
            frmSettings.Show();
        }

        void AlleKnapperTilStandarfarge()
        {
            Color StandarFarge = Color.FromArgb(24, 30, 54);

            btnDbBrukerView.BackColor = StandarFarge;
            btnDbKategorier_BildeView.BackColor = StandarFarge;
            btnDbMålingView.BackColor = StandarFarge;
            btnDbOmrådeView.BackColor = StandarFarge;
            btnDbOverlay_OmrådeView.BackColor = StandarFarge;
            btnDbOverlay_RessursView.BackColor = StandarFarge;
            btnDbPunkter_områdeView.BackColor = StandarFarge;
            btnDbRessursView.BackColor = StandarFarge;
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnDbBrukerView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbBrukerView.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnDbBrukerView.Height, btnDbBrukerView.Top);
            
            DatabaseCommunication db = new DatabaseCommunication();
            brukerList = db.ListAllBrukerFromDb();
            listBoxDatabaseView.DataSource = brukerList;
            listBoxDatabaseView.DisplayMember = "brukerDataTypeToString";
        }

        private void btnDbKategorier_BildeView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbKategorier_BildeView.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnDbKategorier_BildeView.Height, btnDbKategorier_BildeView.Top);

            DatabaseCommunication db = new DatabaseCommunication();
            kategorier_BildeList = db.ListAllKategorier_BildeFromDb();
            listBoxDatabaseView.DataSource = kategorier_BildeList;
            listBoxDatabaseView.DisplayMember = "kategorier_BildeDataTypeToString";
        }

        private void btnDbMålingView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbMålingView.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnDbMålingView.Height, btnDbMålingView.Top);

            DatabaseCommunication db = new DatabaseCommunication();
            målingList = db.ListAllMålingFromDb();
            listBoxDatabaseView.DataSource = målingList;
            listBoxDatabaseView.DisplayMember = "målingDataTypeToString";
        }

        private void btnDbOverlay_OmrådeView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbOverlay_OmrådeView.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnDbOverlay_OmrådeView.Height, btnDbOverlay_OmrådeView.Top);
            
            DatabaseCommunication db = new DatabaseCommunication();
            overlay_OmrådeList = db.ListAllOverlay_OmrådeFromDb();
            listBoxDatabaseView.DataSource = overlay_OmrådeList;
            listBoxDatabaseView.DisplayMember = "overlay_OmrådeDataTypeToString";
        }

        private void btnDbOverlay_RessursView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbOverlay_RessursView.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnDbOverlay_RessursView.Height, btnDbOverlay_RessursView.Top);

            DatabaseCommunication db = new DatabaseCommunication();
            overlay_RessursList = db.ListAllOverlay_RessursFromDb();
            listBoxDatabaseView.DataSource = overlay_RessursList;
            listBoxDatabaseView.DisplayMember = "overlay_RessursDataTypeToString";
        }

        private void btnDbPunkter_områdeView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbPunkter_områdeView.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnDbPunkter_områdeView.Height, btnDbPunkter_områdeView.Top);

            DatabaseCommunication db = new DatabaseCommunication();
            punkter_områdeList = db.ListAllPunkter_områdeFromDb();
            listBoxDatabaseView.DataSource = punkter_områdeList;
            listBoxDatabaseView.DisplayMember = "punkter_områdeDataTypeToString";
        }

        private void btnDbRessursView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbRessursView.BackColor = knapp_trykket;
            
            FlyttNavigasjonsPanel(btnDbRessursView.Height, btnDbRessursView.Top);

            DatabaseCommunication db = new DatabaseCommunication();
            ressursList = db.ListAllRessursFromDb();
            listBoxDatabaseView.DataSource = ressursList;
            listBoxDatabaseView.DisplayMember = "ressursDataTypeToString";
        }

        public void FlyttNavigasjonsPanel(int høyde, int top)
        {
            //henter Høyde på knapp og hvor toppen er plassert 
            pnlNav.Height = høyde;
            pnlNav.Top = top;
            //Denne trenger kun å bli utført en gang, men er med forsikkerhetskyld 
            pnlNav.Left = btnDbBrukerView.Left;
        }

        private void btnDbOmrådeView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbOmrådeView.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnDbOmrådeView.Height, btnDbOmrådeView.Top);

            DatabaseCommunication db = new DatabaseCommunication();
            områdeList = db.ListAllOmrådeFromDb();
            listBoxDatabaseView.DataSource = områdeList;
            listBoxDatabaseView.DisplayMember = "områdeDataTypeToString";
        }
    }
}
