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
    public class ClienteRepository : BaseDatos
    {
        public ClienteRepository() : base()
        {

        }
        public string RegistrarCliente(Cliente cliente)
        {
            if (cliente == null)
            {
                return "datos invalidos de el cliente";
            }
            string ssql = "INSERT INTO [CLIENTES]([Cedula],[Nombre],[Apellido],[Ciudad],[Direccion],[Fecha_Nacimiento],[Puntuacion],[Genero],[Estado])VALUES" +
                          $"('{cliente.Cedula}','{cliente.Nombre}','{cliente.Apellido}','{cliente.Ciudad}','{cliente.Direccion}','{cliente.FechaNacimiento}'," +
                          $"'{cliente.Puntuacion}','{cliente.Genero}','{cliente.Estado}')";
            SqlCommand cmd = new SqlCommand(ssql, conexion);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();
            if (i >= 1)
            {
                return $"se haregistrado el cliente --> {cliente.Nombre} ";
            }
            return "datos invalidos de el cliente";
        }

        public string ActualizarCliente(Cliente cliente)
        {
            string ssql = $"UPDATE [dbo].[CLIENTES] SET Nombre='{cliente.Nombre}',Apellido='{cliente.Apellido}'," +
                $"Ciudad='{cliente.Ciudad}',Direccion='{cliente.Direccion}',Fecha_Nacimiento='{cliente.FechaNacimiento}', Puntuacion='{cliente.Puntuacion}'," +
                $"Genero='{cliente.Genero}',Estado='{cliente.Estado}' WHERE Id='{cliente.Id}'";
            SqlCommand cmd = new SqlCommand(ssql, conexion);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();
            if (i >= 1)
            {
                return $"se actualizo el cliente con el nombre --> {cliente.Nombre} ";
            }
            return "datos invalidos de el cliente";
        }

        public List<Cliente> ConsultarClientes()
        {
            List<Cliente> list = new List<Cliente>();
            string ssql = "select * from CLIENTES";

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

        private Cliente Mapeo(SqlDataReader reader)
        {
            Cliente cliente = new Cliente();

            cliente.Id = Convert.ToInt32(reader["Id"]);
            cliente.Cedula = Convert.ToString(reader["Cedula"]);
            cliente.Nombre = Convert.ToString(reader["Nombre"]);
            cliente.Apellido = Convert.ToString(reader["Apellido"]);
            cliente.Ciudad = Convert.ToString(reader["Ciudad"]);
            cliente.Direccion = Convert.ToString(reader["Direccion"]);
            cliente.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
            cliente.Puntuacion = Convert.ToInt32(reader["Puntuacion"]);
            cliente.Genero = Convert.ToString(reader["Genero"]);
            cliente.Estado = Convert.ToString(reader["Estado"]);
           
            return cliente;
        }

    }
}
