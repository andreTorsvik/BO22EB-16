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
    public partial class frm_S_LoggUt : Form
    {
        public frm_S_LoggUt()
        {
            InitializeComponent();
        }

        private void btnLoggUt_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
