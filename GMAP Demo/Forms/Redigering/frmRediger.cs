using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace GMAP_Demo
{
    public partial class frmRediger : Form
    {
        //log
        //DatabaseCommunication.LogFeil(typeof(classname).Name,System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message); // hvis static 
        //DatabaseCommunication.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message); 

        private Color knapp_trykket;
        public PointLatLng DoubleClick_punkt; //tror denne kan bli flyttet inn i metoedn 
        public static frmRediger instance;
        public frmRediger()
        {
            InitializeComponent();
            instance = this;
            knapp_trykket = Color.FromArgb(46, 51, 73);

            //sette oransjePanelet til Posisjonknapp
            FlyttNavigasjonsPanel(btnObjekt.Height, btnObjekt.Top);
            btnObjekt.BackColor = knapp_trykket;


            // Viser innlogget bruker
            lblUserName.Text = InnloggetBruker.BrukernavnInnlogget;

            this.PnlFormLoader.Controls.Clear();
            frm_R_LeggTilObjekt frm_R_LeggTilObjekt_vrb = new frm_R_LeggTilObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm_R_LeggTilObjekt_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm_R_LeggTilObjekt_vrb);
            frm_R_LeggTilObjekt_vrb.Show();
        }

        private void frmRediger_Load(object sender, EventArgs e)
        {
            Kart.Setup(Kart.MuligKart.Redigering, Kart.PunktFraForrige);

            Kart.LeggTilRessurs(GlobaleLister.LRessurs, Kart.MuligKart.Redigering);
            Kart.LeggTilOmråde(GlobaleLister.LOmråde, Kart.MuligKart.Redigering);

            Kart.reff(Kart.MuligKart.Redigering);
        }

        private void btnTilbake_Click(object sender, EventArgs e)
        {
            frmVisning.instance.map.Position = map.Position;
            frmVisning.instance.map.Zoom = map.Zoom;

            this.Close();
        }

        void AlleKnapperTilStandarfarge()
        {
            Color StandarFarge = Color.FromArgb(24, 30, 54);

            btnLeggTilBilde.BackColor = StandarFarge;
            btnObjekt.BackColor = StandarFarge;
            btnOmråde.BackColor = StandarFarge;
            btnRediger_objekt.BackColor = StandarFarge;
            btnRedigerOmråde.BackColor = StandarFarge;
            btnFjern.BackColor = StandarFarge;
        }

        private void btnObjekt_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnObjekt.Top)
            {
                AlleKnapperTilStandarfarge();
                btnObjekt.BackColor = knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnObjekt.Height, btnObjekt.Top);

                SlettHjelpeMarkører();

                //legge inn rett forms i panelet
                this.PnlFormLoader.Controls.Clear();
                frm_R_LeggTilObjekt frm_R_LeggTilObjekt_vrb = new frm_R_LeggTilObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_R_LeggTilObjekt_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_R_LeggTilObjekt_vrb);
                frm_R_LeggTilObjekt_vrb.Show();
            }


        }

        private void btnOmråde_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnOmråde.Top)
            {
                AlleKnapperTilStandarfarge();
                btnOmråde.BackColor = knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnOmråde.Height, btnOmråde.Top);

                SlettHjelpeMarkører();

                //legge inn rett form i panelet
                this.PnlFormLoader.Controls.Clear();
                frm_R_LeggTilOmråde frm_R_LeggTilOmråde_vrb = new frm_R_LeggTilOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_R_LeggTilOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_R_LeggTilOmråde_vrb);
                frm_R_LeggTilOmråde_vrb.Show();
            }

        }

        private void btnRediger_obj_områ_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnRediger_objekt.Top)
            {
                AlleKnapperTilStandarfarge();
                btnRediger_objekt.BackColor = knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnRediger_objekt.Height, btnRediger_objekt.Top);

                SlettHjelpeMarkører();

                //legge inn rett form i panelet
                this.PnlFormLoader.Controls.Clear();
                frm_R_RedigerObjekt frm_R_RedigerObjektOmråde_vrb = new frm_R_RedigerObjekt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_R_RedigerObjektOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_R_RedigerObjektOmråde_vrb);
                frm_R_RedigerObjektOmråde_vrb.Show();
            }

        }
        private void btnRedigerOmråde_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnRedigerOmråde.Top)
            {
                AlleKnapperTilStandarfarge();
                btnRedigerOmråde.BackColor = knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnRedigerOmråde.Height, btnRedigerOmråde.Top);

                SlettHjelpeMarkører();

                //legge inn rett form i panelet
                this.PnlFormLoader.Controls.Clear();
                frm_R_RedigerOmråde frm_R_RedigerOmråde_vrb = new frm_R_RedigerOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_R_RedigerOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_R_RedigerOmråde_vrb);
                frm_R_RedigerOmråde_vrb.Show();
            }
        }

        private void btnLeggTilBilde_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnLeggTilBilde.Top)
            {
                AlleKnapperTilStandarfarge();
                btnLeggTilBilde.BackColor = knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnLeggTilBilde.Height, btnLeggTilBilde.Top);

                SlettHjelpeMarkører();

                //legge inn rett form i panelet
                this.PnlFormLoader.Controls.Clear();
                frm_R_EndreObjektsymbol frm_R_LeggTilBilde_vrb = new frm_R_EndreObjektsymbol() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_R_LeggTilBilde_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_R_LeggTilBilde_vrb);
                frm_R_LeggTilBilde_vrb.Show();
            }
        }

        private void btnFjern_Click(object sender, EventArgs e)
        {
            if (pnlNav.Top != btnFjern.Top)
            {
                AlleKnapperTilStandarfarge();
                btnFjern.BackColor = knapp_trykket;

                //Flytte oransjePanelet til rett plass
                FlyttNavigasjonsPanel(btnFjern.Height, btnFjern.Top);

                SlettHjelpeMarkører();

                //legge inn rett form i panelet
                this.PnlFormLoader.Controls.Clear();
                frm_R_FjernObjektOmråde frm_R_FjernObjektOmråde_vrb = new frm_R_FjernObjektOmråde() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm_R_FjernObjektOmråde_vrb.FormBorderStyle = FormBorderStyle.None;
                this.PnlFormLoader.Controls.Add(frm_R_FjernObjektOmråde_vrb);
                frm_R_FjernObjektOmråde_vrb.Show();
            }
        }

        private void frmRediger_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.PnlFormLoader.Controls.Clear();
            frmVisning.instance.Show();
        }

        public void FlyttNavigasjonsPanel(int høyde, int top)
        {
            //henter Høyde på knapp og hvor toppen er plassert 
            pnlNav.Height = høyde;
            pnlNav.Top = top;
            //Denne trenger kun å bli utført en gang, men er med forsikkerhetskyld 
            pnlNav.Left = btnObjekt.Left;
        }

        private void map_MouseDoubleClick(PointLatLng pointClick, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoubleClick_punkt = map.FromLocalToLatLng(e.X, e.Y);
                //List<PointLatLng> Lpunkt = new List<PointLatLng>();
                //Lpunkt.Add(DoubleClick_punkt);

                double lat = DoubleClick_punkt.Lat;
                double lng = DoubleClick_punkt.Lng;

                Kart.FjernAlleMarkører_redigier("HjelpeMarkør");
                Kart.LeggtilMarkør(Kart.MuligKart.Redigering, new PointLatLng(lat, lng), -1, "HjelpeMarkør");
                Kart.reff(Kart.MuligKart.Redigering);

                if (frm_R_LeggTilObjekt.instance != null)
                {
                    frm_R_LeggTilObjekt.instance.txtLat.Text = lat.ToString();
                    frm_R_LeggTilObjekt.instance.txtLong.Text = lng.ToString();

                }
                if (frm_R_LeggTilOmråde.instance != null)
                {
                    frm_R_LeggTilOmråde.instance.txtLat.Text = lat.ToString();
                    frm_R_LeggTilOmråde.instance.txtLong.Text = lng.ToString();
                }
                if (frm_R_RedigerObjekt.instance != null)
                {
                    frm_R_RedigerObjekt.instance.txtLat.Text = lat.ToString();
                    frm_R_RedigerObjekt.instance.txtLong.Text = lng.ToString();
                    

                }
                if (frm_R_RedigerOmråde.instance != null)
                {
                    frm_R_RedigerOmråde.instance.txtLat.Text = lat.ToString();
                    frm_R_RedigerOmråde.instance.txtLong.Text = lng.ToString();
                }
            }
        }

        public void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (frm_R_LeggTilOmråde.instance != null)
            {

            }
            if (frm_R_RedigerObjekt.instance != null)
            {
                //info 
                frm_R_RedigerObjekt.instance.txtNavn.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Navn;
                frm_R_RedigerObjekt.instance.txtKategori.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Kategori;
                frm_R_RedigerObjekt.instance.txtSikkerhetsklarering.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Sikkerhetsklarering.ToString();
                frm_R_RedigerObjekt.instance.txtKommentar.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Kommentar;
                frm_R_RedigerObjekt.instance.txtLat.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Lat.ToString();
                frm_R_RedigerObjekt.instance.txtLong.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Lang.ToString();

                //tagliste
                //sletting av eksisterende lister
                if (frm_R_RedigerObjekt.instance.lbValgtTags.Items.Count > 0) frm_R_RedigerObjekt.instance.lbValgtTags.Items.Clear();
                if (frm_R_RedigerObjekt.instance.lbTilgjengeligeTags.Items.Count > 0) frm_R_RedigerObjekt.instance.lbTilgjengeligeTags.Items.Clear();
                if (frm_R_RedigerObjekt.instance.LagretTags.Count > 0) frm_R_RedigerObjekt.instance.LagretTags.Clear();

                var TagListeTilRessurs = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].hentTags();
                var AlleTags = FellesMetoder.FåAlleTags();
                var GjenværendeTag =  AlleTags.Except(TagListeTilRessurs);

                foreach (var tags in TagListeTilRessurs)
                {
                    frm_R_RedigerObjekt.instance.lbValgtTags.Items.Add(tags);
                    frm_R_RedigerObjekt.instance.LagretTags.Add(tags);
                }
                foreach (var tags in GjenværendeTag)
                {
                    frm_R_RedigerObjekt.instance.lbTilgjengeligeTags.Items.Add(tags);
                }

                //info til redigering 
                frm_R_RedigerObjekt.instance.Løpenummer_til_redigering = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Løpenummer_ressurs;

            }
            if (frm_R_FjernObjektOmråde.instance != null)
            {
                frm_R_FjernObjektOmråde.instance.Løpenummer_til_objekt = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Løpenummer_ressurs;
                if (frm_R_FjernObjektOmråde.instance.Løpenummer_til_Område >= 0) frm_R_FjernObjektOmråde.instance.Løpenummer_til_Område = -1;
                frm_R_FjernObjektOmråde.instance.txtInfo.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].ToString();
                frm_R_FjernObjektOmråde.instance.txtLøpenumemr.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Løpenummer_ressurs.ToString();
                frm_R_FjernObjektOmråde.instance.txtNavn.Text = GlobaleLister.LRessurs[Convert.ToInt32(item.Tag)].Navn;
            }

        }

        private void map_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            if (frm_R_RedigerOmråde.instance != null)
            {
                frm_R_RedigerOmråde.instance.Løpenummer_til_redigering = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].Løpenummer_område;
                frm_R_RedigerOmråde.instance.txtNavn.Text = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].Navn;
                frm_R_RedigerOmråde.instance.txtSikkerhetsklarering.Text = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].Sikkerhetsklarering.ToString();
                frm_R_RedigerOmråde.instance.txtKommentar.Text = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].Kommentar;
                frm_R_RedigerOmråde.instance.txtfarge.Text = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].Farge;

                //punkt liste
                if (frm_R_RedigerOmråde.instance.lbPunkter.Items.Count > 0) frm_R_RedigerOmråde.instance.pointLatLngs.Clear();
                var Punktliste = DatabaseCommunication.GetPunkter_området(frm_R_RedigerOmråde.instance.Løpenummer_til_redigering);
                Punktliste = Punktliste.OrderBy(x => x.Rekkefølge_punkter).ToList();
                foreach (var item1 in Punktliste)
                {
                    PointLatLng point = new PointLatLng(item1.Lat, item1.Lang);
                    frm_R_RedigerOmråde.instance.pointLatLngs.Add(point);
                }
                frm_R_RedigerOmråde.instance.txtNrPunkt.Text = Punktliste.Count.ToString();

                //tags
                if (frm_R_RedigerOmråde.instance.lbValgtTags.Items.Count > 0) frm_R_RedigerOmråde.instance.lbValgtTags.Items.Clear();
                if (frm_R_RedigerOmråde.instance.lbTilgjengeligeTags.Items.Count > 0) frm_R_RedigerOmråde.instance.lbTilgjengeligeTags.Items.Clear();
                if (frm_R_RedigerOmråde.instance.LagretTags.Count > 0) frm_R_RedigerOmråde.instance.LagretTags.Clear();

                var TagListeTilRessurs = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].hentTags();
                var AlleTags = FellesMetoder.FåAlleTags();
                var GjenværendeTag = AlleTags.Except(TagListeTilRessurs);

                foreach (var tags in TagListeTilRessurs)
                {
                    frm_R_RedigerOmråde.instance.lbValgtTags.Items.Add(tags);
                    frm_R_RedigerOmråde.instance.LagretTags.Add(tags);
                }
                foreach (var tags in GjenværendeTag)
                {
                    frm_R_RedigerOmråde.instance.lbTilgjengeligeTags.Items.Add(tags);
                }
            }
            if (frm_R_FjernObjektOmråde.instance != null)
            {
                frm_R_FjernObjektOmråde.instance.Løpenummer_til_Område = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].Løpenummer_område;
                if (frm_R_FjernObjektOmråde.instance.Løpenummer_til_objekt >= 0) frm_R_FjernObjektOmråde.instance.Løpenummer_til_objekt = -1;
                frm_R_FjernObjektOmråde.instance.txtInfo.Text = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].ToString();
                frm_R_FjernObjektOmråde.instance.txtLøpenumemr.Text = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].Løpenummer_område.ToString();
                frm_R_FjernObjektOmråde.instance.txtNavn.Text = GlobaleLister.LOmråde[Convert.ToInt32(item.Tag)].Navn;
            }

        }

        private void btnZoomPluss_Click(object sender, EventArgs e)
        {
            instance.map.Zoom++;
        }

        private void btnZoomMinus_Click(object sender, EventArgs e)
        {
            instance.map.Zoom--;
        }

        public void SlettHjelpeMarkører()
        {
            foreach (var item in instance.map.Overlays)
            {
                if (item.Id == "MarkørForOmråde")
                {
                    Kart.FjernAlleMarkører_redigier("MarkørForOmråde");
                    break;
                }
            }
            foreach (var item in instance.map.Overlays)
            {
                if (item.Id == "HjelpeMarkør")
                {
                    Kart.FjernAlleMarkører_redigier("HjelpeMarkør");
                    break;
                }
            }
        }

       
    }
}
