using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace AppHomeWeb.Data
{
    public class Conexion_DL
    {
        public string CadenaConexion()
        {
            string Cadena = "";

            Cadena = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            return Cadena;
        }

    }
}
