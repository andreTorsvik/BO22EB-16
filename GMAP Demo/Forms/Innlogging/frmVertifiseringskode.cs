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
    public partial class frmVertifiseringskode : Form
    {
        public static frmVertifiseringskode instance;
        public frmVertifiseringskode()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnVertifiser_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtKode.Text) == frmInnlogging.instance.listBruker[0].Tallkode)
            {
                //Endre database attributt bruker.godkjent = true
                DatabaseCommunication db = new DatabaseCommunication();

                //endre til updateBruker_vertifisert:
                db.UpdateBruker_Verifisert(frmInnlogging.instance.listBruker[0].Epost, true);

                //logg inn
                InnloggetBruker.BrukernavnInnlogget = frmInnlogging.instance.listBruker[0].Epost;


                frmInnlogging.instance.Hide();
                this.Close();
                Form1 form1 = new Form1(); // instance
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
    }
}
