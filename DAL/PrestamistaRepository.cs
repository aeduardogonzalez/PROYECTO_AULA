using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class PrestamistaRepository
    {

        string fileName = "Prestamista.txt";

        public string GuardarPrestamista(Prestamista prestamista)
        {
            var escritor = new StreamWriter(fileName, true);
            escritor.WriteLine(prestamista.ToString());
            escritor.Close();
            return $"se agrego la persona {prestamista.NombrePrestamista} {prestamista.ApellidoPrestamista}";
        }

        public string GuardarP(List<Prestamista> prestamista)
        {
            var escritor = new StreamWriter(fileName);
            foreach (var item in prestamista)
            {
                escritor.WriteLine(item.ToString());
            }

            escritor.Close();
            return $"archivo actualizado";
        }

    }
}
