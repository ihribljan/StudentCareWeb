using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using DevExtremeAspNetCoreApp2.db;

namespace DevExtremeAspNetCoreApp2.Models {
    public class GrupaB
    {
        public int Id { get; set; }
        public int EkipeId { get; set; }
        public int OU { get; set; }
        public int GR { get; set; }
        public int Bodovi { get; set; }

        public string ekipa { get; set; }
        /*
        public GrupaB(SqlDataReader dr)
        {
            if (dr != null)
            {
                //Id = int.Parse(dr["Id"].ToString());
                //EkipeId = int.Parse(dr["EkipeId"].ToString());
                ekipa = dr["ekipa"].ToString();
                OU = int.Parse(dr["OU"].ToString());
                GR = int.Parse(dr["GR"].ToString());
                Bodovi = int.Parse(dr["Bodovi"].ToString());
            }
        }

        public static List<GrupaB> getAll()
        {
            List<GrupaB> lista = new List<GrupaB>();

            string sqlUpit = "select e.Naziv as 'ekipa', g.OU, g.GR, g.Bodovi from GrupaB g join Ekipe e on g.EkipeId = e.Id";

            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);

            while (dr.Read())
            {
                GrupaB grupaB = new GrupaB(dr);
                lista.Add(grupaB);
            }
            dr.Close();
            return lista;
        }*/
    }
}