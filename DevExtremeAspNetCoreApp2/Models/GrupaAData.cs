using DevExtremeAspNetCoreApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreApp1.Models
{
    static class GrupaAData
    {
        public static List<GrupaA> GrupaA = new List<GrupaA>() {
            new GrupaA {
                Id = 1,
                ekipa = "Fake profil",
                OU = 3,
                GR = 8, 
                Bodovi = 9
            },
            new GrupaA {
                Id = 2,
                ekipa = "Crni biseri CB Ronaldo",
                OU = 3,
                GR = 2,
                Bodovi = 4
            },
            new GrupaA {
                Id = 3,
                ekipa = "ŠD Kostenjar",
                OU = 3,
                GR = -7,
                Bodovi = 3
            },
            new GrupaA {
                Id = 4,
                ekipa = "Jazavci Ozalj",
                OU = 3,
                GR = -3,
                Bodovi = 1
            }
        };
    }
}
