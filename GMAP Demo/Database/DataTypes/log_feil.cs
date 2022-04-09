
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMAP_Demo
{
    public class log_feil
    {
        public string Feilmelding { get; set; }
        public string klasse { get; set; }
        public string Metode { get; set; }
        public string Dato { get; set; } // Dato_opprettet som skriver til databasen må bruke CURRENT_TIMESTAMP pga DATETIME
    }
}
