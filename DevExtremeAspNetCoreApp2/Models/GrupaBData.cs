using DevExtremeAspNetCoreApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreApp1.Models
{
    static class GrupaBData
    {
        public static List<GrupaB> GrupaB = new List<GrupaB>() {
            new GrupaB {
                Id = 5,
                ekipa = "FC Balon",
                OU = 3,
                GR = 3, 
                Bodovi = 7
            },
            new GrupaB {
                Id = 6,
                ekipa = "Cicibani",
                OU = 3,
                GR = 1,
                Bodovi = 6
            },
            new GrupaB {
                Id = 7,
                ekipa = "Brike",
                OU = 3,
                GR = 0,
                Bodovi = 4
            },
            new GrupaB {
                Id = 8,
                ekipa = "Ekipa iz kvarta",
                OU = 3,
                GR = -4,
                Bodovi = 0
            }
        };
    }
}
