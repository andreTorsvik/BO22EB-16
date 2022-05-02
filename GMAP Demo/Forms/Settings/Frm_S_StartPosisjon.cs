﻿using GMap.NET;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class Frm_S_StartPosisjon : Form
    {
        Frm_S_StartPosisjon instance;
        public string FilNavn = "StartPosisjon.txt";
        public Frm_S_StartPosisjon()
        {
            InitializeComponent();
            instance = this;
            SetTheme();
        }

        private void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;

            lblTitle.ForeColor = ThemeDesign.colorPurple;

            gbNåverendeStartpunkt.ForeColor = ThemeDesign.colorLabel;
            gbNåverendeStartpunkt.BackColor = ThemeDesign.colorSecondaryBackground;
            lblNåLat.ForeColor = ThemeDesign.colorLabel;
            lblNåLong.ForeColor = ThemeDesign.colorLabel;
            txtNåværendeLat.ForeColor = ThemeDesign.colorLabel;
            txtNåværendeLat.BackColor = ThemeDesign.colorGray;
            txtNåværendeLong.ForeColor = ThemeDesign.colorLabel;
            txtNåværendeLong.BackColor = ThemeDesign.colorGray;
            txtNåværendeAdresse.ForeColor = ThemeDesign.colorLabel;
            txtNåværendeAdresse.BackColor = ThemeDesign.colorGray;

            gbNyttStartpunkt.ForeColor = ThemeDesign.colorLabel;
            gbNyttStartpunkt.BackColor = ThemeDesign.colorSecondaryBackground;
            lblInfo.ForeColor = ThemeDesign.colorLabel;
            lblNyLat.ForeColor = ThemeDesign.colorLabel;
            lblNyLong.ForeColor = ThemeDesign.colorLabel;
            txtNyLat.ForeColor = ThemeDesign.colorLabel;
            txtNyLat.BackColor = ThemeDesign.colorGray;
            txtNyLong.ForeColor = ThemeDesign.colorLabel;
            txtNyLong.BackColor = ThemeDesign.colorGray;
            txtNyAdresse.ForeColor = ThemeDesign.colorLabel;
            txtNyAdresse.BackColor = ThemeDesign.colorGray;
            btnStart.ForeColor = ThemeDesign.colorLabel;
            btnStart.BackColor = ThemeDesign.colorGray;
        }

        private void Frm_S_StartPosisjon_Load(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            lblInfo.Text = string.Format("Dra \"Visnings kartet\" til der du vil at kartet" + newLine + "skal starte når man åpner applikasjonen");
            txtNyLat.Text = frmSettings.instance.lat.ToString();
            txtNyLong.Text = frmSettings.instance.lng.ToString();
            PointLatLng nåværendeStartPunkt = hentStartpunktFraFil();
            txtNåværendeLat.Text = nåværendeStartPunkt.Lat.ToString();
            txtNåværendeLong.Text = nåværendeStartPunkt.Lng.ToString();
            Fylltekstfelt();
        }

        private PointLatLng hentStartpunktFraFil()
        {

            PointLatLng svar = new PointLatLng();

            svar = FilBehandeling.GiStartPosisjon(FilNavn);
           
            return svar;
        }

       


        private void Fylltekstfelt()
        {

            List<string> LAdresse = new List<string>();
            try
            {
                PointLatLng point = new PointLatLng(Convert.ToDouble(txtNyLat.Text), Convert.ToDouble(txtNyLong.Text));
                LAdresse = Kart.FåAddress(point);

            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }

            if (LAdresse != null)
                txtNyAdresse.Text = "Addresse: \n-----------------" + string.Join(", ", LAdresse.ToArray());
            else
                txtNyAdresse.Text = "Unable to load Address";

            if (LAdresse != null) LAdresse.Clear();
            //nåværende adresse

            try
            {
                PointLatLng point = new PointLatLng(Convert.ToDouble(txtNåværendeLat.Text), Convert.ToDouble(txtNåværendeLong.Text));
                LAdresse = Kart.FåAddress(point);

            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }

            if (LAdresse != null)
                txtNåværendeAdresse.Text = "Addresse: \n-----------------" + string.Join(", ", LAdresse.ToArray());
            else
                txtNåværendeAdresse.Text = "Unable to load Address";

            //ny addresse 
          
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            bool fullført = FilBehandeling.LeggTilStartPosisjon(FilNavn,txtNyLat.Text,txtNyLong.Text);

            if(fullført)
            {
                txtNåværendeLat.Text = txtNyLat.Text;
                txtNåværendeLong.Text = txtNyLong.Text;
                txtNåværendeAdresse.Text = txtNyAdresse.Text;
            }
            else
            {
                MessageBox.Show("Noe galt skjedde");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
