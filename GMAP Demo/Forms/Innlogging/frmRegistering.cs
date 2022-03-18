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
            //kode for sjekk at alle felten er utfylt
            if (string.IsNullOrWhiteSpace(txtFornavn.Text)) altUtfylt=false;
            else if(string.IsNullOrWhiteSpace(txtEtternavn.Text)) altUtfylt = false;
            else if (string.IsNullOrWhiteSpace(txtTelefon.Text)) altUtfylt = false;
            else if (string.IsNullOrWhiteSpace(txtEpost.Text)) altUtfylt = false;
            else if (string.IsNullOrWhiteSpace(txtPassord.Text)) altUtfylt = false;
            else if (string.IsNullOrWhiteSpace(txtBePassord.Text)) altUtfylt = false;

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

                        opprettet = true;
                    }
                    catch (Exception) { }
                }     
            }
            else MessageBox.Show("Fyll ut alle feltene");

            //om sjekk ok
            if (opprettet)
            {
                MessageBox.Show("Bruker er nå opprett, og venter for å bli godkjent av en admin. hvis den blir godkjent " +
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
    }
}
