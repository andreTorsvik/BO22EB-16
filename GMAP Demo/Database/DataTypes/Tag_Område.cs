using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO22EB16
{
    internal class Tag_Område
    {
        public int IdOmråde { get; set; } // IdOmråde som skriver til databasen må bruke DEFAULT pga constraintSequence
        public string Tag { get; set; }

    }
}