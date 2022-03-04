using GMap.NET;
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
    public partial class frmPosisjon : Form
    {
       
        public frmPosisjon()
        {
            InitializeComponent();
        }

        private void btnSøk_Click(object sender, EventArgs e)
        {
            string svar = " ";
            svar += txtAdresse.Text +",";
            svar += txtByKommune.Text+ ",";
            svar += txtLand.Text;
            svar = svar.Trim();
            Form1.AdresseTilKart(svar);
        }

        public static void OppdaterLatLongText(PointLatLng punkt)
        {
            double lat = punkt.Lat;
            double lng = punkt.Lng;

            txtLat.Text = lat.ToString();
            txtLong.Text = lng.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //kode som skriver in lat og long til adresse og legger det inn i
            //txtStart
            //hvis ikke man finner adresse bruker man lat og long

        }

        private void btnSlutt_Click(object sender, EventArgs e)
        {
            //kode som skriver in lat og long til adresse og legger det inn i
            //txtSlutt
            //hvis ikke man finner adresse bruker man lat og long

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //finner rute melleom punktene og og legger ruten på kartet
            //

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
