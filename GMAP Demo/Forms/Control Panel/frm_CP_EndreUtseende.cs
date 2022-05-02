using System;
using System.Reflection;
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
        MethodInfo[] mInfos = typeof(ThemeDesign).GetMethods(BindingFlags.Public | BindingFlags.Static);
        private void frm_CP_EndeUtseende_Load(object sender, EventArgs e)
        {
            lbThemes.DataSource = mInfos;
            lbThemes.DisplayMember = "Name";
        }

        private void btnSelectTheme_Click(object sender, EventArgs e)
        {
            object p = mInfos[lbThemes.SelectedIndex].Invoke(null, null);

            FilBehandeling.LagreTheme(Globalekonstanter.filTheme, lbThemes.SelectedItem.ToString());

            frmControlPanel.instance.SetTheme();
            frmInnlogging.instance.SetTheme();
            
            //endre standerfarge 
            Globalekonstanter.knapp_trykket = ThemeDesign.colorSecondaryGroupedBackground; 
            Globalekonstanter.StandarFargeKnapp = ThemeDesign.colorSecondaryBackground;

            //endre fargen på knappen til formen 
            frmControlPanel.instance.OppdaterThemeKnapp();

            //endre Theme på visning, må derfor åpne den på nytt 
            //her feilen ligger 
            frmVisning.instance.startup();

            instance.SetTheme();

        }
    }
}
