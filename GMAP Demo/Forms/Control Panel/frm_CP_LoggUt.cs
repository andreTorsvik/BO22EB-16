using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BO22EB16
{
    public partial class Frm_CP_LoggUt : Form
    {
        public Frm_CP_LoggUt()
        {
            InitializeComponent();
            SetTheme();
        }

        private void SetTheme()
        {
            this.BackColor = ThemeDesign.colorBackground;

            lblTitle.ForeColor = ThemeDesign.colorPurple;

            gblInnloggetBruker.ForeColor = ThemeDesign.colorLabel;
            gblInnloggetBruker.BackColor = ThemeDesign.colorBackground;
            lblFornavn.ForeColor = ThemeDesign.colorLabel;
            lblEtternavn.ForeColor = ThemeDesign.colorLabel;
            lblTelefonnummer.ForeColor = ThemeDesign.colorLabel;
            lblEpost.ForeColor = ThemeDesign.colorLabel;
            lblSikkerhetsklarering.ForeColor = ThemeDesign.colorLabel;
            tbFornavn.ForeColor = ThemeDesign.colorLabel;
            tbFornavn.BackColor = ThemeDesign.colorGray4;
            tbEtternavn.ForeColor = ThemeDesign.colorLabel;
            tbEtternavn.BackColor = ThemeDesign.colorGray4;
            tbTelefonnummer.ForeColor = ThemeDesign.colorLabel;
            tbTelefonnummer.BackColor = ThemeDesign.colorGray4;
            tbEpost.ForeColor = ThemeDesign.colorLabel;
            tbEpost.BackColor = ThemeDesign.colorGray4;
            tbSikkerhetsklarering.ForeColor = ThemeDesign.colorLabel;
            tbSikkerhetsklarering.BackColor = ThemeDesign.colorGray4;

            btnLoggUt.ForeColor = ThemeDesign.colorLabel;
            btnLoggUt.BackColor = ThemeDesign.colorGray;
        }

        private void BtnLoggUt_Click(object sender, EventArgs e)
        {
            // Litten forsinkelse før appen restarter, må derfor skjule formen
            FrmControlPanel.instance.Hide();
            GlobaleVariabler.LoggUt = true;
            
            Application.Restart();
            Environment.Exit(0);
        }

        private void Frm_S_LoggUt_Load(object sender, EventArgs e)
        {
            Bruker bruker = new Bruker();
            bruker = DBComBruker.ListBrukerInfoFromDb(InnloggetBruker.BrukernavnInnlogget.ToString());

            tbFornavn.Text = bruker.Fornavn.ToString();
            tbEtternavn.Text = bruker.Etternavn.ToString();
            tbTelefonnummer.Text = bruker.Telefonnummer.ToString();
            tbEpost.Text = bruker.Epost.ToString();
            tbSikkerhetsklarering.Text = bruker.Sikkerhetsklarering.ToString();

        }
    }
}
