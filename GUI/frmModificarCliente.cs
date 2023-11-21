using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
namespace GUI
{
    public partial class frmModificarCliente : Form
    {
        BLL.ClienteService clienteService = new BLL.ClienteService();

        public frmModificarCliente()
        {
            InitializeComponent();
        }

        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            cargarGrillaClientes();
        }

        private void cargarGrillaClientes()
        {
            dgvClientes.DataSource = clienteService.ConsultarClientes();
            dgvClientes.Columns[0].Visible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.RowHeadersVisible = false;
        }

        private void dgvClientes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var fila = dgvClientes.Rows[e.RowIndex];
            Cliente cliente = new Cliente
            {
                Cedula = fila.Cells[0].Value.ToString(),
                Nombre = fila.Cells[1].Value.ToString(),
                Apellido = fila.Cells[2].Value.ToString(),
                FechaNacimiento = Convert.ToDateTime(fila.Cells[5].Value),
                Genero = fila.Cells[7].Value.ToString(),
                Direccion = fila.Cells[4].Value.ToString(),
                Puntuacion = Convert.ToInt32(fila.Cells[6].Value),
                Estado = fila.Cells[8].Value.ToString(),
                Ciudad = fila.Cells[3].Value.ToString(),
              
            };
            var respuesta = MessageBox.Show("desea actualizar los datos ", "actualizar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                clienteService.ActualizarCliente(cliente);
                MessageBox.Show("datos actualizados");
                cargarGrillaClientes();
            }
        }
    }
}