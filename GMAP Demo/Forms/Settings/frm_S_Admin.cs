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
            var BrukerListe = DatabaseCommunication.ListAllBrukerFromDb();

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

            var BrukerListe = DatabaseCommunication.ListAllBrukerFromDb();

            //liste over brukere 
            foreach (var item in BrukerListe)
            {
                if (item.Godkjent == true) lbListeOverbrukere.Items.Add(item.BrukerDataTilAdmin);
            }
            lbListeOverbrukere.SelectedIndex = index;
        }

        private void btnGodta_Click(object sender, EventArgs e)
        {
            if (InnloggetBruker.Sikkerhetsklarering == FrmVisning.instance.MaxSikkerhetsklarering)
            {
                string BrukerInfo = lbVenterPåGodkjenning.SelectedItem.ToString();

                string TilEpost = HentEpostFraInfo(BrukerInfo);


                var BrukerListe = DatabaseCommunication.ListBrukerInfoFromDb(TilEpost);
                DatabaseCommunication.UpdateBruker_Godkjent(BrukerListe[0].Epost, true);

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
            if (InnloggetBruker.Sikkerhetsklarering == FrmVisning.instance.MaxSikkerhetsklarering)
            {
                //finn mailen
                string BrukerInfo = lbVenterPåGodkjenning.SelectedItem.ToString();
                string epost = HentEpostFraInfo(BrukerInfo);

                //fjern fra databasen 
                try
                {
                    DatabaseCommunication.DeleteBruker(epost);
                    lbVenterPåGodkjenning.Items.Remove(BrukerInfo);
                }
                catch (Exception)
                {

                }
                listesjekk();
            }
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
                bool tillatelse = KanOppgradere(InnloggetBruker.BrukernavnInnlogget,epost);
                if (tillatelse)
                {
                    var brukerListe = DatabaseCommunication.ListBrukerInfoFromDb(epost);

                    int klarering = brukerListe[0].Sikkerhetsklarering;

                    if (brukerListe[0].Sikkerhetsklarering < FrmVisning.instance.MaxSikkerhetsklarering)
                    {
                        klarering++;
                    }
                    else
                    {
                        MessageBox.Show("Kan ikke oppgradere fordi bruker allerede har høyeste");
                    }

                    DatabaseCommunication.UpdateBruker_Sikkerhetsklarering(epost, klarering);

                    OppdaterListenOverBrukere(selectetItem);
                }
            }

        }

        private void BtnNedgrader_Click(object sender, EventArgs e)
        {
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
                bool tillatelse = KanNedgradere(InnloggetBruker.BrukernavnInnlogget, epost);
                if (tillatelse)
                {
                    var brukerListe = DatabaseCommunication.ListBrukerInfoFromDb(epost);

                    int klarering = brukerListe[0].Sikkerhetsklarering;

                    if (brukerListe[0].Sikkerhetsklarering >= 2)
                    {
                        klarering--;
                    }
                    else
                    {
                        MessageBox.Show("Kan ikke nedgradere fordi bruker allerede har laveste");
                    }
                    DatabaseCommunication.UpdateBruker_Sikkerhetsklarering(epost, klarering);

                    OppdaterListenOverBrukere(selectetItem);
                }
            }           
        }
        private bool KanOppgradere(string Innlogget, string Aktuell)
        {
            bool sjekk = false;

            try
            {
                var InnloggetBruker = DatabaseCommunication.ListBrukerInfoFromDb(Innlogget);
                var AktuellBruker = DatabaseCommunication.ListBrukerInfoFromDb(Aktuell);

                if (InnloggetBruker[0].Sikkerhetsklarering > AktuellBruker[0].Sikkerhetsklarering)
                {
                    sjekk = true;
                }
            }
            catch (Exception)
            {

            }
           

           
            return sjekk;
        }

        private bool KanNedgradere(string Innlogget, string Aktuell)
        {
            bool sjekk = false;

            try
            {
                var InnloggetBruker = DatabaseCommunication.ListBrukerInfoFromDb(Innlogget);
                var AktuellBruker = DatabaseCommunication.ListBrukerInfoFromDb(Aktuell);

                if (InnloggetBruker[0].Sikkerhetsklarering > AktuellBruker[0].Sikkerhetsklarering)
                {
                    sjekk = true;
                }
                if (InnloggetBruker[0].Epost == AktuellBruker[0].Epost)
                {
                    sjekk = true;
                }
            }
            catch (Exception)
            {

            }
           
            return sjekk;
        }
    }
}
