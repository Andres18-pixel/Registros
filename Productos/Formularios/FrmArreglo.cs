using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos.Dao;

namespace Productos.Formularios
{
    public partial class FrmArreglo : Form
    {
        public FrmArreglo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarPromedio()
        {
            int suma = EdadDao.edades.Take(EdadDao.pos).Sum();
            double promedio = (double)suma / EdadDao.pos;
            lbPromedio.Text = $"Promedio: {promedio}";
        }

        private void tbEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //ok
                agregar();
            }
        }

        public void agregar()
        {
            int edad = 0;
            try
            {
                edad = int.Parse(tbEdad.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("No se permiten letras, solo numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                EdadDao.edades[EdadDao.pos++] = edad;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No se admiten mas elementos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tbEdad.Clear();
            tbEdad.Focus();
            MostrarEdades();
            MostrarPromedio();

        }
        public void MostrarEdades()
        {
            lbEdades.DataSource = null;
            lbEdades.DataSource = EdadDao.edades;
            lbEdades.Refresh();
        }

        private void FrmArreglo_Load(object sender, EventArgs e)
        {
            MostrarEdades();
        }
    }
}