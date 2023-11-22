using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class CiudadRepository : BaseDatos
    {
        public CiudadRepository() : base()
        {

        }

        public List<Ciudad> ConsultarCiudad()
        {
            List<Ciudad> list = new List<Ciudad>();
            string ssql = "select * from CIUDADES";

            SqlCommand cmd = new SqlCommand(ssql, conexion);
            AbrirConexion();
            SqlDataReader Rdr = cmd.ExecuteReader();

            while (Rdr.Read())
            {
                list.Add(Mapeo(Rdr));
            }
            Rdr.Close();
            CerrarConexion();

            return list;
        }

        private Ciudad Mapeo(SqlDataReader reader)
        {
            Ciudad ciudad = new Ciudad {
                Id_Ciudad = Convert.ToInt32(reader["Id_Ciudad"]),
                Nombre_Ciudad = Convert.ToString(reader["Nombre_Ciudad"])
            };
            

            return ciudad;

        }
    }
}
