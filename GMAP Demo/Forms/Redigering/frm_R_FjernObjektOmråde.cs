using System;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class frm_R_FjernObjektOmråde : Form
    {
        public int Løpenummer_til_objekt;
        public int Løpenummer_til_Område;

        public static frm_R_FjernObjektOmråde instance;
        public frm_R_FjernObjektOmråde()
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
            lblLøpenummer.ForeColor = ThemeDesign.colorLabel;
            lblNavn.ForeColor = ThemeDesign.colorLabel;
            lblInfo.ForeColor = ThemeDesign.colorLabel;
            txtLøpenumemr.ForeColor = ThemeDesign.colorLabel;
            txtLøpenumemr.BackColor = ThemeDesign.colorGray;
            txtNavn.ForeColor = ThemeDesign.colorLabel;
            txtNavn.BackColor = ThemeDesign.colorGray;
            txtInfo.ForeColor = ThemeDesign.colorLabel;
            txtInfo.BackColor = ThemeDesign.colorGray;

            btnFjern.ForeColor = ThemeDesign.colorLabel;
            btnFjern.BackColor = ThemeDesign.colorGray;
            lblSlettet.ForeColor = ThemeDesign.colorLabel;
        }

        public void fyllInfoObjekt(int Tag)
        {
            Løpenummer_til_objekt = GlobaleLister.LRessurs[Tag].Løpenummer_ressurs;
            txtInfo.Text = GlobaleLister.LRessurs[Tag].ToString();
            txtLøpenumemr.Text = GlobaleLister.LRessurs[Tag].Løpenummer_ressurs.ToString();
            txtNavn.Text = GlobaleLister.LRessurs[Tag].Navn;

            if (Løpenummer_til_Område >= 0) Løpenummer_til_Område = -1;
        }

        public void fyllInfoOmråde(int Tag)
        {
            Løpenummer_til_Område = GlobaleLister.LOmråde[Tag].Løpenummer_område;
            txtInfo.Text = GlobaleLister.LOmråde[Tag].ToString();
            txtLøpenumemr.Text = GlobaleLister.LOmråde[Tag].Løpenummer_område.ToString();
            txtNavn.Text = GlobaleLister.LOmråde[Tag].Navn;

            if (Løpenummer_til_objekt >= 0) Løpenummer_til_objekt = -1;
        }

        private void btnFjern_Click(object sender, EventArgs e)
        {
            if (Løpenummer_til_Område == -1 && Løpenummer_til_objekt != -1) // sletting av ressurs 
            {
                try
                {
                    string Tittel = "Sletting";
                    string tekst = string.Format("Vil du slette ressurs: {0} ", Løpenummer_til_objekt);
                    bool Fjern = FellesMetoder.MeldingsboksYesNo(Tittel, tekst);

                    if (Fjern)
                    {
                        DBComRessurs.DeleteRessurs(Løpenummer_til_objekt);
                        lblSlettet.Text = String.Format("Ressurs nr: {0} er slettet", Løpenummer_til_objekt);
                        Løpenummer_til_objekt = -1;
                        TømInnholdTekstboks();
                        //Må oppdtaere listene og kart
                        FellesMetoder.OppdaterTag_Liste();
                        FellesMetoder.OppdaterKategoriListe();
                        FellesMetoder.OppdaterListe_ressurs();
                        Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
                    }

                }
                catch (Exception feil)
                {
                    MessageBox.Show(String.Format("Noe galt skjedde: {0}", feil.Message));
                }
            }
            else if (Løpenummer_til_objekt == -1 && Løpenummer_til_Område != -1) // sletting av Område
            {
                try
                {
                    string Tittel = "Sletting";
                    string tekst = string.Format("Vil du slette Område: {0} ", Løpenummer_til_Område);

                    bool fjern = FellesMetoder.MeldingsboksYesNo(Tittel, tekst);

                    if (fjern)
                    {
                        DBComPunkter_område.DeletePunkter_området(Løpenummer_til_Område);
                        DBComOmråde.DeleteOmråde(Løpenummer_til_Område);
                        lblSlettet.Text = String.Format("Område nr: {0} er slettet", Løpenummer_til_Område);
                        Løpenummer_til_Område = -1;
                        TømInnholdTekstboks();
                        //Må oppdtaere listene og kart 
                        FellesMetoder.OppdaterTag_Liste();
                        FellesMetoder.OppdaterListe_området();
                        Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
                    }
                }
                catch (Exception feil)
                {
                    MessageBox.Show(String.Format("Noe galt skjedde: {0}", feil.Message));
                }


            }
        }

        public void TømInnholdTekstboks()
        {
            txtInfo.Text = "";
            txtLøpenumemr.Text = "";
            txtNavn.Text = "";
        }

    }
}
