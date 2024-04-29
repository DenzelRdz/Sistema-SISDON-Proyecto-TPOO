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
			this.dgv_Display = new System.Windows.Forms.DataGridView();
			this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tortilleriaDonTitoDBDataSet = new Sistema_SISDON_Proyecto_TPOO.TortilleriaDonTitoDBDataSet();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.clienteTableAdapter = new Sistema_SISDON_Proyecto_TPOO.TortilleriaDonTitoDBDataSetTableAdapters.clienteTableAdapter();
			this.detallepedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.detalle_pedidoTableAdapter = new Sistema_SISDON_Proyecto_TPOO.TortilleriaDonTitoDBDataSetTableAdapters.detalle_pedidoTableAdapter();
			this.idPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidadProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.creadoEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.actualizadoEnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Display)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.detallepedidoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_Display
			// 
			this.dgv_Display.AutoGenerateColumns = false;
			this.dgv_Display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Display.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedidoDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.cantidadProductoDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.creadoEnDataGridViewTextBoxColumn,
            this.actualizadoEnDataGridViewTextBoxColumn,
            this.idEmpleadoDataGridViewTextBoxColumn});
			this.dgv_Display.DataSource = this.detallepedidoBindingSource;
			this.dgv_Display.Location = new System.Drawing.Point(12, 39);
			this.dgv_Display.Name = "dgv_Display";
			this.dgv_Display.Size = new System.Drawing.Size(776, 289);
			this.dgv_Display.TabIndex = 0;
			// 
			// clienteBindingSource
			// 
			this.clienteBindingSource.DataMember = "cliente";
			this.clienteBindingSource.DataSource = this.tortilleriaDonTitoDBDataSet;
			// 
			// tortilleriaDonTitoDBDataSet
			// 
			this.tortilleriaDonTitoDBDataSet.DataSetName = "TortilleriaDonTitoDBDataSet";
			this.tortilleriaDonTitoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			// clienteTableAdapter
			// 
			this.clienteTableAdapter.ClearBeforeFill = true;
			// 
			// detallepedidoBindingSource
			// 
			this.detallepedidoBindingSource.DataMember = "detalle_pedido";
			this.detallepedidoBindingSource.DataSource = this.tortilleriaDonTitoDBDataSet;
			// 
			// detalle_pedidoTableAdapter
			// 
			this.detalle_pedidoTableAdapter.ClearBeforeFill = true;
			// 
			// idPedidoDataGridViewTextBoxColumn
			// 
			this.idPedidoDataGridViewTextBoxColumn.DataPropertyName = "idPedido";
			this.idPedidoDataGridViewTextBoxColumn.HeaderText = "idPedido";
			this.idPedidoDataGridViewTextBoxColumn.Name = "idPedidoDataGridViewTextBoxColumn";
			// 
			// idProductoDataGridViewTextBoxColumn
			// 
			this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
			this.idProductoDataGridViewTextBoxColumn.HeaderText = "idProducto";
			this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
			// 
			// cantidadProductoDataGridViewTextBoxColumn
			// 
			this.cantidadProductoDataGridViewTextBoxColumn.DataPropertyName = "cantidadProducto";
			this.cantidadProductoDataGridViewTextBoxColumn.HeaderText = "cantidadProducto";
			this.cantidadProductoDataGridViewTextBoxColumn.Name = "cantidadProductoDataGridViewTextBoxColumn";
			// 
			// precioUnitarioDataGridViewTextBoxColumn
			// 
			this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "precioUnitario";
			this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "precioUnitario";
			this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
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
			// idEmpleadoDataGridViewTextBoxColumn
			// 
			this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "idEmpleado";
			this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "idEmpleado";
			this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
			// 
			// GMCRUD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dgv_Display);
			this.Name = "GMCRUD";
			this.Text = "GMCRUD";
			this.Load += new System.EventHandler(this.GMCRUD_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Display)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.detallepedidoBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_Display;
		private System.Windows.Forms.ComboBox comboBox1;
		private TortilleriaDonTitoDBDataSet tortilleriaDonTitoDBDataSet;
		private System.Windows.Forms.BindingSource clienteBindingSource;
		private TortilleriaDonTitoDBDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
		private System.Windows.Forms.BindingSource detallepedidoBindingSource;
		private TortilleriaDonTitoDBDataSetTableAdapters.detalle_pedidoTableAdapter detalle_pedidoTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn creadoEnDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn actualizadoEnDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
	}
}