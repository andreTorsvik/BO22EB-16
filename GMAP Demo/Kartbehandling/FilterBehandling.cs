using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO22EB16
{
    public class FilterBehandling
    {
        public static void filtrereBaserPåTagsAND(ref List<Objekt> olist, List<string> TagFilterListe)
        {
            // Metode for å filtere objekter
            // Filter med AND, det vil si: alt på "TagFilterListe" må stemme 

            if (TagFilterListe.Count > 0)
            {
                List<Objekt> listObjekt = olist;

                for (int i = 0; i < listObjekt.Count; i++)
                {
                    // Henter tag(s) til det aktuelle objektet 
                    List<string> TagsItem = listObjekt[i].hentTags();
                    int antallTags = TagsItem.Count;
                    
                    // Antallet må være likt for at alt skal stemme 
                    if ((antallTags == TagFilterListe.Count))
                    {
                        
                        TagsItem = TagsItem.Except(TagFilterListe).ToList();
                        int gjenværende = TagsItem.Count;

                        // Hvis "gjenværende" er forskjellig fra 0, betyr det at
                        // "TagFilterListe" og "TagsItem" ikke er identiske 
                        if (gjenværende != 0) 
                        {
                            listObjekt.RemoveAt(i);
                            i--;
                        }
                    }
                    else
                    {
                        listObjekt.RemoveAt(i);
                        i--;
                    }
                }
            }
            else
            {
                List<Objekt> listObjekt = olist;

                listObjekt.Clear();
            }
        }

        public static void filtrereBaserPåTagsAND(ref List<Område> Olist, List<string> TagFilterListe)
        {
            // Metode for å filtere områder/polygon
            // Filter med AND, det vil si: alt på "TagFilterListe" må stemme 

            if (TagFilterListe.Count > 0)
            {
                List<Område> LOmråde = Olist;

                for (int i = 0; i < LOmråde.Count; i++)
                {
                    // Henter tag(s) til den aktuelle området 
                    List<string> TagsItem = LOmråde[i].hentTags(); ;
                    int antallTags = TagsItem.Count;

                    // Antallet må være likt for at alt skal stemme 
                    if ((antallTags == TagFilterListe.Count) )
                    {
                        TagsItem = TagsItem.Except(TagFilterListe).ToList();
                        int gjenværende = TagsItem.Count;

                        // Hvis "gjenværende" er forskjellig fra 0, betyr det at
                        // "TagFilterListe" og "TagsItem" ikke er identiske 
                        if (gjenværende != 0)  
                        {
                            LOmråde.RemoveAt(i);
                            i--;
                        }
                    }
                    else
                    {
                        LOmråde.RemoveAt(i);
                        i--;
                    }
                }
            }
            else
            {
                List<Område> LOmråde = Olist;

                LOmråde.Clear();
            }
        }

        public static void filtrereBaserPåTagsOR(ref List<Objekt> Rlist, List<string> TagFilterListe)
        {
            // Metode for å filtere objekter
            // Filter med OR, det vil si: Kun en tag fra "TagFilterListe" må stemme 

            if (TagFilterListe.Count > 0)
            {
                List<Objekt> listObjekt = Rlist;

                for (int i = 0; i < listObjekt.Count; i++)
                {
                    // Henter tag(s) til det aktuelle objektet 
                    List<string> TagsItem = listObjekt[i].hentTags(); ;
                    int antallTags = TagsItem.Count; 

                    // Sjekker om de har noen til felles 
                    TagsItem = TagsItem.Except(TagFilterListe).ToList();
                    int gjenværende = TagsItem.Count; 

                    if ((antallTags == gjenværende)) // Ingen like 
                    {
                        listObjekt.RemoveAt(i);
                        i--;
                    }
                }
            }
            else
            {
                List<Objekt> listObjekt = Rlist;

                listObjekt.Clear();
            }
        }

        public static void filtrereBaserPåTagsOR(ref List<Område> Olist, List<string> TagFilterListe)
        {
            // Metode for å filtere områder/polygon
            // Filter med OR, det vil si: Kun en tag fra "TagFilterListe" må stemme

            if (TagFilterListe.Count > 0)
            {
                List<Område> LOmråde = Olist;

                for (int i = 0; i < LOmråde.Count; i++)
                {
                    // Henter tag(s) til det aktuelle objektet
                    List<string> TagsItem = LOmråde[i].hentTags(); ;
                    int antallTags = TagsItem.Count;

                    // Sjekker om de har noen til felles 
                    TagsItem = TagsItem.Except(TagFilterListe).ToList();
                    int gjenværende = TagsItem.Count;

                    if ((antallTags == gjenværende)) // Ingen like 
                    {
                        LOmråde.RemoveAt(i);
                        i--;
                    }
                }
            }
            else
            {
                List<Område> LOmråde = Olist;

                LOmråde.Clear();
            }
        }

    }
}
