using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using FACTUFACIL.CAPACOMMON;
using System.Security.Cryptography;

namespace FACTUFACIL.CAPADOMINIO
{
    class ClsUsuarios
    {
        //Cadena de Conexion por medio del app.config usando System.Configuration despues de hacer Referenecia al using
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["My_ConnectionString"].ConnectionString);

       
     
        // Metodo para Validar si existe un registro en BD en funcion de dos items.
        public bool ValidarUsuario(string Usuario, string cadenaContraCifrada)
        {
                SqlCommand cmd = new SqlCommand("Sp_ValidarUsuarios", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", Usuario);
                cmd.Parameters.AddWithValue("@contraseña", cadenaContraCifrada);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                      // llenando los datos en la cache del sistema para tomarlos despues
                      // en el formulario FrmLoguin.
                        ClsUserCache.USUARIO = reader.GetString(1);
                        ClsUserCache.CONTRASEÑA = reader.GetString(2);
                        ClsUserCache.TIPOUSUARIO = reader.GetString(3);
                    }
                    con.Close();
                    reader.Close();
                    return true;                  
                }
                else
                {
                    con.Close();
                    reader.Close();
                    return false;
                }
                         
        }

     
    }
}
