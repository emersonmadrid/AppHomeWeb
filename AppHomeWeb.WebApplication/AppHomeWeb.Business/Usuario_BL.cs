using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppHomeWeb.Data;
using AppHomeWeb.Entity;

namespace AppHomeWeb.Business
{
    public class Usuario_BL
    {
        public int ValidarUsuario(Usuario_BE Ent)
        {
            Usuario_DL objUsuario_DL = new Usuario_DL();
            return objUsuario_DL.ValidarUsuario(Ent);
        }
        public int ActualizarClave(Usuario_BE Ent)
        {
            Usuario_DL objUsuario_DL = new Usuario_DL();
            return objUsuario_DL.ActualizarClave(Ent);
        }
    }
}
