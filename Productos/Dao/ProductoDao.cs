
using System;
using System.Windows.Forms;
using Productos.Modelos;

namespace Productos.Dao
{
    public class ProductoDao
    {
        public static int TAM = 5;
        const int TAMAÑO = 10;
        private Producto[] carrito = new Producto[TAM];
        private int pos = 0;

        public void Agregar(Producto prod)
        {   
            try
            {
                carrito[pos++] = prod;
            }
            catch (IndexOutOfRangeException)
            {
                 MessageBox.Show("No se pueden agregar más productos al carrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public Producto[] VerCarrito()
        {
            return carrito;
        }




    }
}
