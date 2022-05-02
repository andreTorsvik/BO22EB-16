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
        frm_S_LoggUt instance;
        public frm_S_LoggUt()
        {
            InitializeComponent();
            instance = this;
            SetTheme();
        }

        private void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;

            lblTitle.ForeColor = ThemeDesign.colorPurple;

            gblInnloggetBruker.ForeColor = ThemeDesign.colorLabel;
            gblInnloggetBruker.BackColor = ThemeDesign.colorSecondaryBackground;
            lblFornavn.ForeColor = ThemeDesign.colorLabel;
            lblEtternavn.ForeColor = ThemeDesign.colorLabel;
            lblTelefonnummer.ForeColor = ThemeDesign.colorLabel;
            lblEpost.ForeColor = ThemeDesign.colorLabel;
            lblSikkerhetsklarering.ForeColor = ThemeDesign.colorLabel;
            tbFornavn.ForeColor = ThemeDesign.colorLabel;
            tbFornavn.BackColor = ThemeDesign.colorGray;
            tbEtternavn.ForeColor = ThemeDesign.colorLabel;
            tbEtternavn.BackColor = ThemeDesign.colorGray;
            tbTelefonnummer.ForeColor = ThemeDesign.colorLabel;
            tbTelefonnummer.BackColor = ThemeDesign.colorGray;
            tbEpost.ForeColor = ThemeDesign.colorLabel;
            tbEpost.BackColor = ThemeDesign.colorGray;
            tbSikkerhetsklarering.ForeColor = ThemeDesign.colorLabel;
            tbSikkerhetsklarering.BackColor = ThemeDesign.colorGray;

            btnLoggUt.ForeColor = ThemeDesign.colorLabel;
            btnLoggUt.BackColor = ThemeDesign.colorGray;
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
