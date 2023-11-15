using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using Oracle.ManagedDataAccess.Client;

namespace DAL_ORACLE
{
    public class BaseDatosOracle
    {
        protected OracleConnection conexion = null;    // = new OracleConnection();
        protected string cadena = "user id=USER1;password=123;data source=" +
                                "(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)" +
                                "(HOST=localhost)(PORT=1521))(CONNECT_DATA=" +
                                "(SERVICE_NAME=XE)))";

        public BaseDatosOracle()
        {
            conexion = new OracleConnection(cadena);
        }
        public string AbrirConexion()
        {
            conexion.Open();
            return conexion.State.ToString();
        }

        public string CerrarConexion()
        {
            conexion.Close();
            return conexion.State.ToString();
        }
    }
}
