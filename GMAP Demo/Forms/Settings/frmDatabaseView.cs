﻿using System;
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
        List<Tag_Område> tag_OmrådeList = new List<Tag_Område>();
        List<Tag_Ressurs> tag_RessursList = new List<Tag_Ressurs>();
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

           

            //frmSettings frmSettings = new frmSettings(); // instance 
            //frmSettings.Size = this.Size;
            //frmSettings.Location = this.Location;
            //frmSettings.Show();
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSettings.instance.Show();
        }

        void AlleKnapperTilStandarfarge()
        {
            Color StandarFarge = Color.FromArgb(24, 30, 54);

            btnDbBrukerView.BackColor = StandarFarge;
            btnDbKategorier_BildeView.BackColor = StandarFarge;
            btnDbMålingView.BackColor = StandarFarge;
            btnDbOmrådeView.BackColor = StandarFarge;
            btnDbTag_OmrådeView.BackColor = StandarFarge;
            btnDbTag_RessursView.BackColor = StandarFarge;
            btnDbPunkter_områdeView.BackColor = StandarFarge;
            btnDbRessursView.BackColor = StandarFarge;
        }

        

        private void btnDbBrukerView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbBrukerView.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnDbBrukerView.Height, btnDbBrukerView.Top);
            
            brukerList = DBComBruker.ListAllBrukerFromDb();
            listBoxDatabaseView.DataSource = brukerList;
            listBoxDatabaseView.DisplayMember = "brukerDataTypeToString";
        }

        private void btnDbKategorier_BildeView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbKategorier_BildeView.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnDbKategorier_BildeView.Height, btnDbKategorier_BildeView.Top);

            kategorier_BildeList = DBComKategorier_Bilde.ListAllKategorier_BildeFromDb();
            listBoxDatabaseView.DataSource = kategorier_BildeList;
            listBoxDatabaseView.DisplayMember = "kategorier_BildeDataTypeToString";
        }

        private void btnDbMålingView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbMålingView.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnDbMålingView.Height, btnDbMålingView.Top);

            målingList = DBComMåling.ListAllMålingFromDb();
            listBoxDatabaseView.DataSource = målingList;
            listBoxDatabaseView.DisplayMember = "målingDataTypeToString";
        }

        private void btnDbTag_OmrådeView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbTag_OmrådeView.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnDbTag_OmrådeView.Height, btnDbTag_OmrådeView.Top);
            
            tag_OmrådeList = DBComTag_Område.ListAllTag_OmrådeFromDb();
            listBoxDatabaseView.DataSource = tag_OmrådeList;
            listBoxDatabaseView.DisplayMember = "tag_OmrådeDataTypeToString";
        }

        private void btnDbTag_RessursView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbTag_RessursView.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnDbTag_RessursView.Height, btnDbTag_RessursView.Top);

            tag_RessursList = DBComTag_Ressurs.ListAllTag_RessursFromDb();
            listBoxDatabaseView.DataSource = tag_RessursList;
            listBoxDatabaseView.DisplayMember = "tag_RessursDataTypeToString";
        }

        private void btnDbPunkter_områdeView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbPunkter_områdeView.BackColor = knapp_trykket;

            FlyttNavigasjonsPanel(btnDbPunkter_områdeView.Height, btnDbPunkter_områdeView.Top);

            punkter_områdeList = DBComPunkter_område.ListAllPunkter_områdeFromDb();
            listBoxDatabaseView.DataSource = punkter_områdeList;
            listBoxDatabaseView.DisplayMember = "punkter_områdeDataTypeToString";
        }

        private void btnDbRessursView_Click(object sender, EventArgs e)
        {
            AlleKnapperTilStandarfarge();
            btnDbRessursView.BackColor = knapp_trykket;
            
            FlyttNavigasjonsPanel(btnDbRessursView.Height, btnDbRessursView.Top);

            ressursList = DBComRessurs.ListAllRessursFromDb(InnloggetBruker.Sikkerhetsklarering);
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

            områdeList = DBComOmråde.ListAllOmrådeFromDb();
            listBoxDatabaseView.DataSource = områdeList;
            listBoxDatabaseView.DisplayMember = "områdeDataTypeToString";
        }
    }
}
