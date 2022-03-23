using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using FACTUFACIL.CAPADOMINIO;


namespace FACTUFACIL.CAPAPRESENTACION
{
    public partial class FrmClientes : Form
    {

        int N = 0;
       
        ClsUtilidades ObjUtilidades = new ClsUtilidades();
        ClsClientes ObjClientes = new ClsClientes();
        ClsExportarExcel ObjExportar = new ClsExportarExcel();
               

        public FrmClientes()
        {
            InitializeComponent();
        }

        


        private void FrmClientes_Load(object sender, EventArgs e)
        {                  
            DgCliente.DataSource = ObjClientes.GetClientes();
            ObjClientes.CargaCliente(CBOCLIENTE);
            ObjClientes.CargarNuip(CBONUIP);
            limpiar();
        }

       

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            BTNNUEVO.Visible = false;
            BTNGUARDAR.Visible = true;
            BTNREF.Visible = true;
            CBONUIP.Enabled = true;
            CBOCLIENTE.Enabled = true;
            TXTCIUDAD.Enabled = true;
            TXTDIRECCION.Enabled = true;
            TXTTELEFONO.Enabled = true;
            TXTMAIL.Enabled = true;
            limpiar();
            TXTHABILITADO.Text = "1";
            TXTTIPOCLIENTE.Text = "C";
            N = 1;
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
                                
