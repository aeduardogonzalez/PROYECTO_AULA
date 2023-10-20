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
        private PrestamistaRepository prestamistaRepository = null;
        
        public PrestamistaService()
        {
            prestamistaRepository = new PrestamistaRepository();
        }

        public String GuardarRegistros(Prestamista prestamista)
        {
            if (prestamista.CedulaPrestamista == null || prestamista.NombrePrestamista == null
                || prestamista.ApellidoPrestamista == null || prestamista.DireccionPrestamista == null
                || prestamista.Usuario == null || prestamista.Contraseña == null)
            {
                return $"Campos nulos";
            }
            var message = (prestamistaRepository.GuardarPrestamista(prestamista));
            return message;
        }
    }
}
