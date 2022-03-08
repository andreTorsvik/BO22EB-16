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
        public frm_S_LeggTilBilde()
        {
            InitializeComponent();
        }

        private void lbTilgjengligKategorier_DoubleClick(object sender, EventArgs e)
        {
            string selectedItemtext = lbTilgjengligKategorier.SelectedItem.ToString();

            txtValgtKategori.Text = selectedItemtext;
        }

        private void btnLeggTilBilde_Click(object sender, EventArgs e)
        {
            string path = "";


            OpenFileDialog dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                path = dialog.FileName;
            }

            image = Image.FromFile(path);

            pbValgtBilde.SizeMode = PictureBoxSizeMode.StretchImage;
            pbValgtBilde.Image = image;
        }

        private void frm_S_LeggTilBilde_Load(object sender, EventArgs e)
        {

        }


        private void btnLeggTilIDb_Click(object sender, EventArgs e)
        {
            byte[] imageAsBytes = ImageToByteArray(image);
        }


        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
