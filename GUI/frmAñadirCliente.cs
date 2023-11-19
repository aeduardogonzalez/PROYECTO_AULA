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
    public partial class frmAñadirCliente : Form
    {
        BLL.ClienteService clienteService = new BLL.ClienteService();
        public frmAñadirCliente()
        {
            InitializeComponent();
        }

        private void btnAnadirCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                Cedula = txtCedula.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Ciudad = cboxCiudad.Text,
                Direccion = txtDireccion.Text,
                Fecha_Nacimiento = dtpFechaNacimiento.Value,
                Puntuacion = txtPuntuacion.Text,
                Genero = cboxGenero.Text,
                Estado = cboxEstado.Text

            };

        }
        private void Añadir(Cliente cliente)
        {
            var msg = clienteService.RegistrarCliente(cliente);
            MessageBox.Show(msg);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmAñadirCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
