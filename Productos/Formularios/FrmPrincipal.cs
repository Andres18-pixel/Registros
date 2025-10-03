using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos.Formularios;

namespace Productos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmProducto().Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void edadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArreglo frm = new FrmArreglo();
            frm.ShowDialog();
        }
    }
}
