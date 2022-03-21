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
    public partial class frmVertifiseringskode : Form
    {
        public static frmVertifiseringskode instance;
        public frmVertifiseringskode()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnVertifiser_Click(object sender, EventArgs e)
        {
            if(txtKode.Text == frmInnlogging.instance.)
            {
                //Endre database attributt bruker.godkjent = true


                //logg inn




            }
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
