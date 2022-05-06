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
    public partial class Frm_CP_FjernKategori : Form
    {
        Frm_CP_FjernKategori instance;
        public Frm_CP_FjernKategori()
        {
            InitializeComponent();
            instance = this;
            SetTheme();
        }

        private void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;

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
                var list = DBComRessurs.ListObjektBasedOnKategori(Kategori.Kategorinavn);
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
            if(!string.IsNullOrEmpty( tbValgtKategori.Text))
            {
                string kategori = tbValgtKategori.Text;
                string Tittel = "Vil du fjerne denne Kategorien: ";

                bool Fjern = FellesMetoder.MeldingsboksYesNo(Tittel, kategori);

                if (Fjern)
                {
                    DBComKategorier_Bilde.DeleteKategorier_Bilde(kategori);
                    tbValgtKategori.Text = string.Empty;

                    OppdaterKategoriListe();
                    FellesMetoder.OppdaterKategoriListe();
                }
            }
        }
    }
}
