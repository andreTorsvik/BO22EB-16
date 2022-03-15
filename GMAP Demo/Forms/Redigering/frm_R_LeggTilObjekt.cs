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
    public partial class frm_R_LeggTilObjekt : Form
    {
        
        public static frm_R_LeggTilObjekt instance;
        public frm_R_LeggTilObjekt()
        {
            InitializeComponent();
            instance = this;
        }

        private void frm_R_LeggTilObjekt_Load(object sender, EventArgs e)
        {
            LastInnKategorier();
        }

        private void btnLeggTilOverlay_Click(object sender, EventArgs e)
        {

        }

        private void btnLeggTilObjekt_Click(object sender, EventArgs e)
        {
            DatabaseCommunication db = new DatabaseCommunication();

            db.InsertRessursToDb(txtNavn.Text.ToString(), txtKategori.Text.ToString(), "ola.nordman@stud.hvl.no", Convert.ToInt32(txtSikkerhetsklarering.Text), txtKommentar.Text.ToString(), Convert.ToSingle(txtLat.Text), Convert.ToSingle(txtLong.Text));

            txtNavn.Text = "";
            txtKategori.Text = "";
            txtKommentar.Text = "";
            txtSikkerhetsklarering.Text = "";
            txtLat.Text = "";
            txtLong.Text = "";

        }

        private void lbTilgjengligKategori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengligKategori.SelectedItem.ToString();

            txtKategori.Text = selectedItemtext;
        }

        private void btnLeggTilNyKategori_Click(object sender, EventArgs e)
        {
            string nyKategori = "";

            nyKategori = txtNyKategori.Text;

            DatabaseCommunication db = new DatabaseCommunication();

            db.InsertKategorier_BildeToDb(nyKategori);

            lbTilgjengligKategori.Items.Add(nyKategori);
            lbTilgjengligKategori.Sorted = true;
            txtNyKategori.Text = "";
        }
        private void LastInnKategorier()
        {
            Form1.instance.LKategori.Clear();
            DatabaseCommunication db = new DatabaseCommunication();
            var KategoriListe = db.ListAllKategorier_BildeFromDb();

            foreach (var item in KategoriListe)
            {
                Form1.instance.LKategori.Add(item);
                lbTilgjengligKategori.Items.Add(item.Kategorinavn);
            }

            lbTilgjengligKategori.Sorted = true;
        }


    }
}
