namespace FACTUFACIL.CAPAPRESENTACION
{
    partial class FrmLoguin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoguin));
            this.Lblhora = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lblfecha = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.BTNINGRESAR = new System.Windows.Forms.Button();
            this.TXTCONTRASEÑA = new System.Windows.Forms.TextBox();
            this.TXTUSUARIO = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lblhora
            // 
            this.Lblhora.AutoSize = true;
            this.Lblhora.BackColor = System.Drawing.Color.MidnightBlue;
            this.Lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblhora.ForeColor = System.Drawing.Color.White;
            this.Lblhora.Location = new System.Drawing.Point(470, 55);
            this.Lblhora.Name = "Lblhora";
            this.Lblhora.Size = new System.Drawing.Size(0, 20);
            this.Lblhora.TabIndex = 2005;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.MidnightBlue;
            this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label7.Location = new System.Drawing.Point(456, 24);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(149, 22);
            this.Label7.TabIndex = 2004;
            this.Label7.Text = "Hora del Sistema";
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(1, 12);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(301, 290);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 2003;
            this.PictureBox2.TabStop = false;
            // 
            // Lblfecha
            // 
            this.Lblfecha.AutoSize = true;
            this.Lblfecha.BackColor = System.Drawing.Color.MidnightBlue;
            this.Lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblfecha.ForeColor = System.Drawing.Color.White;
            this.Lblfecha.Location = new System.Drawing.Point(328, 55);
            this.Lblfecha.Name = "Lblfecha";
            this.Lblfecha.Size = new System.Drawing.Size(0, 20);
            this.Lblfecha.TabIndex = 2002;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label5.Location = new System.Drawing.Point(317, 24);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(131, 22);
            this.Label5.TabIndex = 2001;
            this.Label5.Text = "Fecha Sistema";
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.BackColor = System.Drawing.Color.OrangeRed;
            this.BTNSALIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNSALIR.Location = new System.Drawing.Point(463, 251);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(125, 38);
            this.BTNSALIR.TabIndex = 2000;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.UseVisualStyleBackColor = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // BTNINGRESAR
            // 
            this.BTNINGRESAR.BackColor = System.Drawing.Color.DarkGreen;
            this.BTNINGRESAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNINGRESAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNINGRESAR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNINGRESAR.Location = new System.Drawing.Point(331, 251);
            this.BTNINGRESAR.Name = "BTNINGRESAR";
            this.BTNINGRESAR.Size = new System.Drawing.Size(125, 38);
            this.BTNINGRESAR.TabIndex = 1999;
            this.BTNINGRESAR.Text = "INGRESAR";
            this.BTNINGRESAR.UseVisualStyleBackColor = false;
            this.BTNINGRESAR.Click += new System.EventHandler(this.BTNINGRESAR_Click);
            // 
            // TXTCONTRASEÑA
            // 
            this.TXTCONTRASEÑA.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TXTCONTRASEÑA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTCONTRASEÑA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCONTRASEÑA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TXTCONTRASEÑA.Location = new System.Drawing.Point(341, 201);
            this.TXTCONTRASEÑA.MaxLength = 50;
            this.TXTCONTRASEÑA.Name = "TXTCONTRASEÑA";
            this.TXTCONTRASEÑA.Size = new System.Drawing.Size(232, 26);
            this.TXTCONTRASEÑA.TabIndex = 1998;
            this.TXTCONTRASEÑA.UseSystemPasswordChar = true;
            this.TXTCONTRASEÑA.Click += new System.EventHandler(this.TXTCONTRASEÑA_Click);
            this.TXTCONTRASEÑA.TextChanged += new System.EventHandler(this.TXTCONTRASEÑA_TextChanged);
            // 
            // TXTUSUARIO
            // 
            this.TXTUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUSUARIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TXTUSUARIO.Location = new System.Drawing.Point(341, 139);
            this.TXTUSUARIO.MaxLength = 50;
            this.TXTUSUARIO.Name = "TXTUSUARIO";
            this.TXTUSUARIO.Size = new System.Drawing.Size(232, 26);
            this.TXTUSUARIO.TabIndex = 1997;
            this.TXTUSUARIO.Click += new System.EventHandler(this.TXTUSUARIO_Click);
            this.TXTUSUARIO.TextChanged += new System.EventHandler(this.TXTUSUARIO_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label2.Location = new System.Drawing.Point(405, 175);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 22);
            this.Label2.TabIndex = 1996;
            this.Label2.Text = "Contraseña:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(415, 113);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(78, 22);
            this.Label1.TabIndex = 1995;
            this.Label1.Text = "Usuario:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmLoguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(634, 319);
            this.Controls.Add(this.Lblhora);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Lblfecha);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.BTNINGRESAR);
            this.Controls.Add(this.TXTCONTRASEÑA);
            this.Controls.Add(this.TXTUSUARIO);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loguin FACTUFACIL";
            this.Load += new System.EventHandler(this.FrmLoguin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Lblhora;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Lblfecha;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button BTNSALIR;
        internal System.Windows.Forms.Button BTNINGRESAR;
        internal System.Windows.Forms.TextBox TXTCONTRASEÑA;
        internal System.Windows.Forms.TextBox TXTUSUARIO;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer timer1;
    }
}