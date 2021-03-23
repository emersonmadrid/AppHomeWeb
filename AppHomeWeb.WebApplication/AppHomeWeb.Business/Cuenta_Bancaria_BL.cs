using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppHomeWeb.Data;
using AppHomeWeb.Entity;

namespace AppHomeWeb.Business
{
    public class Cuenta_Bancaria_BL
    {
        public List<Cuenta_Bancaria_BE> ListarCuentaBancaria(Cuenta_Bancaria_BE Ent)
        {
            Cuenta_Bancaria_DL objCuenta_Bancaria_DL = new Cuenta_Bancaria_DL();
            return objCuenta_Bancaria_DL.ListarCuentaBancaria(Ent);
        }

        public int RegistrarCuentaBancaria(Cuenta_Bancaria_BE Ent)
        {
            Cuenta_Bancaria_DL objCuenta_Bancaria_DL = new Cuenta_Bancaria_DL();
            return objCuenta_Bancaria_DL.RegistrarCuentaBancaria(Ent);
        }
    }
}
