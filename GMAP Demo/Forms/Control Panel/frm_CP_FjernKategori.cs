using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BO22EB16
{
    public partial class Frm_CP_FjernKategori : Form
    {

        public Frm_CP_FjernKategori()
        {
            InitializeComponent();
            SetTheme();
        }

        private void SetTheme()
        {
            BackColor = ThemeDesign.colorBackground;

            lblTitle.ForeColor = ThemeDesign.colorPurple;

            gbFjernKategori.ForeColor = ThemeDesign.colorLabel;
            gbFjernKategori.BackColor = ThemeDesign.colorBackground;
            lblInfo.ForeColor = ThemeDesign.colorLabel;
            lblSlettbareKategorier.ForeColor = ThemeDesign.colorLabel;
            lblValgtKategori.ForeColor = ThemeDesign.colorLabel;
            lbTilgjengligKategorier.ForeColor = ThemeDesign.colorLabel;
            lbTilgjengligKategorier.BackColor = ThemeDesign.colorGray;
            tbValgtKategori.ForeColor = ThemeDesign.colorLabel;
            tbValgtKategori.BackColor = ThemeDesign.colorGray4;
            btnFjern.ForeColor = ThemeDesign.colorLabel;
            btnFjern.BackColor = ThemeDesign.colorGray;
        }

        private void Frm_S_BrukerInfo_Load(object sender, EventArgs e)
        {
            OppdaterKategoriListe();
        }

        private void OppdaterKategoriListe()
        {
            if (lbTilgjengligKategorier.Items.Count > 0) lbTilgjengligKategorier.Items.Clear();

            var KategoriListe = DBComKategorier_Bilde.ListAllKategorier_BildeFromDb();

            foreach (var Kategori in KategoriListe)
            {
                // Sjekker om det er 0 forkomster av kategorien 
                var list = DBComObjekt.ListObjektBasedOnKategori(Kategori.Kategorinavn);
                if (list.Count == 0)
                {
                    lbTilgjengligKategorier.Items.Add(Kategori.Kategorinavn);
                }

            }

            if (lbTilgjengligKategorier.Items.Count == 0) btnFjern.Enabled = false;
            else btnFjern.Enabled = true;
        }

        private void LbKategorier_DoubleClick(object sender, EventArgs e)
        {
            if (lbTilgjengligKategorier.SelectedIndex != -1)
            {
                if (lbTilgjengligKategorier.SelectedIndex.ToString() != null)
                {
                    string selectedItemtext = lbTilgjengligKategorier.SelectedItem.ToString();

                    tbValgtKategori.Text = selectedItemtext;
                }
            }
        }

        private void BtnFjern_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbValgtKategori.Text))
            {
                string kategori = tbValgtKategori.Text;
                string Tittel = "Vil du fjerne denne kategorien: ";

                bool Fjern = Tekstbehandling.MeldingsboksYesNo(Tittel, kategori);

                if (Fjern)
                {
                    DBComKategorier_Bilde.DeleteKategorier_Bilde(kategori);
                    tbValgtKategori.Text = string.Empty;

                    OppdaterKategoriListe();
                    GlobaleLister.OppdaterKategoriListe();
                }
            }
        }
    }
}
