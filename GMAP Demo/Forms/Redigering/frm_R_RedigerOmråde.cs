﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;

namespace GMAP_Demo
{
    public partial class frm_R_RedigerOmråde : Form
    {
        public static frm_R_RedigerOmråde instance;
        public int Løpenummer_til_redigering;
        public List<string> LagretTags = new List<string>();
        public frm_R_RedigerOmråde()
        {
            InitializeComponent();
            instance = this;
        }
        public BindingList<PointLatLng> pointLatLngs;
        private void InitializepointLatLngs()
        {
            // Create the new BindingList of Part type.
            pointLatLngs = new BindingList<PointLatLng>();

            // Allow new parts to be added, but not removed once committed.        
            pointLatLngs.AllowNew = true;
            pointLatLngs.AllowRemove = true;

            // Raise ListChanged events when new parts are added.
            pointLatLngs.RaiseListChangedEvents = true;
        }

        private void frm_R_RedigerOmråde_Load(object sender, EventArgs e)
        {
            LastInnTags();
            LastInnFargerMulighet();
            InitializepointLatLngs();
            lbPunkter.DataSource = pointLatLngs;

            LabelSikkerhetsklarering.Text = string.Format("Sikkerhetsklarering(1-{0})", frmVisning.instance.MaxSikkerhetsklarering);
        }

        private void LastInnTags()
        {
            HashSet<string> AlleTag = new HashSet<string>();

            var TagOListe = DatabaseCommunication.ListAllTag_OmrådeFromDb();

            foreach (var item in TagOListe)
            {
                AlleTag.Add(item.Tag.ToString());
            }

            var TagRListe = DatabaseCommunication.ListAllTag_RessursFromDb();

            foreach (var item in TagRListe)
            {
                AlleTag.Add(item.Tag.ToString());
            }

            foreach (var item in AlleTag)
            {
                lbTilgjengeligeTags.Items.Add(item);
            }
            lbTilgjengeligeTags.Sorted = true;
        }
        private void LastInnFargerMulighet()
        {
            foreach (var val in Enum.GetValues(typeof(Kart.MuligeFarger)))
            {
                lbTilgjengligFarge.Items.Add(val);
            }
            lbTilgjengligFarge.Sorted = true;
        }

        private void lbTilgjengeligeTags_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengeligeTags.SelectedItem.ToString();

            lbValgtTags.Items.Add(selectedItemtext);

            lbTilgjengeligeTags.Items.Remove(selectedItemtext);

            lbValgtTags.Sorted = true;
        }

        private void lbValgtTags_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbValgtTags.SelectedItem.ToString();

            lbTilgjengeligeTags.Items.Add(selectedItemtext);

