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
            HentAlleBrukere();
        }

        public void HentAlleBrukere()
        {
            DatabaseCommunication db = new DatabaseCommunication();
            var BrukerListe = db.ListAllBrukerFromDb();

            //liste over brukere 
            foreach (var item in BrukerListe)
            {
                if (item.Godkjent == true) lbListeOverbrukere.Items.Add(item.BrukerDataTilAdmin);
                else if (item.Godkjent == false) lbVenterPåGodkjenning.Items.Add(item.BrukerDataTilAdmin);

            }
            //liste over Ventene brukere


        }

        private void btnGodta_Click(object sender, EventArgs e)
        {

            string epost = lbVenterPåGodkjenning.SelectedItem.ToString();
            epost = epost.Substring(0, epost.IndexOf(" "));
            MessageBox.Show(epost);

            //Brude lage en metode som tar epost som argument istendefor 
            DatabaseCommunication db = new DatabaseCommunication();
            var BrukerListe = db.ListAllBrukerFromDb();
            int tallkode = 0;
            foreach (var item in BrukerListe)
            {
                if (item.Epost == epost)
                {
                    tallkode = item.Tallkode;
                    break;
                }
            }

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
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled,", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Melding send");
            }

        }
    }
}
