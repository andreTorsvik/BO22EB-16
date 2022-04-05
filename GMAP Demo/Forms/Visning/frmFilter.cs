using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            if(FrmVisning.instance.LRessurs.Count >0) FrmVisning.instance.LRessurs.Clear();


            var RessursList = DatabaseCommunication.ListAllRessursFromDb();

            foreach (var item in RessursList)
            {
                FrmVisning.instance.LRessurs.Add(item);
            }

            txtAntall.Text = FrmVisning.instance.LRessurs.Count.ToString();
        }

        public void OppdaterRessursListe()
        {
            if (FrmVisning.instance.LRessurs.Count > 0) FrmVisning.instance.LRessurs.Clear();
            //må endres 
            var RessursList = DatabaseCommunication.ListAllRessursFromDb();

            foreach (var item in RessursList)
            {
                FrmVisning.instance.LRessurs.Add(item);
            }
            Kart.LeggTilRessurs(FrmVisning.instance.LRessurs,0);
        }
        public void OppdaterOmrådeListe()
        {
            FrmVisning.instance.LOmråde.Clear();

            var OmrådeListe = DatabaseCommunication.ListAllOmrådeFromDb();

            foreach (var item in OmrådeListe)
            {
                FrmVisning.instance.LOmråde.Add(item);
            }
            Kart.LeggTilOmråde(FrmVisning.instance.LOmråde,0);
           
        }

            private void btnRessurs_Click(object sender, EventArgs e)
        {
            Kart.LeggTilRessurs(FrmVisning.instance.LRessurs,0);
            FrmVisning.reff();
        }

        private void btnFjern_Click(object sender, EventArgs e)
        {
                FrmVisning.instance.map.Overlays.Clear();
                FrmVisning.reff();
                txtNavn.Text = "";
                txtKategori.Text = "";
                txtDato_opprettet.Text = "";
                txtOpprettetAvBruker.Text = "";
                txtSikkerhetsklarering.Text = "";
                txtKommentar.Text = "";
        }

        private void btnHentOmråde_Click(object sender, EventArgs e)
        {
            FrmVisning.instance.LOmråde.Clear();

            var OmrådeListe = DatabaseCommunication.ListAllOmrådeFromDb();

            foreach (var item in OmrådeListe)
            {
                FrmVisning.instance.LOmråde.Add(item);
            }

            txtAntallOmråder.Text = FrmVisning.instance.LOmråde.Count.ToString();
        }

        private void btnLeggTilOmrådet_Click(object sender, EventArgs e)
        {
            Kart.LeggTilOmråde(FrmVisning.instance.LOmråde,0);
            FrmVisning.reff();
        }

        

       
        private void frmFilter_Load(object sender, EventArgs e)
        {
            Kart.InitializekategoriListeVises();
            Kart.InitializekategoriListeSkjult();
            
            lbKategorierVises.DataSource = Kart.kategoriListeVises;
            lbKategorierVises.DisplayMember = "Kategorinavn";
            lbKategorierSkjult.DataSource = Kart.kategoriListeSkjult;
            lbKategorierSkjult.DisplayMember ="Kategorinavn";
        }

        private void lbKategorierVises_DoubleClick(object sender, EventArgs e)
        {
            if (lbKategorierVises.Items.Count > 0)
            {
                Kart.kategoriListeSkjult.Add((Kategorier_Bilde)lbKategorierVises.SelectedItem);
                Kart.kategoriListeVises.Remove((Kategorier_Bilde)lbKategorierVises.SelectedItem);
                Kart.Visning_OppdaterListeOgKart();
                //OppdaterKart();
            }
        }
        private void lbKategorierSkjult_DoubleClick(object sender, EventArgs e)
        {
            if (lbKategorierSkjult.Items.Count > 0)
            {
                Kart.kategoriListeVises.Add((Kategorier_Bilde)lbKategorierSkjult.SelectedItem);
                Kart.kategoriListeSkjult.Remove((Kategorier_Bilde)lbKategorierSkjult.SelectedItem);
                Kart.Visning_OppdaterListeOgKart();
                //OppdaterKart();
            }
        }

        //public void OppdaterKart()
        //{
        //    FrmVisning.instance.map.Overlays.Clear();
        //    if (FrmVisning.instance.LRessurs.Count > 0) FrmVisning.instance.LRessurs.Clear();

        //    var RessursList = DatabaseCommunication.ListAllRessursFromDb();

        //    // Er dette en tungvindt måte å gjøre det på? Kan dette forbedres?
        //    foreach (var item in RessursList)
        //    {
        //        foreach (var item2 in Kart.kategoriListeVises)
        //        {
        //            if (item.Kategori.ToString() == item2.Kategorinavn.ToString())
        //            {
        //                FrmVisning.instance.LRessurs.Add(item);
        //                break;
        //            }
        //        }
        //    }

        //    Kart.LeggTilRessurs(FrmVisning.instance.LRessurs);
        //    FrmVisning.reff();
        //}

    }
}
