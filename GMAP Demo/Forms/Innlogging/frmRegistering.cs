using System;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class frmRegistering : Form
    {
        public static frmRegistering instance;
        public frmRegistering()
        {
            InitializeComponent();
            instance = this;
            SetTheme();
        }

        private void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;
            lblTitle.ForeColor = ThemeDesign.colorBlue;
            lblTitle2.ForeColor = ThemeDesign.colorBlue;
            lbFornavn.ForeColor = ThemeDesign.colorBlue;
            lblEtternavn.ForeColor = ThemeDesign.colorBlue;
            lblTelefonnummer.ForeColor = ThemeDesign.colorBlue;
            lblEpost.ForeColor = ThemeDesign.colorBlue;
            lblPassord.ForeColor = ThemeDesign.colorBlue;
            lblBekreftPassord.ForeColor = ThemeDesign.colorBlue;

            tbFornavn.ForeColor = ThemeDesign.colorLabel;
            tbFornavn.BackColor = ThemeDesign.colorGray;
            tbEtternavn.ForeColor = ThemeDesign.colorLabel;
            tbEtternavn.BackColor = ThemeDesign.colorGray;
            tbTelefonnummer.ForeColor = ThemeDesign.colorLabel;
            tbTelefonnummer.BackColor = ThemeDesign.colorGray;
            tbEpost.ForeColor = ThemeDesign.colorLabel;
            tbEpost.BackColor = ThemeDesign.colorGray;
            tbPassord.ForeColor = ThemeDesign.colorLabel;
            tbPassord.BackColor = ThemeDesign.colorGray;
            tbBekreftPassord.ForeColor = ThemeDesign.colorLabel;
            tbBekreftPassord.BackColor = ThemeDesign.colorGray;

            btnOpprettbruker.ForeColor = ThemeDesign.colorBackground;
            btnOpprettbruker.BackColor = ThemeDesign.colorBlue;
            btnAvbryt.ForeColor = ThemeDesign.colorBackground;
            btnAvbryt.BackColor = ThemeDesign.colorBlue;
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            frmInnlogging.instance.Location = this.Location;
            this.Close();

        }

        private void btnOpprettbruker_Click(object sender, EventArgs e)
        {
            bool opprettet = OpprettBruker();

            if (opprettet)
            {
                MessageBox.Show("Bruker er nå opprett, venter på å bli godkjent av en admin. Hvis den blir godkjent " +
                    "mottar du en mail med en tallkode.");

                this.Close();
            }
        }

        private bool OpprettBruker()
        {
            bool svar = false;
            string fornavn = tbFornavn.Text;
            string etternavn = tbEtternavn.Text;
            string telefon = tbTelefonnummer.Text;
            string Epost = tbEpost.Text.ToLower();
            string passord = tbPassord.Text;
            string bePassord = tbBekreftPassord.Text;

            string utFyllingsmangler = Tekstbehandling.AltUtfylt_Registerings(fornavn, etternavn, telefon, Epost, passord, bePassord);

            if (utFyllingsmangler == string.Empty)
            {
                string feil = Tekstbehandling.SjekkGyldigDataRegistering(Epost, passord, bePassord);

                if (feil == string.Empty)
                {
                    try
                    {
                        //Generer tall 
                        int Tallkode = GenereTallKode();
                        //legge til i database
                        DBComBruker.InsertBrukerToDb(fornavn, etternavn, Convert.ToInt32(telefon), Epost.Trim(), passord, Tallkode);

                        svar = true;
                    }
                    catch (Exception) { }

                }
                else MessageBox.Show(feil);
            }
            else MessageBox.Show(utFyllingsmangler);

            return svar;
        }

        private int GenereTallKode()
        {
            double tallkode = 0;
            Random r = new Random();
            bool sjekk = true;
            while (sjekk)
            {
                for (int i = 0; i < 7; i++)
                {
                    tallkode += r.Next(9) * Math.Pow(10, Convert.ToDouble(i));

                }

                sjekk = false;
                if (tallkode == 0) sjekk = true;

            }
            int Tallkode = Convert.ToInt32(tallkode);

            return Tallkode;
        }

        private void frmRegistering_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            frmInnlogging.instance.Show();
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
