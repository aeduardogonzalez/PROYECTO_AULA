using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PrestamistaService
    {
        DAL.PrestamistaRepository repo = new PrestamistaRepository();
     
        public string RegistrarCliente(Prestamista prestamista)
        {
            var msg = repo.RegistrarPrestamista(prestamista);
            return msg;
        }
        public List<Prestamista> ConsultarPrestamista()
        {
            var msg = repo.ConsultarPrestamista();
            return msg;
        }

        public List<Prestamista> LoginUser(string usuario, string contraseña)
        {
            return ConsultarPrestamista().Where(u => u.Usuario == usuario && u.Contraseña == contraseña).ToList();
        }
    }
}
