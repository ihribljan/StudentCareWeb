using DevExtremeAspNetCoreApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreApp1.Models
{
    static class RasporediData
    {
        public static List<Rasporedi> Rasporedi = new List<Rasporedi>() {
            new Rasporedi {
                Id = 1,
                Vrijeme = "09:00",
                Grupa = "A",
                domacin = "Crni biseri",
                gost = "Jazavci Ozalj",
                GoloviDomacin = "2", 
                GoloviGost = "2"
            },
            new Rasporedi {
                Id = 2,
                Vrijeme = "09:25",
                Grupa = "A",
                domacin = "ŠD Kostenjar",
                gost = "Fake profil",
                GoloviDomacin = "0",
                GoloviGost = "5"
            },
            new Rasporedi {
                Id = 3,
                Vrijeme = "09:50",
                Grupa = "B",
                domacin = "Brike",
                gost = "FC Balon",
                GoloviDomacin = "0",
                GoloviGost = "0"
            },
            new Rasporedi {
                Id = 4,
                Vrijeme = "10:15",
                Grupa = "B",
                domacin = "Ekipa iz kvarta",
                gost = "Cicibani",
                GoloviDomacin = "1",
                GoloviGost = "2"
            },
            new Rasporedi {
                Id = 5,
                Vrijeme = "10:40",
                Grupa = "C",
                domacin = "Zorkovac",
                gost = "CB Popaj",
                GoloviDomacin = "3",
                GoloviGost = "2"
            },
            new Rasporedi {
                Id = 6,
                Vrijeme = "11:05",
                Grupa = "C",
                domacin = "CB Dalmatino",
                gost = "Trsnica Žugelj",
                GoloviDomacin = "0",
                GoloviGost = "1"
            },
            new Rasporedi {
                Id = 7,
                Vrijeme = "11:30",
                Grupa = "D",
                domacin = "CB Dioniz",
                gost = "Fifi i cvjetno društvo",
                GoloviDomacin = "1",
                GoloviGost = "0"
            },
            new Rasporedi {
                Id = 8,
                Vrijeme = "11:55",
                Grupa = "D",
                domacin = "Kamanje",
                gost = "saniTur",
                GoloviDomacin = "1",
                GoloviGost = "3"
            },
            new Rasporedi {
                Id = 9,
                Vrijeme = "12:20",
                Grupa = "A",
                domacin = "Crni biseri",
                gost = "ŠD Kostenjar",
                GoloviDomacin = "3",
                GoloviGost = "0"
            },
            new Rasporedi {
                Id = 10,
                Vrijeme = "12:45",
                Grupa = "A",
                domacin = "Jazavci Ozalj",
                gost = "Fake profil",
                GoloviDomacin = "1",
                GoloviGost = "3"
            },
            new Rasporedi {
                Id = 11,
                Vrijeme = "13:10",
                Grupa = "B",
                domacin = "Brike",
                gost = "Ekipa iz kvarta",
                GoloviDomacin = "2",
                GoloviGost = "0"
            },
            new Rasporedi {
                Id = 12,
                Vrijeme = "13:35",
                Grupa = "B",
                domacin = "FC Balon",
                gost = "Cicibani",
                GoloviDomacin = "3",
                GoloviGost = "1"
            },
            new Rasporedi {
                Id = 13,
                Vrijeme = "14:00",
                Grupa = "C",
                domacin = "Zorkovac",
                gost = "CB Dalmatino",
                GoloviDomacin = "1",
                GoloviGost = "0"
            },
            new Rasporedi {
                Id = 14,
                Vrijeme = "14:25",
                Grupa = "C",
                domacin = "CB Popaj",
                gost = "Trsnica Žugelj",
                GoloviDomacin = "0",
                GoloviGost = "1"
            },
            new Rasporedi {
                Id = 15,
                Vrijeme = "14:50",
                Grupa = "D",
                domacin = "CB Dioniz",
                gost = "Kamanje",
                GoloviDomacin = "3",
                GoloviGost = "0"
            },
            new Rasporedi {
                Id = 16,
                Vrijeme = "15:15",
                Grupa = "D",
                domacin = "Fifi i cvjetno društvo",
                gost = "saniTur",
                GoloviDomacin = "0",
                GoloviGost = "1"
            },
            new Rasporedi {
                Id = 17,
                Vrijeme = "15:40",
                Grupa = "A",
                domacin = "Crni biseri",
                gost = "Fake profil",
                GoloviDomacin = "2",
                GoloviGost = "3"
            },
            new Rasporedi {
                Id = 18,
                Vrijeme = "16:05",
                Grupa = "A",
                domacin = "ŠD Kostenjar",
                gost = "Jazavci Ozalj",
                GoloviDomacin = "3",
                GoloviGost = "2"
            },
            new Rasporedi {
                Id = 19,
                Vrijeme = "16:30",
                Grupa = "B",
                domacin = "Brike",
                gost = "Cicibani",
                GoloviDomacin = "1",
                GoloviGost = "3"
            },
            new Rasporedi {
                Id = 20,
                Vrijeme = "16:55",
                Grupa = "B",
                domacin = "Ekipa iz kvarta",
                gost = "FC Balon",
                GoloviDomacin = "1",
                GoloviGost = "2"
            },
            new Rasporedi {
                Id = 21,
                Vrijeme = "17:20",
                Grupa = "C",
                domacin = "Zorkovac",
                gost = "Trsnica Žugelj",
                GoloviDomacin = "2",
                GoloviGost = "3"
            },
            new Rasporedi {
                Id = 22,
                Vrijeme = "17:45",
                Grupa = "C",
                domacin = "CB Dalmatino",
                gost = "CB Popaj",
                GoloviDomacin = "/",
                GoloviGost = "/"
            },
            new Rasporedi {
                Id = 23,
                Vrijeme = "18:00",
                Grupa = "D",
                domacin = "CB Dioniz",
                gost = "saniTur",
                GoloviDomacin = "1",
                GoloviGost = "1"
            },
            new Rasporedi {
                Id = 24,
                Vrijeme = "18:35",
                Grupa = "D",
                domacin = "Kamanje",
                gost = "Fifi i cvjetno društvo",
                GoloviDomacin = "/",
                GoloviGost = "/"
            },
            new Rasporedi {
                Id = 25,
                Vrijeme = "19:00",
                Grupa = "1/4",
                domacin = "Fake profil",
                gost = "Cicibani",
                GoloviDomacin = "5",
                GoloviGost = "0"
            },
            new Rasporedi {
                Id = 26,
                Vrijeme = "19:30",
                Grupa = "1/4",
                domacin = "Crni biseri CB Ronaldo",
                gost = "FC Balon",
                GoloviDomacin = "4",
                GoloviGost = "2"
            },
            new Rasporedi {
                Id = 27,
                Vrijeme = "20:00",
                Grupa = "1/4",
                domacin = "Trsnica Žugelj",
                gost = "saniTur",
                GoloviDomacin = "2 (3)",
                GoloviGost = "2 (2)"
            },
            new Rasporedi {
                Id = 28,
                Vrijeme = "20:30",
                Grupa = "1/4",
                domacin = "Zorkovac",
                gost = "CB Dioniz",
                GoloviDomacin = "0 (3)",
                GoloviGost = "0 (2)"
            },
            new Rasporedi {
                Id = 29,
                Vrijeme = "21:00",
                Grupa = "1/2",
                domacin = "Fake profil",
                gost = "Trsnica Žugelj",
                GoloviDomacin = "4",
                GoloviGost = "1"
            },
            new Rasporedi {
                Id = 30,
                Vrijeme = "21:30",
                Grupa = "1/2",
                domacin = "Crni biseri CB Ronaldo",
                gost = "Zorkovac",
                GoloviDomacin = "4",
                GoloviGost = "1"
            },
            new Rasporedi {
                Id = 31,
                Vrijeme = "22:20",
                Grupa = "3. mjesto",
                domacin = "Trsnica Žugelj",
                gost = "Zorkovac",
                GoloviDomacin = "0 (2)",
                GoloviGost = "0 (3)"
            },
            new Rasporedi {
                Id = 32,
                Vrijeme = "22:50",
                Grupa = "finale",
                domacin = "Crni biseri CB Ronaldo",
                gost = "Fake profil",
                GoloviDomacin = "0",
                GoloviGost = "2"
            }
        };
    }
}
