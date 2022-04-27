using System;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class frmRegistering : Form
    {
        public frmRegistering()
        {
            InitializeComponent();
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
            string fornavn = txtFornavn.Text;
            string etternavn = txtEtternavn.Text;
            string telefon = txtTelefon.Text;
            string Epost = txtEpost.Text.ToLower();
            string passord = txtPassord.Text;
            string bePassord = txtBePassord.Text;

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
