using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Prestamista
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public Prestamista()
        {

        }

        public Prestamista(string usuario, string contraseña)
        {
            Usuario = usuario;
            Contraseña = contraseña;
        }
    }
}
