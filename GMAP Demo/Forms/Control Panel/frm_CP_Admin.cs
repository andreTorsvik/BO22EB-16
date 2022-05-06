using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class Frm_CP_Admin : Form
    {
        Frm_CP_Admin instance;
        public Frm_CP_Admin()
        {
            InitializeComponent();
            instance = this;
            SetTheme();
        }

        private void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;

            lblTitle.ForeColor = ThemeDesign.colorPurple;

            lblVenterGodkjenning.ForeColor = ThemeDesign.colorLabel;
            btnGodta.ForeColor = ThemeDesign.colorLabel;
            btnGodta.BackColor = ThemeDesign.colorGray;
            btnAvslå.ForeColor = ThemeDesign.colorLabel;
            btnAvslå.BackColor = ThemeDesign.colorGray;
            lbVenterPåGodkjenning.ForeColor = ThemeDesign.colorLabel;
            lbVenterPåGodkjenning.BackColor = ThemeDesign.colorGray;

            lblListeOverBrukere.ForeColor = ThemeDesign.colorLabel;
            btnOppgrader.ForeColor = ThemeDesign.colorLabel;
            btnOppgrader.BackColor = ThemeDesign.colorGray;
            btnNedgrader.ForeColor = ThemeDesign.colorLabel;
            btnNedgrader.BackColor = ThemeDesign.colorGray;
            btnFjern.ForeColor = ThemeDesign.colorLabel;
            btnFjern.BackColor = ThemeDesign.colorGray;
            lbListeOverbrukere.ForeColor = ThemeDesign.colorLabel;
            lbListeOverbrukere.BackColor = ThemeDesign.colorGray;
        }

        private void Frm_S_Admin_Load(object sender, EventArgs e)
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
                if (InnloggetBruker.Sikkerhetsklarering == Globalekonstanter.MaxSikkerhetsklarering)
                {
                    string BrukerInfo = lbVenterPåGodkjenning.SelectedItem.ToString();
                    string TilEpost = HentEpostFraInfo(BrukerInfo);

                    Bruker bruker = DBComBruker.ListBrukerInfoFromDb(TilEpost);
                    DBComBruker.UpdateBruker_Godkjent(bruker.Epost, true);

                    int tallkode = bruker.Tallkode;
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
            //https://www.youtube.com/watch?v=4lzZ0wzEK14
            try
            {
                NetworkCredential login = new NetworkCredential(Properties.Settings.Default.EpostVerifisering, Properties.Settings.Default.PassordEpostVerifisering);
                SmtpClient client = new SmtpClient(Properties.Settings.Default.EmailTypeVerifisering);
                client.Credentials = login;
                client.Port = 587;
                client.EnableSsl = true;

                MailMessage msg = new MailMessage(Properties.Settings.Default.EpostVerifisering, TilEpost);
                msg.Subject = "Verifiseringskode:";
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
                MessageBox.Show("Mail sendt");
            }
        }

        private void BtnAvslå_Click(object sender, EventArgs e)
        {
            if (lbVenterPåGodkjenning.SelectedIndex != -1)
            {
                if (InnloggetBruker.Sikkerhetsklarering == Globalekonstanter.MaxSikkerhetsklarering)
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

        private void BtnOppgrader_Click(object sender, EventArgs e)
        {
            if (lbListeOverbrukere.SelectedIndex != -1)
            {
                // Sjekk om klarering
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
                        Bruker bruker = DBComBruker.ListBrukerInfoFromDb(epost);

                        int klarering = bruker.Sikkerhetsklarering;

                        if (bruker.Sikkerhetsklarering < Globalekonstanter.MaxSikkerhetsklarering)
                        {
                            klarering++;
                            DBComBruker.UpdateBruker_Sikkerhetsklarering(epost, klarering);
                        }
                        else
                        {
                            MessageBox.Show("Kan ikke oppgradere fordi bruker allerede har høyeste");
                        }

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
                        Bruker AktuellBruker = DBComBruker.ListBrukerInfoFromDb(epost);

                        int klarering = AktuellBruker.Sikkerhetsklarering;
                        if (InnloggetBruker.BrukernavnInnlogget == epost)
                        {
                            string Tittel = "Nedgradere deg selv: ";
                            string Endring = string.Format("{0}", epost);

                            bool ØnskerÅNedgrader = FellesMetoder.MeldingsboksYesNo(Tittel, Endring);
                            
                            if (ØnskerÅNedgrader)
                            {
                                bool Nedgrader = false;
                                if (InnloggetBruker.Sikkerhetsklarering == Globalekonstanter.MaxSikkerhetsklarering)
                                {
                                    var antallMaksSikkerhetsklaering = DBComBruker.ListAllBrukerFromDbWithMaksSikkerhetsklarering(Globalekonstanter.MaxSikkerhetsklarering);

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
                                else if(InnloggetBruker.Sikkerhetsklarering >= 1 )
                                {
                                    Nedgrader = false;
                                    MessageBox.Show(string.Format("Kan ikke nedgradere fordi bruker allerede har laveste"));
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
                        else if (AktuellBruker.Sikkerhetsklarering >= Globalekonstanter.MaxSikkerhetsklarering-1) // 2
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
                Bruker InnloggetBruker = DBComBruker.ListBrukerInfoFromDb(Innlogget);
                Bruker AktuellBruker = DBComBruker.ListBrukerInfoFromDb(Aktuell);

                if (InnloggetBruker.Sikkerhetsklarering > Globalekonstanter.MaxSikkerhetsklarering)
                    InnloggetBruker.Sikkerhetsklarering = Globalekonstanter.MaxSikkerhetsklarering;

                if (InnloggetBruker.Sikkerhetsklarering > AktuellBruker.Sikkerhetsklarering)
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
                Bruker InnloggetBruker = DBComBruker.ListBrukerInfoFromDb(Innlogget);
                Bruker AktuellBruker = DBComBruker.ListBrukerInfoFromDb(Aktuell);


                if (InnloggetBruker.Sikkerhetsklarering > AktuellBruker.Sikkerhetsklarering)
                {
                    sjekk = true;
                }
                if (InnloggetBruker.Epost == AktuellBruker.Epost)
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

        private void BtnFjern_Click(object sender, EventArgs e)
        {
            if (lbListeOverbrukere.SelectedIndex != -1)
            {
                // Forløpi kun de med sikkerhetsklaering 3 som kan fjerne 
                if (InnloggetBruker.Sikkerhetsklarering == Globalekonstanter.MaxSikkerhetsklarering)
                {

                    // Finner mailen
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
                            string Tittel = "Vil du Virkelig slette denne brukeren: ";
                            string Endring = string.Format("{0}", epost);

                            bool Fjern = FellesMetoder.MeldingsboksYesNo(Tittel, Endring);

                            if (Fjern)
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
                        Globalekonstanter.MaxSikkerhetsklarering.ToString(), InnloggetBruker.Sikkerhetsklarering.ToString()));
                }
            }

        }
    }
}
