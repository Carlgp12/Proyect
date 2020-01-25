namespace CapaPresentacion
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.gbxListado = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNumero_Documento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxTipo_Documento = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
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
            resources.ApplyResources(this.gbxListado, "gbxListado");
            this.gbxListado.Name = "gbxListado";
            this.gbxListado.TabStop = false;
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
            resources.ApplyResources(this.dgvListado, "dgvListado");
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.DoubleClick += new System.EventHandler(this.dgvListado_DoubleClick);
            // 
            // Eliminar
            // 
            resources.ApplyResources(this.Eliminar, "Eliminar");
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // chkEliminar
            // 
            resources.ApplyResources(this.chkEliminar, "chkEliminar");
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBusqueda
            // 
            resources.ApplyResources(this.txtBusqueda, "txtBusqueda");
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecha_Nacimiento);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.cbxCargo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNumero_Documento);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbxTipo_Documento);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cbxSexo);
            this.groupBox1.Controls.Add(this.txtApellido);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dtpFecha_Nacimiento
            // 
            resources.ApplyResources(this.dtpFecha_Nacimiento, "dtpFecha_Nacimiento");
            this.dtpFecha_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_Nacimiento.Name = "dtpFecha_Nacimiento";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // txtClave
            // 
            resources.ApplyResources(this.txtClave, "txtClave");
            this.txtClave.Name = "txtClave";
            // 
            // cbxCargo
            // 
            resources.ApplyResources(this.cbxCargo, "cbxCargo");
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Items.AddRange(new object[] {
            resources.GetString("cbxCargo.Items"),
            resources.GetString("cbxCargo.Items1"),
            resources.GetString("cbxCargo.Items2")});
            this.cbxCargo.Name = "cbxCargo";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtCorreo
            // 
            resources.ApplyResources(this.txtCorreo, "txtCorreo");
            this.txtCorreo.Name = "txtCorreo";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnEditar, "btnEditar");
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnGuardar, "btnGuardar");
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnNuevo, "btnNuevo");
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtDireccion
            // 
            resources.ApplyResources(this.txtDireccion, "txtDireccion");
            this.txtDireccion.Name = "txtDireccion";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtTelefono
            // 
            resources.ApplyResources(this.txtTelefono, "txtTelefono");
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtNumero_Documento
            // 
            resources.ApplyResources(this.txtNumero_Documento, "txtNumero_Documento");
            this.txtNumero_Documento.Name = "txtNumero_Documento";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // cbxTipo_Documento
            // 
            resources.ApplyResources(this.cbxTipo_Documento, "cbxTipo_Documento");
            this.cbxTipo_Documento.FormattingEnabled = true;
            this.cbxTipo_Documento.Items.AddRange(new object[] {
            resources.GetString("cbxTipo_Documento.Items"),
            resources.GetString("cbxTipo_Documento.Items1")});
            this.cbxTipo_Documento.Name = "cbxTipo_Documento";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cbxSexo
            // 
            resources.ApplyResources(this.cbxSexo, "cbxSexo");
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            resources.GetString("cbxSexo.Items"),
            resources.GetString("cbxSexo.Items1")});
            this.cbxSexo.Name = "cbxSexo";
            // 
            // txtApellido
            // 
            resources.ApplyResources(this.txtApellido, "txtApellido");
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmEmpleado
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxListado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEmpleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DateTimePicker dtpFecha_Nacimiento;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}