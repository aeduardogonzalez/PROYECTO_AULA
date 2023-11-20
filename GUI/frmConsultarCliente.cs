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
    public partial class frmConsultarCliente : Form
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        BLL.ClienteService clienteService = new BLL.ClienteService();

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrillaPersonas();
        }

        private void cargarGrillaPersonas()
        {
            dgvConsulta.DataSource = clienteService.ConsultarClientes();
            //dgvPersonas.AutoResizeColumns();
            dgvConsulta.Columns[0].Visible = false;
            //dgvPersonas.Columns[1].AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill; // auto
            dgvConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsulta.RowHeadersVisible = false;
        }


    }
}
