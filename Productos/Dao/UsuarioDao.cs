using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Dao
{
    public class UsuarioDao
    {
        public String[] users = {"Lucas", "Ana", "Pedro"};
        public String[] pws = { "123", "456", "789" };

        public Boolean ValidarUsuario(String user, String pw)
        {
            for(int i = 0; i < users.Length; i++)
            {
                if(users[i] == user && pws[i] == pw)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
