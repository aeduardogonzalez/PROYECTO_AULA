using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSesion : Form
    {
        public frmSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingresar();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Ingresar()
        {
            if (txtUsuario.Text != "")
            {
                if (txtContraseña.Text != "")
                {
                    List<Prestamista> TEST = new PrestamistaService().ConsultarPrestamista();
                    Prestamista oUsuario = new PrestamistaService().LoginUser(txtUsuario.Text, txtContraseña.Text).FirstOrDefault();
                    if (oUsuario != null)
                    {
                        frmMenuPrincipal Menu = new frmMenuPrincipal();
                        Menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña no válido", "login");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una contraseña válida", "login");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un usuario válido", "login");
            }
        }

        private void frmSession_Load(object sender, EventArgs e)
        {
            

        }

        private void btnCrearSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarse registro = new frmRegistrarse();
            registro.Show();
        }
    }
}
