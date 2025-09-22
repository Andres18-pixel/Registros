using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Dao
{
    public class ProductoDao
    {
        private ProductoDao[] carrito = new ProductoDao[10];
        private int pos = 0;

        public void Agregar(ProductoDao prod)
        {
            carrito[pos++] = prod;
        }




    }
}
