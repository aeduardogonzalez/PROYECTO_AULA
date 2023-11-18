using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Prestamista
    {
        public string CedulaPrestamista {  get; set; }
        public string NombrePrestamista { get; set; }
        public string ApellidoPrestamista { get; set; }
        public string CiudadPrestamista { get; set; }
        public string DireccionPrestamista { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public Prestamista()
        {

        }

        public Prestamista(string identificacion, string nombre, string apellido, string ciudad, string direccion, string usuario, string contraseña)
        {
            CedulaPrestamista = identificacion;
            NombrePrestamista = nombre;
            ApellidoPrestamista = apellido;
            CiudadPrestamista = ciudad;
            DireccionPrestamista = direccion;
            Usuario = usuario;
            Contraseña = contraseña;
        }
    }
}
