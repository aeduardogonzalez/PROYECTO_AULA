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
            if (int.TryParse(txtPuntuacion.Text, out int puntuacion))
            {
                Cliente cliente = new Cliente
                {
                    Cedula = txtCedula.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    Genero = cboxGenero.Text,
                    Direccion = txtDireccion.Text,
                    Puntuacion = puntuacion,
                    Estado = cboxEstado.Text,
                    Ciudad = cboxCiudad.Text
                };
                Insertar(cliente);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido para la puntuación.");
            }


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

        }
    }
}
