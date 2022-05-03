using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class FrmInnlogging : Form
    {
        public static FrmInnlogging instance;
        public List<Bruker> listBruker;

        public FrmInnlogging()
        {
            InitializeComponent();
            instance = this;
            //ThemeDesign.OldTheme();
            SetTheme();
        }

        public void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;
            lblTitle.ForeColor = ThemeDesign.colorBlue;
            lblTitle2.ForeColor = ThemeDesign.colorBlue;
            lblUserName.ForeColor = ThemeDesign.colorBlue;
            lblPassword.ForeColor = ThemeDesign.colorBlue;
            lblIngenBruker.ForeColor = ThemeDesign.colorLabel;
            lblOpprettBruker.ForeColor = ThemeDesign.colorBlue;
            lblTest.ForeColor = ThemeDesign.colorBlue;
            tbUserName.BackColor = ThemeDesign.colorGray;
            tbUserName.ForeColor = ThemeDesign.colorLabel;
            tbPassword.BackColor = ThemeDesign.colorGray;
            tbPassword.ForeColor = ThemeDesign.colorLabel;
            btnLogin.ForeColor = ThemeDesign.colorBackground;
            btnLogin.BackColor = ThemeDesign.colorBlue;
            btnTestUser.ForeColor = ThemeDesign.colorBackground;
            btnTestUser.BackColor = ThemeDesign.colorBlue;
        }

        private void FrmInnlogging_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            listBruker = new List<Bruker>();

            string epost = tbUserName.Text.ToLower();
            string passord = tbPassword.Text;
         
            if(epost.Length > 0 && passord.Length > 0)
                listBruker = DBComBruker.CheckLoginAgainstDb(epost, passord).ToList();

            // if success
            if (listBruker.Count > 0)
            {
                if (listBruker[0].Epost.ToLower() == epost)
                {
                    if (listBruker[0].Verifisert == true)
                    {
                        // Definer bruker 'globalt'
                        InnloggetBruker.BrukernavnInnlogget = listBruker[0].Epost;
                        InnloggetBruker.Sikkerhetsklarering = listBruker[0].Sikkerhetsklarering;


                        Hide();
                        frmVisning frmVisning = new frmVisning(); // instance
                        frmVisning.Show();

                        if (frmVerifiseringskode.instance != null)
                        {
                            frmVerifiseringskode.instance.Close();
                        }
                        if (frmRegistering.instance != null)
                        {
                            frmRegistering.instance.Close();
                        }

                        if (InnloggetBruker.Sikkerhetsklarering > Globalekonstanter.MaxSikkerhetsklarering)
                        {
                            try
                            {
                                DBComBruker.UpdateBruker_Sikkerhetsklarering(InnloggetBruker.BrukernavnInnlogget, Globalekonstanter.MaxSikkerhetsklarering);
                                InnloggetBruker.Sikkerhetsklarering = Globalekonstanter.MaxSikkerhetsklarering;
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
                    else
                    {
                        if (listBruker[0].Godkjent == true)
                        {
                            frmVerifiseringskode frmVerifiseringskode = new frmVerifiseringskode();
                            frmVerifiseringskode.Show();
                        }
                        else if (listBruker[0].Godkjent == false)
                        {
                            MessageBox.Show("Din bruker har ikke blitt godkjent enda");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ikke gyldig innlogging!");
            }
        }

        private void BtnTestUser_Click(object sender, EventArgs e)
        {
            tbUserName.Text = Properties.Settings.Default.GuestAccountEmail;
            tbPassword.Text = Properties.Settings.Default.GuestAccountPassword;
        }

        private void LbNyBruker_MouseEnter(object sender, EventArgs e)
        {
            lblOpprettBruker.Font = new Font(lblOpprettBruker.Font, FontStyle.Underline);
        }

        private void LbNyBruker_MouseLeave(object sender, EventArgs e)
        {
            lblOpprettBruker.Font = new Font(lblOpprettBruker.Font, FontStyle.Regular);
        }

        private void LbNyBruker_Click(object sender, EventArgs e)
        {
            Hide();
            frmRegistering frmRegistering = new frmRegistering(); // instance
            frmRegistering.Size = Size;
            frmRegistering.Location = Location;
            frmRegistering.Show();
        }
    }
}
