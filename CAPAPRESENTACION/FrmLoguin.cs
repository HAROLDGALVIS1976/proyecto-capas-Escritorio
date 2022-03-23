using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using FACTUFACIL.CAPADOMINIO;
using FACTUFACIL.CAPAPRESENTACION;
using System.Security.Cryptography;


namespace FACTUFACIL.CAPAPRESENTACION
{
    public partial class FrmLoguin : Form
    {

        //Cadena de Conexion por medio del app.config usando System.Configuration despues de hacer Referenecia al using
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["My_ConnectionString"].ConnectionString);
       
        ClsUsuarios ObjUsuario = new ClsUsuarios();


        public FrmLoguin()
        {
            InitializeComponent();
        }

        private void FrmLoguin_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;  
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            Lblfecha.Text = DateTime.Now.ToShortDateString();
        }


        private void BTNINGRESAR_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string usuario, contraseña = null;
            usuario = TXTUSUARIO.Text;
            contraseña = TXTCONTRASEÑA.Text;
            try
            {
                if (string.IsNullOrWhiteSpace(usuario) )
                {
                    MessageBox.Show("Ingrese de Forma Correcta el Usuario", "GYGSYSTEMS.COM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TXTUSUARIO.BackColor = Color.Red;
                    Cursor.Current = Cursors.Default;
                }
                else if (string.IsNullOrWhiteSpace(contraseña))
                {
                    MessageBox.Show("Ingrese de Forma Correcta la Contraseña", "GYGSYSTEMS.COM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TXTCONTRASEÑA.BackColor = Color.Red;
                    Cursor.Current = Cursors.Default;
                }
                else
                { 
                    SHA256Managed sha = new SHA256Managed();
                    byte[] byteContra = Encoding.Default.GetBytes(contraseña);
                    byte[] byteContaCifrado = sha.ComputeHash(byteContra);
                    string cadenaContraCifrada = BitConverter.ToString(byteContaCifrado).Replace("-", "");
                    if (ObjUsuario.ValidarUsuario(usuario, cadenaContraCifrada))
                    {
                       Cursor.Current = Cursors.Default;
                       TXTUSUARIO.Clear();
                       TXTCONTRASEÑA.Clear();
                       FrmInicial Inicio = new FrmInicial();
                       Inicio.Show();
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Usuario O Contraseña Incorrectos. ", "GYGSYSTEMS.COM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch(Exception ex)
            {
                Cursor.Current = Cursors.Default;
                con.Close();
                MessageBox.Show("Error al Validar el Usuario" + ex.Message, "GYGSYSTEMS.COM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                con.Close();
            }
        }
           


        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TXTUSUARIO_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void TXTCONTRASEÑA_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void TXTCONTRASEÑA_Click(object sender, EventArgs e)
        {
          TXTCONTRASEÑA.BackColor = Color.White;
        }

        private void TXTUSUARIO_Click(object sender, EventArgs e)
        {
          TXTUSUARIO.BackColor = Color.White;
        }
       







    }
}
