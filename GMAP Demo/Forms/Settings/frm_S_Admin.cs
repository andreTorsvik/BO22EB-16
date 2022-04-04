using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

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
            FyllListeneBoksene();
            listesjekk();
        }

        private void FyllListeneBoksene()
        {
            DatabaseCommunication db = new DatabaseCommunication();
            var BrukerListe = db.ListAllBrukerFromDb();

            //liste over brukere 
            foreach (var item in BrukerListe)
            {
                if (item.Godkjent == true) lbListeOverbrukere.Items.Add(item.BrukerDataTilAdmin); // har logget in med vertifiseringskode
                else if (item.Godkjent == false) lbVenterPåGodkjenning.Items.Add(item.BrukerDataTilAdmin); // har ikke gjort det

            }
            lbListeOverbrukere.Sorted = true;
            lbVenterPåGodkjenning.Sorted = true;
        }

        private void listesjekk()
        {
            if(lbVenterPåGodkjenning.Items.Count <= 0)
            {
                btnGodta.Enabled = false;
                btnAvslå.Enabled = false;
            }
        }

        private void OppdaterListenOverBrukere(int index)
        {
            lbListeOverbrukere.Items.Clear();

            DatabaseCommunication db = new DatabaseCommunication();
            var BrukerListe = db.ListAllBrukerFromDb();

            //liste over brukere 
            foreach (var item in BrukerListe)
            {
                if (item.Godkjent == true) lbListeOverbrukere.Items.Add(item.BrukerDataTilAdmin);
            }
            lbListeOverbrukere.SelectedIndex = index;
        }

        private void btnGodta_Click(object sender, EventArgs e)
        {
            string BrukerInfo = lbVenterPåGodkjenning.SelectedItem.ToString();

            string TilEpost = HentEpostFraInfo(BrukerInfo);

            DatabaseCommunication db = new DatabaseCommunication();
            var BrukerListe = db.ListBrukerInfoFromDb(TilEpost);
            db.UpdateBruker_Godkjent(BrukerListe[0].Epost, true);

            int tallkode = BrukerListe[0].Tallkode; ;
            try
            {
                SendEpost(TilEpost, tallkode);                
                lbVenterPåGodkjenning.Items.Remove(BrukerInfo);
            }
            catch (Exception)
            {
            }
            listesjekk();
        }

        private void SendEpost(string TilEpost, int tallkode)
        {  
            try
            {
                NetworkCredential login = new NetworkCredential("GmapDemo01@gmail.com", GMAP_Demo.Properties.Settings.Default.Passord); // brukernavn og passord må gjømes en plass
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Credentials = login;
                client.Port = 587;
                client.EnableSsl = true;

                MailMessage msg = new MailMessage("GmapDemo01@gmail.com", TilEpost);
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
            catch (Exception) {  }
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

        private void btnAvslå_Click(object sender, EventArgs e)
        {
            //finn mailen
            string BrukerInfo = lbVenterPåGodkjenning.SelectedItem.ToString();
            string epost = HentEpostFraInfo(BrukerInfo);

            //fjern fra databasen 
            try
            {
                DatabaseCommunication db = new DatabaseCommunication();
                db.DeleteUser(epost);
                lbVenterPåGodkjenning.Items.Remove(BrukerInfo);
            }
            catch (Exception)
            {

            }
            listesjekk();
        }

        private string HentEpostFraInfo(string info)
        {
            string Epost = info.Substring(0, info.IndexOf(" "));

            //eposten skal være uten mellom fra før av men kun for sikkerhetsskyld 
            Epost.Trim();

            return Epost;
        }

        private void btnOppgrader_Click(object sender, EventArgs e)
        {
            //sjekk om klarering
            int selectetItem = lbListeOverbrukere.SelectedIndex;
            string BrukerInfo;
            string epost;
            try
            {
                BrukerInfo = lbListeOverbrukere.SelectedItem.ToString();
                epost = HentEpostFraInfo(BrukerInfo);
            }
            catch (Exception)
            {
                epost = null;
            }

            if (epost != null)
            {
                DatabaseCommunication db = new DatabaseCommunication();
                var brukerListe = db.ListBrukerInfoFromDb(epost);

                int klarering = brukerListe[0].Sikkerhetsklarering;

                if (brukerListe[0].Sikkerhetsklarering < Form1.instance.MaxSikkerhetsklarering)
                {
                    klarering++;
                }
                else
                {
                    MessageBox.Show("Kan ikke oppgradere fordi bruker allerede har høyeste");
                }

                db.UpdateBruker_Sikkerhetsklarering(epost, klarering);

                OppdaterListenOverBrukere(selectetItem);
            }

        }

        private void BtnNedgrader_Click(object sender, EventArgs e)
        {
            int selectetItem = lbListeOverbrukere.SelectedIndex;
            string BrukerInfo = lbListeOverbrukere.SelectedItem.ToString();
            string epost = HentEpostFraInfo(BrukerInfo);

            DatabaseCommunication db = new DatabaseCommunication();
            var brukerListe = db.ListBrukerInfoFromDb(epost);

            int klarering = brukerListe[0].Sikkerhetsklarering;

            if (brukerListe[0].Sikkerhetsklarering >= 2)
            {
                klarering--;
            }
            else
            {
                MessageBox.Show("Kan ikke nedgradere fordi bruker allerede har laveste");
            }

            db.UpdateBruker_Sikkerhetsklarering(epost, klarering);

            OppdaterListenOverBrukere(selectetItem);
        }
        private bool KanOppgradere(int InnloggetBruker, int Aktuellbruker)
        {
            bool sjekk = false;





            return sjekk;
        }

    }
}
