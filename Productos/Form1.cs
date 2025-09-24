using System;
using System.Windows.Forms;
using Productos.Dao;
using Productos.Modelos;

namespace Productos
{
    public partial class Form1 : Form
    {
        ProductoDao dao = new ProductoDao();
        public Form1()
        {
            InitializeComponent();
            LlenarGrid();
        }

        public void LlenarGrid()
        {
            this.dgvRegistros.DataSource = dao.VerCarrito();
            this.dgvRegistros.Refresh();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            try
            {
                prod.Nombre = tbNombre.Text.ToUpper();
                prod.Codigo = tbCodigo.Text.ToUpper();
                prod.Precio = double.Parse(tbPrecio.Text);
                prod.IVA = chkIVA.Checked;
            }catch (FormatException)
            {
                MessageBox.Show("No se puede agregar texto en el precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dao.Agregar(prod);
            LlenarGrid();
        }
    }
}
