using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO22EB16
{
    internal class Tag_Objekt
    {
        public int IdObjekt { get; set; } // IdObjekt som skriver til databasen må bruke DEFAULT pga constraintSequence
        public string Tag { get; set; }

    }
}