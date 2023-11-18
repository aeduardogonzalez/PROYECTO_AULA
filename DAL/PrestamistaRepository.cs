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
    public class PrestamistaRepository : BaseDatos
    {
        public string RegistrarPrestamista(Prestamista prestamista)
        {
            if (prestamista == null)
            {
                return "datos invalidos de el prestamista";
            }
            string ssql = "INSERT INTO [PRESTAMISTAS]([CedulaPrestamista],[NombrePrestamista],[ApellidoPrestamista],[CiudadPrestamista]," +
                          "[DireccionPrestamista],[Usuario],[Contraseña])VALUES" +
                          $"('{prestamista.CedulaPrestamista}','{prestamista.NombrePrestamista}','{prestamista.ApellidoPrestamista}'," +
                          $"'{prestamista.CiudadPrestamista}','{prestamista.DireccionPrestamista}','{prestamista.Usuario}','{prestamista.Contraseña}')";
            SqlCommand cmd = new SqlCommand(ssql, conexion);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();
            if (i >= 1)
            {
                return $"Se ha registrado el prestamista --> {prestamista.NombrePrestamista} ";
            }
            return "datos invalidos de el prestamista";
        }
    }
}
