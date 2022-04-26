using GMap.NET;
using System;
using System.Windows.Forms;

namespace GMAP_Demo
{

    public partial class frmFilter : Form
    {
        public static frmFilter instance;
        public int indexRessurs = 0;
        public bool filterOR;
        public bool filterAND;

        public frmFilter()
        {
            InitializeComponent();
            instance = this;
        }

        private void frmFilter_Load(object sender, EventArgs e)
        {
            lbKategorierVises.DataSource = Kart.kategoriListeVises;
            lbKategorierVises.DisplayMember = "Kategorinavn";
            lbKategorierSkjult.DataSource = Kart.kategoriListeSkjult;
            lbKategorierSkjult.DisplayMember = "Kategorinavn";
            lbTagsVises.DataSource = Kart.tag_ListeVises;
            lbTagsVises.DisplayMember = "Tag";
            lbTagsSkjult.DataSource = Kart.tag_ListeSkjult;
            lbTagsSkjult.DisplayMember = "Tag";

            cbOR.Checked = true;
        }

        private void lbKategorierVises_DoubleClick(object sender, EventArgs e)
        {
            if (lbKategorierVises.Items.Count > 0)
            {
                Kart.kategoriListeSkjult.Add((Kategorier_Bilde)lbKategorierVises.SelectedItem);
                Kart.kategoriListeVises.Remove((Kategorier_Bilde)lbKategorierVises.SelectedItem);
                Kart.OppdaterListe_ressurs();
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
            }
        }

        private void lbKategorierSkjult_DoubleClick(object sender, EventArgs e)
        {
            if (lbKategorierSkjult.Items.Count > 0)
            {
                Kart.kategoriListeVises.Add((Kategorier_Bilde)lbKategorierSkjult.SelectedItem);
                Kart.kategoriListeSkjult.Remove((Kategorier_Bilde)lbKategorierSkjult.SelectedItem);
                Kart.OppdaterListe_ressurs();
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
            }
        }

        private void lbTagsVises_DoubleClick(object sender, EventArgs e)
        {
            if (lbTagsVises.Items.Count > 0)
            {
                Kart.tag_ListeSkjult.Add((string)lbTagsVises.SelectedItem);
                Kart.tag_ListeVises.Remove((string)lbTagsVises.SelectedItem);
                Kart.OppdaterListe_ressurs();
                Kart.OppdaterListe_området();
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
            }
        }

        private void lbTagsSkjult_DoubleClick(object sender, EventArgs e)
        {
            if (lbTagsSkjult.Items.Count > 0)
            {
                Kart.tag_ListeVises.Add((string)lbTagsSkjult.SelectedItem);
                Kart.tag_ListeSkjult.Remove((string)lbTagsSkjult.SelectedItem);
                Kart.OppdaterListe_ressurs();
                Kart.OppdaterListe_området();
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
            }
        }

