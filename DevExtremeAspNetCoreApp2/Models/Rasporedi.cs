using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using DevExtremeAspNetCoreApp2.db;

namespace DevExtremeAspNetCoreApp2.Models
{
    public class Rasporedi
    {

        public int Id { get; set; }
        public string Vrijeme { get; set; }
        public string Grupa { get; set; }
        public int DomacinId { get; set; }
        public int GostId { get; set; }
        public string GoloviDomacin { get; set; }
        public string GoloviGost { get; set; }

        public string domacin { get; set; }
        public string gost { get; set; }
        /*
        public Rasporedi(SqlDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["Id"].ToString());
                Vrijeme = dr["Vrijeme"].ToString();
                Grupa = dr["Grupa"].ToString();
                domacin = dr["domacin"].ToString();
                gost = dr["gost"].ToString();
                DomacinId = int.Parse(dr["DomacinId"].ToString());
                GostId = int.Parse(dr["GostId"].ToString());
                GoloviDomacin = dr["GoloviDomacin"].ToString();
                GoloviGost = dr["GoloviGost"].ToString();
            }
        }

        public static List<Rasporedi> getAll()
        {
            List<Rasporedi> lista = new List<Rasporedi>();

            string sqlUpit = "select r.id, r.Vrijeme, r.Grupa, e.Naziv as 'domacin', ee.Naziv as 'gost', r.DomacinId, r.GostId, r.GoloviDomacin, r.GoloviGost from Rasporedi r join ekipe e on r.domacinid = e.id join ekipe ee on r.gostid = ee.id";

            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);

            while (dr.Read())
            {
                Rasporedi rasporedi = new Rasporedi(dr);
                lista.Add(rasporedi);
            }
            dr.Close();
            return lista;
        }*/
    }
}