            lbValgtTags.Items.Remove(selectedItemtext);
        }

        private void lbTilgjengligFarge_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedItemtext = lbTilgjengligFarge.SelectedItem.ToString();

            txtfarge.Text = selectedItemtext;
        }

        private void btnLeggTilTag_Click(object sender, EventArgs e)
        {
            string NyTag = "";
            NyTag = txtNyTag.Text;

            if (!string.IsNullOrEmpty(NyTag))
            {

            }
        }

        private void btnLagreEndring_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text;
            string sikkerhetsklarering = txtSikkerhetsklarering.Text;
            string Kommentar = txtKommentar.Text;
            string Farge = txtfarge.Text;
            int antallPunkter = pointLatLngs.Count;
            int antallTags = lbValgtTags.Items.Count;

            string utFyllingsmangler = Tekstbehandling.SjekkInntastetData_Område(navn, sikkerhetsklarering, Kommentar, Farge, antallPunkter, antallTags);

            if (utFyllingsmangler == string.Empty)
            {
                var Lområde = DatabaseCommunication.ListOmrådeFromDb(Løpenummer_til_redigering);
                string FeilTallSjekk = Tekstbehandling.sjekkSikkerhetsKlarering(sikkerhetsklarering);

                if (FeilTallSjekk == string.Empty)
                {
                    //legge til alle punktene 
                    List<PointLatLng> pList = new List<PointLatLng>();
                    foreach (var item in pointLatLngs)
                    {
                        pList.Add(item);
                    }

                    string Endring = Tekstbehandling.SjekkEndringerOmråde(Lområde, navn, sikkerhetsklarering, Kommentar, Farge,pList,antallTags);
                    string enderingIPunkter = Tekstbehandling.sammenlignPunkter(Lområde, pList);
                    if (Endring != string.Empty)
                    {
                        string caption = "Vil du lagre disse endringene ";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        result = MessageBox.Show(Endring, caption, buttons);
                        if (result == DialogResult.Yes)
                        {
                            //Oppdtaer info 
                            DatabaseCommunication.UpdateOmråde(Løpenummer_til_redigering, navn, Convert.ToInt32(sikkerhetsklarering), Kommentar,Farge);

                            
                            if (enderingIPunkter != string.Empty)
                            {
                                //SLETTE ALLE punlter KNYTTET TIL området 
                                DatabaseCommunication.DeletePunkter_området(Løpenummer_til_redigering);
                                //LEGGE TIL NYE punkter
                                int rekkefølge = 0;
                                foreach (var item in pList)
                                {
                                    float lat = Convert.ToSingle(item.Lat);
                                    float lang = Convert.ToSingle(item.Lng);
                                    DatabaseCommunication.InsertPunkter_områdetToDb(Løpenummer_til_redigering, lat, lang, rekkefølge);
                                    rekkefølge++;
                                }
                            }

                            //Oppdatere Liste med ressurser 
                            Løpenummer_til_redigering = -1;
                            txtNavn.Text = "";
                            //txtKategori.Text = "";
                            txtKommentar.Text = "";
                            txtfarge.Text = "";
                            txtSikkerhetsklarering.Text = "";
                            txtLat.Text = "Dobbelklikk på kartet";
                            txtLong.Text = "Dobbelklikk på kartet";
                            txtNrPunkt.Text = "0";
                            Kart.OppdaterListe_området();
                            Kart.OppdaterKart(Kart.MuligKart.Begge, GlobaleLister.LRessurs, GlobaleLister.LOmråde);

                        }
                    }
                    else MessageBox.Show("Ingen Endring");
                }
                else MessageBox.Show(FeilTallSjekk);
            }
            else MessageBox.Show(utFyllingsmangler);
        }

        private void btnLeggTilPunkt_Click(object sender, EventArgs e)
        {
            if ((txtLat.Text != null) && (txtLong.Text != null) && (txtLat.Text != "Dobbelklikk på kartet + \"legg til\""))
            {
                try
                {
                    double lat = Convert.ToDouble(txtLat.Text);
                    double lng = Convert.ToDouble(txtLong.Text);
                    int rekkefølge = pointLatLngs.Count;
                    PointLatLng point = new PointLatLng(lat, lng);

                    pointLatLngs.Add(point);

                    Kart.LeggtilMarkør(Kart.MuligKart.Redigering, point, rekkefølge, "MarkørForOmråde");
                    Kart.FjernAlleMarkører_redigier("HjelpeMarkør");
                    Kart.reff(Kart.MuligKart.Redigering);

                    txtLat.Text = "Dobbelklikk på kartet + \"legg til\"";
                    txtLong.Text = "Dobbelklikk på kartet + \"legg til\"";
                    txtNrPunkt.Text = (pointLatLngs.Count).ToString();
                }
                catch (Exception feilmelding)
                {
                    DatabaseCommunication.LogFeil(GetType().Name, System.Reflection.MethodBase.GetCurrentMethod().Name, feilmelding.Message);
                }
            }
        }

        private void btnFjernPunktIListe_Click(object sender, EventArgs e)
        {
            if (pointLatLngs.Count > 0)
            {
                Kart.FjernAlleMarkører_redigier("MarkørForOmråde");
                pointLatLngs.Clear();
                txtNrPunkt.Text = "0";
            }
        }
    }
}
