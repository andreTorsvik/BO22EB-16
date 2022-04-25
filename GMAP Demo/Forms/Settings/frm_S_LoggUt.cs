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
    public partial class frm_S_LoggUt : Form
    {
        public frm_S_LoggUt()
        {
            InitializeComponent();
        }

        private void btnLoggUt_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void frm_S_LoggUt_Load(object sender, EventArgs e)
        {
            List<Bruker> listBruker = new List<Bruker>();
            listBruker = DBComBruker.ListBrukerInfoFromDb(InnloggetBruker.BrukernavnInnlogget.ToString());

            tbFornavn.Text = listBruker[0].Fornavn.ToString();
            tbEtternavn.Text = listBruker[0].Etternavn.ToString();
            tbTelefonnummer.Text = listBruker[0].Telefonnummer.ToString();
            tbEpost.Text = listBruker[0].Epost.ToString();
            tbSikkerhetsklarering.Text = listBruker[0].Sikkerhetsklarering.ToString();
        }
    }
}
