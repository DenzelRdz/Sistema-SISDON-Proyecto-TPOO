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
            this.clienteTableAdapter = new Sistema_SISDON_Proyecto_TPOO.TortilleriaDonTitoDBDataSetTableAdapters.clienteTableAdapter();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Display
            // 
            this.dgv_Display.AllowUserToAddRows = false;
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
            this.dgv_Display.Location = new System.Drawing.Point(12, 78);
            this.dgv_Display.Name = "dgv_Display";
            this.dgv_Display.Size = new System.Drawing.Size(776, 255);
            this.dgv_Display.TabIndex = 4;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "nombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "nombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            // 
            // apellidoClienteDataGridViewTextBoxColumn
            // 
            this.apellidoClienteDataGridViewTextBoxColumn.DataPropertyName = "apellidoCliente";
            this.apellidoClienteDataGridViewTextBoxColumn.HeaderText = "apellidoCliente";
            this.apellidoClienteDataGridViewTextBoxColumn.Name = "apellidoClienteDataGridViewTextBoxColumn";
            // 
            // telefonoClienteDataGridViewTextBoxColumn
            // 
            this.telefonoClienteDataGridViewTextBoxColumn.DataPropertyName = "telefonoCliente";
            this.telefonoClienteDataGridViewTextBoxColumn.HeaderText = "telefonoCliente";
            this.telefonoClienteDataGridViewTextBoxColumn.Name = "telefonoClienteDataGridViewTextBoxColumn";
            // 
            // correoClienteDataGridViewTextBoxColumn
            // 
            this.correoClienteDataGridViewTextBoxColumn.DataPropertyName = "correoCliente";
            this.correoClienteDataGridViewTextBoxColumn.HeaderText = "correoCliente";
            this.correoClienteDataGridViewTextBoxColumn.Name = "correoClienteDataGridViewTextBoxColumn";
            // 
            // creadoEnDataGridViewTextBoxColumn
            // 
            this.creadoEnDataGridViewTextBoxColumn.DataPropertyName = "creadoEn";
            this.creadoEnDataGridViewTextBoxColumn.HeaderText = "creadoEn";
            this.creadoEnDataGridViewTextBoxColumn.Name = "creadoEnDataGridViewTextBoxColumn";
            // 
            // actualizadoEnDataGridViewTextBoxColumn
            // 
            this.actualizadoEnDataGridViewTextBoxColumn.DataPropertyName = "actualizadoEn";
            this.actualizadoEnDataGridViewTextBoxColumn.HeaderText = "actualizadoEn";
            this.actualizadoEnDataGridViewTextBoxColumn.Name = "actualizadoEnDataGridViewTextBoxColumn";
            // 
            // rfcClienteDataGridViewTextBoxColumn
            // 
            this.rfcClienteDataGridViewTextBoxColumn.DataPropertyName = "rfcCliente";
            this.rfcClienteDataGridViewTextBoxColumn.HeaderText = "rfcCliente";
            this.rfcClienteDataGridViewTextBoxColumn.Name = "rfcClienteDataGridViewTextBoxColumn";
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
            // 
            // tortilleriaDonTitoDBDataSet
            // 
            this.tortilleriaDonTitoDBDataSet.DataSetName = "TortilleriaDonTitoDBDataSet";
            this.tortilleriaDonTitoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(91, 26);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 5;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(172, 26);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 6;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(253, 26);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 7;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(545, 26);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 8;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Location = new System.Drawing.Point(439, 29);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(100, 20);
            this.txt_Buscar.TabIndex = 9;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.btn_Buscar);
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
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
    }
}