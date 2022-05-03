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
        }

        private void btnVertifiser_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(tbKode.Text) == FrmInnlogging.instance.listBruker[0].Tallkode)
            {
                //Endre database attributt bruker.godkjent = true

                //endre til updateBruker_vertifisert:
                DBComBruker.UpdateBruker_Verifisert(FrmInnlogging.instance.listBruker[0].Epost, true);

                //logg inn
                InnloggetBruker.BrukernavnInnlogget = FrmInnlogging.instance.listBruker[0].Epost;
                InnloggetBruker.Sikkerhetsklarering = FrmInnlogging.instance.listBruker[0].Sikkerhetsklarering;

                FrmInnlogging.instance.Hide();
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
