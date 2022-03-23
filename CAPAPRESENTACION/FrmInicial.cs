using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FACTUFACIL.CAPACOMMON;
using FACTUFACIL.CAPADOMINIO;
using FACTUFACIL.CAPAPRESENTACION;

namespace FACTUFACIL.CAPAPRESENTACION
{
    public partial class FrmInicial : Form
    {

        public FrmInicial()
        {
            InitializeComponent();
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {
            AdministrarPermisos();
            timer1.Enabled = true;
            LblUsuario.Text = ClsUserCache.USUARIO;
        }

        // instanciando un Formulario Hijo
        private Form currentChildForm;

        //Metodo para Cargar un formulario establecido dentro deL PanelFormulario 
        private void AbrirFormHijo(Form FormHijo)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = FormHijo;
            //End
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            PanelFormulario.Controls.Add(FormHijo);
            PanelFormulario.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }


        //Metodo para bloquear cuaquier boton segun prmiso del Uuario
        private void AdministrarPermisos()
        {
            if (ClsUserCache.TIPOUSUARIO == ClsTipoUsuario.Administrador)
            {
                //BTNCLIENTES.Enabled = false;

            }
            if (ClsUserCache.TIPOUSUARIO == ClsTipoUsuario.Empleado)
            {
                BTNCLIENTES.Enabled = false;

            }
            if (ClsUserCache.TIPOUSUARIO == ClsTipoUsuario.Cliente)
            {
                BTNCLIENTES.Enabled = false;

            }
        }
        
        private void BTNREFERENCIA_Click(object sender, EventArgs e)
        {         
            
        }

        private void BTNCOMPRAS_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AbrirFormHijo(new FrmCompras());
            Cursor.Current = Cursors.Default;
        }

        private void BTNCLIENTES_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AbrirFormHijo(new FrmClientes());
            Cursor.Current = Cursors.Default;
        }

        private void BTNPROVEEDORES_Click(object sender, EventArgs e)
        {

        }

        private void BTNGASTOS_Click(object sender, EventArgs e)
        {

        }

        private void BTNIMPVETAPROD2_Click(object sender, EventArgs e)
        {

        }

        private void BTNDEVCOMPRAS_Click(object sender, EventArgs e)
        {

        }

        private void BTNDEVVENTAS_Click(object sender, EventArgs e)
        {

        }

        private void BTNCXC_Click(object sender, EventArgs e)
        {

        }

        private void BTNCXP_Click(object sender, EventArgs e)
        {

        }

        private void BTNINFORMES_Click(object sender, EventArgs e)
        {

        }

        private void BTNCXP_CXC_Click(object sender, EventArgs e)
        {

        }

        private void BTNLIBRODIARIO_Click(object sender, EventArgs e)
        {

        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            this.Close();          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            Lblfecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
