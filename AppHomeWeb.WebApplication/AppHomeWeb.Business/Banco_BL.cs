using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppHomeWeb.Data;
using AppHomeWeb.Entity;

namespace AppHomeWeb.Business
{
    public class Banco_BL
    {
        public List<Banco_BE> ListarBanco()
        {
            Banco_DL objBanco_DL = new Banco_DL();
            return objBanco_DL.ListarBanco();
        }
    }
}
