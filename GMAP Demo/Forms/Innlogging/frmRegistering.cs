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
            bool altUtfylt = true;
            bool opprettet = false;
            string utFyllingsmangler = "Du mangler:";
            //kode for sjekk at alle felten er utfylt
            if (string.IsNullOrWhiteSpace(txtFornavn.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Fornavn";
            }
            if (string.IsNullOrWhiteSpace(txtEtternavn.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Etternavn";
            }
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Telefonnummer";
            }
            if (string.IsNullOrWhiteSpace(txtEpost.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Epost";
            }
            if (string.IsNullOrWhiteSpace(txtPassord.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Passord";
            }
            if (string.IsNullOrWhiteSpace(txtBePassord.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " bekrefte passord";
            }

            if (altUtfylt)
            {
                bool sjekkInnhold = true;
                string feil = null;
                //alle sjekkenede  
                if (!(txtPassord.Text == txtBePassord.Text))
                {
                    sjekkInnhold = false;
                    feil += "Passord samsvarer ikke";
                }

                //En enkel epost adresse sjekk 
                if (!((txtEpost.Text.Contains(".com") || txtEpost.Text.Contains(".no") || txtEpost.Text.Contains(".net"))
                    && txtEpost.Text.Contains("@")))
                {
                    sjekkInnhold = false;
                    if (feil == null) feil = "Du har ikke oppgitt en mail adresse";
                    else feil += ", og du har ikke oppgitt en mail adresse";
                }

                if (feil != null) MessageBox.Show(feil);


                if (sjekkInnhold)
                {
                    //sjekk at ingen har samme epost
                    var SjekkEpost = DatabaseCommunication.ListBrukerInfoFromDb(txtEpost.Text.Trim());
                    if (SjekkEpost.Count == 0)
                    {
                        try
                        {
                            //Generer tall 
                            int Tallkode = GenereTallKode();
                            //legge til i database
                            DatabaseCommunication.InsertBrukerToDb(txtFornavn.Text.ToString(), txtEtternavn.Text.ToString(), Convert.ToInt32(txtTelefon.Text), txtEpost.Text.ToString().Trim(), txtPassord.Text.ToString(), Tallkode);

                            opprettet = true;
                        }
                        catch (Exception) { }
                    }
                    else
                    {
                        MessageBox.Show("Mailen eksitere allerede i systemet");
                    }
                }
            }
            else MessageBox.Show(utFyllingsmangler);

            //om bruker er oprrettet 
            if (opprettet)
            {
                MessageBox.Show("Bruker er nå opprett, og venter for å bli godkjent av en admin. Hvis den blir godkjent " +
                    "vil du motta en mail med en kode.");

                this.Close();
            }
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
