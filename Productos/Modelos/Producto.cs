using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Modelos
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public Boolean IVA { get; set; }

        public double Monto
        {
            get
            {
                //return IVA ? Precio * 1.15 : Precio;
                if(IVA)
                {
                    return Precio * 1.15;
                }
                else
                {
                    return Precio;
                }
            }
        }
    }
}
