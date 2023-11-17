using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;
using System.Data;

namespace DAL_ORACLE
{
    public class ClienteRepositoryOracle : BaseDatosOracle
    {
        //public string RegistrarCategoria(Cliente cliente)
        //{
        //    OracleConnection sqlCon = new OracleConnection();
        //    try
        //    {
        //        sqlCon = BaseDatosOracle.getInstancia().CrearConexion();
        //        OracleCommand comando = new OracleCommand("PRC_INSERTAR_CLIENTES", sqlCon);
        //        comando.CommandType = CommandType.StoredProcedure;
        //        comando.Parameters.Add("nombre", OracleDbType.Varchar2).Value = cliente.nomb_categoria;
        //        sqlCon.Open();
        //        comando.ExecuteReader();
        //        return "Se agregó la categoría " + categoria.nomb_categoria;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
        //    }
        //}

        public string RegistrarCliente(Cliente cliente)
        {
            string ssql = "PRC_INSERTAR_CLIENTES";

            AbrirConexion();
            OracleCommand orclCmd1 = conexion.CreateCommand();
            orclCmd1.CommandText = ssql;

            orclCmd1.Parameters.Add(new OracleParameter(":nombre", cliente.Nombre));

            int i = orclCmd1.ExecuteNonQuery();

            CerrarConexion();

            if (i > 0)
            {
                return "Se agregó la categoría " + cliente.Nombre;
            }
            else
            {
                return "No se pudo agregar el cliente.";
            }
        }

        public string Editar(Cliente cliente)
        {
            string ssql = "prc_actualizar_cliente";
            AbrirConexion();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandText = ssql;

            cmd.Parameters.Add(new OracleParameter(":nombre", cliente.Nombre));
            cmd.Parameters.Add(new OracleParameter(":id", cliente.Cedula));


            int i = cmd.ExecuteNonQuery();
            CerrarConexion();

            if (i == 1)
            {
                return $"Se actualizó la categoría con el nombre --> {cliente.Nombre}";
            }
            else if (i == 0)
            {
                return "No se encontró una categoría con el ID especificado.";
            }
            else
            {
                return "Error al actualizar la categoría. Se actualizaron múltiples registros.";
            }
        }

    }
}
