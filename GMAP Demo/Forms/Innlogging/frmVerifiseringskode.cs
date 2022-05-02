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
    public partial class frmVerifiseringskode : Form
    {
        public static frmVerifiseringskode instance;
        public frmVerifiseringskode()
        {
            InitializeComponent();
            instance = this;
            //SetTheme();
        }

        private void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;
            lblSkrivInn.ForeColor = ThemeDesign.colorBlue;
            tbKode.ForeColor = ThemeDesign.colorLabel;
            tbKode.BackColor = ThemeDesign.colorGray;
            btnVerifiser.ForeColor = ThemeDesign.colorBackground;
            btnVerifiser.BackColor = ThemeDesign.colorBlue;
            btnAvbryt.ForeColor = ThemeDesign.colorBackground;
            btnAvbryt.BackColor = ThemeDesign.colorBlue;
            lblKommetPåMail.ForeColor = ThemeDesign.colorBlue;
            lblSjekkSøppelpost.ForeColor = ThemeDesign.colorBlue;
        }

        private void btnVertifiser_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(tbKode.Text) == frmInnlogging.instance.listBruker[0].Tallkode)
            {
                //Endre database attributt bruker.godkjent = true

                //endre til updateBruker_vertifisert:
                DBComBruker.UpdateBruker_Verifisert(frmInnlogging.instance.listBruker[0].Epost, true);

                //logg inn
                InnloggetBruker.BrukernavnInnlogget = frmInnlogging.instance.listBruker[0].Epost;
                InnloggetBruker.Sikkerhetsklarering = frmInnlogging.instance.listBruker[0].Sikkerhetsklarering;

                frmInnlogging.instance.Hide();
                this.Close();
                frmVisning form1 = new frmVisning(); // instance
                form1.Size = this.Size;
                form1.Show();
            }
            else
            {
                MessageBox.Show("Feil kode");
            }
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

        }

        private void frmVerifiseringskode_Load(object sender, EventArgs e)
        {

        }
    }
}
