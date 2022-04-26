using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    public class FilterBehandling
    {
        public static void filtrereBaserPåTagsAND(ref List<Ressurs> Rlist, List<string> TagFilterListe)
        {
            if (TagFilterListe.Count > 0)
            {
                List<Ressurs> LRessurs = Rlist;

                for (int i = 0; i < LRessurs.Count; i++)
                {
                    List<string> TagsItem = LRessurs[i].hentTags();
                    int antallTags = TagsItem.Count;
                    
                    if ((antallTags == TagFilterListe.Count))
                    {
                        TagsItem = TagsItem.Except(TagFilterListe).ToList();
                        int gjenværende = TagsItem.Count;

                        if (gjenværende != 0) //må ha alle like 
                        {
                            LRessurs.RemoveAt(i);
                            i--;
                        }
                    }
                    else
                    {
                        LRessurs.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        public static void filtrereBaserPåTagsAND(ref List<Område> Olist, List<string> TagFilterListe)
        {
            if (TagFilterListe.Count > 0)
            {
                List<Område> LOmråde = Olist;

                for (int i = 0; i < LOmråde.Count; i++)
                {
                    List<string> TagsItem = LOmråde[i].hentTags(); ;
                    int antallTags = TagsItem.Count; 

                    if ((antallTags == TagFilterListe.Count) )
                    {
                        TagsItem = TagsItem.Except(TagFilterListe).ToList();
                        int gjenværende = TagsItem.Count;

                        if (gjenværende != 0) //må ha alle like 
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
        }

        public static void filtrereBaserPåTagsOR(ref List<Ressurs> Rlist, List<string> TagFilterListe)
        {
            if (TagFilterListe.Count > 0)
            {
                List<Ressurs> LRessurs = Rlist;

                for (int i = 0; i < LRessurs.Count; i++)
                {
                    List<string> TagsItem = LRessurs[i].hentTags(); ;
                    int antallTags = TagsItem.Count; 

                    TagsItem = TagsItem.Except(TagFilterListe).ToList();
                    int gjenværende = TagsItem.Count; 

                    if ((antallTags == gjenværende)) // ingen like 
                    {
                        LRessurs.RemoveAt(i);
                        i--;
                    }
                }
            }
            else
            {
                List<Ressurs> LRessurs = Rlist;

                LRessurs.Clear();
            }
        }

        public static void filtrereBaserPåTagsOR(ref List<Område> Olist, List<string> TagFilterListe)
        {
            if(TagFilterListe.Count > 0)
            {
                List<Område> LOmråde = Olist;

                for (int i = 0; i < LOmråde.Count; i++)
                {
                    List<string> TagsItem = LOmråde[i].hentTags(); ;
                    int antallTags = TagsItem.Count; 

                    TagsItem = TagsItem.Except(TagFilterListe).ToList();
                    int gjenværende = TagsItem.Count;

                    if ((antallTags == gjenværende)) // ingen like 
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
