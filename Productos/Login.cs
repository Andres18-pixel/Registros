using Productos.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos
{
    public partial class Login : Form
    {
        UsuarioDao users = new UsuarioDao();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logear();
        }

        private void Logear()
        {
            if (users.Validar(tbUsuario.Text, tbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales invalida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logear();
            }
        }

        private void tbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            tbPassword.Focus();
        }

        private void chkShowPw_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkShowPw.Checked)
            {
                tbPassword.PasswordChar = '*';
                chkShowPw.Text = "Mostrar Contraseña";
            }
            else
            {
                tbPassword.PasswordChar = '\0';
                chkShowPw.Text = "Ocultar Contraseña";
            }
        }
    }
}
