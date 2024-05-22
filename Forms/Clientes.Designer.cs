namespace Sistema_SISDON_Proyecto_TPOO.Forms
{
	partial class Clientes
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
			this.dgv_Display = new System.Windows.Forms.DataGridView();
			this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellidoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefonoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.correoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.creadoEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.actualizadoEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rfcClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tortilleriaDonTitoDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tortilleriaDonTitoDBDataSet = new Sistema_SISDON_Proyecto_TPOO.TortilleriaDonTitoDBDataSet();
			this.btn_Nuevo = new System.Windows.Forms.Button();
			this.btn_Eliminar = new System.Windows.Forms.Button();
			this.btn_Modificar = new System.Windows.Forms.Button();
			this.txt_idbuscar = new System.Windows.Forms.TextBox();
			this.btn_leer = new System.Windows.Forms.Button();
			this.dtp_actualizadoen = new System.Windows.Forms.DateTimePicker();
			this.dtp_creadoen = new System.Windows.Forms.DateTimePicker();
			this.tbox_rfc = new System.Windows.Forms.TextBox();
			this.tbox_telefono = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbox_apellido = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbox_nombre = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbox_correo = new System.Windows.Forms.TextBox();
			this.tbox_id = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btn_limpiar = new System.Windows.Forms.Button();
			this.btn_buscar = new System.Windows.Forms.Button();
			this.tbox_buscar = new System.Windows.Forms.TextBox();
			this.lblRFCError = new System.Windows.Forms.Label();
			this.lblCorreoError = new System.Windows.Forms.Label();
			this.lblTelefonoError = new System.Windows.Forms.Label();
			this.lblApellidosError = new System.Windows.Forms.Label();
			this.lblNombreError = new System.Windows.Forms.Label();
			this.clienteTableAdapter = new Sistema_SISDON_Proyecto_TPOO.TortilleriaDonTitoDBDataSetTableAdapters.clienteTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Display)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_Display
			// 
			this.dgv_Display.AllowUserToAddRows = false;
			this.dgv_Display.AllowUserToDeleteRows = false;
			this.dgv_Display.AllowUserToResizeColumns = false;
			this.dgv_Display.AllowUserToResizeRows = false;
			this.dgv_Display.AutoGenerateColumns = false;
			this.dgv_Display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Display.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.apellidoClienteDataGridViewTextBoxColumn,
            this.telefonoClienteDataGridViewTextBoxColumn,
            this.correoClienteDataGridViewTextBoxColumn,
            this.creadoEnDataGridViewTextBoxColumn,
            this.actualizadoEnDataGridViewTextBoxColumn,
            this.rfcClienteDataGridViewTextBoxColumn});
			this.dgv_Display.DataSource = this.clienteBindingSource;
			this.dgv_Display.Location = new System.Drawing.Point(3, 379);
			this.dgv_Display.Name = "dgv_Display";
			this.dgv_Display.ReadOnly = true;
			this.dgv_Display.Size = new System.Drawing.Size(773, 238);
			this.dgv_Display.TabIndex = 4;
			this.dgv_Display.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Display_CellContentClick);
			// 
			// idClienteDataGridViewTextBoxColumn
			// 
			this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
			this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
			this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
			this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nombreClienteDataGridViewTextBoxColumn
			// 
			this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "nombreCliente";
			this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "nombreCliente";
			this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
			this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// apellidoClienteDataGridViewTextBoxColumn
			// 
			this.apellidoClienteDataGridViewTextBoxColumn.DataPropertyName = "apellidoCliente";
			this.apellidoClienteDataGridViewTextBoxColumn.HeaderText = "apellidoCliente";
			this.apellidoClienteDataGridViewTextBoxColumn.Name = "apellidoClienteDataGridViewTextBoxColumn";
			this.apellidoClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// telefonoClienteDataGridViewTextBoxColumn
			// 
			this.telefonoClienteDataGridViewTextBoxColumn.DataPropertyName = "telefonoCliente";
			this.telefonoClienteDataGridViewTextBoxColumn.HeaderText = "telefonoCliente";
			this.telefonoClienteDataGridViewTextBoxColumn.Name = "telefonoClienteDataGridViewTextBoxColumn";
			this.telefonoClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// correoClienteDataGridViewTextBoxColumn
			// 
			this.correoClienteDataGridViewTextBoxColumn.DataPropertyName = "correoCliente";
			this.correoClienteDataGridViewTextBoxColumn.HeaderText = "correoCliente";
			this.correoClienteDataGridViewTextBoxColumn.Name = "correoClienteDataGridViewTextBoxColumn";
			this.correoClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// creadoEnDataGridViewTextBoxColumn
			// 
			this.creadoEnDataGridViewTextBoxColumn.DataPropertyName = "creadoEn";
			this.creadoEnDataGridViewTextBoxColumn.HeaderText = "creadoEn";
			this.creadoEnDataGridViewTextBoxColumn.Name = "creadoEnDataGridViewTextBoxColumn";
			this.creadoEnDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// actualizadoEnDataGridViewTextBoxColumn
			// 
			this.actualizadoEnDataGridViewTextBoxColumn.DataPropertyName = "actualizadoEn";
			this.actualizadoEnDataGridViewTextBoxColumn.HeaderText = "actualizadoEn";
			this.actualizadoEnDataGridViewTextBoxColumn.Name = "actualizadoEnDataGridViewTextBoxColumn";
			this.actualizadoEnDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// rfcClienteDataGridViewTextBoxColumn
			// 
			this.rfcClienteDataGridViewTextBoxColumn.DataPropertyName = "rfcCliente";
			this.rfcClienteDataGridViewTextBoxColumn.HeaderText = "rfcCliente";
			this.rfcClienteDataGridViewTextBoxColumn.Name = "rfcClienteDataGridViewTextBoxColumn";
			this.rfcClienteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// clienteBindingSource
			// 
			this.clienteBindingSource.DataMember = "cliente";
			this.clienteBindingSource.DataSource = this.tortilleriaDonTitoDBDataSetBindingSource;
			// 
			// tortilleriaDonTitoDBDataSetBindingSource
			// 
			this.tortilleriaDonTitoDBDataSetBindingSource.DataSource = this.tortilleriaDonTitoDBDataSet;
			this.tortilleriaDonTitoDBDataSetBindingSource.Position = 0;
			this.tortilleriaDonTitoDBDataSetBindingSource.CurrentChanged += new System.EventHandler(this.tortilleriaDonTitoDBDataSetBindingSource_CurrentChanged);
			// 
			// tortilleriaDonTitoDBDataSet
			// 
			this.tortilleriaDonTitoDBDataSet.DataSetName = "TortilleriaDonTitoDBDataSet";
			this.tortilleriaDonTitoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// btn_Nuevo
			// 
			this.btn_Nuevo.Location = new System.Drawing.Point(538, 24);
			this.btn_Nuevo.Name = "btn_Nuevo";
			this.btn_Nuevo.Size = new System.Drawing.Size(91, 72);
			this.btn_Nuevo.TabIndex = 5;
			this.btn_Nuevo.Text = "Nuevo";
			this.btn_Nuevo.UseVisualStyleBackColor = true;
			this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
			// 
			// btn_Eliminar
			// 
			this.btn_Eliminar.Location = new System.Drawing.Point(635, 24);
			this.btn_Eliminar.Name = "btn_Eliminar";
			this.btn_Eliminar.Size = new System.Drawing.Size(91, 72);
			this.btn_Eliminar.TabIndex = 6;
			this.btn_Eliminar.Text = "Eliminar";
			this.btn_Eliminar.UseVisualStyleBackColor = true;
			this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
			// 
			// btn_Modificar
			// 
			this.btn_Modificar.Location = new System.Drawing.Point(538, 102);
			this.btn_Modificar.Name = "btn_Modificar";
			this.btn_Modificar.Size = new System.Drawing.Size(91, 72);
			this.btn_Modificar.TabIndex = 7;
			this.btn_Modificar.Text = "Modificar";
			this.btn_Modificar.UseVisualStyleBackColor = true;
			this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
			// 
			// txt_idbuscar
			// 
			this.txt_idbuscar.Location = new System.Drawing.Point(538, 198);
			this.txt_idbuscar.Name = "txt_idbuscar";
			this.txt_idbuscar.Size = new System.Drawing.Size(188, 20);
			this.txt_idbuscar.TabIndex = 9;
			this.txt_idbuscar.TextChanged += new System.EventHandler(this.txt_idbuscar_TextChanged);
			// 
			// btn_leer
			// 
			this.btn_leer.Location = new System.Drawing.Point(635, 102);
			this.btn_leer.Name = "btn_leer";
			this.btn_leer.Size = new System.Drawing.Size(91, 72);
			this.btn_leer.TabIndex = 10;
			this.btn_leer.Text = "Leer";
			this.btn_leer.UseVisualStyleBackColor = true;
			this.btn_leer.Click += new System.EventHandler(this.btn_leer_Click);
			// 
			// dtp_actualizadoen
			// 
			this.dtp_actualizadoen.Enabled = false;
			this.dtp_actualizadoen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_actualizadoen.Location = new System.Drawing.Point(253, 106);
			this.dtp_actualizadoen.Name = "dtp_actualizadoen";
			this.dtp_actualizadoen.Size = new System.Drawing.Size(100, 20);
			this.dtp_actualizadoen.TabIndex = 29;
			// 
			// dtp_creadoen
			// 
			this.dtp_creadoen.Enabled = false;
			this.dtp_creadoen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_creadoen.Location = new System.Drawing.Point(147, 105);
			this.dtp_creadoen.Name = "dtp_creadoen";
			this.dtp_creadoen.Size = new System.Drawing.Size(100, 20);
			this.dtp_creadoen.TabIndex = 28;
			// 
			// tbox_rfc
			// 
			this.tbox_rfc.Location = new System.Drawing.Point(21, 333);
			this.tbox_rfc.Name = "tbox_rfc";
			this.tbox_rfc.Size = new System.Drawing.Size(100, 20);
			this.tbox_rfc.TabIndex = 30;
			this.tbox_rfc.TextChanged += new System.EventHandler(this.tbox_rfc_TextChanged);
			// 
			// tbox_telefono
			// 
			this.tbox_telefono.Location = new System.Drawing.Point(21, 247);
			this.tbox_telefono.Name = "tbox_telefono";
			this.tbox_telefono.Size = new System.Drawing.Size(100, 20);
			this.tbox_telefono.TabIndex = 24;
			this.tbox_telefono.TextChanged += new System.EventHandler(this.tbox_telefono_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(18, 317);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(28, 13);
			this.label8.TabIndex = 25;
			this.label8.Text = "RFC";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 232);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 26;
			this.label4.Text = "Telefono:";
			// 
			// tbox_apellido
			// 
			this.tbox_apellido.Location = new System.Drawing.Point(21, 202);
			this.tbox_apellido.Name = "tbox_apellido";
			this.tbox_apellido.Size = new System.Drawing.Size(100, 20);
			this.tbox_apellido.TabIndex = 23;
			this.tbox_apellido.TextChanged += new System.EventHandler(this.tbox_apellido_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(250, 90);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "Fecha actualizacion";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 187);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 21;
			this.label3.Text = "Apellidos:";
			// 
			// tbox_nombre
			// 
			this.tbox_nombre.Location = new System.Drawing.Point(21, 154);
			this.tbox_nombre.Name = "tbox_nombre";
			this.tbox_nombre.Size = new System.Drawing.Size(100, 20);
			this.tbox_nombre.TabIndex = 22;
			this.tbox_nombre.TextChanged += new System.EventHandler(this.tbox_nombre_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(144, 89);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Fecha Creacion";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 18;
			this.label2.Text = "Nombre:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 272);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Correo:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "ID:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// tbox_correo
			// 
			this.tbox_correo.Location = new System.Drawing.Point(21, 288);
			this.tbox_correo.Name = "tbox_correo";
			this.tbox_correo.Size = new System.Drawing.Size(100, 20);
			this.tbox_correo.TabIndex = 27;
			this.tbox_correo.TextChanged += new System.EventHandler(this.tbox_correo_TextChanged);
			// 
			// tbox_id
			// 
			this.tbox_id.Enabled = false;
			this.tbox_id.Location = new System.Drawing.Point(21, 106);
			this.tbox_id.Name = "tbox_id";
			this.tbox_id.Size = new System.Drawing.Size(100, 20);
			this.tbox_id.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(557, 182);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(148, 13);
			this.label9.TabIndex = 32;
			this.label9.Text = "ID a Eliminar, Modificar o Leer";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// btn_limpiar
			// 
			this.btn_limpiar.Location = new System.Drawing.Point(307, 40);
			this.btn_limpiar.Name = "btn_limpiar";
			this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
			this.btn_limpiar.TabIndex = 33;
			this.btn_limpiar.Text = "Limpiar";
			this.btn_limpiar.UseVisualStyleBackColor = true;
			this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
			// 
			// btn_buscar
			// 
			this.btn_buscar.Location = new System.Drawing.Point(226, 40);
			this.btn_buscar.Name = "btn_buscar";
			this.btn_buscar.Size = new System.Drawing.Size(75, 23);
			this.btn_buscar.TabIndex = 34;
			this.btn_buscar.Text = "Buscar";
			this.btn_buscar.UseVisualStyleBackColor = true;
			this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
			// 
			// tbox_buscar
			// 
			this.tbox_buscar.Location = new System.Drawing.Point(12, 40);
			this.tbox_buscar.Name = "tbox_buscar";
			this.tbox_buscar.Size = new System.Drawing.Size(208, 20);
			this.tbox_buscar.TabIndex = 35;
			this.tbox_buscar.TextChanged += new System.EventHandler(this.tbox_buscar_TextChanged);
			// 
			// lblRFCError
			// 
			this.lblRFCError.AutoSize = true;
			this.lblRFCError.ForeColor = System.Drawing.Color.Red;
			this.lblRFCError.Location = new System.Drawing.Point(144, 336);
			this.lblRFCError.Name = "lblRFCError";
			this.lblRFCError.Size = new System.Drawing.Size(35, 13);
			this.lblRFCError.TabIndex = 40;
			this.lblRFCError.Text = "label6";
			// 
			// lblCorreoError
			// 
			this.lblCorreoError.AutoSize = true;
			this.lblCorreoError.ForeColor = System.Drawing.Color.Red;
			this.lblCorreoError.Location = new System.Drawing.Point(144, 291);
			this.lblCorreoError.Name = "lblCorreoError";
			this.lblCorreoError.Size = new System.Drawing.Size(35, 13);
			this.lblCorreoError.TabIndex = 39;
			this.lblCorreoError.Text = "label5";
			// 
			// lblTelefonoError
			// 
			this.lblTelefonoError.AutoSize = true;
			this.lblTelefonoError.ForeColor = System.Drawing.Color.Red;
			this.lblTelefonoError.Location = new System.Drawing.Point(144, 250);
			this.lblTelefonoError.Name = "lblTelefonoError";
			this.lblTelefonoError.Size = new System.Drawing.Size(35, 13);
			this.lblTelefonoError.TabIndex = 38;
			this.lblTelefonoError.Text = "label4";
			// 
			// lblApellidosError
			// 
			this.lblApellidosError.AutoSize = true;
			this.lblApellidosError.ForeColor = System.Drawing.Color.Red;
			this.lblApellidosError.Location = new System.Drawing.Point(144, 205);
			this.lblApellidosError.Name = "lblApellidosError";
			this.lblApellidosError.Size = new System.Drawing.Size(35, 13);
			this.lblApellidosError.TabIndex = 37;
			this.lblApellidosError.Text = "label3";
			// 
			// lblNombreError
			// 
			this.lblNombreError.AutoSize = true;
			this.lblNombreError.ForeColor = System.Drawing.Color.Red;
			this.lblNombreError.Location = new System.Drawing.Point(144, 157);
			this.lblNombreError.Name = "lblNombreError";
			this.lblNombreError.Size = new System.Drawing.Size(35, 13);
			this.lblNombreError.TabIndex = 36;
			this.lblNombreError.Text = "label2";
			// 
			// clienteTableAdapter
			// 
			this.clienteTableAdapter.ClearBeforeFill = true;
			// 
			// Clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 629);
			this.Controls.Add(this.lblRFCError);
			this.Controls.Add(this.lblCorreoError);
			this.Controls.Add(this.lblTelefonoError);
			this.Controls.Add(this.lblApellidosError);
			this.Controls.Add(this.lblNombreError);
			this.Controls.Add(this.tbox_buscar);
			this.Controls.Add(this.btn_buscar);
			this.Controls.Add(this.btn_limpiar);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dtp_actualizadoen);
			this.Controls.Add(this.dtp_creadoen);
			this.Controls.Add(this.tbox_rfc);
			this.Controls.Add(this.tbox_telefono);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbox_apellido);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbox_nombre);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbox_correo);
			this.Controls.Add(this.tbox_id);
			this.Controls.Add(this.btn_leer);
			this.Controls.Add(this.txt_idbuscar);
			this.Controls.Add(this.btn_Modificar);
			this.Controls.Add(this.btn_Eliminar);
			this.Controls.Add(this.btn_Nuevo);
			this.Controls.Add(this.dgv_Display);
			this.Name = "Clientes";
			this.Text = "Clientes";
			this.Load += new System.EventHandler(this.Clientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Display)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.DataGridView dgv_Display;
        private System.Windows.Forms.BindingSource tortilleriaDonTitoDBDataSetBindingSource;
        private TortilleriaDonTitoDBDataSet tortilleriaDonTitoDBDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private TortilleriaDonTitoDBDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creadoEnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualizadoEnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfcClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox txt_idbuscar;
        private System.Windows.Forms.Button btn_leer;
        private System.Windows.Forms.DateTimePicker dtp_actualizadoen;
        private System.Windows.Forms.DateTimePicker dtp_creadoen;
        private System.Windows.Forms.TextBox tbox_rfc;
        private System.Windows.Forms.TextBox tbox_telefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_apellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_correo;
        private System.Windows.Forms.TextBox tbox_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox tbox_buscar;
        private System.Windows.Forms.Label lblRFCError;
        private System.Windows.Forms.Label lblCorreoError;
        private System.Windows.Forms.Label lblTelefonoError;
        private System.Windows.Forms.Label lblApellidosError;
        private System.Windows.Forms.Label lblNombreError;
    }
}