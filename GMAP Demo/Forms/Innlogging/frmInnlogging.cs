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
using GMAP_Demo.Database.DataTypes;

namespace GMAP_Demo
{
    public partial class frmInnlogging : Form
    {

        public frmInnlogging()
        {
            InitializeComponent();
        }

        private void frmInnlogging_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseCommunication db = new DatabaseCommunication();
            List<Bruker> listBruker = new List<Bruker>();

            listBruker = db.CheckLoginAgainstDb(tbUserName.Text, tbPassword.Text).ToList();

            // if success
            if (listBruker.Count > 0)
            {
                if (listBruker[0].Epost == tbUserName.Text)
                {
                    // Definer bruker 'globalt'
                    InnloggetBruker.BrukernavnInnlogget = tbUserName.Text;

                    // Trenger vi å fjerne innloggingsinformasjon her?
                    tbUserName.Text = "";
                    tbPassword.Text = "";

                    this.Hide();
                    Form1 form1 = new Form1(); // instance
                    form1.Size = this.Size;
                    form1.Location = this.Location;
                    form1.Show();
                }
            }
            else
            {
                MessageBox.Show("Ikke gyldig innlogging!");
            }

            
        }

        private void btnTestUser_Click(object sender, EventArgs e)
        {
            tbUserName.Text = "ola.nordman@stud.hvl.no";
            tbPassword.Text = "PassOla";
        }
    }
}
