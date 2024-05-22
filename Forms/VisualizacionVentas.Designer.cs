namespace Sistema_SISDON_Proyecto_TPOO.Forms
{
	partial class VisualizacionVentas
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
			this.dgv_Visualizacion = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Visualizacion)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_Visualizacion
			// 
			this.dgv_Visualizacion.AllowUserToAddRows = false;
			this.dgv_Visualizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_Visualizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Visualizacion.Location = new System.Drawing.Point(12, 12);
			this.dgv_Visualizacion.Name = "dgv_Visualizacion";
			this.dgv_Visualizacion.ReadOnly = true;
			this.dgv_Visualizacion.RowHeadersVisible = false;
			this.dgv_Visualizacion.Size = new System.Drawing.Size(764, 605);
			this.dgv_Visualizacion.TabIndex = 0;
			// 
			// VisualizacionVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 629);
			this.Controls.Add(this.dgv_Visualizacion);
			this.Name = "VisualizacionVentas";
			this.Text = "Ventas";
			this.Load += new System.EventHandler(this.VisualizacionVentas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_Visualizacion)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_Visualizacion;
	}
}