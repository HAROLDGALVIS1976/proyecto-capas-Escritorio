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
using FACTUFACIL.CAPADATOS;


namespace FACTUFACIL.CAPADOMINIO
{
    public class ClsClientes
    {

        int N = 0;
        //Cadena de Conexion por medio del app.config usando System.Configuration despues de hacer Referenecia al using
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["My_ConnectionString"].ConnectionString);

      

        public  List<Cliente> GetClientes()
        {              
               
                    List<Cliente> lista = new List<Cliente>();
                    SqlDataReader reader = null;
                    SqlCommand cmd = new SqlCommand("Sp_BuscaCliente", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Cliente ocliente = new Cliente();
                        ocliente.IDCLIENTE = Convert.ToInt32(reader[0]);
                        ocliente.CLIENTE = Convert.ToString(reader[1]);
                        ocliente.NUIP = Convert.ToString(reader[2]);
                        ocliente.DIRECCION = Convert.ToString(reader[3]);
                        ocliente.TELEFONO = Convert.ToString(reader[4]);
                        ocliente.CIUDAD = Convert.ToString(reader[5]);
                        ocliente.EMAIL = Convert.ToString(reader[6]);
                        ocliente.IDRUTA = Convert.ToInt32(reader[7]);
                        ocliente.BHABILITADO = Convert.ToInt32(reader[8]);
                        ocliente.TIPOUSUARIO = Convert.ToString(reader[9]);
                        lista.Add(ocliente);
                    }
                    con.Close();
                    return lista;
               

        }

        public void GuardarCliente(string Cliente, string Nuip, string Direccion, string Telefono, string Ciudad, string Mail, int Ruta, int Habilitado, string Tipo)
        {    
            try
            {      
                SqlCommand cmd = new SqlCommand("Sp_GuardaCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cliente", Cliente);
                cmd.Parameters.AddWithValue("@nuip", Nuip);
                cmd.Parameters.AddWithValue("@direccion", Direccion);
                cmd.Parameters.AddWithValue("@telefono", Telefono);
                cmd.Parameters.AddWithValue("@ciudad", Ciudad);
                cmd.Parameters.AddWithValue("@mail", Mail);
                cmd.Parameters.AddWithValue("@ruta", Ruta);
                cmd.Parameters.AddWithValue("@habiltado", Habilitado);
                cmd.Parameters.AddWithValue("@tipo", Tipo);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error al Guardar el Cliente" + ex.Message);
            }
            finally
            {
                con.Close();
            }
            
        }

        public void ModificarCliente(string Cliente, string Nuip, string Direccion, string Telefono, string Ciudad, string Mail, int Ruta, int Habilitado, string Tipo)
        {         
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_ModificaCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cliente", Cliente);
                cmd.Parameters.AddWithValue("@nuip", Nuip);
                cmd.Parameters.AddWithValue("@direccion", Direccion);
                cmd.Parameters.AddWithValue("@telefono", Telefono);
                cmd.Parameters.AddWithValue("@ciudad", Ciudad);
                cmd.Parameters.AddWithValue("@mail", Mail);
                cmd.Parameters.AddWithValue("@ruta", Ruta);
                cmd.Parameters.AddWithValue("@habiltado", Habilitado);
                cmd.Parameters.AddWithValue("@tipo", Tipo);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                cmd.Parameters.Clear();
                
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error al Modificar el Cliente" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        //Metodo para cargar los clientes en en el cboclientes
        public void CargaCliente(ComboBox Cbo)
        {
            try
            {
                SqlDataReader reader = null;
                SqlCommand cmd = new SqlCommand("Sp_CompletaCliente", con); //Sp_CompletaNuipCliente
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Cbo.Items.Add(reader["CLIENTE"].ToString());
                }
                con.Close();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error al Buscar el Cliente" + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }
       
        //Metodo para cargar los clientes en en el cboclientes
        public void CargarNuip(ComboBox Cbo)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Sp_CompletaNuipCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Cbo.Items.Add(reader["NUIP"].ToString());
                }
                con.Close();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error al Buscar el Documento" + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        //Metodo para cargar los clientes en en el cboclientes
        public void CargaRuta(ComboBox Cbo)
        {
            try
            {
                SqlDataReader reader = null;
                SqlCommand cmd = new SqlCommand("Sp_CompletaRuta", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Cbo.Items.Add(reader["RUTA"].ToString());
                }
                con.Close();
                cmd.Parameters.Clear();

            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error al Buscar el Cliente" + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        // Metodo para Buscar losdatos de un registro en funcion de un item que es un combobox
        public void Buscar(ComboBox CBONUIP, ComboBox CBOCLIENTE, TextBox TXTDIRECCION, TextBox TXTTELEFONO, TextBox TXTCIUDAD, TextBox TXTMAIL, ComboBox CBORUTA, TextBox TXTHABILITADO, TextBox TXTTIPOCLIENTE)
        {
            try
            {
                SqlDataReader reader = null;
                Cursor.Current = Cursors.WaitCursor;
                SqlCommand cmd = new SqlCommand("Sp_BuscaCli", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nuip", CBONUIP.Text);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    CBOCLIENTE.Text = Convert.ToString(reader["CLIENTE"]);
                    TXTDIRECCION.Text = Convert.ToString(reader["DIRECCION"]);
                    TXTTELEFONO.Text = Convert.ToString(reader["TELEFONO"]);
                    TXTCIUDAD.Text = Convert.ToString(reader["CIUDAD"]);
                    TXTMAIL.Text = Convert.ToString(reader["EMAIL"]);
                    CBORUTA.Text = Convert.ToString(reader["IDRUTA"]);
                    TXTHABILITADO.Text = Convert.ToString(reader["BHABILITADO"]);
                    TXTTIPOCLIENTE.Text = Convert.ToString(reader["TIPOUSUARIO"]);
                }
                    con.Close();
                    reader.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error al Buscar el Cliente" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        // Metodo para Buscar losdatos de un registro en funcion de un item que es un combobox
        public Boolean ValidarCliente_Nuip(string Nuip)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                SqlCommand cmd = new SqlCommand("Sp_ValidaCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nuip", Nuip);
                con.Open();
                int t = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                cmd.Parameters.Clear();
                if ((t == 0))
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error al Validar el Cliente" + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return true;
        }

    }
}
