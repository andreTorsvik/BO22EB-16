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
    public partial class FrmVerifiseringskode : Form
    {
        public static FrmVerifiseringskode instance;

        public FrmVerifiseringskode()
        {
            InitializeComponent();
            instance = this;
        }

        private void BtnVerifiser_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(tbKode.Text) == FrmInnlogging.instance.listBruker[0].Tallkode)
            {
                //Endre database attributt bruker.godkjent = true

                // Endre til updateBruker_verifisert:
                DBComBruker.UpdateBruker_Verifisert(FrmInnlogging.instance.listBruker[0].Epost, true);

                // Logg inn
                InnloggetBruker.BrukernavnInnlogget = FrmInnlogging.instance.listBruker[0].Epost;
                InnloggetBruker.Sikkerhetsklarering = FrmInnlogging.instance.listBruker[0].Sikkerhetsklarering;

                FrmInnlogging.instance.Hide();
                Close();

                // Åpner visnings formen 
                FrmVisning frmVisning = new FrmVisning(); 
                frmVisning.Size = Size;
                frmVisning.Show();
            }
            else
            {
                MessageBox.Show("Feil kode");
            }
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtKode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

        }
    }
}
