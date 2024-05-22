namespace Sistema_SISDON_Proyecto_TPOO.Forms
{
	partial class RealizarVenta
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
			this.gbox_TablaDeProductos = new System.Windows.Forms.GroupBox();
			this.dgv_TablaDeProductos = new System.Windows.Forms.DataGridView();
			this.gbox_Productos = new System.Windows.Forms.GroupBox();
			this.tbox_CodigoProducto = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gbox_Cliente = new System.Windows.Forms.GroupBox();
			this.lbl_StatusCliente = new System.Windows.Forms.Label();
			this.btn_IngresarCliente = new System.Windows.Forms.Button();
			this.tbox_Cliente = new System.Windows.Forms.TextBox();
			this.lbl_Cliente1 = new System.Windows.Forms.Label();
			this.gbox_Empleado = new System.Windows.Forms.GroupBox();
			this.lbl_Empleado_Status = new System.Windows.Forms.Label();
			this.btn_LogInEmpleado = new System.Windows.Forms.Button();
			this.tbox_EmpleadoID = new System.Windows.Forms.TextBox();
			this.lbl_Empleado1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbox_CantidadProd = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.gbox_Venta = new System.Windows.Forms.GroupBox();
			this.btn_PagoEnEfectivo = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btn_PagoConTarjeta = new System.Windows.Forms.Button();
			this.btn_ReiniciarVenta = new System.Windows.Forms.Button();
			this.lbl_VentaRealizadaConExito = new System.Windows.Forms.Label();
			this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precioUnitarioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbox_TablaDeProductos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_TablaDeProductos)).BeginInit();
			this.gbox_Productos.SuspendLayout();
			this.gbox_Cliente.SuspendLayout();
			this.gbox_Empleado.SuspendLayout();
			this.gbox_Venta.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbox_TablaDeProductos
			// 
			this.gbox_TablaDeProductos.Controls.Add(this.dgv_TablaDeProductos);
			this.gbox_TablaDeProductos.Location = new System.Drawing.Point(236, 12);
			this.gbox_TablaDeProductos.Name = "gbox_TablaDeProductos";
			this.gbox_TablaDeProductos.Size = new System.Drawing.Size(540, 467);
			this.gbox_TablaDeProductos.TabIndex = 0;
			this.gbox_TablaDeProductos.TabStop = false;
			this.gbox_TablaDeProductos.Text = "Tabla de Productos";
			// 
			// dgv_TablaDeProductos
			// 
			this.dgv_TablaDeProductos.AllowUserToAddRows = false;
			this.dgv_TablaDeProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_TablaDeProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.cantidadProducto,
            this.precioUnitarioProducto,
            this.precioFinal});
			this.dgv_TablaDeProductos.Location = new System.Drawing.Point(6, 16);
			this.dgv_TablaDeProductos.Name = "dgv_TablaDeProductos";
			this.dgv_TablaDeProductos.ReadOnly = true;
			this.dgv_TablaDeProductos.Size = new System.Drawing.Size(528, 429);
			this.dgv_TablaDeProductos.TabIndex = 0;
			// 
			// gbox_Productos
			// 
			this.gbox_Productos.Controls.Add(this.label3);
			this.gbox_Productos.Controls.Add(this.tbox_CantidadProd);
			this.gbox_Productos.Controls.Add(this.tbox_CodigoProducto);
			this.gbox_Productos.Controls.Add(this.label2);
			this.gbox_Productos.Location = new System.Drawing.Point(12, 83);
			this.gbox_Productos.Name = "gbox_Productos";
			this.gbox_Productos.Size = new System.Drawing.Size(218, 70);
			this.gbox_Productos.TabIndex = 0;
			this.gbox_Productos.TabStop = false;
			this.gbox_Productos.Text = "Productos";
			// 
			// tbox_CodigoProducto
			// 
			this.tbox_CodigoProducto.Location = new System.Drawing.Point(10, 36);
			this.tbox_CodigoProducto.Name = "tbox_CodigoProducto";
			this.tbox_CodigoProducto.Size = new System.Drawing.Size(154, 20);
			this.tbox_CodigoProducto.TabIndex = 3;
			this.tbox_CodigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_CodigoProducto_KeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Código del producto:";
			// 
			// gbox_Cliente
			// 
			this.gbox_Cliente.Controls.Add(this.lbl_StatusCliente);
			this.gbox_Cliente.Controls.Add(this.btn_IngresarCliente);
			this.gbox_Cliente.Controls.Add(this.tbox_Cliente);
			this.gbox_Cliente.Controls.Add(this.lbl_Cliente1);
			this.gbox_Cliente.Location = new System.Drawing.Point(12, 161);
			this.gbox_Cliente.Name = "gbox_Cliente";
			this.gbox_Cliente.Size = new System.Drawing.Size(218, 65);
			this.gbox_Cliente.TabIndex = 0;
			this.gbox_Cliente.TabStop = false;
			this.gbox_Cliente.Text = "Cliente";
			// 
			// lbl_StatusCliente
			// 
			this.lbl_StatusCliente.AutoSize = true;
			this.lbl_StatusCliente.Location = new System.Drawing.Point(7, 43);
			this.lbl_StatusCliente.Name = "lbl_StatusCliente";
			this.lbl_StatusCliente.Size = new System.Drawing.Size(95, 13);
			this.lbl_StatusCliente.TabIndex = 3;
			this.lbl_StatusCliente.Text = "Cliente sin registrar";
			// 
			// btn_IngresarCliente
			// 
			this.btn_IngresarCliente.Location = new System.Drawing.Point(157, 15);
			this.btn_IngresarCliente.Name = "btn_IngresarCliente";
			this.btn_IngresarCliente.Size = new System.Drawing.Size(55, 23);
			this.btn_IngresarCliente.TabIndex = 6;
			this.btn_IngresarCliente.Text = "Ingresar";
			this.btn_IngresarCliente.UseVisualStyleBackColor = true;
			this.btn_IngresarCliente.Click += new System.EventHandler(this.btn_IngresarCliente_Click);
			// 
			// tbox_Cliente
			// 
			this.tbox_Cliente.Location = new System.Drawing.Point(75, 16);
			this.tbox_Cliente.Name = "tbox_Cliente";
			this.tbox_Cliente.Size = new System.Drawing.Size(76, 20);
			this.tbox_Cliente.TabIndex = 5;
			// 
			// lbl_Cliente1
			// 
			this.lbl_Cliente1.AutoSize = true;
			this.lbl_Cliente1.Location = new System.Drawing.Point(7, 20);
			this.lbl_Cliente1.Name = "lbl_Cliente1";
			this.lbl_Cliente1.Size = new System.Drawing.Size(62, 13);
			this.lbl_Cliente1.TabIndex = 0;
			this.lbl_Cliente1.Text = "Ingresar ID:";
			// 
			// gbox_Empleado
			// 
			this.gbox_Empleado.Controls.Add(this.lbl_Empleado_Status);
			this.gbox_Empleado.Controls.Add(this.btn_LogInEmpleado);
			this.gbox_Empleado.Controls.Add(this.tbox_EmpleadoID);
			this.gbox_Empleado.Controls.Add(this.lbl_Empleado1);
			this.gbox_Empleado.Location = new System.Drawing.Point(12, 12);
			this.gbox_Empleado.Name = "gbox_Empleado";
			this.gbox_Empleado.Size = new System.Drawing.Size(218, 65);
			this.gbox_Empleado.TabIndex = 0;
			this.gbox_Empleado.TabStop = false;
			this.gbox_Empleado.Text = "Empleado";
			// 
			// lbl_Empleado_Status
			// 
			this.lbl_Empleado_Status.AutoSize = true;
			this.lbl_Empleado_Status.Location = new System.Drawing.Point(7, 42);
			this.lbl_Empleado_Status.Name = "lbl_Empleado_Status";
			this.lbl_Empleado_Status.Size = new System.Drawing.Size(209, 13);
			this.lbl_Empleado_Status.TabIndex = 3;
			this.lbl_Empleado_Status.Text = "Favor de ingresar ID de empleado a operar";
			// 
			// btn_LogInEmpleado
			// 
			this.btn_LogInEmpleado.Location = new System.Drawing.Point(137, 15);
			this.btn_LogInEmpleado.Name = "btn_LogInEmpleado";
			this.btn_LogInEmpleado.Size = new System.Drawing.Size(75, 23);
			this.btn_LogInEmpleado.TabIndex = 2;
			this.btn_LogInEmpleado.Text = "Ingresar";
			this.btn_LogInEmpleado.UseVisualStyleBackColor = true;
			this.btn_LogInEmpleado.Click += new System.EventHandler(this.btn_LogInEmpleado_Click);
			// 
			// tbox_EmpleadoID
			// 
			this.tbox_EmpleadoID.Location = new System.Drawing.Point(75, 16);
			this.tbox_EmpleadoID.Name = "tbox_EmpleadoID";
			this.tbox_EmpleadoID.Size = new System.Drawing.Size(56, 20);
			this.tbox_EmpleadoID.TabIndex = 1;
			// 
			// lbl_Empleado1
			// 
			this.lbl_Empleado1.AutoSize = true;
			this.lbl_Empleado1.Location = new System.Drawing.Point(7, 20);
			this.lbl_Empleado1.Name = "lbl_Empleado1";
			this.lbl_Empleado1.Size = new System.Drawing.Size(62, 13);
			this.lbl_Empleado1.TabIndex = 0;
			this.lbl_Empleado1.Text = "Ingresar ID:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(169, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(12, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "x";
			// 
			// tbox_CantidadProd
			// 
			this.tbox_CantidadProd.Location = new System.Drawing.Point(184, 36);
			this.tbox_CantidadProd.Name = "tbox_CantidadProd";
			this.tbox_CantidadProd.Size = new System.Drawing.Size(28, 20);
			this.tbox_CantidadProd.TabIndex = 4;
			this.tbox_CantidadProd.Text = "1";
			this.tbox_CantidadProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_CodigoProducto_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(237, 529);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(196, 25);
			this.label4.TabIndex = 1;
			this.label4.Text = "Cambio: $10.00MXN";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(237, 494);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(172, 25);
			this.label6.TabIndex = 1;
			this.label6.Text = "Total: $10.00MXN";
			// 
			// gbox_Venta
			// 
			this.gbox_Venta.Controls.Add(this.label9);
			this.gbox_Venta.Controls.Add(this.textBox1);
			this.gbox_Venta.Controls.Add(this.label8);
			this.gbox_Venta.Controls.Add(this.btn_PagoConTarjeta);
			this.gbox_Venta.Controls.Add(this.btn_PagoEnEfectivo);
			this.gbox_Venta.Location = new System.Drawing.Point(12, 232);
			this.gbox_Venta.Name = "gbox_Venta";
			this.gbox_Venta.Size = new System.Drawing.Size(218, 110);
			this.gbox_Venta.TabIndex = 0;
			this.gbox_Venta.TabStop = false;
			this.gbox_Venta.Text = "Venta";
			// 
			// btn_PagoEnEfectivo
			// 
			this.btn_PagoEnEfectivo.Location = new System.Drawing.Point(10, 43);
			this.btn_PagoEnEfectivo.Name = "btn_PagoEnEfectivo";
			this.btn_PagoEnEfectivo.Size = new System.Drawing.Size(206, 23);
			this.btn_PagoEnEfectivo.TabIndex = 8;
			this.btn_PagoEnEfectivo.Text = "Pagar con Efectivo";
			this.btn_PagoEnEfectivo.UseVisualStyleBackColor = true;
			this.btn_PagoEnEfectivo.Click += new System.EventHandler(this.btn_PagoEnEfectivo_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 13);
			this.label8.TabIndex = 3;
			this.label8.Text = "Efectivo: $";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(65, 17);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(119, 20);
			this.textBox1.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(185, 20);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(31, 13);
			this.label9.TabIndex = 5;
			this.label9.Text = "MXN";
			// 
			// btn_PagoConTarjeta
			// 
			this.btn_PagoConTarjeta.Location = new System.Drawing.Point(10, 72);
			this.btn_PagoConTarjeta.Name = "btn_PagoConTarjeta";
			this.btn_PagoConTarjeta.Size = new System.Drawing.Size(206, 23);
			this.btn_PagoConTarjeta.TabIndex = 9;
			this.btn_PagoConTarjeta.Text = "Pago con Tarjeta";
			this.btn_PagoConTarjeta.UseVisualStyleBackColor = true;
			// 
			// btn_ReiniciarVenta
			// 
			this.btn_ReiniciarVenta.Location = new System.Drawing.Point(22, 348);
			this.btn_ReiniciarVenta.Name = "btn_ReiniciarVenta";
			this.btn_ReiniciarVenta.Size = new System.Drawing.Size(206, 23);
			this.btn_ReiniciarVenta.TabIndex = 2;
			this.btn_ReiniciarVenta.Text = "Reiniciar Venta";
			this.btn_ReiniciarVenta.UseVisualStyleBackColor = true;
			this.btn_ReiniciarVenta.Click += new System.EventHandler(this.btn_ReiniciarVenta_Click);
			// 
			// lbl_VentaRealizadaConExito
			// 
			this.lbl_VentaRealizadaConExito.AutoSize = true;
			this.lbl_VentaRealizadaConExito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_VentaRealizadaConExito.ForeColor = System.Drawing.Color.Green;
			this.lbl_VentaRealizadaConExito.Location = new System.Drawing.Point(355, 575);
			this.lbl_VentaRealizadaConExito.Name = "lbl_VentaRealizadaConExito";
			this.lbl_VentaRealizadaConExito.Size = new System.Drawing.Size(303, 29);
			this.lbl_VentaRealizadaConExito.TabIndex = 3;
			this.lbl_VentaRealizadaConExito.Text = "¡Venta Realizada con Éxito!";
			this.lbl_VentaRealizadaConExito.Visible = false;
			// 
			// idProducto
			// 
			this.idProducto.FillWeight = 50F;
			this.idProducto.HeaderText = "ID";
			this.idProducto.Name = "idProducto";
			this.idProducto.Width = 50;
			// 
			// nombreProducto
			// 
			this.nombreProducto.HeaderText = "Producto";
			this.nombreProducto.Name = "nombreProducto";
			// 
			// cantidadProducto
			// 
			this.cantidadProducto.HeaderText = "Cantidad";
			this.cantidadProducto.Name = "cantidadProducto";
			// 
			// precioUnitarioProducto
			// 
			this.precioUnitarioProducto.HeaderText = "Precio Unitario";
			this.precioUnitarioProducto.Name = "precioUnitarioProducto";
			// 
			// precioFinal
			// 
			this.precioFinal.HeaderText = "Precio Total";
			this.precioFinal.Name = "precioFinal";
			// 
			// RealizarVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 629);
			this.Controls.Add(this.lbl_VentaRealizadaConExito);
			this.Controls.Add(this.btn_ReiniciarVenta);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.gbox_Empleado);
			this.Controls.Add(this.gbox_Productos);
			this.Controls.Add(this.gbox_Venta);
			this.Controls.Add(this.gbox_Cliente);
			this.Controls.Add(this.gbox_TablaDeProductos);
			this.Name = "RealizarVenta";
			this.Text = "RealizarVenta";
			this.Load += new System.EventHandler(this.RealizarVenta_Load);
			this.gbox_TablaDeProductos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_TablaDeProductos)).EndInit();
			this.gbox_Productos.ResumeLayout(false);
			this.gbox_Productos.PerformLayout();
			this.gbox_Cliente.ResumeLayout(false);
			this.gbox_Cliente.PerformLayout();
			this.gbox_Empleado.ResumeLayout(false);
			this.gbox_Empleado.PerformLayout();
			this.gbox_Venta.ResumeLayout(false);
			this.gbox_Venta.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbox_TablaDeProductos;
		private System.Windows.Forms.GroupBox gbox_Productos;
		private System.Windows.Forms.DataGridView dgv_TablaDeProductos;
		private System.Windows.Forms.GroupBox gbox_Cliente;
		private System.Windows.Forms.TextBox tbox_Cliente;
		private System.Windows.Forms.Label lbl_Cliente1;
		private System.Windows.Forms.GroupBox gbox_Empleado;
		private System.Windows.Forms.TextBox tbox_EmpleadoID;
		private System.Windows.Forms.Label lbl_Empleado1;
		private System.Windows.Forms.Label lbl_Empleado_Status;
		private System.Windows.Forms.Button btn_LogInEmpleado;
		private System.Windows.Forms.Button btn_IngresarCliente;
		private System.Windows.Forms.Label lbl_StatusCliente;
		private System.Windows.Forms.TextBox tbox_CodigoProducto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbox_CantidadProd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox gbox_Venta;
		private System.Windows.Forms.Button btn_PagoEnEfectivo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btn_PagoConTarjeta;
		private System.Windows.Forms.Button btn_ReiniciarVenta;
		private System.Windows.Forms.Label lbl_VentaRealizadaConExito;
		private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioProducto;
		private System.Windows.Forms.DataGridViewTextBoxColumn precioFinal;
	}
}