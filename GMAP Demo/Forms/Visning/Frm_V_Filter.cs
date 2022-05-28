using GMap.NET;
using System;
using System.Windows.Forms;
using System.Threading;

namespace GMAP_Demo
{

    public partial class Frm_V_Filter : Form
    {
        public static Frm_V_Filter instance;
        public int indexRessurs = 0;
        

        // For timing til simulering av målinger:
        static bool målingRunning = false;
        public static System.Threading.Timer timer = new System.Threading.Timer(MålingSim.TimerProc);

        public Frm_V_Filter()
        {
            InitializeComponent();
            instance = this;

            lbKategorierVises.DataSource = GlobaleLister.kategoriListeVises;
            lbKategorierVises.DisplayMember = "Kategorinavn";
            lbKategorierSkjult.DataSource = GlobaleLister.kategoriListeSkjult;
            lbKategorierSkjult.DisplayMember = "Kategorinavn";
            lbTagsVises.DataSource = GlobaleLister.tag_ListeVises;
            lbTagsVises.DisplayMember = "Tag";
            lbTagsSkjult.DataSource = GlobaleLister.tag_ListeSkjult;
            lbTagsSkjult.DisplayMember = "Tag";
            SetTheme();

            // For å vise riktig verdig i formen, når man åpner den
            cbViseOmråde.Checked = !Kart.VisOmrådePåKart;
        }

        private void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;
            
            lblTitle.ForeColor = ThemeDesign.colorBlue;

            gbFilter.ForeColor = ThemeDesign.colorLabel;
            gbFilter.BackColor = ThemeDesign.colorBackground;
            lblKategorierSkjult.ForeColor = ThemeDesign.colorLabel;
            lblKategorierVises.ForeColor = ThemeDesign.colorLabel;
            lblTagsSkjult.ForeColor = ThemeDesign.colorLabel;
            lblTagsVises.ForeColor = ThemeDesign.colorLabel;
            lbKategorierSkjult.ForeColor = ThemeDesign.colorLabel;
            lbKategorierSkjult.BackColor = ThemeDesign.colorGray;
            lbKategorierVises.ForeColor = ThemeDesign.colorLabel;
            lbKategorierVises.BackColor = ThemeDesign.colorGray;
            lbTagsSkjult.ForeColor = ThemeDesign.colorLabel;
            lbTagsSkjult.BackColor = ThemeDesign.colorGray;
            lbTagsVises.ForeColor = ThemeDesign.colorLabel;
            lbTagsVises.BackColor = ThemeDesign.colorGray;
            btnKategoriLeggTilAlle.ForeColor = ThemeDesign.colorLabel;
            btnKategoriLeggTilAlle.BackColor = ThemeDesign.colorGray;
            btnKategoriFjernAlle.ForeColor = ThemeDesign.colorLabel;
            btnKategoriFjernAlle.BackColor = ThemeDesign.colorGray;
            btnTagLeggTilAlle.ForeColor = ThemeDesign.colorLabel;
            btnTagLeggTilAlle.BackColor = ThemeDesign.colorGray;
            btnTagFjernAlle.ForeColor = ThemeDesign.colorLabel;
            btnTagFjernAlle.BackColor = ThemeDesign.colorGray;
            cbViseOmråde.ForeColor = ThemeDesign.colorLabel;
            cbOR.ForeColor = ThemeDesign.colorLabel;
            cbAND.ForeColor = ThemeDesign.colorLabel;

            gbObjekt.ForeColor = ThemeDesign.colorLabel;
            gbObjekt.BackColor = ThemeDesign.colorBackground;
            lblHoppTilEtOmråde.ForeColor = ThemeDesign.colorLabel;
            lblObjektAntall.ForeColor = ThemeDesign.colorLabel;
            btnForrigeObjekt.ForeColor = ThemeDesign.colorLabel;
            btnForrigeObjekt.BackColor = ThemeDesign.colorGray;
            btnNesteObjekt.ForeColor = ThemeDesign.colorLabel;
            btnNesteObjekt.BackColor = ThemeDesign.colorGray;

            tbAntallObjekter.ForeColor = ThemeDesign.colorLabel;
            tbAntallObjekter.BackColor = ThemeDesign.colorGray;

