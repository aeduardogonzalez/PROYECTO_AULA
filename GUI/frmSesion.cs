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
            this.Hide();
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
