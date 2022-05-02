using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class frm_CP_EndeUtseende : Form
    {
        frm_CP_EndeUtseende instance;
        public frm_CP_EndeUtseende()
        {
            InitializeComponent();
            instance = this;
            SetTheme();
        }

        private void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;

            lblTitle.ForeColor = ThemeDesign.colorPurple;

            lbThemes.ForeColor = ThemeDesign.colorLabel;
            lbThemes.BackColor = ThemeDesign.colorGray;
            btnSelectTheme.ForeColor = ThemeDesign.colorLabel;
            btnSelectTheme.BackColor = ThemeDesign.colorGray;
        }

        //https://www.naveedulhaq.com/index.php/dot-net-core/get-the-list-of-method-names-from-the-c-class/
        private void frm_CP_EndeUtseende_Load(object sender, EventArgs e)
        {
            MethodInfo[] mInfos = typeof(ThemeDesign).GetMethods(BindingFlags.Public |BindingFlags.Static);

            foreach (MethodInfo mi in mInfos)
            {
                lbThemes.Items.Add(mi.Name);
            }
        }

        private void btnSelectTheme_Click(object sender, EventArgs e)
        {
            lbThemes.SelectedItem.
        }
    }
}