            gbInfo.ForeColor = ThemeDesign.colorLabel;
            gbInfo.BackColor = ThemeDesign.colorBackground;
            lblNavn.ForeColor = ThemeDesign.colorLabel;
            lblKategori.ForeColor = ThemeDesign.colorLabel;
            lbMålingDato.ForeColor = ThemeDesign.colorLabel;
            lblMåling.ForeColor = ThemeDesign.colorLabel;
            lblEnhetMåling.ForeColor = ThemeDesign.colorLabel;
            lblDato_opprettet.ForeColor = ThemeDesign.colorLabel;
            lblOpprettetAvBruker.ForeColor = ThemeDesign.colorLabel;
            lblSikkerhetsklarering.ForeColor = ThemeDesign.colorLabel;
            lblKommentar.ForeColor = ThemeDesign.colorLabel;
            lblTag.ForeColor = ThemeDesign.colorLabel;
            tbNavn.ForeColor = ThemeDesign.colorLabel;
            tbNavn.BackColor = ThemeDesign.colorGray4;
            tbKategori.ForeColor = ThemeDesign.colorLabel;
            tbKategori.BackColor = ThemeDesign.colorGray4;
            tbMålingDato.ForeColor = ThemeDesign.colorLabel;
            tbMålingDato.BackColor = ThemeDesign.colorGray4;
            tbMåling.ForeColor = ThemeDesign.colorLabel;
            tbMåling.BackColor = ThemeDesign.colorGray4;
            tbEnhetMåling.ForeColor = ThemeDesign.colorLabel;
            tbEnhetMåling.BackColor = ThemeDesign.colorGray4;
            tbDato_opprettet.ForeColor = ThemeDesign.colorLabel;
            tbDato_opprettet.BackColor = ThemeDesign.colorGray4;
            tbOpprettetAvBruker.ForeColor = ThemeDesign.colorLabel;
            tbOpprettetAvBruker.BackColor = ThemeDesign.colorGray4;
            tbSikkerhetsklarering.ForeColor = ThemeDesign.colorLabel;
            tbSikkerhetsklarering.BackColor = ThemeDesign.colorGray4;
            tbKommentar.ForeColor = ThemeDesign.colorLabel;
            tbKommentar.BackColor = ThemeDesign.colorGray4;
            lbTags.ForeColor = ThemeDesign.colorLabel;
            lbTags.BackColor = ThemeDesign.colorGray4;

            btnTimerMåling.ForeColor = ThemeDesign.colorLabel;
            btnTimerMåling.BackColor = ThemeDesign.colorGray;
        }

        private void FrmFilter_Load(object sender, EventArgs e)
        {
            GlobaleVariabler.filterOR = true;
            if(GlobaleLister.LObjekt.Count > 0) tbAntallObjekter.Text = GlobaleLister.LObjekt.Count.ToString();
        }

        private void LbKategorierVises_DoubleClick(object sender, EventArgs e)
        {
            if (lbKategorierVises.Items.Count > 0)
            {
                // Oppdatere begge listen basert på hva som er valgt 
                GlobaleLister.kategoriListeSkjult.Add((Kategorier_Bilde)lbKategorierVises.SelectedItem);
                GlobaleLister.kategoriListeVises.Remove((Kategorier_Bilde)lbKategorierVises.SelectedItem);

                // Oppdaterer ressurs liste 
                GlobaleLister.OppdaterListe_Objekt();

                // Oppdaterer kartet 
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
            }
        }

        private void LbKategorierSkjult_DoubleClick(object sender, EventArgs e)
        {
            if (lbKategorierSkjult.Items.Count > 0)
            {
                // Oppdatere begge listen basert på hva som er valgt 
                GlobaleLister.kategoriListeVises.Add((Kategorier_Bilde)lbKategorierSkjult.SelectedItem);
                GlobaleLister.kategoriListeSkjult.Remove((Kategorier_Bilde)lbKategorierSkjult.SelectedItem);

                // Oppdaterer ressurs liste
                GlobaleLister.OppdaterListe_Objekt();

                // Oppdaterer kartet 
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
            }
        }

        private void LbTagsVises_DoubleClick(object sender, EventArgs e)
        {
            if (lbTagsVises.Items.Count > 0)
            {
                // Oppdatere begge listen basert på hva som er valgt
                GlobaleLister.tag_ListeSkjult.Add((string)lbTagsVises.SelectedItem);
                GlobaleLister.tag_ListeVises.Remove((string)lbTagsVises.SelectedItem);

                // Oppdaterer begge liste
                GlobaleLister.OppdaterListe_Objekt();
                GlobaleLister.OppdaterListe_området();

                // Oppdaterer kartet 
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
            }
        }

