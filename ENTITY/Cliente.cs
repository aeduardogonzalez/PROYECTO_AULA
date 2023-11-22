using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Cedula {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Ciudad ciudad {  get; set; }
        public string Direccion { get; set; }
        public string FechaNacimiento {  get; set; }
        public decimal Puntuacion { get; set; }
        public string Genero {  get; set; }
        public string Estado { get; set; }

    }
}