            try
            {
                if (string.IsNullOrWhiteSpace(CBOCLIENTE.Text) || string.IsNullOrWhiteSpace(CBONUIP.Text) || string.IsNullOrWhiteSpace(TXTDIRECCION.Text) || string.IsNullOrWhiteSpace(TXTTELEFONO.Text) || string.IsNullOrWhiteSpace(TXTCIUDAD.Text) || string.IsNullOrWhiteSpace(TXTMAIL.Text) || string.IsNullOrWhiteSpace(CBORUTA.Text) || string.IsNullOrWhiteSpace(TXTHABILITADO.Text) || string.IsNullOrWhiteSpace(TXTTIPOCLIENTE.Text))
                {
                    MessageBox.Show("Hay un Campo Vacio, Corrijalo por Favor", "GYGSYSTEMS.COM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (N == 1)
                {
                    if (ObjClientes.ValidarCliente_Nuip(CBONUIP.Text))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        BTNNUEVO.Visible = true;
                        BTNGUARDAR.Visible = false;
                        BTNREF.Visible = true;
                        CBONUIP.Enabled = true;
                        CBOCLIENTE.Enabled = true;
                        TXTCIUDAD.Enabled = true;
                        TXTDIRECCION.Enabled = true;
                        TXTTELEFONO.Enabled = true;
                        TXTMAIL.Enabled = true;
                        Cursor.Current = Cursors.Default;
                        limpiar();
                        N = 0;
                        MessageBox.Show("El Cliente  con el Documento "+ CBONUIP.Text +"  ya  Existe, por Ello No Se Permite Ingresarlo de Nuevo", "GYGSYSTEMS.COM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    else
                    {
                        Cursor.Current = Cursors.WaitCursor;                      
                        ObjClientes.GuardarCliente(CBOCLIENTE.Text, CBONUIP.Text, TXTDIRECCION.Text, TXTTELEFONO.Text, TXTCIUDAD.Text, TXTMAIL.Text, int.Parse(CBORUTA.Text), int.Parse(TXTHABILITADO.Text), TXTTIPOCLIENTE.Text);
                        BTNNUEVO.Visible = true;
                        BTNGUARDAR.Visible = false;
                        BTNREF.Visible = true;
                        CBONUIP.Enabled = true;
                        CBOCLIENTE.Enabled = false;
                        TXTCIUDAD.Enabled = false;
                        TXTDIRECCION.Enabled = false;
                        TXTTELEFONO.Enabled = false;
                        TXTMAIL.Enabled = false;
                        TXTTIPOCLIENTE.Enabled = false;
                        TXTHABILITADO.Enabled = false;
                       // DgCliente.DataSource = ObjUtilidades.MostrarTodo("Sp_BuscaCliente");
                        limpiar();
                        N = 0;
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Ha Ingresado Nuevo Cliente de Forma Exitosa. ", "GYGSYSTEMS.COM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
                else if (N == 2)
                {
                    if (ObjClientes.ValidarCliente_Nuip(CBONUIP.Text))
                    {
                        Cursor.Current = Cursors.WaitCursor;                     
                        ObjClientes.ModificarCliente(CBOCLIENTE.Text, CBONUIP.Text, TXTDIRECCION.Text, TXTTELEFONO.Text, TXTCIUDAD.Text, TXTMAIL.Text, int.Parse(CBORUTA.Text), int.Parse(TXTHABILITADO.Text), TXTTIPOCLIENTE.Text);
                        BTNNUEVO.Visible = true;
                        BTNGUARDAR.Visible = false;
                        BTNREF.Visible = true;
                        CBONUIP.Enabled = true;
                        CBOCLIENTE.Enabled = false;
                        TXTCIUDAD.Enabled = false;
                        TXTDIRECCION.Enabled = false;
                        TXTTELEFONO.Enabled = false;
                        TXTMAIL.Enabled = false;
                        TXTTIPOCLIENTE.Enabled = false;
                        TXTHABILITADO.Enabled = false;
                        //DgCliente.DataSource = ObjUtilidades.MostrarTodo("Sp_BuscaCliente");
                        limpiar();
                        N = 0;
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Modificacion de Datos Exitosa. ", "GYGSYSTEMS.COM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        BTNNUEVO.Visible = true;
                        BTNGUARDAR.Visible = false;
                        BTNREF.Visible = true;
                        CBONUIP.Enabled = true;
                        CBOCLIENTE.Enabled = false;
                        TXTCIUDAD.Enabled = false;
                        TXTDIRECCION.Enabled = false;
                        TXTTELEFONO.Enabled = false;
                        TXTMAIL.Enabled = false;
                        TXTTIPOCLIENTE.Enabled = false;
                        TXTHABILITADO.Enabled = false;
                        Cursor.Current = Cursors.Default;
                        limpiar();
                        N = 0;
                        MessageBox.Show("El Cliente No Existe", "GYGSYSTEMS.COM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Error" + ex.Message);
            }

        }

        private void BTNREF_Click(object sender, EventArgs e)
        {
            try
            {
                //string.IsNullOrWhiteSpace(CBOCLIENTE.Text)
                if (string.IsNullOrWhiteSpace(CBONUIP.Text))
                {
                    MessageBox.Show("El Cliente no Puede Estar Vacio", "GYGSYSTEMS.COM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CBONUIP.BackColor = Color.Red;
                }
                else
                {
                    if (ObjClientes.ValidarCliente_Nuip(CBONUIP.Text))
                    {
                         Cursor.Current = Cursors.WaitCursor;
                         ObjClientes.Buscar(CBONUIP, CBOCLIENTE, TXTDIRECCION, TXTTELEFONO, TXTCIUDAD, TXTMAIL, CBORUTA, TXTHABILITADO, TXTTIPOCLIENTE);                   
                         BTNNUEVO.Visible = false;
                         BTNGUARDAR.Visible = true;
                         BTNREF.Visible = false;
                         CBOCLIENTE.Enabled = false;
                         CBONUIP.Enabled = false;
                         TXTCIUDAD.Enabled = true;
                         TXTDIRECCION.Enabled = true;
                         TXTTELEFONO.Enabled = true;
                         TXTMAIL.Enabled = true;
                         TXTHABILITADO.Enabled = true;
                         N = 2;
                         Cursor.Current = Cursors.Default;
                         MessageBox.Show("Ya puede Modificar Los datos del Cliente", "GYGSYSTEMS.COM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        BTNNUEVO.Visible = true;
                        BTNGUARDAR.Visible = false;
                        BTNREF.Visible = true;
                        CBONUIP.Enabled = true;
                        CBOCLIENTE.Enabled = true;
                        TXTCIUDAD.Enabled = true;
                        TXTDIRECCION.Enabled = true;
                        TXTTELEFONO.Enabled = true;
                        TXTMAIL.Enabled = true;
                        Cursor.Current = Cursors.Default;
                        limpiar();
                        N = 0;
                        MessageBox.Show("El Cliente No Existe", "GYGSYSTEMS.COM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    }
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Error al Buscar el Cliente" + ex.Message);
            }

        }

        private void BTNEXPORTAR_Click(object sender, EventArgs e)
        {
           ObjExportar.ExportarExcel(DgCliente);
        }





        //Metodo para limpiar los items
        private void limpiar()
        {
            CBOCLIENTE.Text = null;
            CBONUIP.Text = null;
            CBORUTA.Text = "1";
            TXTDIRECCION.Clear();
            TXTTELEFONO.Clear();
            TXTCIUDAD.Clear();
            TXTMAIL.Clear();
            TXTHABILITADO.Clear();
            TXTTIPOCLIENTE.Clear();
            N = 0;
        }


        private void CBOCLIENTE_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBOCLIENTE.BackColor = Color.White;
        }

        private void CBONUIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBONUIP.BackColor = Color.White;

        }

    










    }
}
