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
        public static List<Ressurs> LRessurs = new List<Ressurs>();

        public frmFilter()
        {
            InitializeComponent();
             
        }


        private void btnLeggTil_Click(object sender, EventArgs e)
        {
            LRessurs.Clear();

            DatabaseCommunication db = new DatabaseCommunication();
            var RessursList = db.ListAllRessursFromDb();
            foreach (var item in RessursList)
            {
                LRessurs.Add(item);
            }

            txtAntall.Text = LRessurs.Count.ToString();
        }

        private void btnRessurs_Click(object sender, EventArgs e)
        {
            Form1.LeggTilRessursPåKart(LRessurs);
        }

        private void txtAntall_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFjern_Click(object sender, EventArgs e)
        {
            Form1.map.Overlays.Clear();
            //Form1.map.Overlays.Remove("test1");
            Form1.reff();
            txtInfo.Text = "";
        }
    }
}
