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

            if (frmVisning.instance.LRessurs.Count > 0) frmVisning.instance.LRessurs.Clear();


            var RessursList = DatabaseCommunication.ListAllRessursFromDb();

            foreach (var item in RessursList)
            {
                frmVisning.instance.LRessurs.Add(item);
            }

            txtAntall.Text = frmVisning.instance.LRessurs.Count.ToString();
        }

        public void OppdaterRessursListe()
        {
            if (frmVisning.instance.LRessurs.Count > 0) frmVisning.instance.LRessurs.Clear();
            //må endres 
            var RessursList = DatabaseCommunication.ListAllRessursFromDb();

            foreach (var item in RessursList)
            {
                frmVisning.instance.LRessurs.Add(item);
            }
            Kart.LeggTilRessurs(frmVisning.instance.LRessurs, Kart.MuligKart.Visning);
        }

        public void OppdaterOmrådeListe()
        {
            frmVisning.instance.LOmråde.Clear();

            var OmrådeListe = DatabaseCommunication.ListAllOmrådeFromDb();

            foreach (var item in OmrådeListe)
            {
                frmVisning.instance.LOmråde.Add(item);
            }
            Kart.LeggTilOmråde(frmVisning.instance.LOmråde, Kart.MuligKart.Visning);

        }

        private void btnRessurs_Click(object sender, EventArgs e)
        {
            Kart.LeggTilRessurs(frmVisning.instance.LRessurs, Kart.MuligKart.Visning);
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
            frmVisning.instance.LOmråde.Clear();

            var OmrådeListe = DatabaseCommunication.ListAllOmrådeFromDb();

            foreach (var item in OmrådeListe)
            {
                frmVisning.instance.LOmråde.Add(item);
            }

            txtAntallOmråder.Text = frmVisning.instance.LOmråde.Count.ToString();
        }

        private void btnLeggTilOmrådet_Click(object sender, EventArgs e)
        {
            Kart.LeggTilOmråde(frmVisning.instance.LOmråde, Kart.MuligKart.Visning);
            Kart.reff(Kart.MuligKart.Visning);
        }

        private void frmFilter_Load(object sender, EventArgs e)
        {
            //Kart.InitializekategoriListeVises();
            //Kart.InitializekategoriListeSkjult();

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
                Kart.OppdaterKart(Kart.MuligKart.Visning, frmVisning.instance.LRessurs, frmVisning.instance.LOmråde);

            }
        }
        private void lbKategorierSkjult_DoubleClick(object sender, EventArgs e)
        {
            if (lbKategorierSkjult.Items.Count > 0)
            {
                Kart.kategoriListeVises.Add((Kategorier_Bilde)lbKategorierSkjult.SelectedItem);
                Kart.kategoriListeSkjult.Remove((Kategorier_Bilde)lbKategorierSkjult.SelectedItem);
                Kart.OppdaterListe_ressurs();
                Kart.OppdaterKart(Kart.MuligKart.Visning, frmVisning.instance.LRessurs, frmVisning.instance.LOmråde);
            }
        }
    }
}
