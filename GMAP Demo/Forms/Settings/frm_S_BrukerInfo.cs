using GMAP_Demo.Database.DataTypes;
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
    public partial class frm_S_BrukerInfo : Form
    {
        public frm_S_BrukerInfo()
        {
            InitializeComponent();
            DatabaseCommunication db = new DatabaseCommunication();
            List<Bruker> listBruker = new List<Bruker>();
            listBruker = (db.ListBrukerInfoFromDb(InnloggetBruker.BrukernavnInnlogget.ToString()));

            tbFornavn.Text = listBruker[0].Fornavn.ToString();
            tbEtternavn.Text = listBruker[0].Etternavn.ToString();
            tbTelefonnummer.Text = listBruker[0].Telefonnummer.ToString();
            tbEpost.Text = listBruker[0].Epost.ToString();
            tbSikkerhetsklarering.Text = listBruker[0].Sikkerhetsklarering.ToString();
        }
    }
}
