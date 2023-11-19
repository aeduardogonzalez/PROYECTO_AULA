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
                Id = Convert.ToInt32(fila.Cells[0].Value),
                Cedula = fila.Cells[1].Value.ToString(),
                Nombre = fila.Cells[2].Value.ToString(),
                Apellido = fila.Cells[3].Value.ToString(),
                Ciudad = fila.Cells[4].Value.ToString(),
                Direccion = fila.Cells[5].Value.ToString(),
                FechaNacimiento = Convert.ToDateTime(fila.Cells[6].Value),
                Puntuacion = Convert.ToInt32(fila.Cells[7].Value),
                Genero = fila.Cells[8].Value.ToString(),
                Estado = fila.Cells[9].Value.ToString()
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