using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public partial class frm_R_RedigerObjekt : Form
    {

        public static frm_R_RedigerObjekt instance;
        public int Løpenummer_til_redigering = -1;
        public List<string> LGamleTag = new List<string>();

        public frm_R_RedigerObjekt()
        {
            InitializeComponent();
            instance = this;
        }
        private void frm_R_RedigerObjekt_Load(object sender, EventArgs e)
        {
            LastInnKategorier();
            LastInnTags();
            LabelSikkerhetsklarering.Text = string.Format("Sikkerhetsklarering(1-{0})", Globalekonstanter.MaxSikkerhetsklarering);
        }

        private void lbTilgjengligKategori_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbTilgjengligKategori.SelectedIndex != -1)
            {
                string selectedItemtext = lbTilgjengligKategori.SelectedItem.ToString();

                txtKategori.Text = selectedItemtext;
            }
        }

        private void LastInnKategorier()
        {
            GlobaleLister.LKategori.Clear();
            var KategoriListe = DBComKategorier_Bilde.ListAllKategorier_BildeFromDb();

            foreach (var item in KategoriListe)
            {
                GlobaleLister.LKategori.Add(item);
                lbTilgjengligKategori.Items.Add(item.Kategorinavn);
            }
        }

        private void btnLeggTilNyKategori_Click(object sender, EventArgs e)
        {
            string nyKategori = "";

            nyKategori = txtNyKategori.Text;


            if (!string.IsNullOrEmpty(nyKategori))
            {
                DBComKategorier_Bilde.InsertKategorier_BildeToDb(nyKategori);

                lbTilgjengligKategori.Items.Add(nyKategori);
                lbTilgjengligKategori.Sorted = true;
                txtNyKategori.Text = "";
            }

            Kart.OppdaterKategoriListe();
        }

        private void LastInnTags()
        {
            if (lbTilgjengeligeTags.Items.Count > 0) lbTilgjengeligeTags.Items.Clear();

            HashSet<string> AlleTag = FellesMetoder.FåAlleTags();

            foreach (var item in AlleTag)
            {
                lbTilgjengeligeTags.Items.Add(item);
            }

            lbTilgjengeligeTags.Sorted = true;
        }

        private void lbTilgjengeligeTags_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbTilgjengeligeTags.SelectedIndex != -1)
            {
                string selectedItemtext = lbTilgjengeligeTags.SelectedItem.ToString();

                lbValgtTags.Items.Add(selectedItemtext);

                lbTilgjengeligeTags.Items.Remove(selectedItemtext);
            }
        }

        private void lbValgtTags_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbValgtTags.SelectedIndex != -1)
            {
                string selectedItemtext = lbValgtTags.SelectedItem.ToString();

                lbTilgjengeligeTags.Items.Add(selectedItemtext);

                lbValgtTags.Items.Remove(selectedItemtext);
            }
        }

        private void btnLeggTilTag_Click(object sender, EventArgs e)
        {
            string NyTag = "";
            NyTag = txtNyTag.Text;

            if (!string.IsNullOrEmpty(NyTag))
            {
                lbTilgjengeligeTags.Items.Add(NyTag);
                lbTilgjengeligeTags.Sorted = true;
                txtNyTag.Text = "";
            }
        }

        public void FyllKoordinater(double lat, double lang)
        {
            txtLat.Text = lat.ToString();
            txtLong.Text = lang.ToString();
        }

        public void FyllInfoObjekt(int Tag)
        {
            //løpenummeret 
            Løpenummer_til_redigering = GlobaleLister.LRessurs[Tag].Løpenummer_ressurs;
            //info 
            txtNavn.Text = GlobaleLister.LRessurs[Tag].Navn;
            txtKategori.Text = GlobaleLister.LRessurs[Tag].Kategori;
            txtSikkerhetsklarering.Text = GlobaleLister.LRessurs[Tag].Sikkerhetsklarering.ToString();
            txtKommentar.Text = GlobaleLister.LRessurs[Tag].Kommentar;
            txtLat.Text = GlobaleLister.LRessurs[Tag].Lat.ToString();
            txtLong.Text = GlobaleLister.LRessurs[Tag].Lang.ToString();


            //sletting av eksisterende lister
            if (lbValgtTags.Items.Count > 0) lbValgtTags.Items.Clear();
            if (lbTilgjengeligeTags.Items.Count > 0) lbTilgjengeligeTags.Items.Clear();
            if (LGamleTag.Count > 0) LGamleTag.Clear();

            //tagliste
            var TagListeTilRessurs = GlobaleLister.LRessurs[Tag].hentTags();
            var AlleTags = FellesMetoder.FåAlleTags();
            var GjenværendeTag = AlleTags.Except(TagListeTilRessurs);

            //sorter Tags
            foreach (var tags in TagListeTilRessurs)
            {
                lbValgtTags.Items.Add(tags);
                LGamleTag.Add(tags);
            }
            foreach (var tags in GjenværendeTag)
            {
                lbTilgjengeligeTags.Items.Add(tags);
            }

        }

        private void btnLeggTilObjekt_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text;
            string kategori = txtKategori.Text;
            string sikkerhetsklarering = txtSikkerhetsklarering.Text;
            string Kommentar = txtKommentar.Text;
            string lat = txtLat.Text;
            string lang = txtLong.Text;
            int antallTags = lbValgtTags.Items.Count;
            List<string> NyTags = new List<string>();

            foreach (var item in lbValgtTags.Items)
            {
                NyTags.Add(item.ToString());
            }

            string SjekkFeil = RedigerObjekt(Løpenummer_til_redigering, navn, kategori, sikkerhetsklarering, Kommentar, lat, lang, antallTags, LGamleTag, NyTags);

            if (SjekkFeil != string.Empty) MessageBox.Show(SjekkFeil);

            Kart.OppdaterTag_Liste();
        }

        private string RedigerObjekt(int løpenummer, string navn, string kategori, string sikkerhetsklarering, string kommentar, string lat, string lang, int AntallTags, List<string> GamleTags, List<string> nyTags)
        {
            if (løpenummer >= 0)
            {
                string feilmelding = string.Empty;

                string utFyllingsmangler = Tekstbehandling.AltUtfylt_Objekt(navn, kategori, sikkerhetsklarering, kommentar, lat, lang, AntallTags, Globalekonstanter.tekstLatLong_objekt);

                if (utFyllingsmangler == string.Empty)
                {
                    var ressurs = DBComRessurs.ListRessursFromDb(løpenummer);
                    string FeilTallSjekk = Tekstbehandling.sjekkGyldigTallData_objekt(sikkerhetsklarering, lat, lang);
                    if (FeilTallSjekk == string.Empty)
                    {
                        string Endring = Tekstbehandling.SjekkEndringer_Objekt(ressurs, navn, kategori, sikkerhetsklarering, kommentar, lat, lang, GamleTags, nyTags);
                        if (Endring != string.Empty)
                        {
                            string Tittle = "Vil du lagre disse endringene ";
                            bool lagreEndring = FellesMetoder.MeldingsboksYesNo(Tittle, Endring);
                          
                            if (lagreEndring)
                            {
                                try
                                {
                                    DBComRessurs.UpdateRessurs(løpenummer, navn, kategori, Convert.ToInt32(sikkerhetsklarering), kommentar, Convert.ToSingle(lat), Convert.ToSingle(lang));

                                    List<string> SjekkOmNye1 = nyTags.Except(GamleTags).ToList();
                                    List<string> SjekkOmNye2 = GamleTags.Except(nyTags).ToList();
                                    if (SjekkOmNye1.Count != 0 || SjekkOmNye2.Count != 0)
                                    {
                                        //SLETTE ALLE TAGS KNYTTET TIL RESSURS 
                                        DBComTag_Ressurs.DeleteTags_Ressurs(løpenummer);
                                        //LEGGE TIL NYE
                                        foreach (var item in lbValgtTags.Items)
                                        {
                                            DBComTag_Ressurs.InsertTag_RessursToDb(item.ToString(), løpenummer);
                                        }
                                    }
                                }
                                catch (Exception Feilmelding)
                                {
                                    feilmelding = Feilmelding.Message;

                                }
                                //tøme tekstfelt og lister 
                                TømeTekstFeltOgLister();

                                //Oppdatere Liste med ressurser 

                                Kart.OppdaterListe_ressurs();
                                Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LRessurs, GlobaleLister.LOmråde);

                            }
                        }
                        else MessageBox.Show("Ingen Endring");
                    }
                    else MessageBox.Show(FeilTallSjekk);
                }
                else MessageBox.Show(utFyllingsmangler);
                return feilmelding;
            }
            else
            {
                return String.Format("Klikk på objekt du ønsker å endre");
            }

        }

        private void TømeTekstFeltOgLister()
        {
            //tekstfelt
            Løpenummer_til_redigering = -1;
            txtNavn.Text = "";
            txtKategori.Text = "";
            txtKommentar.Text = "";
            txtSikkerhetsklarering.Text = "";
            txtLat.Text = Globalekonstanter.tekstLatLong_objekt;
            txtLong.Text = Globalekonstanter.tekstLatLong_objekt;

            //lister
            lbValgtTags.Items.Clear();
            lbTilgjengeligeTags.Items.Clear();
            LastInnTags();
        }
    }
}
