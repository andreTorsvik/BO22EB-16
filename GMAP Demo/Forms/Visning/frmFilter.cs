using System;
using System.Windows.Forms;

namespace GMAP_Demo
{

    public partial class frmFilter : Form
    {
        public static frmFilter instance;

        public frmFilter()
        {
            InitializeComponent();
            instance = this;
        }
      
        public void OppdaterOmrådeListe()
        {
            GlobaleLister.LOmråde.Clear();

            var OmrådeListe = DBComOmråde.ListAllOmrådeFromDb();

            foreach (var item in OmrådeListe)
            {
                GlobaleLister.LOmråde.Add(item);
            }
            Kart.LeggTilOmråde(GlobaleLister.LOmråde, Kart.MuligKart.Visning);
        }

        private void btnFjern_Click(object sender, EventArgs e)
        {
            frmVisning.instance.map.Overlays.Clear();
            Kart.reff(Kart.MuligKart.Visning);
            txtNavn.Text = "";
            txtKategori.Text = "";
            txtDato_opprettet.Text = "";
            txtOpprettetAvBruker.Text = "";
            txtSikkerhetsklarering.Text = "";
            txtKommentar.Text = "";
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
                Kart.OppdaterKart(Kart.MuligKart.Visning, GlobaleLister.LRessurs, GlobaleLister.LOmråde);
            }
        }
    }
}
