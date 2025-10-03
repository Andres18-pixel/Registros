

using Productos.Modelos;
using System;
using System.Windows.Forms;

namespace Productos.Dao
{
    public class ProductoDao
    {
        public static int TAM = 5;
        public const int TAMAÑO = 10;

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
                MessageBox.Show("No se puede agregar mas elementos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        public Producto[] VerCarrito()
        {
            
            return carrito;
        }

        

    }
}
