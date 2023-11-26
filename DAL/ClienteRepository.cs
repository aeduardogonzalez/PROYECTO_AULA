using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
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
            string ssql = "INSERT INTO CLIENTES(Cedula,Nombre,Apellido,FechaNacimiento,Genero,Direccion,Puntuacion,Estado,Id_Ciudad,Nombre_Ciudad) VALUES" +
            $"('" + cliente.Cedula + "', '" + cliente.Nombre + "', '" + cliente.Apellido + "', '" + cliente.FechaNacimiento + "', '" + cliente.Genero + "' , '" +
            "" + cliente.Direccion + "',  '" + cliente.Puntuacion + "', '" + cliente.Estado + "', '" + cliente.ciudad.Id_Ciudad + "', '" +
            "" + cliente.ciudad.Nombre_Ciudad + "');";
            SqlCommand cmd = new SqlCommand(ssql, conexion);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();
            if (i >= 1)
            {
                return $"se ha registrado el cliente --> {cliente.Nombre} ";
            }
            return "datos invalidos de el cliente";
        }

        public string ActualizarCliente(Cliente cliente)
        {
            string ssql = $"UPDATE[dbo].[CLIENTES] SET Cedula = '{cliente.Cedula}', Nombre = '{cliente.Nombre}', Apellido = '{cliente.Apellido}'," +
                $"FechaNacimiento = '{cliente.FechaNacimiento}', Genero = '{cliente.Genero}', Direccion = '{cliente.Direccion}', Puntuacion = '{cliente.Puntuacion}'," +
                $"Estado = '{cliente.Estado}', Id_Ciudad = '{cliente.ciudad.Id_Ciudad}', Nombre_Ciudad = '{cliente.ciudad.Nombre_Ciudad}' WHERE ID = '{cliente.ID}'";

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
            Cliente cliente = new Cliente
            {
                ID = Convert.ToInt32(reader["ID"]),
                Cedula = Convert.ToString(reader["Cedula"]),
                Nombre = Convert.ToString(reader["Nombre"]),
                Apellido = Convert.ToString(reader["Apellido"]),
                FechaNacimiento = Convert.ToString(reader["FechaNacimiento"]),
                Genero = Convert.ToString(reader["Genero"]),
                Direccion = Convert.ToString(reader["Direccion"]),
                Puntuacion = Convert.ToDecimal(reader["Puntuacion"]),
                Estado = Convert.ToString(reader["Estado"]),
                ciudad = new Ciudad { Id_Ciudad = Convert.ToInt32(reader["Id_Ciudad"]), Nombre_Ciudad = Convert.ToString(reader["Nombre_Ciudad"])},

            };

            return cliente;

        }


    }
}
