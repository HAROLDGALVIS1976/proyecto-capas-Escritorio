using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FACTUFACIL.CAPAPRESENTACION
{
    public partial class FrmCompras : Form
    {
       

        public FrmCompras()
        {
            InitializeComponent();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {

        }



      private void BTNNUEVO_Click(object sender, EventArgs e)
      {
        Cursor.Current = Cursors.Default;
        BTNNUEVO.Visible = false;
        BTNBUSCAREF.Visible = true;
        CBOFACTURA.Enabled = true;
        CBODESCRIPCION.Enabled = true;
        TXTCANT.Enabled = true;
        TXTVALUNICOSTO.Enabled = true;
        CBOPROVEEDOR.Enabled = true;
        CBODESCRIPCION.BackColor = Color.White;
        CBOPROVEEDOR.BackColor = Color.White;
        CBOTIPO.BackColor = Color.White;
        TXTFECHACOMPRA.BackColor = Color.White;
        TXTFECHAPAG.BackColor = Color.White;
        CBOFACTURA.BackColor = Color.White;
        TXTVALUNICOSTO.BackColor = Color.White;
        TXTCANT.BackColor = Color.White;
        TXTTOTAL.BackColor = Color.White;
        TXTTOTAL.BackColor = Color.White;
       // Utilidades.CargaCombobox("REFERENCIAS", "DESCRIPCION", CBODESCRIPCION)
       // Utilidades.autocompletar("Sp_CompletaRef", "DESCRIPCION", CBODESCRIPCION)
        Limpiar();
        Cursor.Current = Cursors.Default;
        //CBOFACTURA.Focus();
      }

      private void BTNGUARDAR2_Click(object sender, EventArgs e)
      {

      }

      private void BTNSALIR_Click(object sender, EventArgs e)
      {

      }

      private void BTNCANCELA_Click(object sender, EventArgs e)
      {

      }

      private void BTNBUSCAREF3_Click(object sender, EventArgs e)
      {

      }

      private void RadioButton2_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void RadioButton1_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void RadioButton3_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void RadioButton5_CheckedChanged(object sender, EventArgs e)
      {

      }

      private void RadioButton6_CheckedChanged(object sender, EventArgs e)
      {

      }


        
      private void Limpiar()
      {
        CBOFACTURA.Text = null;
        CBODESCRIPCION.Text = null;
        TXTCANT.Clear();
        TXTVALUNICOSTO.Clear();
        CBOPROVEEDOR.Text = null;
        TXTTOTAL.Clear();
        CBOTIPO.Text = null;
        TXTFECHACOMPRA.Clear();
        TXTFECHAPAG.Clear();
        TXTVALTOTPXP.Clear();
       // SplitContainer1.Visible = False
        CBODESCRIPCION.Enabled = true;
        TXTCANT.Enabled = true;
        TXTVALUNICOSTO.Enabled = true;
        CBOPROVEEDOR.Enabled = true;

      }


    }
}
