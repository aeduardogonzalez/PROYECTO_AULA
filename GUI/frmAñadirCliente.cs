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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarClientesFiltrado();
        }

        private void CargarClientesFiltrado()
        {
            var filtro = txtBuscar.Text;
            var list = clienteService.BuscarFiltrado(filtro);
            cargarGrillaPersonas(list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
            this.Close();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarBD();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsulta.Columns[e.ColumnIndex].Name == "ModificarDGV")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    txtId.Text = dgvConsulta.Rows[index].Cells["Id"].Value.ToString();
                    txtCedula.Text = dgvConsulta.Rows[index].Cells["Cedula"].Value.ToString();
                    txtNombre.Text = dgvConsulta.Rows[index].Cells["nombre"].Value.ToString();
                    txtApellido.Text = dgvConsulta.Rows[index].Cells["Apellido"].Value.ToString();
                    dtpFechaNacimiento.Text = dgvConsulta.Rows[index].Cells["FechaNacimiento"].Value.ToString();
                    cboxGenero.Text = dgvConsulta.Rows[index].Cells["genero"].Value.ToString();
                    txtDireccion.Text = dgvConsulta.Rows[index].Cells["direccion"].Value.ToString();
                    txtPuntuacion.Text = dgvConsulta.Rows[index].Cells["puntuacion"].Value.ToString();
                    cboxEstado.Text = dgvConsulta.Rows[index].Cells["estado"].Value.ToString();
                    cboxCiudad.Text = dgvConsulta.Rows[index].Cells["ciudad"].Value.ToString();
                }
            }
        }

        private void ModificarBD() 
        {
            if ((txtId.Text != "") || (txtNombre.Text != "") || (txtApellido.Text != "") || (dtpFechaNacimiento.Text != "")
                || (cboxGenero.Text != "") || (txtDireccion.Text != "") || (txtPuntuacion.Text != "") || (cboxEstado.Text != "")
                || (txtIdCiudad.Text != "") || (cboxCiudad.Text != ""))
                 
            {
                Ciudad CiudadIndex = (Ciudad)cboxCiudad.SelectedItem;
                Cliente cliente = new Cliente
                {
                    Cedula = txtCedula.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    FechaNacimiento = Convert.ToString(dtpFechaNacimiento.Value.ToString("d")),
                    Genero = cboxGenero.Text,
                    Direccion = txtDireccion.Text,
                    Puntuacion = Convert.ToDecimal(txtPuntuacion.Text),
                    Estado = cboxEstado.Text,
                    ciudad = CiudadIndex,
                    ID = Convert.ToInt32(txtId.Text)
                };
                if (cliente == null)
                {
                    var msg = clienteService.ActualizarCliente(cliente);
                    MessageBox.Show(msg, "Gestion de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGrillaPersonas(clienteService.ConsultarClientes());
                }
                else
                {
                    var msg = clienteService.ActualizarCliente(cliente);
                    MessageBox.Show(msg, "Gestion de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar!", "Gestion de producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
