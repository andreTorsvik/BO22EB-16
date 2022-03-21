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
using System.Net.Mail;
using System.Net;

namespace GMAP_Demo
{
    public partial class frmInnlogging : Form
    {
        public static frmInnlogging instance;


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
                    form1.Show();

                    if(frmVertifiseringskode.instance != null)
                    {
                        frmVertifiseringskode.instance.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                NetworkCredential login = new NetworkCredential("GmapDemo01@gmail.com", "Pass_Gmap_Demo_12!"); // brukernavn og passord må gjømes en plass
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Credentials = login;
                client.Port = 587;
                client.EnableSsl = true;

                MailMessage msg = new MailMessage("GmapDemo01@gmail.com", "GmapDemo01@gmail.com");
                msg.Subject = "Vertifiseringskode:";
                msg.Body = "123456";
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBack);
                string userstae = "sending...";
                client.SendAsync(msg, userstae);
            }
            catch (Exception)
            {

                
            }
            
        }
        private void SendCompletedCallBack(object sender,AsyncCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled,",e.UserState),"Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}",e.UserState,e.Error),"message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Melding send");
            }

        }


        private void LbNyBruker_MouseEnter(object sender, EventArgs e)
        {
            LbNyBruker.Font = new Font(LbNyBruker.Font, FontStyle.Underline);
        }

        private void LbNyBruker_MouseLeave(object sender, EventArgs e)
        {
            LbNyBruker.Font = new Font(LbNyBruker.Font,FontStyle.Regular);
        }

        private void LbNyBruker_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void LbNyBruker_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmRegistering frmRegistering = new frmRegistering(); // instance
            frmRegistering.Size = this.Size;
            frmRegistering.Location =this.Location;
            frmRegistering.Show();
            
        }
    }
}
