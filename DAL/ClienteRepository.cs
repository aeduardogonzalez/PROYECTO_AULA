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
            string ssql = "INSERT INTO [CLIENTES]([Cedula],[Nombre],[Apellido],[FechaNacimiento],[Sexo],[Direccion],[Puntuacion],[Estado],[Id_Ciudad])VALUES" +
                          $"('{cliente.Cedula}','{cliente.Nombre}','{cliente.Apellido}', '{cliente.FechaNacimiento}, '{cliente.Genero}' ,'{cliente.Direccion}', '{cliente.Puntuacion}''," +
                          $",  '{cliente.Estado}', '{cliente.Ciudad}')";
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
            string ssql = $"UPDATE [dbo].[CLIENTES] SET Nombre='{cliente.Nombre}',Apellido='{cliente.Apellido}', FechaNacimiento='{cliente.FechaNacimiento}'," +
                $"Sexo='{cliente.Genero}', Direccion='{cliente.Direccion}',  Puntuacion='{cliente.Puntuacion}', Estado='{cliente.Estado}'," +
                $" Id_Ciudad='{cliente.Ciudad}' WHERE Cedula='{cliente.Cedula}'";
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
            
            cliente.Cedula = Convert.ToString(reader["Cedula"]);
            cliente.Nombre = Convert.ToString(reader["Nombre"]);
            cliente.Apellido = Convert.ToString(reader["Apellido"]);
            cliente.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
            cliente.Genero = Convert.ToString(reader["Sexo"]);
            cliente.Direccion = Convert.ToString(reader["Direccion"]);
            cliente.Puntuacion = Convert.ToInt32(reader["Puntuacion"]);
            cliente.Estado = Convert.ToString(reader["Estado"]);
            cliente.Ciudad = Convert.ToString(reader["Id_Ciudad"]);
            return cliente;
        }

    }
}
