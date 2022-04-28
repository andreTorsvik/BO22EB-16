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
    public partial class frm_S_FjernKategori : Form
    {
        public frm_S_FjernKategori()
        {
            InitializeComponent();

        }

        private void frm_S_BrukerInfo_Load(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            labelInfo.Text = string.Format("Du må fjerne alle forkomster av \"kategorien\"" + newLine + "før den kommer opp her");

            OppdaterKategoriListe();
        }

        private void OppdaterKategoriListe()
        {
            if (lbTilgjengligKategorier.Items.Count > 0) lbTilgjengligKategorier.Items.Clear();

            var KategoriListe = DBComKategorier_Bilde.ListAllKategorier_BildeFromDb();

            foreach (var Kategori in KategoriListe)
            {
                var list = DBComRessurs.ListRessursBasedonKategori(Kategori.Kategorinavn);
                if (list.Count == 0)
                {
                    lbTilgjengligKategorier.Items.Add(Kategori.Kategorinavn);
                }

            }

            lbTilgjengligKategorier.Sorted = true;
            if (lbTilgjengligKategorier.Items.Count == 0) btnFjern.Enabled = false;
            else btnFjern.Enabled = true;
        }

        private void lbKategorier_DoubleClick(object sender, EventArgs e)
        {
            if (lbTilgjengligKategorier.SelectedIndex != -1)
            {
                if (lbTilgjengligKategorier.SelectedIndex.ToString() != null)
                {
                    string selectedItemtext = lbTilgjengligKategorier.SelectedItem.ToString();

                    txtValgtKategori.Text = selectedItemtext;
                }
            }
        }

        private void btnFjern_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty( txtValgtKategori.Text))
            {
                string kategori = txtValgtKategori.Text;
                string caption = "Vil du Fjerne denne Kategorien: ";
                
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(kategori, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    DBComKategorier_Bilde.DeleteKategorier_Bilde(kategori);
                    txtValgtKategori.Text = string.Empty;

                    OppdaterKategoriListe();
                    Kart.OppdaterKategoriListe();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
