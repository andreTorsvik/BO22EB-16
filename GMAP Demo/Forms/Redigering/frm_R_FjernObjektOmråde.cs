using System;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class Frm_R_FjernObjektOmråde : Form
    {
        public int Id_til_objekt;
        public int Id_til_Område;

        public static Frm_R_FjernObjektOmråde instance;
        public Frm_R_FjernObjektOmråde()
        {
            InitializeComponent();
            instance = this;
            lblSlettet.Text = "";
            SetTheme();
        }

        private void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;

            lblTitle.ForeColor = ThemeDesign.colorOrange;

            gbObjekt.ForeColor = ThemeDesign.colorLabel;
            gbObjekt.BackColor = ThemeDesign.colorBackground;
            lblKlikkPåObjektet.ForeColor = ThemeDesign.colorLabel;
            lblIdOmråde.ForeColor = ThemeDesign.colorLabel;
            lblNavn.ForeColor = ThemeDesign.colorLabel;
            lblInfo.ForeColor = ThemeDesign.colorLabel;
            txtIdOmråde.ForeColor = ThemeDesign.colorLabel;
            txtIdOmråde.BackColor = ThemeDesign.colorGray;
            txtNavn.ForeColor = ThemeDesign.colorLabel;
            txtNavn.BackColor = ThemeDesign.colorGray;
            txtInfo.ForeColor = ThemeDesign.colorLabel;
            txtInfo.BackColor = ThemeDesign.colorGray;

            btnFjern.ForeColor = ThemeDesign.colorLabel;
            btnFjern.BackColor = ThemeDesign.colorGray;
            lblSlettet.ForeColor = ThemeDesign.colorLabel;
        }

        public void FyllInfoObjekt(int Tag)
        {

            Id_til_objekt = GlobaleLister.LObjekt[Tag].IdObjekt;
           
            txtIdOmråde.Text = GlobaleLister.LObjekt[Tag].IdObjekt.ToString();
            txtNavn.Text = GlobaleLister.LObjekt[Tag].Navn;
            string newLine = Environment.NewLine;
            txtInfo.Text = "Objekt: "+ newLine + GlobaleLister.LObjekt[Tag].ToString();

            if (Id_til_Område >= 0) Id_til_Område = -1;
        }

        public void FyllInfoOmråde(int Tag)
        {
            Id_til_Område = GlobaleLister.LOmråde[Tag].IdOmråde;
            
            txtIdOmråde.Text = GlobaleLister.LOmråde[Tag].IdOmråde.ToString();
            txtNavn.Text = GlobaleLister.LOmråde[Tag].Navn;
            string newLine = Environment.NewLine;
            txtInfo.Text = "Område: "+ newLine + GlobaleLister.LOmråde[Tag].ToString();

            if (Id_til_objekt >= 0) Id_til_objekt = -1;
        }

        private void BtnFjern_Click(object sender, EventArgs e)
        {
            if (Id_til_Område == -1 && Id_til_objekt != -1) // Sletting av objekt 
            {
                try
                {
                    string Tittel = "Sletting";
                    string tekst = string.Format("Vil du slette objekt: {0} ", Id_til_objekt);
                    bool Fjern = Tekstbehandling.MeldingsboksYesNo(Tittel, tekst);

                    if (Fjern)
                    {
                        DBComObjekt.DeleteObjekt(Id_til_objekt);
                        lblSlettet.Text = String.Format("Objekt nr: {0} er slettet", Id_til_objekt);
                        Id_til_objekt = -1;
                        TømInnholdTekstboks();

                        //Må oppdtaere listene og kart
                        GlobaleLister.OppdaterTag_Liste();
                        GlobaleLister.OppdaterKategoriListe();
                        GlobaleLister.OppdaterListe_Objekt();
                        Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
                    }

                }
                catch (Exception feilmelding)
                {
                    DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                    MessageBox.Show(String.Format("Noe galt skjedde: {0}", feilmelding.Message));
                }
            }
            else if (Id_til_objekt == -1 && Id_til_Område != -1) // Sletting av Område
            {
                try
                {
                    string Tittel = "Sletting";
                    string tekst = string.Format("Vil du slette Område: {0} ", Id_til_Område);

                    bool fjern = Tekstbehandling.MeldingsboksYesNo(Tittel, tekst);

                    if (fjern)
                    {
                        DBComPunkter_område.DeletePunkter_området(Id_til_Område);
                        DBComOmråde.DeleteOmråde(Id_til_Område);
                        lblSlettet.Text = String.Format("Område nr: {0} er slettet", Id_til_Område);

                        
                        Id_til_Område = -1;
                        TømInnholdTekstboks();

                        //Må oppdtaere listene og kart 
                        GlobaleLister.OppdaterTag_Liste();
                        GlobaleLister.OppdaterListe_området();
                        Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
                    }
                }
                catch (Exception feilmelding)
                {
                    DBComLog_feil.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                    MessageBox.Show(String.Format("Noe galt skjedde: {0}", feilmelding.Message));
                }
            }
            else
            {
                MessageBox.Show("Ingen er valgt");
            }
        }

        public void TømInnholdTekstboks()
        {
            txtInfo.Text = "";
            txtIdOmråde.Text = "";
            txtNavn.Text = "";
        }

        private void Frm_R_FjernObjektOmråde_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }
    }
}
