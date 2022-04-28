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
            FyllListeneBoksene();
            GodkjentListeSjekk();
        }

        private void FyllListeneBoksene()
        {
            var BrukerListe = DBComBruker.ListAllBrukerFromDb();

            //liste over brukere 
            foreach (var item in BrukerListe)
            {
                if (item.Godkjent == true) lbListeOverbrukere.Items.Add(item.BrukerDataTilAdmin); // har logget in med vertifiseringskode
                else if (item.Godkjent == false) lbVenterPåGodkjenning.Items.Add(item.BrukerDataTilAdmin); // har ikke gjort det

            }
            lbListeOverbrukere.Sorted = true;
            lbVenterPåGodkjenning.Sorted = true;
        }

        private void GodkjentListeSjekk()
        {
            if (lbVenterPåGodkjenning.Items.Count <= 0)
            {
                btnGodta.Enabled = false;
                btnAvslå.Enabled = false;
            }
        }

        private void OppdaterListenOverBrukere(int index)
        {
            lbListeOverbrukere.Items.Clear();

            var BrukerListe = DBComBruker.ListAllBrukerFromDb();

            //liste over brukere 
            foreach (var item in BrukerListe)
            {
                if (item.Godkjent == true) lbListeOverbrukere.Items.Add(item.BrukerDataTilAdmin);
            }
            if (index < lbListeOverbrukere.Items.Count)
                lbListeOverbrukere.SelectedIndex = index;
            else
                lbListeOverbrukere.SelectedIndex = index - 1;

        }

        private void btnGodta_Click(object sender, EventArgs e)
        {
            if (lbVenterPåGodkjenning.SelectedIndex != -1)
            {
                if (InnloggetBruker.Sikkerhetsklarering == frmVisning.instance.MaxSikkerhetsklarering)
                {
                    string BrukerInfo = lbVenterPåGodkjenning.SelectedItem.ToString();
                    string TilEpost = HentEpostFraInfo(BrukerInfo);

                    var BrukerListe = DBComBruker.ListBrukerInfoFromDb(TilEpost);
                    DBComBruker.UpdateBruker_Godkjent(BrukerListe[0].Epost, true);

                    int tallkode = BrukerListe[0].Tallkode; ;
                    try
                    {
                        SendEpost(TilEpost, tallkode);
                        lbVenterPåGodkjenning.Items.Remove(BrukerInfo);
                    }
                    catch (Exception feilmelding)
                    {
                        DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                    }
                    GodkjentListeSjekk();
                }

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
            catch (Exception) { }
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
            if (lbVenterPåGodkjenning.SelectedIndex != -1)
            {
                if (InnloggetBruker.Sikkerhetsklarering == frmVisning.instance.MaxSikkerhetsklarering)
                {
                    //finn mailen
                    string BrukerInfo = lbVenterPåGodkjenning.SelectedItem.ToString();
                    string epost = HentEpostFraInfo(BrukerInfo);
                    FjernBruker(epost, BrukerInfo, -1);
                }
            }
        }

        private void FjernBruker(string epost, string BrukerInfo, int index)
        {
            //fjern fra databasen 
            try
            {
                DBComBruker.DeleteBruker(epost);
                lbVenterPåGodkjenning.Items.Remove(BrukerInfo);
            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }
            GodkjentListeSjekk();

            if (index != -1)
            {
                OppdaterListenOverBrukere(index);
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
            if (lbListeOverbrukere.SelectedIndex != -1)
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
                    bool tillatelse = KanOppgradere(InnloggetBruker.BrukernavnInnlogget, epost);
                    if (tillatelse)
                    {
                        var brukerListe = DBComBruker.ListBrukerInfoFromDb(epost);

                        int klarering = brukerListe[0].Sikkerhetsklarering;

                        if (brukerListe[0].Sikkerhetsklarering < frmVisning.instance.MaxSikkerhetsklarering)
                        {
                            klarering++;
                        }
                        else
                        {
                            MessageBox.Show("Kan ikke oppgradere fordi bruker allerede har høyeste");
                        }

                        DBComBruker.UpdateBruker_Sikkerhetsklarering(epost, klarering);

                        OppdaterListenOverBrukere(selectetItem);
                    }
                    else
                    {
                        string newLine = Environment.NewLine;
                        MessageBox.Show(string.Format("Du kan ikke oppgradere denne brukeren." + newLine
                            + "Du må ha høyre sikkerhetsklarering enn brukeren" + newLine + "Du har: {0}", InnloggetBruker.Sikkerhetsklarering));
                    }
                }
            }

        }

        private void BtnNedgrader_Click(object sender, EventArgs e)
        {
            if (lbListeOverbrukere.SelectedIndex != -1)
            {
                int selectetItem = lbListeOverbrukere.SelectedIndex;
                string BrukerInfo;
                string epost;

                try
                {
                    BrukerInfo = lbListeOverbrukere.SelectedItem.ToString();
                    epost = HentEpostFraInfo(BrukerInfo);
                }
                catch (Exception feilmelding)
                {
                    epost = null;
                    DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                }

                if (epost != null)
                {
                    bool tillatelse = KanNedgradereEllerFjerne(InnloggetBruker.BrukernavnInnlogget, epost);
                    if (tillatelse)
                    {
                        var brukerListe = DBComBruker.ListBrukerInfoFromDb(epost);

                        int klarering = brukerListe[0].Sikkerhetsklarering;
                        if (InnloggetBruker.BrukernavnInnlogget == epost)
                        {
                            string caption = "Nedgradere av deg selv: ";
                            string Endring = string.Format("{0}", epost);
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;

                            // Displays the MessageBox.
                            result = MessageBox.Show(Endring, caption, buttons);
                            if (result == DialogResult.Yes)
                            {
                                bool Nedgrader = false;
                                if (InnloggetBruker.Sikkerhetsklarering == frmVisning.instance.MaxSikkerhetsklarering)
                                {
                                    var antallMaksSikkerhetsklaering = DBComBruker.ListAllBrukerFromDbWithMaksSikkerhetsklarering(frmVisning.instance.MaxSikkerhetsklarering);

                                    if (antallMaksSikkerhetsklaering.Count > 1) // må være minst 2
                                    {
                                        Nedgrader = true;
                                    }
                                    else
                                    {
                                        string newLine = Environment.NewLine;
                                        MessageBox.Show(string.Format("Du er den eneste med maks sikkerhetsklaering." + newLine
                                            + "Oppgrader noen andre før du kan nedgraderes"));
                                    }
                                }
                                else
                                {
                                    Nedgrader = true;
                                }

                                if (Nedgrader)
                                {
                                    klarering--;
                                    DBComBruker.UpdateBruker_Sikkerhetsklarering(epost, klarering);
                                    if (epost == InnloggetBruker.BrukernavnInnlogget) InnloggetBruker.Sikkerhetsklarering--;
                                }

                            }
                        }
                        else if (brukerListe[0].Sikkerhetsklarering >= 2)
                        {
                            klarering--;
                            DBComBruker.UpdateBruker_Sikkerhetsklarering(epost, klarering);
                            if (epost == InnloggetBruker.BrukernavnInnlogget) InnloggetBruker.Sikkerhetsklarering--;
                        }
                        else
                        {
                            MessageBox.Show("Kan ikke nedgradere fordi bruker allerede har laveste");
                        }

                        OppdaterListenOverBrukere(selectetItem);
                    }
                    else
                    {
                        string newLine = Environment.NewLine;
                        MessageBox.Show(string.Format("Du kan ikke nedgradere denne brukeren." + newLine
                            + "Du må ha høyre sikkerhetsklarering enn brukeren" + newLine + "Du har: {0}", InnloggetBruker.Sikkerhetsklarering));
                    }
                }
            }
        }
        private bool KanOppgradere(string Innlogget, string Aktuell)
        {
            bool sjekk = false;

            try
            {
                var InnloggetBruker = DBComBruker.ListBrukerInfoFromDb(Innlogget);
                var AktuellBruker = DBComBruker.ListBrukerInfoFromDb(Aktuell);

                if (InnloggetBruker[0].Sikkerhetsklarering > frmVisning.instance.MaxSikkerhetsklarering)
                    InnloggetBruker[0].Sikkerhetsklarering = frmVisning.instance.MaxSikkerhetsklarering;

                if (InnloggetBruker[0].Sikkerhetsklarering > AktuellBruker[0].Sikkerhetsklarering)
                {
                    sjekk = true;
                }
            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }



            return sjekk;
        }

        private bool KanNedgradereEllerFjerne(string Innlogget, string Aktuell)
        {
            bool sjekk = false;

            try
            {
                var InnloggetBruker = DBComBruker.ListBrukerInfoFromDb(Innlogget);
                var AktuellBruker = DBComBruker.ListBrukerInfoFromDb(Aktuell);


                if (InnloggetBruker[0].Sikkerhetsklarering > AktuellBruker[0].Sikkerhetsklarering)
                {
                    sjekk = true;
                }
                if (InnloggetBruker[0].Epost == AktuellBruker[0].Epost)
                {
                    sjekk = true;
                }
            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }

            return sjekk;
        }

        private void btnFjern_Click(object sender, EventArgs e)
        {
            if (lbListeOverbrukere.SelectedIndex != -1)
            {
                //forløpi kun de med sikkerhetsklaering 3 som kan fjerne 
                if (InnloggetBruker.Sikkerhetsklarering == frmVisning.instance.MaxSikkerhetsklarering)
                {

                    //finn mailen
                    int selectetItem = lbListeOverbrukere.SelectedIndex;
                    string BrukerInfo = lbListeOverbrukere.SelectedItem.ToString();
                    string epost = HentEpostFraInfo(BrukerInfo);

                    if (InnloggetBruker.BrukernavnInnlogget == epost)
                    {
                        MessageBox.Show("Du kan ikke slette din egen bruker");
                    }
                    else
                    {
                        bool Tillatelse = KanNedgradereEllerFjerne(InnloggetBruker.BrukernavnInnlogget, epost);

                        if (Tillatelse)
                        {
                            string caption = "Vil du Virkelig slette denne brukeren: ";
                            string Endring = string.Format("{0}", epost);
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;

                            // Displays the MessageBox.
                            result = MessageBox.Show(Endring, caption, buttons);
                            if (result == DialogResult.Yes)
                            {
                                FjernBruker(epost, BrukerInfo, selectetItem);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Du kan ikke fjerne en med høyeste sikkerhetsklarering");
                        }
                    }

                }
                else
                {
                    string newLine = Environment.NewLine;
                    MessageBox.Show(string.Format("Du Må ha høyeste sikkerhetsklarering: {0}." + newLine + "Du har: {1}",
                        frmVisning.instance.MaxSikkerhetsklarering.ToString(), InnloggetBruker.Sikkerhetsklarering.ToString()));
                }
            }

        }
    }
}
