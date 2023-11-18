using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace BLL
{
    public interface IFunciones
    {
        string RegistrarCliente(Cliente cliente);
        string ActualizarCliente(Cliente cliente);
        List<Cliente> ConsultarClientes();
    }
}
