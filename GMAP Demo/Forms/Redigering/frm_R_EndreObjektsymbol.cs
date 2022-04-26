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
    public partial class frm_R_EndreObjektsymbol : Form
    {
        public Image image = null;
        public byte[] imageData;
        public string valgtKategori;

        public frm_R_EndreObjektsymbol()
        {
            InitializeComponent();
        }

        private void lbTilgjengligKategorier_DoubleClick(object sender, EventArgs e)
        {
            if (lbTilgjengligKategorier.SelectedIndex.ToString() != null)
            {
                string selectedItemtext = lbTilgjengligKategorier.SelectedItem.ToString();

                txtValgtKategori.Text = selectedItemtext;
                valgtKategori = txtValgtKategori.Text.ToString();

                // vis bilde hvis tilgjengelig
                List<Kategorier_Bilde> kategori = DBComKategorier_Bilde.GetBildeForKategoriFromDbKategorier_Bilde(selectedItemtext.ToString());
                if (kategori[0].Bilde != null) // Sjekk om kategori har bilde
                {
                    
                    image = Bildebehandling.byteArrayToImage(kategori[0].Bilde);

                    pbValgtKategori.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbValgtKategori.Image = image;
                    pbValgtKategori.Visible = true;

                }
                else
                {
                    pbValgtKategori.Visible = false;
                }
                
                
            }
        }

        private void btnLeggTilBilde_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            string filepath = null;

            if (DialogResult.OK == dialog.ShowDialog())
            {
                filepath = dialog.FileName;
            }

            if(filepath != null)
            {
                image = Image.FromFile(filepath);
                imageData = Bildebehandling.ImageToByteArray(image);

                pbValgtBilde.SizeMode = PictureBoxSizeMode.StretchImage;
                pbValgtBilde.Image = image;
            }
            
        }

        private void frm_S_LeggTilBilde_Load(object sender, EventArgs e)
        {
            var KategoriListe = DBComKategorier_Bilde.ListAllKategorier_BildeFromDb();

            foreach (var item in KategoriListe)
            {
                GlobaleLister.LKategori.Add(item);
                lbTilgjengligKategorier.Items.Add(item.Kategorinavn);
            }

            lbTilgjengligKategorier.Sorted = true;
        }


        private void btnLeggTilIDb_Click(object sender, EventArgs e)
        {
            if ((valgtKategori != null) && (imageData != null))
            {
                DBComKategorier_Bilde.InsertBildeToChosenKategorier_BildeToDb(valgtKategori, imageData);
                pbValgtKategori.Visible = false;
                pbValgtBilde.Dispose();
                txtValgtKategori.Text = "";
                lbTilgjengligKategorier.ClearSelected();
            }
            else if ((valgtKategori == null) && (imageData != null))
            {
                MessageBox.Show("Vennligst velg en kategori, fra listen, som dette bilde skal knyttes til.", "Kunne ikke utføre oppgaven!");
            }
            else if ((valgtKategori != null) && (imageData == null))
            {
                MessageBox.Show("Vennligst velg et bilde som skal knyttes til den valgte kategorien.", "Kunne ikke utføre oppgaven!");
            }
            else MessageBox.Show("Du har ikke valgt en kategori, og har heller ikke valgt et bilde.", "Kunne ikke utføre oppgaven!");
        }

    }
}
