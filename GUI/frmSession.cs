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
    public partial class frmSession : Form
    {
        public frmSession()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\imagenes\fondo2.png");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSession_Load(object sender, EventArgs e)
        {

        }
    }
}
