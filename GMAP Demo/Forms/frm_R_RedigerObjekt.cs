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
    public partial class frm_R_RedigerObjekt : Form
    {
        public static frm_R_RedigerObjekt instance;
        public frm_R_RedigerObjekt()
        {
            InitializeComponent();
            instance = this;
        }

        private void frm_R_RedigerObjektOmråde_Load(object sender, EventArgs e)
        {

        }
    }
}
