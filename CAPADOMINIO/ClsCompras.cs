using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACTUFACIL.CAPADOMINIO
{
    public class ClsCompras
    {
        int N = 0;
        //Cadena de Conexion por medio del app.config usando System.Configuration despues de hacer Referenecia al using
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["My_ConnectionString"].ConnectionString);

      

    }
}
