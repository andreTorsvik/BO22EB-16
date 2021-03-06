using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BO22EB16
{
    public partial class Frm_V_Posisjon : Form
    {
        public static Frm_V_Posisjon instance;
        public PointLatLng TilPunkt;
        public PointLatLng FraPunkt;

        public Frm_V_Posisjon()
        {
            InitializeComponent();
            instance = this;
            SetTheme();
        }

        private void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;
            lblTitle.ForeColor = ThemeDesign.colorBlue;

            gbPosisjon.ForeColor = ThemeDesign.colorLabel;
            gbPosisjon.BackColor = ThemeDesign.colorBackground;
            lblLand.ForeColor = ThemeDesign.colorLabel;
            lblByKommune.ForeColor = ThemeDesign.colorLabel;
            lblAdresse.ForeColor = ThemeDesign.colorLabel;
            txtLand.ForeColor = ThemeDesign.colorLabel;
            txtLand.BackColor = ThemeDesign.colorGray;
            txtByKommune.ForeColor = ThemeDesign.colorLabel;
            txtByKommune.BackColor = ThemeDesign.colorGray;
            txtAdresse.ForeColor = ThemeDesign.colorLabel;
            txtAdresse.BackColor = ThemeDesign.colorGray;
            btnSøk.ForeColor = ThemeDesign.colorLabel;
            btnSøk.BackColor = ThemeDesign.colorGray;

            gbKoordinater.ForeColor = ThemeDesign.colorLabel;
            gbKoordinater.BackColor = ThemeDesign.colorBackground;
            lblBasertPå.ForeColor = ThemeDesign.colorLabel;
            lblLat.ForeColor = ThemeDesign.colorLabel;
            lblLong.ForeColor = ThemeDesign.colorLabel;
            txtLat.ForeColor = ThemeDesign.colorLabel;
            txtLat.BackColor = ThemeDesign.colorGray4;
            txtLong.ForeColor = ThemeDesign.colorLabel;
            txtLong.BackColor = ThemeDesign.colorGray4;

            gbRute.ForeColor = ThemeDesign.colorLabel;
            gbRute.BackColor = ThemeDesign.colorBackground;
            lblBasertPå2.ForeColor = ThemeDesign.colorLabel;
            lblFra.ForeColor = ThemeDesign.colorLabel;
            lblTil.ForeColor = ThemeDesign.colorLabel;
            lblDistanse.ForeColor = ThemeDesign.colorLabel;
            btnStart.ForeColor = ThemeDesign.colorLabel;
            btnStart.BackColor = ThemeDesign.colorGray;
            btnSlutt.ForeColor = ThemeDesign.colorLabel;
            btnSlutt.BackColor = ThemeDesign.colorGray;
            btnFinnRute.ForeColor = ThemeDesign.colorLabel;
            btnFinnRute.BackColor =  ThemeDesign.colorGray;
            btnFjernRute.ForeColor = ThemeDesign.colorLabel;
            btnFjernRute.BackColor = ThemeDesign.colorGray;
            tbFra.ForeColor = ThemeDesign.colorLabel;
            tbFra.BackColor = ThemeDesign.colorGray4;
            tbTil.ForeColor = ThemeDesign.colorLabel;
            tbTil.BackColor = ThemeDesign.colorGray4;
        }

        private void BtnSøk_Click(object sender, EventArgs e)
        {
            string land = txtLand.Text;
            string byKommune = txtByKommune.Text;
            string adresse = txtAdresse.Text;
                
            // Utføres om EN er fylt ut 
            if(!(string.IsNullOrWhiteSpace(land) && string.IsNullOrWhiteSpace(byKommune) && string.IsNullOrWhiteSpace(adresse)))
                Kart.FinnLokasjon(land,byKommune,adresse);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(txtLat.Text != Globalekonstanter.tekstLatLong_objekt && txtLong.Text != Globalekonstanter.tekstLatLong_objekt) // "Dobbelklikk på kartet"
            {
                // Legger til addresse basert på koordinatene i lat og long i starttekstfeltet
                List<string> LAdresse = new List<string>();
                try
                {
                    PointLatLng point = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text));
                    LAdresse = Kart.FåAddress(point);
                    FraPunkt = point;
                }
                catch (Exception feilmelding)
                {
                    DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                }

                if (LAdresse != null)
                    tbFra.Text = "Addresse: \n-----------------" + string.Join(", ", LAdresse.ToArray());
                else
                    tbFra.Text = "Unable to load Address";
            }
           
        }

        private void BtnSlutt_Click(object sender, EventArgs e)
        {
            if (txtLat.Text != Globalekonstanter.tekstLatLong_objekt && txtLong.Text != Globalekonstanter.tekstLatLong_objekt)
            {
                // Legger til addresse basert på koordinatene i lat og long i måltekstfeltet
                List<string> LAdresse = new List<string>();
                try
                {
                    PointLatLng point = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text));
                    LAdresse = Kart.FåAddress(point);
                    TilPunkt = point;
                }
                catch (Exception feilmelding)
                {
                    DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                }

                if (LAdresse != null)
                    tbTil.Text = "Addresse: \n-----------------" + string.Join(", ", LAdresse.ToArray());
                else
                    tbTil.Text = "Unable to load Address";
            }
        }

        private void BtnFinnRute_Click(object sender, EventArgs e)
        {
            if (!FraPunkt.IsEmpty && !TilPunkt.IsEmpty)
            {
                try
                {
                    Kart.LeggTilRute(FraPunkt, TilPunkt);    
                }
                catch (Exception feilmelding)
                {
                    DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                }
            }
        }

        private void BtnFjernRute_Click(object sender, EventArgs e)
        {
            Kart.FjernRute();
        }

        public void FyllKoordinater(double lat, double lang)
        {
            txtLat.Text = lat.ToString();
            txtLong.Text = lang.ToString();
        }
    }
}
