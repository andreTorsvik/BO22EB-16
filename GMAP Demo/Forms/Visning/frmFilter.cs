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
        private void btnLeggTil_Click(object sender, EventArgs e)
        {

            if (GlobaleLister.LRessurs.Count > 0) GlobaleLister.LRessurs.Clear();


            var RessursList = DatabaseCommunication.ListAllRessursFromDb();

            foreach (var item in RessursList)
            {
                GlobaleLister.LRessurs.Add(item);
            }

            txtAntall.Text = GlobaleLister.LRessurs.Count.ToString();
        }

        public void OppdaterRessursListe()
        {
            if (GlobaleLister.LRessurs.Count > 0) GlobaleLister.LRessurs.Clear();
            //må endres 
            var RessursList = DatabaseCommunication.ListAllRessursFromDb();

            foreach (var item in RessursList)
            {
                GlobaleLister.LRessurs.Add(item);
            }
            Kart.LeggTilRessurs(GlobaleLister.LRessurs, Kart.MuligKart.Visning);
        }

        public void OppdaterOmrådeListe()
        {
            GlobaleLister.LOmråde.Clear();

            var OmrådeListe = DatabaseCommunication.ListAllOmrådeFromDb();

            foreach (var item in OmrådeListe)
            {
                GlobaleLister.LOmråde.Add(item);
            }
            Kart.LeggTilOmråde(GlobaleLister.LOmråde, Kart.MuligKart.Visning);

        }

        private void btnRessurs_Click(object sender, EventArgs e)
        {
            Kart.LeggTilRessurs(GlobaleLister.LRessurs, Kart.MuligKart.Visning);
            Kart.reff(Kart.MuligKart.Visning);
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

        private void btnHentOmråde_Click(object sender, EventArgs e)
        {
            GlobaleLister.LOmråde.Clear();

            var OmrådeListe = DatabaseCommunication.ListAllOmrådeFromDb();

            foreach (var item in OmrådeListe)
            {
                GlobaleLister.LOmråde.Add(item);
            }

            txtAntallOmråder.Text = GlobaleLister.LOmråde.Count.ToString();
        }

        private void btnLeggTilOmrådet_Click(object sender, EventArgs e)
        {
            Kart.LeggTilOmråde(GlobaleLister.LOmråde, Kart.MuligKart.Visning);
            Kart.reff(Kart.MuligKart.Visning);
        }

        private void frmFilter_Load(object sender, EventArgs e)
        {
            lbKategorierVises.DataSource = Kart.kategoriListeVises;
            lbKategorierVises.DisplayMember = "Kategorinavn";
            lbKategorierSkjult.DataSource = Kart.kategoriListeSkjult;
            lbKategorierSkjult.DisplayMember = "Kategorinavn";
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
    }
}
