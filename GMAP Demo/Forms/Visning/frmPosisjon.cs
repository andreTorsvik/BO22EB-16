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
            string svar = " ";
            int ZoomLevel = 0;
            svar += txtAdresse.Text + ",";
            svar += txtByKommune.Text + ",";
            svar += txtLand.Text;
            svar = svar.Trim();
            FrmVisning.AdresseTilKart(svar);

            //tror det finnes bedre metoder for dette
            if (txtLand.Text != "") ZoomLevel = 5;
            if (txtByKommune.Text != "") ZoomLevel = 11;
            if (txtAdresse.Text != "") ZoomLevel = 18;

            FrmVisning.instance.map.Zoom = ZoomLevel;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List<string> LAdresse = new List<string>();
            try
            {
                PointLatLng point = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text));
                LAdresse = GetAddress(point);
                Fra = point;
            }
            catch (Exception)
            {

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
                LAdresse = GetAddress(point);
                Til = point;
            }
            catch (Exception)
            {

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
                    FrmVisning.LeggTilRute(Fra, Til);
                    
                    
                }
                catch (Exception)
                {

                    
                }
            }
        }

        private void btnFjernRute_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FrmVisning.instance.map.Overlays.Count; i++)
            {
                if (FrmVisning.instance.map.Overlays[i].Id == "routes")
                {  
                    FrmVisning.instance.map.Overlays.RemoveAt(i);
                    FrmVisning.reff();
                    LbDistanse.Text = "[Distanse i Km]";
                    break;
                }
            }

        }

        private List<string> GetAddress(PointLatLng point)
        {
            //må bruke google API  for denne delen av koden
            //hvis man ikke har google API vil denne delen ikke virke
            try
            {
                List<Placemark> Info = null;
                var statusCode = GMapProviders.GoogleMap.GetPlacemarks(point, out Info);
                //var statusCode = GMapProviders.OpenStreetMap.GetPlacemarks(point,out Info);
                if (statusCode == GeoCoderStatusCode.OK && Info != null)
                {
                    List<string> addresse = new List<string>();
                    addresse.Add(Info[0].Address);
                    return addresse;
                }
            }
            catch (Exception)
            {
    
            }
            return null;
        }

        private void frmPosisjon_Load(object sender, EventArgs e)
        {

        }
    }
}
