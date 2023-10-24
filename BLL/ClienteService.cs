using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteService
    {
        private ClienteRepository ClienteRepository = null;
        private List<Cliente> ClienteList = null;
        public ClienteService()
        {
            ClienteRepository = new ClienteRepository();
            ClienteList = ClienteRepository.ConsultarTodos();

        }

        public String GuardarRegistros(Cliente cliente)
        {
            if (cliente.Cedula == null || cliente.Nombre == null || cliente.Apellido == null
                || cliente.Ciudad == null || cliente.Direccion == null || cliente.Fecha_Nacimiento == null
                || cliente.Puntuacion == 0 || cliente.Genero == ' ' || cliente.Estado == ' ')
            {
                return $"Campos nulos";
            }
            var message = (ClienteRepository.GuardarClientes(cliente));
            ClienteList = ClienteRepository.ConsultarTodos();
            return message;
        }

        public List<Cliente> ConsultarTodos()
        {
            return ClienteList;
        }

        //public string Eliminar(string CedulaAEliminar)
        //{
        //    try
        //    {
        //        var ClienteAEliminar = ClienteList.FirstOrDefault(p => p.Cedula == CedulaAEliminar);
        //
        //        if (ClienteAEliminar != null)
        //        {
        //            ClienteList.Remove(ClienteAEliminar);
        //            ClienteRepository.Guardar(ClienteList);
        //            return "Registro eliminado con éxito.";
        //        }
        //        else
        //        {
        //            return "No se encontró un registro con el ID proporcionado.";
        //        }
        //    }
        //    catch (IOException)
        //    {
        //        return "Ocurrió un error al intentar eliminar el registro.";
        //    }
        //}

        public Cliente BuscarPorId(string id)
        {
            foreach (var item in ClienteList)
            {
                if (id == item.Cedula)
                {
                    return item;
                }
            }
            return null;
        }


        public List<Cliente> Consultar()
        {
            return ClienteList;
        }


        public List<Cliente> FiltroDeConsulta(string filtro)
        {
            if (filtro == "")
            {
                return ClienteList;
            }
            List<Cliente> lista = new List<Cliente>();
            foreach (var item in ClienteList)
            {
                if (item.Nombre.Contains(filtro) || item.Cedula.StartsWith(filtro))
                {
                    lista.Add(item);
                }
            }
            return lista;
        }

        public string ModificarRegistro(string cedula, Cliente cliente)
        {
            try
            {
                var ClienteAModificar = ClienteList.FirstOrDefault(p => p.Cedula == cedula);

                if (ClienteAModificar != null)
                {
                    ClienteAModificar.Nombre = cliente.Nombre;

                    ClienteRepository.Guardar(ClienteList);
                    return "Registro modificado con éxito.";
                }
                else
                {
                    return "No se encontró un registro con el ID de la liquidación proporcionado.";
                }
            }
            catch (IOException)
            {
                return "Ocurrió un error al intentar modificar el registro.";
            }
        }

    }
}