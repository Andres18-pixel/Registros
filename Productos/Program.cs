using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (Login login = new Login())
            {
                if(login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FrmPrincipal());
                }
                
            }
        }
    }
}
