namespace CapaPresentacion
{
    partial class frmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            this.gbxListado = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero_Documento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxTipo_Documento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRazon_Social = new System.Windows.Forms.TextBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxListado
            // 
            this.gbxListado.Controls.Add(this.dgvListado);
            this.gbxListado.Controls.Add(this.chkEliminar);
            this.gbxListado.Controls.Add(this.btnEliminar);
            this.gbxListado.Controls.Add(this.txtBusqueda);
            this.gbxListado.Controls.Add(this.label11);
            this.gbxListado.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.gbxListado.Location = new System.Drawing.Point(16, 260);
            this.gbxListado.Name = "gbxListado";
            this.gbxListado.Size = new System.Drawing.Size(913, 266);
            this.gbxListado.TabIndex = 30;
            this.gbxListado.TabStop = false;
            this.gbxListado.Text = "Listado";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToOrderColumns = true;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListado.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvListado.Location = new System.Drawing.Point(21, 64);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(883, 196);
            this.dgvListado.TabIndex = 29;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.DoubleClick += new System.EventHandler(this.dgvListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 62;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(674, 30);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(149, 24);
            this.chkEliminar.TabIndex = 27;
            this.chkEliminar.Text = "Marcar para Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnEliminar.Location = new System.Drawing.Point(829, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 33);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtBusqueda.Location = new System.Drawing.Point(193, 28);
            this.txtBusqueda.MaxLength = 10;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(144, 26);
            this.txtBusqueda.TabIndex = 24;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label11.Location = new System.Drawing.Point(17, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Busqueda por Documento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(303, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 42);
            this.label1.TabIndex = 28;
            this.label1.Text = "PROVEEDORES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNumero_Documento);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbxTipo_Documento);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtRazon_Social);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.groupBox1.Location = new System.Drawing.Point(15, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 218);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtID.Location = new System.Drawing.Point(49, 173);
            this.txtID.MaxLength = 50;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(38, 26);
            this.txtID.TabIndex = 32;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(517, 151);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 33);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label12.Location = new System.Drawing.Point(18, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon Social:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnEditar.Location = new System.Drawing.Point(517, 112);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 33);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnGuardar.Location = new System.Drawing.Point(517, 73);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 33);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btnNuevo.Location = new System.Drawing.Point(517, 34);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 33);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtDireccion.Location = new System.Drawing.Point(98, 133);
            this.txtDireccion.MaxLength = 150;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccion.Size = new System.Drawing.Size(395, 66);
            this.txtDireccion.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label6.Location = new System.Drawing.Point(18, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de Documento:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtCorreo.Location = new System.Drawing.Point(275, 97);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(218, 26);
            this.txtCorreo.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label7.Location = new System.Drawing.Point(215, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numero de Documento:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtTelefono.Location = new System.Drawing.Point(89, 97);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(120, 26);
            this.txtTelefono.TabIndex = 16;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label8.Location = new System.Drawing.Point(18, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dirección:";
            // 
            // txtNumero_Documento
            // 
            this.txtNumero_Documento.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtNumero_Documento.Location = new System.Drawing.Point(373, 22);
            this.txtNumero_Documento.MaxLength = 10;
            this.txtNumero_Documento.Name = "txtNumero_Documento";
            this.txtNumero_Documento.Size = new System.Drawing.Size(120, 26);
            this.txtNumero_Documento.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label9.Location = new System.Drawing.Point(18, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telefono:";
            // 
            // cbxTipo_Documento
            // 
            this.cbxTipo_Documento.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.cbxTipo_Documento.FormattingEnabled = true;
            this.cbxTipo_Documento.Items.AddRange(new object[] {
            "C.I",
            "RIF"});
            this.cbxTipo_Documento.Location = new System.Drawing.Point(155, 22);
            this.cbxTipo_Documento.Name = "cbxTipo_Documento";
            this.cbxTipo_Documento.Size = new System.Drawing.Size(54, 28);
            this.cbxTipo_Documento.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label10.Location = new System.Drawing.Point(215, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Correo:";
            // 
            // txtRazon_Social
            // 
            this.txtRazon_Social.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtRazon_Social.Location = new System.Drawing.Point(116, 61);
            this.txtRazon_Social.MaxLength = 50;
            this.txtRazon_Social.Name = "txtRazon_Social";
            this.txtRazon_Social.Size = new System.Drawing.Size(377, 26);
            this.txtRazon_Social.TabIndex = 10;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(633, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(941, 528);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxListado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedor";
            this.Padding = new System.Windows.Forms.Padding(100);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PROVEEDORES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProveedor_FormClosing);
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            this.gbxListado.ResumeLayout(false);
            this.gbxListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxListado;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero_Documento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxTipo_Documento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRazon_Social;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}