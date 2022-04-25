using System;
using System.Windows.Forms;
using GMap.NET;

namespace GMAP_Demo
{

    public partial class frmFilter : Form
    {
        public static frmFilter instance;
        public int indexRessurs = 0;

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
            if(cbViseOmråde.Checked) Kart.ViseOmrådePåKart = false;
            else Kart.ViseOmrådePåKart = true;

            Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
        }

        private void btnNesteRessurs_Click(object sender, EventArgs e)
        {
            indexRessurs++;
            if(indexRessurs >= GlobaleLister.LRessurs.Count) indexRessurs = 0;

            FyllInfoObjekt(indexRessurs);
            Flytt(indexRessurs);
        }

        private void btnForrigeRessurs_Click(object sender, EventArgs e)
        {
            indexRessurs--;
            if (indexRessurs < 0) indexRessurs = GlobaleLister.LRessurs.Count - 1;

            FyllInfoObjekt(indexRessurs);
            Flytt(indexRessurs);
        }

        private void Flytt(int index)
        {
            double lat = GlobaleLister.LRessurs[index].Lat;
            double lang = GlobaleLister.LRessurs[index].Lang;

            PointLatLng point = new PointLatLng(lat,lang);

            frmVisning.instance.map.Position = point;
        }

        public static void FyllInfoObjekt(int Tag)
        {
            instance.txtNavn.Text = GlobaleLister.LRessurs[Convert.ToInt32(Tag)].Navn;
            instance.txtKategori.Text = GlobaleLister.LRessurs[Convert.ToInt32(Tag)].Kategori;
            instance.txtDato_opprettet.Text = GlobaleLister.LRessurs[Convert.ToInt32(Tag)].Dato_opprettet;
            instance.txtOpprettetAvBruker.Text = GlobaleLister.LRessurs[Convert.ToInt32(Tag)].Opprettet_av_bruker;
            instance.txtSikkerhetsklarering.Text = GlobaleLister.LRessurs[Convert.ToInt32(Tag)].Sikkerhetsklarering.ToString();
            instance.txtKommentar.Text = GlobaleLister.LRessurs[Convert.ToInt32(Tag)].Kommentar;

            //tags
            if (instance.lbTags.Items.Count > 0) instance.lbTags.Items.Clear();

            var TagListeTilRessurs = GlobaleLister.LRessurs[Convert.ToInt32(Tag)].hentTags();
            foreach (var tags in TagListeTilRessurs)
            {
                instance.lbTags.Items.Add(tags);
            }
            //måling
        }

        private void btnKategoriLeggTilAlle_Click(object sender, EventArgs e)
        {

        }
    }
}
