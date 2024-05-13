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
			this.gbox_Pedido = new System.Windows.Forms.GroupBox();
			this.gbox_Productos = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btn_Producto_1 = new System.Windows.Forms.Button();
			this.btn_Producto_2 = new System.Windows.Forms.Button();
			this.btn_Producto_4 = new System.Windows.Forms.Button();
			this.btn_Producto_3 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.gbox_Cliente = new System.Windows.Forms.GroupBox();
			this.lbl_Cliente1 = new System.Windows.Forms.Label();
			this.tbox_Cliente = new System.Windows.Forms.TextBox();
			this.gbox_Empleado = new System.Windows.Forms.GroupBox();
			this.tbox_EmpleadoID = new System.Windows.Forms.TextBox();
			this.lbl_Empleado1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.lbl_Empleado_Status = new System.Windows.Forms.Label();
			this.btn_ReinicioVenta = new System.Windows.Forms.Button();
			this.gbox_Pedido.SuspendLayout();
			this.gbox_Productos.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.gbox_Cliente.SuspendLayout();
			this.gbox_Empleado.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbox_Pedido
			// 
			this.gbox_Pedido.Controls.Add(this.dataGridView1);
			this.gbox_Pedido.Location = new System.Drawing.Point(314, 12);
			this.gbox_Pedido.Name = "gbox_Pedido";
			this.gbox_Pedido.Size = new System.Drawing.Size(971, 591);
			this.gbox_Pedido.TabIndex = 0;
			this.gbox_Pedido.TabStop = false;
			this.gbox_Pedido.Text = "Pedido";
			// 
			// gbox_Productos
			// 
			this.gbox_Productos.Controls.Add(this.flowLayoutPanel1);
			this.gbox_Productos.Location = new System.Drawing.Point(12, 358);
			this.gbox_Productos.Name = "gbox_Productos";
			this.gbox_Productos.Size = new System.Drawing.Size(296, 245);
			this.gbox_Productos.TabIndex = 0;
			this.gbox_Productos.TabStop = false;
			this.gbox_Productos.Text = "Productos";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.btn_Producto_1);
			this.flowLayoutPanel1.Controls.Add(this.btn_Producto_2);
			this.flowLayoutPanel1.Controls.Add(this.btn_Producto_3);
			this.flowLayoutPanel1.Controls.Add(this.btn_Producto_4);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 226);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// btn_Producto_1
			// 
			this.btn_Producto_1.Location = new System.Drawing.Point(3, 3);
			this.btn_Producto_1.Name = "btn_Producto_1";
			this.btn_Producto_1.Size = new System.Drawing.Size(139, 102);
			this.btn_Producto_1.TabIndex = 0;
			this.btn_Producto_1.Text = "Tortillas de Maíz (1kg)";
			this.btn_Producto_1.UseVisualStyleBackColor = true;
			// 
			// btn_Producto_2
			// 
			this.btn_Producto_2.Location = new System.Drawing.Point(148, 3);
			this.btn_Producto_2.Name = "btn_Producto_2";
			this.btn_Producto_2.Size = new System.Drawing.Size(139, 102);
			this.btn_Producto_2.TabIndex = 0;
			this.btn_Producto_2.Text = "Tortillas de Harina (1kg)";
			this.btn_Producto_2.UseVisualStyleBackColor = true;
			// 
			// btn_Producto_4
			// 
			this.btn_Producto_4.Location = new System.Drawing.Point(148, 111);
			this.btn_Producto_4.Name = "btn_Producto_4";
			this.btn_Producto_4.Size = new System.Drawing.Size(139, 102);
			this.btn_Producto_4.TabIndex = 0;
			this.btn_Producto_4.Text = "Tortilla para Taco (1kg)";
			this.btn_Producto_4.UseVisualStyleBackColor = true;
			// 
			// btn_Producto_3
			// 
			this.btn_Producto_3.Location = new System.Drawing.Point(3, 111);
			this.btn_Producto_3.Name = "btn_Producto_3";
			this.btn_Producto_3.Size = new System.Drawing.Size(139, 102);
			this.btn_Producto_3.TabIndex = 0;
			this.btn_Producto_3.Text = "Tortilla para Burrito (1kg)";
			this.btn_Producto_3.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 16);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(959, 429);
			this.dataGridView1.TabIndex = 0;
			// 
			// gbox_Cliente
			// 
			this.gbox_Cliente.Controls.Add(this.tbox_Cliente);
			this.gbox_Cliente.Controls.Add(this.lbl_Cliente1);
			this.gbox_Cliente.Location = new System.Drawing.Point(12, 114);
			this.gbox_Cliente.Name = "gbox_Cliente";
			this.gbox_Cliente.Size = new System.Drawing.Size(296, 238);
			this.gbox_Cliente.TabIndex = 0;
			this.gbox_Cliente.TabStop = false;
			this.gbox_Cliente.Text = "Cliente";
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
			// tbox_Cliente
			// 
			this.tbox_Cliente.Location = new System.Drawing.Point(75, 16);
			this.tbox_Cliente.Name = "tbox_Cliente";
			this.tbox_Cliente.Size = new System.Drawing.Size(100, 20);
			this.tbox_Cliente.TabIndex = 1;
			// 
			// gbox_Empleado
			// 
			this.gbox_Empleado.Controls.Add(this.lbl_Empleado_Status);
			this.gbox_Empleado.Controls.Add(this.button1);
			this.gbox_Empleado.Controls.Add(this.tbox_EmpleadoID);
			this.gbox_Empleado.Controls.Add(this.lbl_Empleado1);
			this.gbox_Empleado.Location = new System.Drawing.Point(12, 12);
			this.gbox_Empleado.Name = "gbox_Empleado";
			this.gbox_Empleado.Size = new System.Drawing.Size(296, 66);
			this.gbox_Empleado.TabIndex = 0;
			this.gbox_Empleado.TabStop = false;
			this.gbox_Empleado.Text = "Empleado";
			// 
			// tbox_EmpleadoID
			// 
			this.tbox_EmpleadoID.Location = new System.Drawing.Point(75, 16);
			this.tbox_EmpleadoID.Name = "tbox_EmpleadoID";
			this.tbox_EmpleadoID.Size = new System.Drawing.Size(134, 20);
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(215, 15);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Ingresar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// lbl_Empleado_Status
			// 
			this.lbl_Empleado_Status.AutoSize = true;
			this.lbl_Empleado_Status.Location = new System.Drawing.Point(75, 43);
			this.lbl_Empleado_Status.Name = "lbl_Empleado_Status";
			this.lbl_Empleado_Status.Size = new System.Drawing.Size(89, 13);
			this.lbl_Empleado_Status.TabIndex = 3;
			this.lbl_Empleado_Status.Text = "Favor de ingresar";
			// 
			// btn_ReinicioVenta
			// 
			this.btn_ReinicioVenta.Location = new System.Drawing.Point(11, 85);
			this.btn_ReinicioVenta.Name = "btn_ReinicioVenta";
			this.btn_ReinicioVenta.Size = new System.Drawing.Size(297, 23);
			this.btn_ReinicioVenta.TabIndex = 1;
			this.btn_ReinicioVenta.Text = "Reiniciar Venta";
			this.btn_ReinicioVenta.UseVisualStyleBackColor = true;
			// 
			// RealizarVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1297, 615);
			this.Controls.Add(this.btn_ReinicioVenta);
			this.Controls.Add(this.gbox_Empleado);
			this.Controls.Add(this.gbox_Cliente);
			this.Controls.Add(this.gbox_Productos);
			this.Controls.Add(this.gbox_Pedido);
			this.Name = "RealizarVenta";
			this.Text = "RealizarVenta";
			this.Load += new System.EventHandler(this.RealizarVenta_Load);
			this.gbox_Pedido.ResumeLayout(false);
			this.gbox_Productos.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.gbox_Cliente.ResumeLayout(false);
			this.gbox_Cliente.PerformLayout();
			this.gbox_Empleado.ResumeLayout(false);
			this.gbox_Empleado.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbox_Pedido;
		private System.Windows.Forms.GroupBox gbox_Productos;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btn_Producto_1;
		private System.Windows.Forms.Button btn_Producto_2;
		private System.Windows.Forms.Button btn_Producto_3;
		private System.Windows.Forms.Button btn_Producto_4;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox gbox_Cliente;
		private System.Windows.Forms.TextBox tbox_Cliente;
		private System.Windows.Forms.Label lbl_Cliente1;
		private System.Windows.Forms.GroupBox gbox_Empleado;
		private System.Windows.Forms.TextBox tbox_EmpleadoID;
		private System.Windows.Forms.Label lbl_Empleado1;
		private System.Windows.Forms.Label lbl_Empleado_Status;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btn_ReinicioVenta;
	}
}