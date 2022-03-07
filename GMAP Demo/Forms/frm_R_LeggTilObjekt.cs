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
    public partial class frm_R_LeggTilObjekt : Form
    {
        public static frm_R_LeggTilObjekt instance;
        public frm_R_LeggTilObjekt()
        {
            InitializeComponent();
            instance = this;
        }

        private void frm_R_LeggTilObjekt_Load(object sender, EventArgs e)
        {

        }

        private void btnLeggTilOverlay_Click(object sender, EventArgs e)
        {

        }

        private void btnLeggTilObjekt_Click(object sender, EventArgs e)
        {
            DatabaseCommunication db = new DatabaseCommunication();

            db.InsertRessursToDb(txtNavn.Text.ToString(), "termometer", "ola.nordman@stud.hvl.no", Convert.ToInt32(txtSikkerhetsklarering.Text), txtKommentar.Text.ToString(), Convert.ToSingle(txtLat.Text), Convert.ToSingle(txtLong.Text));

            txtNavn.Text = "";
            txtKommentar.Text = "";
            txtSikkerhetsklarering.Text = "";
            txtLat.Text = "";
            txtLong.Text = "";

        }
    }
}
