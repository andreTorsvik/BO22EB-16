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
        public bool filterOR;
        public bool filterAND;

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
            btnForrigeRessurs.ForeColor = ThemeDesign.colorLabel;
            btnForrigeRessurs.BackColor = ThemeDesign.colorGray;
            btnNesteRessurs.ForeColor = ThemeDesign.colorLabel;
            btnNesteRessurs.BackColor = ThemeDesign.colorGray;

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
            filterOR = true;
            if(GlobaleLister.LRessurs.Count > 0) tbAntallObjekter.Text = GlobaleLister.LRessurs.Count.ToString();
        }

        private void LbKategorierVises_DoubleClick(object sender, EventArgs e)
        {
            if (lbKategorierVises.Items.Count > 0)
            {
                // Oppdatere begge listen basert på hva som er valgt 
                GlobaleLister.kategoriListeSkjult.Add((Kategorier_Bilde)lbKategorierVises.SelectedItem);
                GlobaleLister.kategoriListeVises.Remove((Kategorier_Bilde)lbKategorierVises.SelectedItem);

                // Oppdaterer ressurs liste 
                FellesMetoder.OppdaterListe_ressurs();

                // Oppdaterer kartet 
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
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
                FellesMetoder.OppdaterListe_ressurs();

                // Oppdaterer kartet 
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
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
                FellesMetoder.OppdaterListe_ressurs();
                FellesMetoder.OppdaterListe_området();

                // Oppdaterer kartet 
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
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
                FellesMetoder.OppdaterListe_ressurs();
                FellesMetoder.OppdaterListe_området();

                // Oppdaterer kartet
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
            }
        }

        private void CbViseOmråde_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViseOmråde.Checked) Kart.VisOmrådePåKart = false;
            else Kart.VisOmrådePåKart = true;

            Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
        }

        private void BtnNesteRessurs_Click(object sender, EventArgs e)
        {
            indexRessurs++;
            if (indexRessurs >= GlobaleLister.LRessurs.Count) indexRessurs = 0;

            // Fyller inn info om objektet i filter 
            FyllInfoObjekt(indexRessurs);

            // Flytter kartet til objektet  
            FlyttTilObjekt(indexRessurs);
        }

        private void BtnForrigeRessurs_Click(object sender, EventArgs e)
        {
            indexRessurs--;
            if (indexRessurs < 0) indexRessurs = GlobaleLister.LRessurs.Count - 1;
            else if (indexRessurs >= GlobaleLister.LRessurs.Count) indexRessurs = GlobaleLister.LRessurs.Count - 1;
            
            // Fyller inn info om objektet i filter 
            FyllInfoObjekt(indexRessurs);
           
            // Flytter kartet til objektet 
            FlyttTilObjekt(indexRessurs);
        }

        private void FlyttTilObjekt(int index)
        {
            if(GlobaleLister.LRessurs.Count > 0)
            {
                PointLatLng point = GlobaleLister.LRessurs[index].GiPunktet();

                FrmVisning.instance.map.Position = point;
            }         
        }

        public void FyllInfoObjekt(int Tag)
        {
            if(GlobaleLister.LRessurs.Count > 0)
            {
                // Info
                tbNavn.Text = GlobaleLister.LRessurs[Tag].Navn;
                tbKategori.Text = GlobaleLister.LRessurs[Tag].Kategori;
                tbDato_opprettet.Text = GlobaleLister.LRessurs[Tag].Dato_opprettet;
                tbOpprettetAvBruker.Text = GlobaleLister.LRessurs[Tag].Opprettet_av_bruker;
                tbSikkerhetsklarering.Text = GlobaleLister.LRessurs[Tag].Sikkerhetsklarering.ToString();
                tbKommentar.Text = GlobaleLister.LRessurs[Tag].Kommentar;

                // Tags
                if (lbTags.Items.Count > 0) lbTags.Items.Clear();

                var TagListeTilRessurs = GlobaleLister.LRessurs[Tag].hentTags();
                foreach (var tags in TagListeTilRessurs)
                {
                    lbTags.Items.Add(tags);
                }
                //måling
                Måling NyesteMåling = DBComMåling.GetLatestValueMålingFromSelectedRessurs(GlobaleLister.LRessurs[Tag].Id_ressurs)[0];
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
            filterOR = cbOR.Checked;
            filterAND = cbAND.Checked;

            //Oppdaterer listene 
            FellesMetoder.OppdaterListe_ressurs();
            FellesMetoder.OppdaterListe_området();

            //Oppdatere kartet
            Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
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
                GlobaleLister.LRessurs.Clear();

                // Oppdatere antall
                tbAntallObjekter.Text = GlobaleLister.LRessurs.Count.ToString();

                // Oppdater kartet
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
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
                FellesMetoder.OppdaterListe_ressurs();
                FellesMetoder.OppdaterListe_området();

                // Oppdatere kartet 
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
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
                GlobaleLister.LRessurs.Clear();

                // Oppdatere antall
                tbAntallObjekter.Text = GlobaleLister.LRessurs.Count.ToString();

                // Oppdatere kartet 
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
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
                FellesMetoder.OppdaterListe_ressurs();

                // Oppdatere kartet 
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
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
                timer.Change(0, 10000); // Starter timeren og simulering av måling gjentaes hvert 10sek.
            }
        }

        public void OppdaterAntall()
        {
            tbAntallObjekter.Text = GlobaleLister.LRessurs.Count.ToString();
        }
    }
}
