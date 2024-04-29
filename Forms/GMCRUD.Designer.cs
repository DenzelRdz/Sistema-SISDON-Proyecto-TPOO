namespace Sistema_SISDON_Proyecto_TPOO.Forms
{
	partial class GMCRUD
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.tortilleriaDonTitoDBDataSet = new Sistema_SISDON_Proyecto_TPOO.TortilleriaDonTitoDBDataSet();
			this.detalle_pedidoTableAdapter = new Sistema_SISDON_Proyecto_TPOO.TortilleriaDonTitoDBDataSetTableAdapters.detalle_pedidoTableAdapter();
			this.tortilleriaDonTitoDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clienteTableAdapter = new Sistema_SISDON_Proyecto_TPOO.TortilleriaDonTitoDBDataSetTableAdapters.clienteTableAdapter();
			this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellidoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefonoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.correoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.creadoEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.actualizadoEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rfcClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.apellidoClienteDataGridViewTextBoxColumn,
            this.telefonoClienteDataGridViewTextBoxColumn,
            this.correoClienteDataGridViewTextBoxColumn,
            this.creadoEnDataGridViewTextBoxColumn,
            this.actualizadoEnDataGridViewTextBoxColumn,
            this.rfcClienteDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.clienteBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 39);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(776, 289);
			this.dataGridView1.TabIndex = 0;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Clientes",
            "Detalles de Pedidos",
            "Detalles de Ventas",
            "Empleados",
            "Inventario",
            "Metodos de Pago",
            "Pedidos",
            "Ventas"});
			this.comboBox1.Location = new System.Drawing.Point(12, 12);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 1;
			// 
			// tortilleriaDonTitoDBDataSet
			// 
			this.tortilleriaDonTitoDBDataSet.DataSetName = "TortilleriaDonTitoDBDataSet";
			this.tortilleriaDonTitoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// detalle_pedidoTableAdapter
			// 
			this.detalle_pedidoTableAdapter.ClearBeforeFill = true;
			// 
			// tortilleriaDonTitoDBDataSetBindingSource
			// 
			this.tortilleriaDonTitoDBDataSetBindingSource.DataSource = this.tortilleriaDonTitoDBDataSet;
			this.tortilleriaDonTitoDBDataSetBindingSource.Position = 0;
			// 
			// clienteBindingSource
			// 
			this.clienteBindingSource.DataMember = "cliente";
			this.clienteBindingSource.DataSource = this.tortilleriaDonTitoDBDataSet;
			// 
			// clienteTableAdapter
			// 
			this.clienteTableAdapter.ClearBeforeFill = true;
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
			// GMCRUD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "GMCRUD";
			this.Text = "GMCRUD";
			this.Load += new System.EventHandler(this.GMCRUD_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBox1;
		private TortilleriaDonTitoDBDataSet tortilleriaDonTitoDBDataSet;
		private TortilleriaDonTitoDBDataSetTableAdapters.detalle_pedidoTableAdapter detalle_pedidoTableAdapter;
		private System.Windows.Forms.BindingSource tortilleriaDonTitoDBDataSetBindingSource;
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
	}
}