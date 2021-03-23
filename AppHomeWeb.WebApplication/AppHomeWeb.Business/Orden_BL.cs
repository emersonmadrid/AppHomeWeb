using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppHomeWeb.Data;
using AppHomeWeb.Entity;

namespace AppHomeWeb.Business
{
    public class Orden_BL
    {
        public List<Orden_BE> ListarOrdenCliente(Orden_BE Ent)
        {
            Orden_DL objOrden_DL = new Orden_DL();
            return objOrden_DL.ListarOrdenCliente(Ent);
        }


    }
}
