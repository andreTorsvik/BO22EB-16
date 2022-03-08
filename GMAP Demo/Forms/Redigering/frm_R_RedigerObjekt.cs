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
    public partial class frm_R_RedigerObjekt : Form
    {
        public static frm_R_RedigerObjekt instance;
        public frm_R_RedigerObjekt()
        {
            InitializeComponent();
            instance = this;
        }

       

        private void lbTilgjengligKategori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengligKategori.SelectedItem.ToString();

            txtKategori.Text = selectedItemtext;
        }

        private void frm_R_RedigerObjekt_Load(object sender, EventArgs e)
        {
            LastInnKategorier();
        }

        private void LastInnKategorier()
        {
            Form1.LKategori.Clear();
            DatabaseCommunication db = new DatabaseCommunication();
            var KategoriListe = db.ListAllKategorier_BildeFromDb();

            foreach (var item in KategoriListe)
            {
                Form1.LKategori.Add(item);
                lbTilgjengligKategori.Items.Add(item.Kategorinavn);
            }

            lbTilgjengligKategori.Sorted = true;
        }
    }
}