        private void LbTagsSkjult_DoubleClick(object sender, EventArgs e)
        {
            if (lbTagsSkjult.Items.Count > 0)
            {
                // Oppdatere begge listen basert på hva som er valgt
                GlobaleLister.tag_ListeVises.Add((string)lbTagsSkjult.SelectedItem);
                GlobaleLister.tag_ListeSkjult.Remove((string)lbTagsSkjult.SelectedItem);

                // Oppdaterer begge liste
                GlobaleLister.OppdaterListe_Objekt();
                GlobaleLister.OppdaterListe_området();

                // Oppdaterer kartet
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
            }
        }

        private void CbViseOmråde_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViseOmråde.Checked) Kart.VisOmrådePåKart = false;
            else Kart.VisOmrådePåKart = true;

            Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
        }

        private void BtnNesteObjekt_Click(object sender, EventArgs e)
        {
            indexRessurs++;
            if (indexRessurs >= GlobaleLister.LObjekt.Count) indexRessurs = 0;

            // Fyller inn info om objektet i filter 
            FyllInfoObjekt(indexRessurs);

            // Flytter kartet til objektet  
            FlyttTilObjekt(indexRessurs);
        }

        private void BtnForrigeObjekt_Click(object sender, EventArgs e)
        {
            indexRessurs--;
            if (indexRessurs < 0) indexRessurs = GlobaleLister.LObjekt.Count - 1;
            else if (indexRessurs >= GlobaleLister.LObjekt.Count) indexRessurs = GlobaleLister.LObjekt.Count - 1;
            
            // Fyller inn info om objektet i filter 
            FyllInfoObjekt(indexRessurs);
           
            // Flytter kartet til objektet 
            FlyttTilObjekt(indexRessurs);
        }

        private void FlyttTilObjekt(int index)
        {
            if(GlobaleLister.LObjekt.Count > 0)
            {
                PointLatLng point = GlobaleLister.LObjekt[index].GiPunktet();

                FrmVisning.instance.map.Position = point;
            }         
        }

        public void FyllInfoObjekt(int Tag)
        {
            if(GlobaleLister.LObjekt.Count > 0)
            {
                // Info
                tbNavn.Text = GlobaleLister.LObjekt[Tag].Navn;
                tbKategori.Text = GlobaleLister.LObjekt[Tag].Kategori;
                tbDato_opprettet.Text = GlobaleLister.LObjekt[Tag].Dato_opprettet;
                tbOpprettetAvBruker.Text = GlobaleLister.LObjekt[Tag].Opprettet_av_bruker;
                tbSikkerhetsklarering.Text = GlobaleLister.LObjekt[Tag].Sikkerhetsklarering.ToString();
                tbKommentar.Text = GlobaleLister.LObjekt[Tag].Kommentar;

                // Tags
                if (lbTags.Items.Count > 0) lbTags.Items.Clear();

                var TagListeTilRessurs = GlobaleLister.LObjekt[Tag].hentTags();
                foreach (var tags in TagListeTilRessurs)
                {
                    lbTags.Items.Add(tags);
                }
                //måling
                Måling NyesteMåling = DBComMåling.GetLatestValueMålingFromSelectedObjekt(GlobaleLister.LObjekt[Tag].IdObjekt)[0];
                if(NyesteMåling != null)
                {                
                    tbMålingDato.Text = NyesteMåling.Dato;
                    tbEnhetMåling.Text = NyesteMåling.Enhet;

                    if (NyesteMåling.Dato == "Ingen måling")
                        tbMåling.Text = "Ingen måling";                                  
                    else
                        tbMåling.Text = NyesteMåling.Verdi.ToString();
                }
                
            }
            
        }

        public void FyllInfoOmråde(int Tag)
        {
            if (GlobaleLister.LOmråde.Count > 0)
            {
                // Info
                tbNavn.Text = GlobaleLister.LOmråde[Tag].Navn;
                tbKategori.Text = "";
                tbMåling.Text = "";
                tbMålingDato.Text = "";
                tbEnhetMåling.Text = "";
                tbDato_opprettet.Text = GlobaleLister.LOmråde[Tag].Dato_opprettet;
                tbOpprettetAvBruker.Text = GlobaleLister.LOmråde[Tag].Opprettet_av_bruker;
                tbSikkerhetsklarering.Text = GlobaleLister.LOmråde[Tag].Sikkerhetsklarering.ToString();
                tbKommentar.Text = GlobaleLister.LOmråde[Tag].Kommentar;

                // Tags
                if (lbTags.Items.Count > 0) lbTags.Items.Clear();

                var TagListeTilOmråde = GlobaleLister.LOmråde[Tag].hentTags();
                foreach (var tags in TagListeTilOmråde)
                {
                    lbTags.Items.Add(tags);
                }
            }
        }

        private void CbOR_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOR.Checked)
                cbAND.Checked = false;
            else
                cbAND.Checked = true;

            OppdatarKartMedFilter();
        }

        private void CbAND_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAND.Checked) 
                cbOR.Checked = false;
            else 
                cbOR.Checked = true;

            OppdatarKartMedFilter();
        }

        private void OppdatarKartMedFilter()
        {
            //bool variabler til det "checked" valget 
            GlobaleVariabler.filterOR = cbOR.Checked;
            GlobaleVariabler.filterAND = cbAND.Checked;

            //Oppdaterer listene 
            GlobaleLister.OppdaterListe_Objekt();
            GlobaleLister.OppdaterListe_området();

            //Oppdatere kartet
            Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
        }

        private void BtnTagFjernAlle_Click(object sender, EventArgs e)
        {
            if (lbTagsVises.Items.Count > 0)
            {
                // Legger over alle til den andre listen

                int antall = lbTagsVises.Items.Count;
                for (int i = 0; i < antall; i++)
                {
                    GlobaleLister.tag_ListeSkjult.Add((string)lbTagsVises.Items[0]);
                    GlobaleLister.tag_ListeVises.Remove((string)lbTagsVises.Items[0]);
                }

                //Tømmer listene, siden ingen tags er valgt 
                GlobaleLister.LOmråde.Clear();
                GlobaleLister.LObjekt.Clear();

                // Oppdatere antall
                tbAntallObjekter.Text = GlobaleLister.LObjekt.Count.ToString();

                // Oppdater kartet
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
            }

        }

        private void BtnTagLeggTilAlle_Click(object sender, EventArgs e)
        {
            if (lbTagsSkjult.Items.Count > 0)
            {
                // Legger over alle til den andre listen
                int antall = lbTagsSkjult.Items.Count;
                for (int i = 0; i < antall; i++)
                {
                    GlobaleLister.tag_ListeVises.Add((string)lbTagsSkjult.Items[0]);
                    GlobaleLister.tag_ListeSkjult.Remove((string)lbTagsSkjult.Items[0]);
                }

                // Oppdatere listene 
                GlobaleLister.OppdaterListe_Objekt();
                GlobaleLister.OppdaterListe_området();

                // Oppdatere kartet 
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
            }

        }

        private void BtnKategoriFjernAlle_Click(object sender, EventArgs e)
        {
            if (lbKategorierVises.Items.Count > 0)
            {
                // Legger over alle til den andre listen
                int antall = lbKategorierVises.Items.Count;
                for (int i = 0; i < antall; i++)
                {
                    GlobaleLister.kategoriListeSkjult.Add((Kategorier_Bilde)lbKategorierVises.Items[0]);
                    GlobaleLister.kategoriListeVises.Remove((Kategorier_Bilde)lbKategorierVises.Items[0]);
                }

                // Tømmer listene, siden ingen kategori er valgt 
                GlobaleLister.LObjekt.Clear();

                // Oppdatere antall
                tbAntallObjekter.Text = GlobaleLister.LObjekt.Count.ToString();

                // Oppdatere kartet 
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
            }
        }

        private void BtnKategoriLeggTilAlle_Click(object sender, EventArgs e)
        {
            if (lbKategorierSkjult.Items.Count > 0)
            {
                // Legger over alle til den andre listen
                int antall = lbKategorierSkjult.Items.Count;
                for (int i = 0; i < antall; i++)
                {
                    GlobaleLister.kategoriListeVises.Add((Kategorier_Bilde)lbKategorierSkjult.Items[0]);
                    GlobaleLister.kategoriListeSkjult.Remove((Kategorier_Bilde)lbKategorierSkjult.Items[0]);
                }

                // Oppdatere listen 
                GlobaleLister.OppdaterListe_Objekt();

                // Oppdatere kartet 
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
            }
        }


        internal void BtnTimerMåling_Click(object sender, EventArgs e)
        {
            if (målingRunning)
            {
                målingRunning = false;
                btnTimerMåling.Text = "Simulering av målinger inaktiv";
                timer.Change(Timeout.Infinite, Timeout.Infinite); // Timeren aktiveres aldri i denne modusen.
            }
            else
            {
                målingRunning = true;
                btnTimerMåling.Text = "Simulering av målinger aktiv";
                timer.Change(0, Globalekonstanter.målingSimIntervall); // Starter timeren og simulering av måling gjentaes hvert 10sek.
            }
        }

        public void OppdaterAntall()
        {
            tbAntallObjekter.Text = GlobaleLister.LObjekt.Count.ToString();
        }
    }
}
