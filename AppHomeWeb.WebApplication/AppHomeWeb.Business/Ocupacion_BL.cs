using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppHomeWeb.Data;
using AppHomeWeb.Entity;

namespace AppHomeWeb.Business
{
    public class Ocupacion_BL
    {

        public List<Ocupacion_BE> ListarOcupacion()
        {
            Ocupacion_DL objOcupacion_DL = new Ocupacion_DL();
            return objOcupacion_DL.ListarOcupacion();
        }
    }
}
