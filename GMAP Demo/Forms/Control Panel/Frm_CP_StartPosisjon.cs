using GMap.NET;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class Frm_CP_StartPosisjon : Form
    {
        Frm_CP_StartPosisjon instance;
        
        public Frm_CP_StartPosisjon()
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
            gbNåverendeStartpunkt.BackColor = ThemeDesign.colorBackground;
            lblNåLat.ForeColor = ThemeDesign.colorLabel;
            lblNåLong.ForeColor = ThemeDesign.colorLabel;
            txtNåværendeLat.ForeColor = ThemeDesign.colorLabel;
            txtNåværendeLat.BackColor = ThemeDesign.colorGray4;
            txtNåværendeLong.ForeColor = ThemeDesign.colorLabel;
            txtNåværendeLong.BackColor = ThemeDesign.colorGray4;
            txtNåværendeAdresse.ForeColor = ThemeDesign.colorLabel;
            txtNåværendeAdresse.BackColor = ThemeDesign.colorGray;

            gbNyttStartpunkt.ForeColor = ThemeDesign.colorLabel;
            gbNyttStartpunkt.BackColor = ThemeDesign.colorBackground;
            lblInfo.ForeColor = ThemeDesign.colorLabel;
            lblNyLat.ForeColor = ThemeDesign.colorLabel;
            lblNyLong.ForeColor = ThemeDesign.colorLabel;
            txtNyLat.ForeColor = ThemeDesign.colorLabel;
            txtNyLat.BackColor = ThemeDesign.colorGray4;
            txtNyLong.ForeColor = ThemeDesign.colorLabel;
            txtNyLong.BackColor = ThemeDesign.colorGray4;
            txtNyAdresse.ForeColor = ThemeDesign.colorLabel;
            txtNyAdresse.BackColor = ThemeDesign.colorGray;
            btnBrukSomStart.ForeColor = ThemeDesign.colorLabel;
            btnBrukSomStart.BackColor = ThemeDesign.colorGray;
        }

        private void Frm_S_StartPosisjon_Load(object sender, EventArgs e)
        {
            // Disse blir oppdatert når man åpner ControlPanel
            txtNyLat.Text = FrmControlPanel.instance.lat.ToString();
            txtNyLong.Text = FrmControlPanel.instance.lng.ToString();

            // Henter nåværende startpunkt fra fil 
            PointLatLng nåværendeStartPunkt = HentStartpunktFraFil();

            // Skriver dem inn
            txtNåværendeLat.Text = nåværendeStartPunkt.Lat.ToString();
            txtNåværendeLong.Text = nåværendeStartPunkt.Lng.ToString();

            // Fyller tekstfeltene basert på lat og long 
            Fylltekstfelt();
        }

        private PointLatLng HentStartpunktFraFil()
        {
            PointLatLng svar = new PointLatLng();

            svar = FilBehandling.HentStartPosisjon(Globalekonstanter.filStartPosisjon);
           
            return svar;
        }

        private void Fylltekstfelt()
        {
            //For å få adresse i tekstfeltet bruker vi Google Api

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

        private void BtnBrukSomStart_Click(object sender, EventArgs e)
        {

            bool fullført = FilBehandling.LeggTilStartPosisjon(Globalekonstanter.filStartPosisjon,txtNyLat.Text,txtNyLong.Text);

            if(fullført)
            {
                txtNåværendeLat.Text = txtNyLat.Text;
                txtNåværendeLong.Text = txtNyLong.Text;
                txtNåværendeAdresse.Text = txtNyAdresse.Text;
            }
            else
            {
                MessageBox.Show("Det oppstod en feil, vennligst prøv på nytt.");
            }
        }
    }
}
