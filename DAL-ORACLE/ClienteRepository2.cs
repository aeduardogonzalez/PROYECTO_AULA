using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL_ORACLE
{
    public class ClienteRepository2 : BaseDatos
    {
        public ClienteRepository2() : base()
        {

        }
        public string InsertarPersona(Cliente cliente)
        {
            if (cliente == null)
            {
                return "datos invalidos de la persona";
            }
            string ssql = "INSERT INTO [Personas]([Cedula],[Nombre],[Telefono],[FechaNacimiento])VALUES" +
                $"('{cliente.Cedula}','{cliente.Nombre}','{cliente.Apellido}','{cliente.Ciudad}')";
            SqlCommand cmd = new SqlCommand(ssql, conexion);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();
            if (i >= 1)
            {
                return $"se guardo la persona --> {cliente.Nombre} ";
            }
            return "datos invalidos de la persona";
        }

        public string EditarPersona(Cliente cliente)
        {
            string ssql = $"UPDATE [dbo].[Personas] SET [Cedula] = '{cliente.Cedula}', Nombre='{cliente.Nombre}',Telefono='{cliente.Apellido}',FechaNacimiento='{cliente.Ciudad}' WHERE ID='{cliente.Cedula}'";
            SqlCommand cmd = new SqlCommand(ssql, conexion);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();
            if (i >= 1)
            {
                return $"se actualizo la persona con el nombre--> {cliente.Nombre} ";
            }
            return "datos invalidos de la persona";
        }

        public List<Cliente> ObtenerTodos()
        {
            List<Cliente> list = new List<Cliente>();
            string ssql = "select * from clientes";

            SqlCommand cmd = new SqlCommand(ssql, conexion);
            AbrirConexion();
            SqlDataReader Rdr = cmd.ExecuteReader();

            while (Rdr.Read())
            {
                list.Add(Mapear(Rdr));
            }
            Rdr.Close();
            CerrarConexion();

            return list;

        }

        private Cliente Mapear(SqlDataReader reader)
        {
            Cliente persona = new Cliente();

            persona.Cedula = Convert.ToString(reader["Cedula"]);
            persona.Nombre = Convert.ToString(reader["Nombre"]);
            persona.Apellido = Convert.ToString(reader["Telefono"]);
            persona.Ciudad = Convert.ToString(reader["FechaNacimiento"]);

            return persona;
        }

    }
}
