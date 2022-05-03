using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GMAP_Demo
{
    public class FellesMetoder
    {
        public static void OppdaterListe_området() // Vurdere å flyttet
        {
            // Tømmer listen
            GlobaleLister.LOmråde.Clear();

            // Henter alle områdene
            var OmrådeListe = DBComOmråde.ListAllOmrådeFromDb();

            // Legger dem til i den globale listen 
            foreach (var item in OmrådeListe)
            {
                GlobaleLister.LOmråde.Add(item);
            }

            // Filterer ut områder basert på tag 
            if (GlobaleLister.tag_ListeVises.Count != 0)
            {
                // Finner ut hvilket filter man skal bruke 
                bool OR = frmFilter.instance.filterOR;
                bool AND = frmFilter.instance.filterAND;

                if (OR && !AND) // OR
                {
                    if (GlobaleLister.kategoriListeSkjult.Count != 0 || GlobaleLister.tag_ListeSkjult.Count != 0)
                    {
                        FilterBehandling.filtrereBaserPåTagsOR(ref GlobaleLister.LOmråde, GlobaleLister.tag_ListeVises.ToList());
                    }
                }
                else if (AND && !OR) // AND
                    FilterBehandling.filtrereBaserPåTagsAND(ref GlobaleLister.LOmråde, GlobaleLister.tag_ListeVises.ToList());
            }
            else // ingen valgte tags 
            {
                GlobaleLister.LOmråde.Clear();
            }

        }

        public static void OppdaterListe_ressurs() // Vurdere å flyttet
        {
            // Tømmerlisten 
            if (GlobaleLister.LRessurs.Count > 0) GlobaleLister.LRessurs.Clear();

            // Henter alle ressurser
            var RessursList = DBComRessurs.ListAllRessursFromDb(InnloggetBruker.Sikkerhetsklarering);

            // Legger til i den globale listen, men basert på kategorilisten 
            foreach (var item in RessursList)
            {
                foreach (var item2 in GlobaleLister.kategoriListeVises)
                {
                    if (item.Kategori.ToString() == item2.Kategorinavn.ToString())
                    {
                        GlobaleLister.LRessurs.Add(item);
                        break;
                    }
                }
            }

            // Filtrering ut objekter baser på tag
            if (GlobaleLister.kategoriListeVises.Count != 0 || GlobaleLister.tag_ListeVises.Count != 0)
            {
                // Finner ut hvilket filter man skal bruke 
                bool OR = frmFilter.instance.filterOR;
                bool AND = frmFilter.instance.filterAND;

                if (OR && !AND) // OR
                {
                    if (GlobaleLister.kategoriListeSkjult.Count != 0 || GlobaleLister.tag_ListeSkjult.Count != 0)
                    {
                        FilterBehandling.filtrereBaserPåTagsOR(ref GlobaleLister.LRessurs, GlobaleLister.tag_ListeVises.ToList());
                    }
                }
                else if (AND && !OR) // AND
                    FilterBehandling.filtrereBaserPåTagsAND(ref GlobaleLister.LRessurs, GlobaleLister.tag_ListeVises.ToList());
            }
            else // Ingen valgte tags 
            {
                GlobaleLister.LRessurs.Clear();
            }
        }

        public static void OppdaterTag_Liste() // Vurdere å flyttet
        {
            //oppdatere Vises tagliste 

            // Tømer hvis den har innhold 
            if (GlobaleLister.tag_ListeVises.Count > 0) GlobaleLister.tag_ListeVises.Clear();

            // Henter alle tags fra databasen
            HashSet<string> tag_ListeAlle = new HashSet<string>();
            tag_ListeAlle = FellesMetoder.FåAlleTags();

            // Henter alle "skjulte" tags 
            List<string> ListsjultTags = GlobaleLister.tag_ListeSkjult.ToList();

            // Sorter ut alle de "skjulte" fra alle tags  
            List<string> ListeVisteTags = tag_ListeAlle.Except(ListsjultTags).ToList();

            //oppdatere TagVisteListe
            foreach (var item in ListeVisteTags)
            {
                GlobaleLister.tag_ListeVises.Add(item);
            }

            //oppdatere  skjulte taglisten:

            //tømer listen 
            if (GlobaleLister.tag_ListeSkjult.Count > 0) GlobaleLister.tag_ListeSkjult.Clear();

            // Sorter ut alle de "synlige" fra alle tags 
            ListsjultTags = tag_ListeAlle.Except(ListeVisteTags).ToList();

            //legger dem til 
            if (ListsjultTags.Count != 0)
            {
                foreach (var item in ListsjultTags)
                {
                    GlobaleLister.tag_ListeSkjult.Add(item);
                }
            }
        }


        public static void OppdaterKategoriListe()
        {
            GlobaleLister.kategoriListeVises.Clear();

            List<Kategorier_Bilde> kategoriListeAlle = new List<Kategorier_Bilde>();
            kategoriListeAlle = DBComKategorier_Bilde.ListAllKategorier_BildeFromDb();
            foreach (var item in kategoriListeAlle)
            {
                GlobaleLister.kategoriListeVises.Add(item);
            }
        }
        public static HashSet<string> FåAlleTags()
        {
            HashSet<string> AlleTag = new HashSet<string>();

            try
            {
                var TagOListe = DBComTag_Område.ListAllTag_OmrådeFromDb();
                foreach (var item in TagOListe)
                {
                    AlleTag.Add(item.Tag.ToString());
                }

                var TagRListe = DBComTag_Ressurs.ListAllTag_RessursFromDb();
                foreach (var item in TagRListe)
                {
                    AlleTag.Add(item.Tag.ToString());
                }

            }
            catch (Exception)
            {

            }

            return AlleTag;

        }
        public static bool MeldingsboksYesNo(string Tittle, string tekst)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(tekst, Tittle, buttons);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
