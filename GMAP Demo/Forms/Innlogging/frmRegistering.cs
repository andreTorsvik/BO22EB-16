using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.Close();
            frmInnlogging frmInnlogg = new frmInnlogging(); // instance
            frmInnlogg.Size = this.Size;
            frmInnlogg.Location = this.Location;
            frmInnlogg.Show();
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
            else if (string.IsNullOrWhiteSpace(txtEtternavn.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Etternavn";
            }
            else if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Telefonnummer";
            }
            else if (string.IsNullOrWhiteSpace(txtEpost.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Epost";
            }
            else if (string.IsNullOrWhiteSpace(txtPassord.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " Passord";
            }
            else if (string.IsNullOrWhiteSpace(txtBePassord.Text))
            {
                altUtfylt = false;
                utFyllingsmangler += " bekrefte passord";
            }

            if (altUtfylt)
            {
                bool sjekkInnhold = false;

                //alle sjekkenede  
                if(txtPassord.Text == txtBePassord.Text) sjekkInnhold = true;
                else MessageBox.Show("Passord samsvarer ikke");

                if (sjekkInnhold)
                {
                    //sjekk at ingen har samme epost

                    //generer tall 
                    double tallkode = GenereTallKode();

                    //Legg til i database
                    try
                    {
                        //legge til i database
                        opprettet = true;
                    }
                    catch (Exception) { }
                }     
            }
            else MessageBox.Show(utFyllingsmangler);

            //om sjekk ok
            if (opprettet)
            {
                MessageBox.Show("Bruker er nå opprett, og venter for å bli godkjent av en admin. Hvis den blir godkjent " +
                    "vil du motta en mail med en kode.");

                this.Close();
                frmInnlogging frmInnlogg = new frmInnlogging();
                frmInnlogg.Size = this.Size;
                frmInnlogg.Location = this.Location;
                frmInnlogg.Show(); 
            }
        }

        private double GenereTallKode()
        {
            double tallkode = 0;
            Random r = new Random();

            for (int i = 0; i < 7; i++)
            {
                tallkode += r.Next(9) * Math.Pow(10, Convert.ToDouble(i));
            }
            if (tallkode == 0) return -1;

            return tallkode;
        }

        private void frmRegistering_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
