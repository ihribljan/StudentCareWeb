using DevExtremeAspNetCoreApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreApp1.Models
{
    static class GrupaDData
    {
        public static List<GrupaD> GrupaD = new List<GrupaD>() {
            new GrupaD {
                Id = 13,
                ekipa = "CB Dioniz",
                OU = 3,
                GR = 4, 
                Bodovi = 7
            },
            new GrupaD {
                Id = 14,
                ekipa = "saniTur",
                OU = 3,
                GR = 3,
                Bodovi = 7
            },
            new GrupaD {
                Id = 15,
                ekipa = "Fifi i cvjetno društvo",
                OU = 2,
                GR = -1,
                Bodovi = 0
            },
            new GrupaD {
                Id = 16,
                ekipa = "Kamanje",
                OU = 2,
                GR = -5,
                Bodovi = 0
            }
        };
    }
}
