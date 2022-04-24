using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace GMAP_Demo
{
    public partial class frmInnlogging : Form
    {
        public static frmInnlogging instance;
        public List<Bruker> listBruker;
        public frmInnlogging()
        {
            InitializeComponent();
            instance = this;
        }

        private void frmInnlogging_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            listBruker = new List<Bruker>();

            string Epost = tbUserName.Text.ToLower();
            string passord = tbPassword.Text;

            listBruker = DatabaseCommunication.CheckLoginAgainstDb(Epost, passord).ToList();

            // if success
            if (listBruker.Count > 0)
            {
                if (listBruker[0].Epost.ToLower() == Epost)
                {
                    if (listBruker[0].Verifisert == true)
                    {
                        // Definer bruker 'globalt'
                        InnloggetBruker.BrukernavnInnlogget = listBruker[0].Epost;
                        InnloggetBruker.Sikkerhetsklarering = listBruker[0].Sikkerhetsklarering;
                        this.Hide();
                        frmVisning form1 = new frmVisning(); // instance
                        form1.Size = this.Size;

                        form1.Show();

                        if (frmVertifiseringskode.instance != null)
                        {
                            frmVertifiseringskode.instance.Close();
                        }
                    }
                    else
                    {
                        if (listBruker[0].Godkjent == true)
                        {
                            frmVertifiseringskode vertifiseringskode = new frmVertifiseringskode();
                            vertifiseringskode.Show();
                        }
                        else if (listBruker[0].Godkjent == false)
                        {
                            MessageBox.Show("Du har ikke blitt godkjent enda");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ikke gyldig innlogging!");
            }    
        }

        private void btnTestUser_Click(object sender, EventArgs e)
        {
            tbUserName.Text = "Gjest@stud.hvl.no";
            tbPassword.Text = "PassGjest";
        }


        private void LbNyBruker_MouseEnter(object sender, EventArgs e)
        {
            LbNyBruker.Font = new Font(LbNyBruker.Font, FontStyle.Underline);
        }

        private void LbNyBruker_MouseLeave(object sender, EventArgs e)
        {
            LbNyBruker.Font = new Font(LbNyBruker.Font,FontStyle.Regular);
        }

        private void btNyBruker_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistering frmRegistering = new frmRegistering(); // instance
            frmRegistering.Size = this.Size;
            frmRegistering.Location = this.Location;
            frmRegistering.Show();
        }

        private void LbNyBruker_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistering frmRegistering = new frmRegistering(); // instance
            frmRegistering.Size = this.Size;
            frmRegistering.Location = this.Location;
            frmRegistering.Show();
        }
    }
}
