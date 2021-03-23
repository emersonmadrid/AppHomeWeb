using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppHomeWeb.Data;
using AppHomeWeb.Entity;

namespace AppHomeWeb.Business
{
    public class Tipo_Documento_BL
    {
        public List<Tipo_Documento_BE> ListarTipo_Documento()
        {

            Tipo_Documento_DL objTipo_Documento_DL = new Tipo_Documento_DL();
            return objTipo_Documento_DL.ListarTipo_Documento();

        }
    }
}
