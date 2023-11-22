using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;
namespace GUI
{
    public partial class frmAñadirCliente : Form
    {
        BLL.ClienteService clienteService = new BLL.ClienteService();
        public frmAñadirCliente()
        {
            InitializeComponent();
        }

        private void btnAnadirCliente_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPuntuacion.Text, out decimal puntuacion))
            {
                Ciudad clienteindex = (Ciudad)cboxCiudad.SelectedItem;
                Cliente cliente = new Cliente
                {
                    Cedula = txtCedula.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    FechaNacimiento = Convert.ToString(dtpFechaNacimiento.Value.ToString("d")),
                    Genero = cboxGenero.Text,
                    Direccion = txtDireccion.Text,
                    Puntuacion = puntuacion,
                    Estado = cboxEstado.Text,
                    ciudad= clienteindex
                };
                Insertar(cliente);
                cargarGrillaPersonas(clienteService.ConsultarClientes());
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido para la puntuación.");
            }

        }

        private void cargarGrillaPersonas(List<Cliente> clientes)
        {
            dgvConsulta.Rows.Clear();

            if (clientes != null)
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

        private void CargarComboPersonas()
        {
            CiudadService ciudadService = new CiudadService();
            cboxCiudad.DataSource = ciudadService.ConsultarCiudad();
            cboxCiudad.DisplayMember = "Nombre_Ciudad";
            cboxCiudad.ValueMember = "Id_Ciudad";
            cboxCiudad.SelectedIndex = -1;
            cboxCiudad.DropDownStyle = ComboBoxStyle.DropDownList;

        }


        private void Insertar(Cliente cliente)
        {
            var msg = clienteService.RegistrarCliente(cliente);
            MessageBox.Show(msg);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void frmAñadirCliente_Load(object sender, EventArgs e)
        {
            cargarGrillaPersonas(clienteService.ConsultarClientes());
            CargarComboPersonas();
        }
    }
}
