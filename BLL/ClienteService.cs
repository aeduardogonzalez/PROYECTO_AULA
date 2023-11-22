using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class ClienteService : IFunciones
    {
        DAL.ClienteRepository repo = new ClienteRepository();

        public string RegistrarCliente(Cliente cliente)
        {
            var msg = repo.RegistrarCliente(cliente);
            return msg;
        }
        
        public string ActualizarCliente(Cliente cliente)
        {
            return repo.ActualizarCliente(cliente);
        }

        public List<Cliente> ConsultarClientes()
        {
            var msg = repo.ConsultarClientes();
            return msg;
        }

        public List<Cliente> BuscarX(string x)
        {
            return ConsultarClientes().Where(item => item.Cedula == x || item.ciudad.Nombre_Ciudad.Contains(x) || item.Genero.Contains(x)
                    || item.Estado.Contains(x)).ToList();
        }
    }
}