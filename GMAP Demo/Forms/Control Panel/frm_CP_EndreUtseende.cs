using System;
using System.Reflection;
using System.Windows.Forms;
using System.ComponentModel;
using System.Net;


namespace GMAP_Demo
{
    public partial class Frm_CP_EndreUtseende : Form
    {
        public static Frm_CP_EndreUtseende instance;
        
        public Frm_CP_EndreUtseende()
        {
            InitializeComponent();
            instance = this;
            SetTheme();
        }

        private void SetTheme()
        {
            BackColor = ThemeDesign.colorBackground;

            lblTitle.ForeColor = ThemeDesign.colorPurple;

            lbThemes.ForeColor = ThemeDesign.colorLabel;
            lbThemes.BackColor = ThemeDesign.colorGray;
            btnSelectTheme.ForeColor = ThemeDesign.colorLabel;
            btnSelectTheme.BackColor = ThemeDesign.colorGray;
        }

        //https://www.naveedulhaq.com/index.php/dot-net-core/get-the-list-of-method-names-from-the-c-class/
        MethodInfo[] mInfos = typeof(ThemeDesign).GetMethods(BindingFlags.Public | BindingFlags.Static);
        private void Frm_CP_EndeUtseende_Load(object sender, EventArgs e)
        {
            lbThemes.DataSource = mInfos;
            lbThemes.DisplayMember = "Name";
        }

        private void BtnSelectTheme_Click(object sender, EventArgs e)
        {
            https://docs.microsoft.com/en-us/dotnet/api/system.reflection.methodbase.invoke?view=net-6.0
            //invoke den aktuelle metoden 
            mInfos[lbThemes.SelectedIndex].Invoke(null, null);

            //skriver til fil for å lagre 
            FilBehandeling.LagreTheme(Globalekonstanter.filTheme, lbThemes.SelectedItem.ToString());

            //Setter theme på de instance som er oppe
            if (FrmControlPanel.instance != null)
            {
                FrmControlPanel.instance.SetTheme();

                //endre fargen på knappen til formen 
                FrmControlPanel.instance.OppdaterThemeKnapp();
            }      
            if (FrmInnlogging.instance != null)
                FrmInnlogging.instance.SetTheme();

            SetTheme();

            //endre standerfarge 
            Globalekonstanter.knapp_trykket = ThemeDesign.colorSecondaryGroupedBackground;
            Globalekonstanter.StandardFargeKnapp = ThemeDesign.colorSecondaryBackground;

            //endre Theme på visning, Åpner nå filter uavhengiv va som var der før
            //for å endre theme 
            frmVisning.instance.ByttetTheme();
        }
    }
}
