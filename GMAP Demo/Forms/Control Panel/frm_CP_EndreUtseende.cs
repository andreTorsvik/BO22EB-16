using System;
using System.Reflection;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class Frm_CP_EndeUtseende : Form
    {
        public static frm_CP_EndeUtseende instance;
        public frm_CP_EndeUtseende()
        {
            InitializeComponent();
            instance = this;
            SetTheme();
        }

        private void SetTheme()
        {
            this.BackColor = ThemeDesign.colorBackground;

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
            https://docs.microsoft.com/en-us/dotnet/api/system.reflection.methodbase.invoke?view=net-6.0
            mInfos[lbThemes.SelectedIndex].Invoke(null, null);

            //skriver til fil for å lagre 
            FilBehandeling.LagreTheme(Globalekonstanter.filTheme, lbThemes.SelectedItem.ToString());

            //Setter theme på de instance som er oppe
            if (frmControlPanel.instance != null)
            {
                frmControlPanel.instance.SetTheme();

                //endre fargen på knappen til formen 
                frmControlPanel.instance.OppdaterThemeKnapp();
            }      
            if (frmInnlogging.instance != null)
                frmInnlogging.instance.SetTheme();

            SetTheme();

            //endre standerfarge 
            Globalekonstanter.knapp_trykket = ThemeDesign.colorSecondaryGroupedBackground;
            Globalekonstanter.StandarFargeKnapp = ThemeDesign.colorSecondaryBackground;

            //endre Theme på visning, Åpner nå filter uavhengiv va som var der før
            //for å endre theme 
            frmVisning.instance.ByttetTheme();
        }
    }
}
