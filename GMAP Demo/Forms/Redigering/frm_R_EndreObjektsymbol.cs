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
    public partial class Frm_R_EndreObjektsymbol : Form
    {
        public static Frm_R_EndreObjektsymbol instance;
        public Image image = null;
        public byte[] imageData;
        public string valgtKategori;

        public Frm_R_EndreObjektsymbol()
        {
            InitializeComponent();
            instance = this;
            SetTheme();
        }

        private void SetTheme()
        {
            instance.BackColor = ThemeDesign.colorBackground;

            lblTitle.ForeColor = ThemeDesign.colorOrange;

            gbKategori.ForeColor = ThemeDesign.colorLabel;
            gbKategori.BackColor = ThemeDesign.colorBackground;
            lblTilgjengeligeKategorier.ForeColor = ThemeDesign.colorLabel;
            lblValgtKategori.ForeColor = ThemeDesign.colorLabel;
            lbTilgjengligKategorier.ForeColor = ThemeDesign.colorLabel;
            lbTilgjengligKategorier.BackColor = ThemeDesign.colorGray;
            tbValgtKategori.ForeColor = ThemeDesign.colorLabel;
            tbValgtKategori.BackColor = ThemeDesign.colorGray4;

            gbBilde.ForeColor = ThemeDesign.colorLabel;
            gbBilde.BackColor = ThemeDesign.colorBackground;
            lblVelgBilde.ForeColor = ThemeDesign.colorLabel;
            lblValgtBilde.ForeColor = ThemeDesign.colorLabel;
            lblVelgBilde.ForeColor = ThemeDesign.colorLabel;
            btnLVelgBildeFraFiler.ForeColor = ThemeDesign.colorLabel;
            btnLVelgBildeFraFiler.BackColor = ThemeDesign.colorGray;

            gblLastOppTilDB.ForeColor = ThemeDesign.colorLabel;
            gblLastOppTilDB.BackColor = ThemeDesign.colorBackground;
            btnLeggTilIDb.ForeColor = ThemeDesign.colorLabel;
            btnLeggTilIDb.BackColor = ThemeDesign.colorGray;


            pbValgtBilde.BackColor = ThemeDesign.colorGray;
            pbValgtKategori.BackColor = ThemeDesign.colorGray;
        }

        private void LbTilgjengligKategorier_DoubleClick(object sender, EventArgs e)
        {
            if (lbTilgjengligKategorier.SelectedIndex != -1)
            {
                if (lbTilgjengligKategorier.SelectedIndex.ToString() != null)
                {
                    string selectedItemtext = lbTilgjengligKategorier.SelectedItem.ToString();

                    tbValgtKategori.Text = selectedItemtext;
                    valgtKategori = tbValgtKategori.Text.ToString();

                    // vis bilde hvis tilgjengelig
                    List<Kategorier_Bilde> kategori = DBComKategorier_Bilde.GetBildeForKategoriFromDbKategorier_Bilde(valgtKategori);
                    if (kategori[0].Bilde != null) // Sjekk om kategori har bilde
                    {
                        image = Bildebehandling.byteArrayToImage(kategori[0].Bilde);

                        pbValgtKategori.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbValgtKategori.Image = image;
                        pbValgtKategori.Visible = true;

                    }
                    else
                    {
                        pbValgtKategori.Visible = false;
                    }
                }
            }
            
        }

        private void BtnLeggTilBilde_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            string filepath = null;

            if (DialogResult.OK == dialog.ShowDialog())
            {
                filepath = dialog.FileName;
            }

            if(filepath != null)
            {

                try
                {
                    image = Image.FromFile(filepath);
                    imageData = Bildebehandling.ImageToByteArray(image);

                    pbValgtBilde.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbValgtBilde.Image = image;
                }
                catch (Exception)
                {
                    MessageBox.Show("Det oppstod et problem med å hente inn bilde, vennligst prøv igjen", "Problemer med innhenting av bilde.");
                }
            }          
        }

        private void Frm_S_LeggTilBilde_Load(object sender, EventArgs e)
        {
            var KategoriListe = DBComKategorier_Bilde.ListAllKategorier_BildeFromDb();

            foreach (var item in KategoriListe)
            {
                GlobaleLister.LKategori.Add(item);
                lbTilgjengligKategorier.Items.Add(item.Kategorinavn);
            }
        }

        private void BtnLeggTilIDb_Click(object sender, EventArgs e)
        {
            if ((valgtKategori != null) && (imageData != null)) //
            {
                DBComKategorier_Bilde.InsertBildeToChosenKategorier_BildeToDb(valgtKategori, imageData);///valgtKategori
                pbValgtKategori.Visible = false;
                pbValgtBilde.Image = null;
                tbValgtKategori.Text = "";
                lbTilgjengligKategorier.ClearSelected();
                valgtKategori = null;
                imageData = null;

                OppdaterKart();
            }
            else if ((valgtKategori == null) && (imageData != null))// valgtKategori == null
            {
                MessageBox.Show("Vennligst velg en kategori, fra listen, som dette bilde skal knyttes til.", "Kunne ikke utføre oppgaven!");
            }
            else if ((valgtKategori != null) && (imageData == null)) //(valgtKategori != null)
            {
                MessageBox.Show("Vennligst velg et bilde som skal knyttes til den valgte kategorien.", "Kunne ikke utføre oppgaven!");
            }
            else MessageBox.Show("Du har ikke valgt en kategori, og har heller ikke valgt et bilde.", "Kunne ikke utføre oppgaven!");
        }

        private void BtnFjernBilde_Click(object sender, EventArgs e)
        {
            if (valgtKategori != null)
            {
                DBComKategorier_Bilde.DeleteBildeFromKategorier_Bilde(valgtKategori);
                pbValgtKategori.Visible = false;
                pbValgtBilde.Image = null;
                tbValgtKategori.Text = "";
                lbTilgjengligKategorier.ClearSelected();
                valgtKategori = null;
                imageData = null;

                OppdaterKart();
            }
            else
            {
                MessageBox.Show("Vennligst velg en kategori fra listen, for å fjerne tilknyttet bilde.", "Kunne ikke utføre oppgaven!");
            }
        }

        private void OppdaterKart()
        {
            //Kart.OppdaterListe_ressurs();
            Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LObjekt, GlobaleLister.LOmråde);
        }
    }
}
