using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppHomeWeb.Data;
using AppHomeWeb.Entity;

namespace AppHomeWeb.Business
{
    public class Reniec_BL
    {

        public Reniec_BE BuscarDNI(string txtDni)
        {
            Reniec_DL objReniec_DL = new Reniec_DL();
            return objReniec_DL.BuscarDNI(txtDni);
        }

    }
}
