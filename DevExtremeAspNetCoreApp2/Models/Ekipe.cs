using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using DevExtremeAspNetCoreApp2.db;

namespace DevExtremeAspNetCoreApp2.Models {
    public class Ekipe
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        /*
        public Ekipe(SqlDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["Id"].ToString());
                Naziv = dr["Naziv"].ToString();
            }
        }
        /*
        public static List<Ekipe> getAll()
        {
            
            List<Ekipe> lista = new List<Ekipe>();
            string sqlUpit = "SELECT * FROM Ekipe";
            SqlDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);

            while (dr.Read())
            {
                Ekipe ekipe = new Ekipe(dr);
                lista.Add(ekipe);
            }
            dr.Close();
            return lista;
        }*/
    }
}
