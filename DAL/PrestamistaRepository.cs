﻿using System;
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
            string ssql = "INSERT INTO [PRESTAMISTAS]([Usuario],[Contraseña])VALUES" +
                          $"('{prestamista.Usuario}','{prestamista.Contraseña}')";
            SqlCommand cmd = new SqlCommand(ssql, conexion);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();
            if (i >= 1)
            {
                return $"Se ha registrado el prestamista --> {prestamista.Usuario}";
            }
            return "datos invalidos de el prestamista";
        }

        public List<Prestamista> ConsultarPrestamista()
        {
            List<Prestamista> list = new List<Prestamista>();
            string ssql = "select * from PRESTAMISTAS";

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
        private Prestamista Mapear(SqlDataReader reader)
        {
            Prestamista prestamista = new Prestamista();

            prestamista.Usuario = Convert.ToString(reader["Usuario"]);
            prestamista.Contraseña = Convert.ToString(reader["Contraseña"]);

            return prestamista;
        }

    }
}
