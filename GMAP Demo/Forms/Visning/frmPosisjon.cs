using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class frmPosisjon : Form
    {
        public static frmPosisjon instance;
        public PointLatLng Til;
        public PointLatLng Fra;
        public frmPosisjon()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnSøk_Click(object sender, EventArgs e)
        {
            string Land = txtLand.Text;
            string ByKommune = txtByKommune.Text;
            string Adresse = txtAdresse.Text;
                
            Kart.FinnLokasjon(Land,ByKommune,Adresse);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List<string> LAdresse = new List<string>();
            try
            {
                PointLatLng point = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text));
                LAdresse = Kart.FåAddress(point);
                Fra = point;
            }
            catch (Exception feilmelding)
            {
                DatabaseCommunication.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }

            if (LAdresse != null)
                txtFra.Text = "Addresse: \n-----------------" + string.Join(", ", LAdresse.ToArray());
            else
                txtFra.Text = "Unable to load Address";
        }

        private void btnSlutt_Click(object sender, EventArgs e)
        {
            List<string> LAdresse = new List<string>();
            try
            {
                PointLatLng point = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text));
                LAdresse = Kart.FåAddress(point);
                Til = point;
            }
            catch (Exception feilmelding)
            {
                DatabaseCommunication.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }

            if (LAdresse != null)
                txtTil.Text = "Addresse: \n-----------------" + string.Join(", ", LAdresse.ToArray());
            else
                txtTil.Text = "Unable to load Address";
        }

        private void btnFinnRute_Click(object sender, EventArgs e)
        {
            if (!Fra.IsEmpty && !Til.IsEmpty)
            {
                try
                {
                    Kart.LeggTilRute(Fra, Til);    
                }
                catch (Exception feilmelding)
                {
                    DatabaseCommunication.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                }
            }
        }

        private void btnFjernRute_Click(object sender, EventArgs e)
        {
            Kart.FjernRute();
        }
        

        private void frmPosisjon_Load(object sender, EventArgs e)
        {

        }
    }
}
