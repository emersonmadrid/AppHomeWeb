using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppHomeWeb.Data;
using AppHomeWeb.Entity;

namespace AppHomeWeb.Business
{
    public class Cliente_BL
    {
        public int RegistrarCliente(Cliente_BE Ent)
        {
            Cliente_DL objCliente_DL = new Cliente_DL();
            return objCliente_DL.RegistrarCliente(Ent);
        }

        public List<Cliente_BE> ListarDatoCliente(Cliente_BE Ent)
        {
            Cliente_DL objDatoCliente_DL = new Cliente_DL();
            return objDatoCliente_DL.ListarDatoCliente(Ent);
        }

        public int ActualizarCliente(Cliente_BE Ent)
        {
            Cliente_DL objCliente_DL = new Cliente_DL();
            return objCliente_DL.ActualizarCliente(Ent);
        }



    }
}
