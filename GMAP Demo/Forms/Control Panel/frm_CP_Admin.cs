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
        //Frm_CP_Admin instance;

        public Frm_CP_Admin()
        {
            InitializeComponent();
            //instance = this;
            SetTheme();
        }

        private void SetTheme()
        {
            //instance.BackColor = ThemeDesign.colorBackground;
            BackColor = ThemeDesign.colorBackground;

            lblTitle.ForeColor = ThemeDesign.colorPurple;

            lblVenterGodkjenning.ForeColor = ThemeDesign.colorLabel;
            btnGodta.ForeColor = ThemeDesign.colorLabel;
            btnGodta.BackColor = ThemeDesign.colorGray;
            btnAvslå.ForeColor = ThemeDesign.colorLabel;
            btnAvslå.BackColor = ThemeDesign.colorGray;
            lbVenterPåGodkjenning.ForeColor = ThemeDesign.colorLabel;
            lbVenterPåGodkjenning.BackColor = ThemeDesign.colorGray;

            lblListeOverIkkeVertifiserte.ForeColor = ThemeDesign.colorLabel;
            lbIkkeVerifisert.BackColor = ThemeDesign.colorGray;
            lbIkkeVerifisert.ForeColor = ThemeDesign.colorLabel;


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
        }

        private void FyllListeneBoksene()
        {
            if (lbListeOverbrukere.Items.Count > 0) lbListeOverbrukere.Items.Clear();
            if (lbVenterPåGodkjenning.Items.Count > 0) lbVenterPåGodkjenning.Items.Clear();

            var BrukerListe = DBComBruker.ListAllBrukerFromDb();

            //liste over brukere 
            foreach (var item in BrukerListe)
            {
                if (item.Godkjent == true)
                    if (item.Verifisert == true)// Har logget inn med vertifiseringskode
                        lbListeOverbrukere.Items.Add(item.BrukerDataTilAdmin);
                    else
                        lbIkkeVerifisert.Items.Add(item.BrukerDataIkkeVertifisert);

                else if (item.Godkjent == false) lbVenterPåGodkjenning.Items.Add(item.BrukerDataTilAdmin); // har ikke gjort det

            }
            GodkjentListeSjekk();
        }

        private void GodkjentListeSjekk()
        {
            if (lbVenterPåGodkjenning.Items.Count <= 0)
            {
                btnGodta.Enabled = false;
                btnAvslå.Enabled = false;
            }
        }

        private void OppdaterListenOverBrukere() // int index
        {
            lbListeOverbrukere.Items.Clear();

            var BrukerListe = DBComBruker.ListAllBrukerFromDb();

            // Liste over brukere 
            foreach (var item in BrukerListe)
            {
                if (item.Godkjent == true) lbListeOverbrukere.Items.Add(item.BrukerDataTilAdmin);
            }
            //if (index < lbListeOverbrukere.Items.Count)
            //    lbListeOverbrukere.SelectedIndex = index;
            //else
            //    lbListeOverbrukere.SelectedIndex = index - 1;

        }

        private void btnGodta_Click(object sender, EventArgs e)
        {
            if (lbVenterPåGodkjenning.SelectedIndex == -1)
            {
                return;
            }

            if (InnloggetBruker.Sikkerhetsklarering != Globalekonstanter.MaxSikkerhetsklarering)
            {
                MessageBox.Show("Du må ha høyeste sikkerhetsklarering for å godkjenne/avslå brukere");
                return;
            }

            string BrukerInfo = lbVenterPåGodkjenning.SelectedItem.ToString();
            string TilEpost = HentEpostFraInfo(BrukerInfo);

            // Henter infoen om brukern som nettopp har blitt godkjent med hjelp av eposten  
            Bruker GodkjentBruker = DBComBruker.ListBrukerInfoFromDb(TilEpost);

            DBComBruker.UpdateBruker_Godkjent(GodkjentBruker.Epost, true);

            // lagrer tallkoden som ble laget når brukern ble opprettet 
            int tallkode = GodkjentBruker.Tallkode;

            try
            {

                // Sender epost med tallkode 
                SendEpost(TilEpost, tallkode);

                // Fjerner brukeren fra listen og legger til i vente listen
                lbVenterPåGodkjenning.Items.Remove(BrukerInfo);
                lbIkkeVerifisert.Items.Add(GodkjentBruker.BrukerDataIkkeVertifisert);
            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
            }
            GodkjentListeSjekk();
        }

        private void SendEpost(string TilEpost, int tallkode)
        {
            //https://www.youtube.com/watch?v=4lzZ0wzEK14
            try
            {

                NetworkCredential login = new NetworkCredential(Properties.Settings.Default.EpostVerifisering, Properties.Settings.Default.PassordEpostVerifisering);//, "dlpkqccjjxolhvog"
                SmtpClient client = new SmtpClient(Properties.Settings.Default.EmailTypeVerifisering);//Properties.Settings.Default.EmailTypeVerifisering
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
                MessageBox.Show("Mail sendt");
                //DBComBruker.UpdateBruker_Godkjent(GodkjentBruker.Epost, true);
                //GodkjentBruker = null;
                //FyllListeneBoksene();
            }
        }

        private void BtnAvslå_Click(object sender, EventArgs e)
        {
            if (lbVenterPåGodkjenning.SelectedIndex == -1)
            {
                return;
            }

            if (InnloggetBruker.Sikkerhetsklarering != Globalekonstanter.MaxSikkerhetsklarering)
            {
                MessageBox.Show("Du må ha høyeste sikkerhetsklarering for å godkjenne/avslå brukere");
                return;
            }

            // Finn mailen
            string BrukerInfo = lbVenterPåGodkjenning.SelectedItem.ToString();
            string epost = HentEpostFraInfo(BrukerInfo);
            FjernBruker(epost, BrukerInfo);


        }

        private void FjernBruker(string epost, string BrukerInfo)
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
            if (lbListeOverbrukere.SelectedIndex == -1)
            {
                return;
            }

            string BrukerInfo;
            string epost;
            // Henter epost adresse fra listen
            try
            {
                BrukerInfo = lbListeOverbrukere.SelectedItem.ToString();
                epost = HentEpostFraInfo(BrukerInfo);
            }
            catch (Exception feilmelding)
            {
                DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                return;
            }

            // Henter infomasjon om brukeren,  
            Bruker AkutellBruker = DBComBruker.ListBrukerInfoFromDb(epost);

            // Sjekker man har tillatelse til å oppgradere 
            bool tillatelse = KanOppgradere(InnloggetBruker.BrukernavnInnlogget, AkutellBruker);
            if (!tillatelse)
            {
                string newLine = Environment.NewLine;
                MessageBox.Show(string.Format(
                      "Du kan ikke oppgradere denne brukeren." + newLine
                    + "Du må ha høyre sikkerhetsklarering enn brukeren." + newLine
                    + "Du har: {0}", InnloggetBruker.Sikkerhetsklarering));

                return;
            }

            // Ekstra sjekk at man ikke kommer over grensen 
            if (AkutellBruker.Sikkerhetsklarering >= Globalekonstanter.MaxSikkerhetsklarering)
            {
                MessageBox.Show("Kan ikke oppgradere fordi bruker allerede har høyeste");
                return;
            }

            // Øker sikkerhetsklareringen 
            int klarering = AkutellBruker.Sikkerhetsklarering;
            klarering++;

            DBComBruker.UpdateBruker_Sikkerhetsklarering(AkutellBruker.Epost, klarering);
            OppdaterListenOverBrukere(); //selectetItem
        }

        private void BtnNedgrader_Click(object sender, EventArgs e)
        {

            if (lbListeOverbrukere.SelectedIndex == -1)
            {
                return;
            }

            string BrukerInfo;
            string epost;

            // Henter epost adresse fra listen
            try
            {
                BrukerInfo = lbListeOverbrukere.SelectedItem.ToString();
                epost = HentEpostFraInfo(BrukerInfo);
            }
            catch (Exception feilmelding)
            {

                DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                return;
            }

            // Henter info om den aktuellbrukeren 
            Bruker AktuellBruker = DBComBruker.ListBrukerInfoFromDb(epost);

            // Sjekker om man får lov
            bool tillatelse = KanNedgradereEllerFjerne(InnloggetBruker.BrukernavnInnlogget, AktuellBruker);
            if (!tillatelse)
            {
                string newLine = Environment.NewLine;
                MessageBox.Show(string.Format(
                     "Du kan ikke nedgradere denne brukeren." + newLine
                   + "Du må ha høyre sikkerhetsklarering enn brukeren." + newLine
                   + "Du har: {0}", InnloggetBruker.Sikkerhetsklarering));

                return;
            }

            // Sjekk om man prøver å nedgradere seg selv 
            if (InnloggetBruker.BrukernavnInnlogget == epost)
            {
                if (InnloggetBruker.Sikkerhetsklarering == Globalekonstanter.MaxSikkerhetsklarering)
                {
                    // Sjekk om det fremdeles er noen med maks, om du nedgardere deg selv.
                    // Det må være minst en til for å kunne gjennomføre 

                    var antallMaksSikkerhetsklaering = DBComBruker.ListAllBrukerFromDbWithMaksSikkerhetsklarering(Globalekonstanter.MaxSikkerhetsklarering);

                    if (antallMaksSikkerhetsklaering.Count <= 1) // må minst være 2
                    {
                        string newLine = Environment.NewLine;
                        MessageBox.Show(string.Format("Du er den eneste med maks sikkerhetsklaering." + newLine
                            + "Oppgrader noen andre før du kan nedgraderes"));
                        return;
                    }
                }
                else if (InnloggetBruker.Sikkerhetsklarering <= 1)
                {
                    MessageBox.Show(string.Format("Kan ikke nedgradere fordi du allerede har laveste"));
                    return;
                }

                // Har da lov til å nedgradere seg selv 
                string Tittel = "Nedgradere deg selv: ";
                string Endring = string.Format("{0}", epost);

                bool ØnskerÅNedgrader = Tekstbehandling.MeldingsboksYesNo(Tittel, Endring);

                if (!ØnskerÅNedgrader)
                {
                    return;
                }

            }
            else if (AktuellBruker.Sikkerhetsklarering <= 1)
            {
                MessageBox.Show("Kan ikke nedgradere fordi bruker allerede har laveste");
                return;
            }

            int klarering = AktuellBruker.Sikkerhetsklarering;
            klarering--;

            DBComBruker.UpdateBruker_Sikkerhetsklarering(epost, klarering);
            if (epost == InnloggetBruker.BrukernavnInnlogget) InnloggetBruker.Sikkerhetsklarering--;

            OppdaterListenOverBrukere();

        }

        private bool KanOppgradere(string Innlogget, Bruker AktuellBruker)
        {
            bool sjekk = false;

            try
            {
                Bruker InnloggetBruker = DBComBruker.ListBrukerInfoFromDb(Innlogget);

                //Hvis man med en feil har høyre enn maks 
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

        private bool KanNedgradereEllerFjerne(string Innlogget, Bruker AktuellBruker)
        {
            bool sjekk = false;

            try
            {
                Bruker InnloggetBruker = DBComBruker.ListBrukerInfoFromDb(Innlogget);

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
            if (lbListeOverbrukere.SelectedIndex == -1)
            {
                return;
            }

            // Forløpi kun de med sikkerhetsklaering 3 som kan fjerne 
            if (InnloggetBruker.Sikkerhetsklarering != Globalekonstanter.MaxSikkerhetsklarering)
            {
                string newLine = Environment.NewLine;
                MessageBox.Show(string.Format("Du må ha høyeste sikkerhetsklarering: {0}." + newLine + "Du har: {1}",
                    Globalekonstanter.MaxSikkerhetsklarering.ToString(), InnloggetBruker.Sikkerhetsklarering.ToString()));

                return;
            }

            // Finner mailen         
            string BrukerInfo = lbListeOverbrukere.SelectedItem.ToString();
            string epost = HentEpostFraInfo(BrukerInfo);

            // Kan ikke slette sin egen bruker 
            if (InnloggetBruker.BrukernavnInnlogget == epost)
            {
                MessageBox.Show("Du kan ikke slette din egen bruker");
                return;
            }

            Bruker AktuellBruker = DBComBruker.ListBrukerInfoFromDb(epost);

            // Sjekker om man har høyre enn den aktuell brukeren 
            bool Tillatelse = KanNedgradereEllerFjerne(InnloggetBruker.BrukernavnInnlogget, AktuellBruker);
            if (!Tillatelse)
            {
                MessageBox.Show("Du kan ikke fjerne en med høyre eller lik sikkerhetsklarering");
                return;
            }

            string Tittel = "Vil du virkelig slette denne brukeren: ";
            string Endring = string.Format("{0}", epost);
            bool Fjern = Tekstbehandling.MeldingsboksYesNo(Tittel, Endring);

            if (Fjern)
            {
                FjernBruker(epost, BrukerInfo);
            }
        }
    }
}
