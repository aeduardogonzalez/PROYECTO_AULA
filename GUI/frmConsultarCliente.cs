using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultarCliente : Form
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        BLL.ClienteService clienteService = new BLL.ClienteService();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cargarGrillaPersonas(List<Cliente> clientes)
        {
            dgvConsulta.Rows.Clear();

            if ( clientes != null)
            {
                foreach (var cliente in clientes)
                {
                    int index = dgvConsulta.Rows.Add();
                    DataGridViewRow row = dgvConsulta.Rows[index];
                    row.Cells["Id"].Value = cliente.ID;
                    row.Cells["cedula"].Value = cliente.Cedula;
                    row.Cells["nombre"].Value = cliente.Nombre;
                    row.Cells["Apellido"].Value = cliente.Apellido;
                    row.Cells["FechaNacimiento"].Value = cliente.FechaNacimiento;
                    row.Cells["genero"].Value = cliente.Genero;
                    row.Cells["direccion"].Value = cliente.Direccion;
                    row.Cells["puntuacion"].Value = cliente.Puntuacion;
                    row.Cells["estado"].Value = cliente.Estado;
                    row.Cells["Id_Ciudad"].Value = cliente.ciudad.Id_Ciudad;
                    row.Cells["ciudad"].Value = cliente.ciudad.Nombre_Ciudad;
                }
            }
        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            cargarGrillaPersonas(clienteService.ConsultarClientes());
        }
    }
}
