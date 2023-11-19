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
        public string Ciudad {  get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento {  get; set; }
        public int Puntuacion { get; set; }
        public string Genero {  get; set; }
        public string Estado { get; set; }


        public Cliente()
        {

        }

        public Cliente(string cedula, string nombre, string apellido, string ciudad, string direccion, DateTime fecha_Nacimiento, int puntuacion, string genero, string estado)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Ciudad = ciudad;
            Direccion = direccion;
            FechaNacimiento = fecha_Nacimiento;
            Puntuacion = puntuacion;
            Genero = genero;
            Estado = estado;
        }
    }
}
