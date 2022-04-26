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
            lableSlettet.Text = "";
        }

        private void frm_R_FjernObjektOmråde_Load(object sender, EventArgs e)
        {

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
                    string caption = "Sletting";
                    string tekst = string.Format("Vil du slette ressurs: {0} ", Løpenummer_til_objekt);
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(tekst, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        DBComRessurs.DeleteRessurs(Løpenummer_til_objekt);
                        lableSlettet.Text = String.Format("Ressurs nr: {0} er slettet", Løpenummer_til_objekt);
                        Løpenummer_til_objekt = -1;
                        TømInnholdTekstboks();
                        //Må oppdtaere listene og kart
                        Kart.OppdaterTag_Liste();
                        Kart.OppdaterListe_ressurs();
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
                    string caption = "Sletting";
                    string tekst = string.Format("Vil du slette Område: {0} ", Løpenummer_til_Område);
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    // Displays the MessageBox.
                    result = MessageBox.Show(tekst, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        DBComPunkter_område.DeletePunkter_området(Løpenummer_til_Område);
                        DBComOmråde.DeleteOmråde(Løpenummer_til_Område);
                        lableSlettet.Text = String.Format("Område nr: {0} er slettet", Løpenummer_til_Område);
                        Løpenummer_til_Område = -1;
                        TømInnholdTekstboks();
                        //Må oppdtaere listene og kart 
                        Kart.OppdaterTag_Liste();
                        Kart.OppdaterListe_området();
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
