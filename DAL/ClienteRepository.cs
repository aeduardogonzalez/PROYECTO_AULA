using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteRepository
    {
        string fileName = "Cliente.txt";

        public string GuardarClientes(Cliente cliente)
        {
            var escritor = new StreamWriter(fileName, true); 
            escritor.WriteLine(cliente.ToString());
            escritor.Close();
            return $"se agrego la persona {cliente.Nombre} {cliente.Apellido}";
        }

        public string Guardar(List<Cliente> cliente)
        {
            var escritor = new StreamWriter(fileName);
            foreach (var item in cliente)
            {
                escritor.WriteLine(item.ToString());
            }

            escritor.Close();
            return $"archivo actualizado";
        }

        public List<Cliente> ConsultarTodos()
        {
            var listaClientes = new List<Cliente>();
            StreamReader lector = new StreamReader(fileName);
            while (!lector.EndOfStream)
            {
                listaClientes.Add(Map(lector.ReadLine()));
            }
            lector.Close();
            return listaClientes;
        }

        private Cliente Map(string linea)
        {
            var p = new Cliente();
            p.Cedula = linea.Split(';')[0];
            p.Nombre = linea.Split(';')[1];
            p.Apellido = linea.Split(';')[2];
            p.Ciudad = linea.Split(';')[3];
            p.Direccion = linea.Split(';')[4];
            p.Fecha_Nacimiento = DateTime.Parse(linea.Split(';')[5]);
            p.Puntuacion = int.Parse(linea.Split(';')[6]);
            p.Genero = char.Parse(linea.Split(';')[7]);
            p.Estado = char.Parse(linea.Split(';')[8]);
            return p;
        }
    }
}