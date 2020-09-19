using DevExtremeAspNetCoreApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreApp1.Models
{
    static class GrupaCData
    {
        public static List<GrupaC> GrupaC = new List<GrupaC>() {
            new GrupaC {
                Id = 9,
                ekipa = "Trsnica Žugelj",
                OU = 3,
                GR = 2, 
                Bodovi = 9
            },
            new GrupaC {
                Id = 10,
                ekipa = "Zorkovac",
                OU = 3,
                GR = 1,
                Bodovi = 6
            },
            new GrupaC {
                Id = 11,
                ekipa = "CB Popaj",
                OU = 2,
                GR = -2,
                Bodovi = 0
            },
            new GrupaC {
                Id = 12,
                ekipa = "CB Dalmatino",
                OU = 2,
                GR = -2,
                Bodovi = 0
            }
        };
    }
}
