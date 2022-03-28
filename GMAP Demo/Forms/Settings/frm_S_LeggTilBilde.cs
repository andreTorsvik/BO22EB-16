using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class frm_S_LeggTilBilde : Form
    {
        public Image image = null;
        public byte[] imageData;
        public string valgtKategori;

        public frm_S_LeggTilBilde()
        {
            InitializeComponent();
        }

        private void lbTilgjengligKategorier_DoubleClick(object sender, EventArgs e)
        {
            string selectedItemtext = lbTilgjengligKategorier.SelectedItem.ToString();

            txtValgtKategori.Text = selectedItemtext;
            valgtKategori = txtValgtKategori.Text.ToString();
        }

        private void btnLeggTilBilde_Click(object sender, EventArgs e)
        {
            Bildebehandling bildebehandling = new Bildebehandling();
            OpenFileDialog dialog = new OpenFileDialog();
            string filepath = null;

            if (DialogResult.OK == dialog.ShowDialog())
            {
                filepath = dialog.FileName;
            }

            if(filepath != null)
            {
                image = Image.FromFile(filepath);
                imageData = bildebehandling.ImageToByteArray(image);

                pbValgtBilde.SizeMode = PictureBoxSizeMode.StretchImage;
                pbValgtBilde.Image = image;
            }
            
        }

        private void frm_S_LeggTilBilde_Load(object sender, EventArgs e)
        {
            DatabaseCommunication db = new DatabaseCommunication();
            var KategoriListe = db.ListAllKategorier_BildeFromDb();

            foreach (var item in KategoriListe)
            {
                Form1.instance.LKategori.Add(item);
                lbTilgjengligKategorier.Items.Add(item.Kategorinavn);
            }

            lbTilgjengligKategorier.Sorted = true;
        }


        private void btnLeggTilIDb_Click(object sender, EventArgs e)
        {
            DatabaseCommunication db = new DatabaseCommunication();

            db.InsertBildeToChosenKategorier_BildeToDb(valgtKategori, imageData);
        }



    }
}
