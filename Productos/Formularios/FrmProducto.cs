using Productos.Dao;
using Productos.Modelos;
using System;
using System.Windows.Forms;

namespace Productos
{
    public partial class FrmProducto : Form
    {
        ProductoDao dao = new ProductoDao();
        public FrmProducto()
        {
            InitializeComponent();
            LlenarGrid();
        }

        public void LlenarGrid()
        {
            this.dgvRegistros.DataSource = dao.VerCarrito();
            this.dgvRegistros.Refresh();
        }

        private void btnRegistrar_Click(object sender, System.EventArgs e)
        {
            Producto prod = new Producto();
            try
            {
                prod.Nombre = tbNombre.Text.ToUpper();
                prod.Codigo = tbCodigo.Text.ToUpper();
                prod.Precio = double.Parse(tbPrecio.Text);
                prod.IVA = chkIVA.Checked;
                dao.Agregar(prod);
            }
            catch(FormatException)
            {
                MessageBox.Show("No se puede agregar texto en el precio ","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            LlenarGrid();
        }
    }
}
