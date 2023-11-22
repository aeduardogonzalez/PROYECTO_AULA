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
    public class CiudadService
    {
        DAL.CiudadRepository repo = new CiudadRepository();
        public List<Ciudad> ConsultarCiudad()
        {
            var msg = repo.ConsultarCiudad();
            return msg;
        }
    }
}
