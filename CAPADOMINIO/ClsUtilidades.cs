using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using FACTUFACIL;

namespace FACTUFACIL.CAPADOMINIO
{
    public class ClsUtilidades
    {
        //Cadena de Conexion por medio del app.config usando System.Configuration despues de hacer Referenecia al using
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["My_ConnectionString"].ConnectionString);


        public DataTable MostrarTodo(string Stored_Prod)
        {
            DataTable Tabla = new DataTable();
            SqlDataReader leer = null;
            SqlCommand cmd = new SqlCommand(Stored_Prod, con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            leer = cmd.ExecuteReader();
            Tabla.Load(leer);
            Tabla.Dispose();
            con.Close();
            return Tabla;
        }

      
          





    }
}
