using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    
    public partial class frmFilter : Form
    {
        public static frmFilter instance;

        public frmFilter()
        {
            InitializeComponent();
            instance = this;
        }


        private void btnLeggTil_Click(object sender, EventArgs e)
        {

            Form1.LRessurs.Clear();

            DatabaseCommunication db = new DatabaseCommunication();
            var RessursList = db.ListAllRessursFromDb();
            foreach (var item in RessursList)
            {
                Form1.LRessurs.Add(item);
            }

            txtAntall.Text = Form1.LRessurs.Count.ToString();
        }

        private void btnRessurs_Click(object sender, EventArgs e)
        {
            //Form1.LeggTilRessursPåKart(Form1.LRessurs);
            int tag = 0;
            GMapMarker marker;
            foreach (var item in Form1.LRessurs)
            {
                PointLatLng punkt = item.GiPunktet();

                marker = new GMarkerGoogle(punkt, GMarkerGoogleType.green);

                marker.ToolTipText = String.Format("{0}", item.Navn);
                marker.ToolTip.Fill = Brushes.Black;
                marker.ToolTip.Foreground = Brushes.White;
                marker.ToolTip.Stroke = Pens.Black;
                marker.ToolTip.TextPadding = new Size(20, 20);
                marker.Tag = tag;
                tag++;

                GMapOverlay markers = new GMapOverlay("test1");
                markers.Markers.Add(marker);
                Form1.instance.map.Overlays.Add(markers);
            }
            Form1.reff();
        }

        private void txtAntall_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFjern_Click(object sender, EventArgs e)
        {
            Form1.instance.map.Overlays.Clear();
            //Form1.map.Overlays.Remove("test1");
            Form1.reff();
            txtNavn.Text = "";
            txtKategori.Text = "";
            txtDato_opprettet.Text = "";
            txtOpprettetAvBruker.Text = "";
            txtSikkerhetsklarering.Text = "";
            txtKommentar.Text = "";
            
        }
    }
}
