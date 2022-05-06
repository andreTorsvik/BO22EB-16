using System;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class Frm_R_FjernObjektOmråde : Form
    {
        public int Løpenummer_til_objekt;
        public int Løpenummer_til_Område;

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
            Løpenummer_til_objekt = GlobaleLister.listObjekt[Tag].IdObjekt;
            txtInfo.Text = GlobaleLister.listObjekt[Tag].ToString();
            txtIdOmråde.Text = GlobaleLister.listObjekt[Tag].IdObjekt.ToString();
            txtNavn.Text = GlobaleLister.listObjekt[Tag].Navn;

            if (Løpenummer_til_Område >= 0) Løpenummer_til_Område = -1;
        }

        public void FyllInfoOmråde(int Tag)
        {
            Løpenummer_til_Område = GlobaleLister.LOmråde[Tag].IdOmråde;
            txtInfo.Text = GlobaleLister.LOmråde[Tag].ToString();
            txtIdOmråde.Text = GlobaleLister.LOmråde[Tag].IdOmråde.ToString();
            txtNavn.Text = GlobaleLister.LOmråde[Tag].Navn;

            if (Løpenummer_til_objekt >= 0) Løpenummer_til_objekt = -1;
        }

        private void BtnFjern_Click(object sender, EventArgs e)
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
                        DBComObjekt.DeleteObjekt(Løpenummer_til_objekt);
                        lblSlettet.Text = String.Format("Ressurs nr: {0} er slettet", Løpenummer_til_objekt);
                        Løpenummer_til_objekt = -1;
                        TømInnholdTekstboks();
                        //Må oppdtaere listene og kart
                        FellesMetoder.OppdaterTag_Liste();
                        FellesMetoder.OppdaterKategoriListe();
                        FellesMetoder.OppdaterListe_Objekt();
                        Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.listObjekt, GlobaleLister.LOmråde);
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
                        Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.listObjekt, GlobaleLister.LOmråde);
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
            txtIdOmråde.Text = "";
            txtNavn.Text = "";
        }

        private void Frm_R_FjernObjektOmråde_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }
    }
}