        private void cbViseOmråde_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViseOmråde.Checked) Kart.ViseOmrådePåKart = false;
            else Kart.ViseOmrådePåKart = true;

            Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
        }

        private void btnNesteRessurs_Click(object sender, EventArgs e)
        {
            indexRessurs++;
            if (indexRessurs >= GlobaleLister.LRessurs.Count) indexRessurs = 0;

            FyllInfoObjekt(indexRessurs);
            FlyttTilObjekt(indexRessurs);
        }

        private void btnForrigeRessurs_Click(object sender, EventArgs e)
        {
            indexRessurs--;
            if (indexRessurs < 0) indexRessurs = GlobaleLister.LRessurs.Count - 1;
            else if(indexRessurs >= GlobaleLister.LRessurs.Count) indexRessurs = GlobaleLister.LRessurs.Count - 1;
            FyllInfoObjekt(indexRessurs);
            FlyttTilObjekt(indexRessurs);
        }

        private void FlyttTilObjekt(int index)
        {
            PointLatLng point = GlobaleLister.LRessurs[index].GiPunktet();

            frmVisning.instance.map.Position = point;
        }

        public void FyllInfoObjekt(int Tag)
        {
            txtNavn.Text = GlobaleLister.LRessurs[Tag].Navn;
            txtKategori.Text = GlobaleLister.LRessurs[Tag].Kategori;
            txtDato_opprettet.Text = GlobaleLister.LRessurs[Tag].Dato_opprettet;
            txtOpprettetAvBruker.Text = GlobaleLister.LRessurs[Tag].Opprettet_av_bruker;
            txtSikkerhetsklarering.Text = GlobaleLister.LRessurs[Tag].Sikkerhetsklarering.ToString();
            txtKommentar.Text = GlobaleLister.LRessurs[Tag].Kommentar;

            //tags
            if (lbTags.Items.Count > 0) lbTags.Items.Clear();

            var TagListeTilRessurs = GlobaleLister.LRessurs[Tag].hentTags();
            foreach (var tags in TagListeTilRessurs)
            {
                lbTags.Items.Add(tags);
            }
            //måling
            txtMåling.Text = Convert.ToString(DBComMåling.GetLatestValueMålingFromSelectedRessurs(GlobaleLister.LRessurs[Tag].Løpenummer_ressurs)[0]);
        }

        public void FyllInfoOmråde(int Tag)
        {
            txtNavn.Text = GlobaleLister.LOmråde[Tag].Navn;
            txtKategori.Text = "";
            txtMåling.Text = "";
            txtDato_opprettet.Text = GlobaleLister.LOmråde[Tag].Dato_opprettet;
            txtOpprettetAvBruker.Text = GlobaleLister.LOmråde[Tag].Opprettet_av_bruker;
            txtSikkerhetsklarering.Text = GlobaleLister.LOmråde[Tag].Sikkerhetsklarering.ToString();
            txtKommentar.Text = GlobaleLister.LOmråde[Tag].Kommentar;

            //tags
            if (lbTags.Items.Count > 0) lbTags.Items.Clear();

            var TagListeTilOmråde = GlobaleLister.LOmråde[Tag].hentTags();
            foreach (var tags in TagListeTilOmråde)
            {
               lbTags.Items.Add(tags);
            }

        }

        private void cbOR_CheckedChanged(object sender, EventArgs e)
        {
            if(cbOR.Checked)
            {
                cbAND.Checked = false;
            }
            else 
            {
                cbAND.Checked = true;
            }
            SettFilterValg();

            Kart.OppdaterListe_ressurs();
            Kart.OppdaterListe_området();
            Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
        }

        private void cbAND_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAND.Checked)
            {
                cbOR.Checked = false;
            }
            else
            {
                cbOR.Checked = true;
            }

            SettFilterValg();

            Kart.OppdaterListe_ressurs();
            Kart.OppdaterListe_området();
            Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);

        }

        private void SettFilterValg()
        {
            filterOR = cbOR.Checked;
            filterAND = cbAND.Checked;
        }

        private void btnTagFjernAlle_Click(object sender, EventArgs e)
        {
            if(lbTagsVises.Items.Count >0 )
            {
                int antall = lbTagsVises.Items.Count;
                for (int i = 0; i < antall; i++)
                {
                    Kart.tag_ListeSkjult.Add((string)lbTagsVises.Items[0]);
                    Kart.tag_ListeVises.Remove((string)lbTagsVises.Items[0]);
                }

                Kart.OppdaterListe_ressurs();
                Kart.OppdaterListe_området();
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
            }
            
        }

        private void btnTagLeggTilAlle_Click(object sender, EventArgs e)
        {
            if(lbTagsSkjult.Items.Count > 0)
            {
                int antall = lbTagsSkjult.Items.Count;
                for (int i = 0; i < antall; i++)
                {
                    Kart.tag_ListeVises.Add((string)lbTagsSkjult.Items[0]);
                    Kart.tag_ListeSkjult.Remove((string)lbTagsSkjult.Items[0]);
                }

                Kart.OppdaterListe_ressurs();
                Kart.OppdaterListe_området();
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
            }
            
        }

        private void btnKategoriFjernAlle_Click(object sender, EventArgs e)
        {
            if (lbKategorierVises.Items.Count > 0)
            {
                int antall = lbKategorierVises.Items.Count;
                for (int i = 0; i < antall; i++)
                {
                    Kart.kategoriListeSkjult.Add((Kategorier_Bilde)lbKategorierVises.Items[0]);
                    Kart.kategoriListeVises.Remove((Kategorier_Bilde)lbKategorierVises.Items[0]);
                }

                Kart.OppdaterListe_ressurs();
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
            }
        }
        private void btnKategoriLeggTilAlle_Click(object sender, EventArgs e)
        {
            if (lbKategorierSkjult.Items.Count >0)
            {
                int antall = lbKategorierSkjult.Items.Count;
                for (int i = 0; i < antall; i++)
                {
                    Kart.kategoriListeVises.Add((Kategorier_Bilde)lbKategorierSkjult.Items[0]);
                    Kart.kategoriListeSkjult.Remove((Kategorier_Bilde)lbKategorierSkjult.Items[0]);
                }

                Kart.OppdaterListe_ressurs();
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
            }     
        }
    }
}
