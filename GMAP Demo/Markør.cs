using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;

namespace GMAP_Demo
{
    public class Markør
    {
        public int Rekkefølge { get; set; }
        public double lang { get; set; }
        public double lat { get; set; }

        public PointLatLng giPunkt()
        {
            return new PointLatLng(lat, lang);
        }
    }
}
