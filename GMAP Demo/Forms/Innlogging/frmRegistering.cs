using System;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class FrmRegistering : Form
    {
        public static FrmRegistering instance;
        public FrmRegistering()
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

        private void BtnAvbryt_Click(object sender, EventArgs e)
        {
            FrmInnlogging.instance.Location = Location;
            Close();

        }

        private void BtnOpprettbruker_Click(object sender, EventArgs e)
        {
            bool opprettet = OpprettBruker();

            if (opprettet)
            {
                MessageBox.Show("Bruker er nå opprett, vent på å bli godkjent av en administrator." +
                                "Hvis den blir godkjent mottar du en mail med en tallkode.");

                Close();
            }
        }

        private bool OpprettBruker()
        {
            bool svar = false;

            string fornavn = tbFornavn.Text;
            string etternavn = tbEtternavn.Text;
            string telefon = tbTelefonnummer.Text;
            string epost = tbEpost.Text.ToLower();
            string passord = tbPassord.Text;
            string bekreftPassord = tbBekreftPassord.Text;

            string utfyllingMangler = Tekstbehandling.AltUtfylt_Registerings(fornavn, etternavn, telefon, epost, passord, bekreftPassord);

            if (utfyllingMangler == string.Empty)
            {
                string feil = Tekstbehandling.SjekkGyldigDataRegistering(epost, passord, bekreftPassord);

                if (feil == string.Empty)
                {
                    try
                    {
                        //Generer tall 
                        int Tallkode = GenererTallKode();
                        //legge til i database
                        DBComBruker.InsertBrukerToDb(fornavn, etternavn, Convert.ToInt32(telefon), epost.Trim(), passord, Tallkode);

                        svar = true;
                    }
                    catch (Exception) { }

                }
                else MessageBox.Show(feil);
            }
            else MessageBox.Show(utfyllingMangler);

            return svar;
        }

        private int GenererTallKode()
        {
            double tallkode = 0;
            Random r = new Random();
            bool sjekk = true;
            while (sjekk)
            {
                for (int i = 0; i < Globalekonstanter.AntallSiffer; i++)
                {
                    tallkode += r.Next(9) * Math.Pow(10, Convert.ToDouble(i));

                }

                sjekk = false;
                if (tallkode == 0) sjekk = true;

            }
            int Tallkode = Convert.ToInt32(tallkode);

            return Tallkode;
        }

        private void FrmRegistering_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            FrmInnlogging.instance.Show();
        }

        private void TxtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
