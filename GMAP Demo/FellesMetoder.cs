using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    public class FellesMetoder
    {
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
            catch (Exception feilmelding)
            {

            }

            return AlleTag;
        }


        public static void FiltreBAserPåTags(ref List<Ressurs> Rlist, List<string> TagFilterListe)
        {

            List<Ressurs> LRessurs = Rlist;

            for (int i = 0; i < LRessurs.Count; i++)
            {
                List<string> TagsItem = LRessurs[i].hentTags(); ;
                int antallTags = TagsItem.Count; //3

                TagsItem = TagsItem.Except(TagFilterListe).ToList();
                int Nåværende= TagsItem.Count;// 


                if((antallTags == Nåværende))
                {
                    LRessurs.RemoveAt(i);
                    i--;
                }
            }
        }

    }
}
