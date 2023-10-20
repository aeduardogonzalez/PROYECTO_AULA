using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cliente
    {
        public string Cedula {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Ciudad {  get; set; }
        public string Direccion { get; set; }
        public int Edad {  get; set; }
        public int Puntuacion { get; set; }
        public char Genero {  get; set; }
        public char Estado { get; set; }


        public Cliente()
        {

        }

        public Cliente(string cedula, string nombre, string apellido, string ciudad, string direccion, int edad, int puntuacion, char genero, char estado)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Ciudad = ciudad;
            Direccion = direccion;
            Edad = edad;
            Puntuacion = puntuacion;
            Genero = genero;
            Estado = estado;
        }
    }
}
