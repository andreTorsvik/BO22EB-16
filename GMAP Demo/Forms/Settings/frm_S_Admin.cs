using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class frm_S_Admin : Form
    {
        public frm_S_Admin()
        {
            InitializeComponent();
        }

        private void frm_S_Admin_Load(object sender, EventArgs e)
        {
            FyllListene();
        }

        public void FyllListene()
        {
            DatabaseCommunication db = new DatabaseCommunication();
            var BrukerListe = db.ListAllBrukerFromDb();

            //liste over brukere 
            foreach (var item in BrukerListe)
            {
                if (item.Godkjent == true) lbListeOverbrukere.Items.Add(item.BrukerDataTilAdmin); // har logget in med vertifiseringskode
                else if (item.Godkjent == false) lbVenterPåGodkjenning.Items.Add(item.BrukerDataTilAdmin); // har ikke gjort det

            }
        }

        private void btnGodta_Click(object sender, EventArgs e)
        {

            string BrukerInfo = lbVenterPåGodkjenning.SelectedItem.ToString();
            string epost = BrukerInfo.Substring(0, BrukerInfo.IndexOf(" "));

            //Brude lage en metode som tar epost som argument istendefor 
            DatabaseCommunication db = new DatabaseCommunication();
            
            //den delen skal ikke feile siden eposten finnes 
            var BrukerListe = db.ListBrukerInfoFromDb(epost);

            int tallkode = BrukerListe[0].Tallkode; ;

            SendEpost(epost,tallkode);
        }

        private void SendEpost(string epost,int tallkode)
        {
            try
            {
                NetworkCredential login = new NetworkCredential("GmapDemo01@gmail.com", "Pass_Gmap_Demo_12!"); // brukernavn og passord må gjømes en plass
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Credentials = login;
                client.Port = 587;
                client.EnableSsl = true;

                MailMessage msg = new MailMessage("GmapDemo01@gmail.com", epost);
                msg.Subject = "Vertifiseringskode:";
                msg.Body = String.Format(tallkode.ToString());
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


        private void SendCompletedCallBack(object sender, AsyncCompletedEventArgs e)
        {
            // blir brukt med SendEpost 
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled,", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Mail send");
            }

        }
    }
}
