namespace sistemUsuario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPNombre = new System.Windows.Forms.Label();
            this.lblSNombre = new System.Windows.Forms.Label();
            this.lblPApellido = new System.Windows.Forms.Label();
            this.lblSApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtPNombre = new System.Windows.Forms.TextBox();
            this.txtSNombre = new System.Windows.Forms.TextBox();
            this.txtPApellido = new System.Windows.Forms.TextBox();
            this.txtSApellido = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bntGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPNombre
            // 
            this.lblPNombre.AutoSize = true;
            this.lblPNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNombre.Location = new System.Drawing.Point(50, 110);
            this.lblPNombre.Name = "lblPNombre";
            this.lblPNombre.Size = new System.Drawing.Size(128, 18);
            this.lblPNombre.TabIndex = 0;
            this.lblPNombre.Text = "Primer Nombre:";
            this.lblPNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSNombre
            // 
            this.lblSNombre.AutoSize = true;
            this.lblSNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSNombre.Location = new System.Drawing.Point(45, 159);
            this.lblSNombre.Name = "lblSNombre";
            this.lblSNombre.Size = new System.Drawing.Size(144, 18);
            this.lblSNombre.TabIndex = 1;
            this.lblSNombre.Text = "Segundo Nombre:";
            // 
            // lblPApellido
            // 
            this.lblPApellido.AutoSize = true;
            this.lblPApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPApellido.Location = new System.Drawing.Point(47, 212);
            this.lblPApellido.Name = "lblPApellido";
            this.lblPApellido.Size = new System.Drawing.Size(127, 18);
            this.lblPApellido.TabIndex = 2;
            this.lblPApellido.Text = "Primer Apellido:";
            // 
            // lblSApellido
            // 
            this.lblSApellido.AutoSize = true;
            this.lblSApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSApellido.Location = new System.Drawing.Point(46, 267);
            this.lblSApellido.Name = "lblSApellido";
            this.lblSApellido.Size = new System.Drawing.Size(143, 18);
            this.lblSApellido.TabIndex = 3;
            this.lblSApellido.Text = "Segundo Apellido:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(47, 328);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 18);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(45, 394);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(66, 18);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(45, 454);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(85, 18);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(50, 515);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(51, 18);
            this.lblEdad.TabIndex = 7;
            this.lblEdad.Text = "Edad:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(46, 571);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(69, 18);
            this.lblGenero.TabIndex = 8;
            this.lblGenero.Text = "Género:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(47, 64);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(165, 18);
            this.lblDocumento.TabIndex = 9;
            this.lblDocumento.Text = "Número Documento:";
            // 
            // txtPNombre
            // 
            this.txtPNombre.Location = new System.Drawing.Point(243, 109);
            this.txtPNombre.Name = "txtPNombre";
            this.txtPNombre.Size = new System.Drawing.Size(295, 22);
            this.txtPNombre.TabIndex = 10;
            this.txtPNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPNombre_KeyPress);
            this.txtPNombre.Validated += new System.EventHandler(this.txtPNombre_Validated);
            // 
            // txtSNombre
            // 
            this.txtSNombre.Location = new System.Drawing.Point(242, 159);
            this.txtSNombre.Name = "txtSNombre";
            this.txtSNombre.Size = new System.Drawing.Size(294, 22);
            this.txtSNombre.TabIndex = 11;
            this.txtSNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSNombre_KeyPress);
            this.txtSNombre.Validated += new System.EventHandler(this.txtSNombre_Validated);
            // 
            // txtPApellido
            // 
            this.txtPApellido.Location = new System.Drawing.Point(244, 212);
            this.txtPApellido.Name = "txtPApellido";
            this.txtPApellido.Size = new System.Drawing.Size(294, 22);
            this.txtPApellido.TabIndex = 12;
            this.txtPApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPApellido_KeyPress);
            this.txtPApellido.Validated += new System.EventHandler(this.txtPApellido_Validated);
            // 
            // txtSApellido
            // 
            this.txtSApellido.Location = new System.Drawing.Point(243, 267);
            this.txtSApellido.Name = "txtSApellido";
            this.txtSApellido.Size = new System.Drawing.Size(295, 22);
            this.txtSApellido.TabIndex = 13;
            this.txtSApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSApellido_KeyPress);
            this.txtSApellido.Validated += new System.EventHandler(this.txtSApellido_Validated);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(243, 64);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(293, 22);
            this.txtDocumento.TabIndex = 14;
            this.txtDocumento.Validated += new System.EventHandler(this.txtDocumento_Validated);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(242, 328);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(293, 22);
            this.txtTelefono.TabIndex = 15;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtTelefono.Validated += new System.EventHandler(this.txtTelefono_Validated);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(240, 394);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(295, 27);
            this.txtCorreo.TabIndex = 16;
            this.txtCorreo.Validated += new System.EventHandler(this.txtCorreo_Validated);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(240, 467);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(298, 22);
            this.txtDireccion.TabIndex = 17;
            this.txtDireccion.Validated += new System.EventHandler(this.txtDireccion_Validated);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(240, 515);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(78, 22);
            this.txtEdad.TabIndex = 18;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            this.txtEdad.Validated += new System.EventHandler(this.txtEdad_Validated);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbxImagen.Image")));
            this.pbxImagen.Location = new System.Drawing.Point(663, 64);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(318, 299);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 21;
            this.pbxImagen.TabStop = false;
            // 
            // btnInsertar
            // 
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertar.Location = new System.Drawing.Point(663, 452);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(107, 52);
            this.btnInsertar.TabIndex = 22;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(242, 568);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(295, 22);
            this.txtGenero.TabIndex = 25;
            this.txtGenero.Validated += new System.EventHandler(this.txtGenero_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bntGuardar
            // 
            this.bntGuardar.Location = new System.Drawing.Point(874, 454);
            this.bntGuardar.Name = "bntGuardar";
            this.bntGuardar.Size = new System.Drawing.Size(95, 52);
            this.bntGuardar.TabIndex = 26;
            this.bntGuardar.Text = "Guardar";
            this.bntGuardar.UseVisualStyleBackColor = true;
            this.bntGuardar.Click += new System.EventHandler(this.bntGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 627);
            this.Controls.Add(this.bntGuardar);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtSApellido);
            this.Controls.Add(this.txtPApellido);
            this.Controls.Add(this.txtSNombre);
            this.Controls.Add(this.txtPNombre);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblSApellido);
            this.Controls.Add(this.lblPApellido);
            this.Controls.Add(this.lblSNombre);
            this.Controls.Add(this.lblPNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTERFAZ DE USUARIO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPNombre;
        private System.Windows.Forms.Label lblSNombre;
        private System.Windows.Forms.Label lblPApellido;
        private System.Windows.Forms.Label lblSApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtPNombre;
        private System.Windows.Forms.TextBox txtSNombre;
        private System.Windows.Forms.TextBox txtPApellido;
        private System.Windows.Forms.TextBox txtSApellido;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button bntGuardar;
    }
}

