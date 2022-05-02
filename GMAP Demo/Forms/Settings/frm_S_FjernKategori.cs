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
        frm_S_FjernKategori instance;
        public frm_S_FjernKategori()
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
            tbValgtKategori.BackColor = ThemeDesign.colorGray6;
            btnFjern.ForeColor = ThemeDesign.colorLabel;
            btnFjern.BackColor = ThemeDesign.colorGray;
        }

        private void frm_S_BrukerInfo_Load(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;
            lblInfo.Text = string.Format("Du må fjerne alle forkomster av \"kategorien\"" + newLine + "før den kommer opp her" + newLine + "NB: Er ikke sikkert du har tilgang til alle objektene på grunn av sikkerhetsklarering");

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

                    tbValgtKategori.Text = selectedItemtext;
                }
            }
        }

        private void btnFjern_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty( tbValgtKategori.Text))
            {
                string kategori = tbValgtKategori.Text;
                string Tittel = "Vil du Fjerne denne Kategorien: ";

                bool Fjern = FellesMetoder.MeldingsboksYesNo(Tittel, kategori);

                if (Fjern)
                {
                    DBComKategorier_Bilde.DeleteKategorier_Bilde(kategori);
                    tbValgtKategori.Text = string.Empty;

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
