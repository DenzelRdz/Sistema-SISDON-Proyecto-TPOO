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
			this.dgv_Display = new System.Windows.Forms.DataGridView();
			this.tbox_id = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbox_nombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbox_apellido = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbox_telefono = new System.Windows.Forms.TextBox();
			this.tbox_correo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbox_rfc = new System.Windows.Forms.TextBox();
			this.btn_Create = new System.Windows.Forms.Button();
			this.dtp_creadoen = new System.Windows.Forms.DateTimePicker();
			this.dtp_actualizadoen = new System.Windows.Forms.DateTimePicker();
			this.btn_ReadTable = new System.Windows.Forms.Button();
			this.btn_Update = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Read = new System.Windows.Forms.Button();
			this.btn_MonthDisplay = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.btn_ExecPath = new System.Windows.Forms.Button();
			this.tortilleriaDonTitoDBDataSet = new Sistema_SISDON_Proyecto_TPOO.TortilleriaDonTitoDBDataSet();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Display)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_Display
			// 
			this.dgv_Display.AllowUserToAddRows = false;
			this.dgv_Display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Display.Location = new System.Drawing.Point(12, 12);
			this.dgv_Display.Name = "dgv_Display";
			this.dgv_Display.Size = new System.Drawing.Size(776, 136);
			this.dgv_Display.TabIndex = 3;
			// 
			// tbox_id
			// 
			this.tbox_id.Location = new System.Drawing.Point(15, 208);
			this.tbox_id.Name = "tbox_id";
			this.tbox_id.Size = new System.Drawing.Size(100, 20);
			this.tbox_id.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 192);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "idCliente";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(118, 192);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "nombreCliente";
			// 
			// tbox_nombre
			// 
			this.tbox_nombre.Location = new System.Drawing.Point(121, 208);
			this.tbox_nombre.Name = "tbox_nombre";
			this.tbox_nombre.Size = new System.Drawing.Size(100, 20);
			this.tbox_nombre.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(224, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "apellidoCliente";
			// 
			// tbox_apellido
			// 
			this.tbox_apellido.Location = new System.Drawing.Point(227, 208);
			this.tbox_apellido.Name = "tbox_apellido";
			this.tbox_apellido.Size = new System.Drawing.Size(100, 20);
			this.tbox_apellido.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(330, 193);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "telefonoCliente";
			// 
			// tbox_telefono
			// 
			this.tbox_telefono.Location = new System.Drawing.Point(333, 208);
			this.tbox_telefono.Name = "tbox_telefono";
			this.tbox_telefono.Size = new System.Drawing.Size(100, 20);
			this.tbox_telefono.TabIndex = 10;
			// 
			// tbox_correo
			// 
			this.tbox_correo.Location = new System.Drawing.Point(15, 253);
			this.tbox_correo.Name = "tbox_correo";
			this.tbox_correo.Size = new System.Drawing.Size(100, 20);
			this.tbox_correo.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 237);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "correoCliente";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(118, 237);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "creadoEn";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(224, 238);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "actualizadoEn";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(330, 238);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "rfcCliente";
			// 
			// tbox_rfc
			// 
			this.tbox_rfc.Location = new System.Drawing.Point(333, 253);
			this.tbox_rfc.Name = "tbox_rfc";
			this.tbox_rfc.Size = new System.Drawing.Size(100, 20);
			this.tbox_rfc.TabIndex = 14;
			// 
			// btn_Create
			// 
			this.btn_Create.Location = new System.Drawing.Point(15, 286);
			this.btn_Create.Name = "btn_Create";
			this.btn_Create.Size = new System.Drawing.Size(75, 23);
			this.btn_Create.TabIndex = 15;
			this.btn_Create.Text = "Create";
			this.btn_Create.UseVisualStyleBackColor = true;
			this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
			// 
			// dtp_creadoen
			// 
			this.dtp_creadoen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_creadoen.Location = new System.Drawing.Point(121, 253);
			this.dtp_creadoen.Name = "dtp_creadoen";
			this.dtp_creadoen.Size = new System.Drawing.Size(100, 20);
			this.dtp_creadoen.TabIndex = 12;
			// 
			// dtp_actualizadoen
			// 
			this.dtp_actualizadoen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_actualizadoen.Location = new System.Drawing.Point(227, 254);
			this.dtp_actualizadoen.Name = "dtp_actualizadoen";
			this.dtp_actualizadoen.Size = new System.Drawing.Size(100, 20);
			this.dtp_actualizadoen.TabIndex = 13;
			// 
			// btn_ReadTable
			// 
			this.btn_ReadTable.Location = new System.Drawing.Point(12, 154);
			this.btn_ReadTable.Name = "btn_ReadTable";
			this.btn_ReadTable.Size = new System.Drawing.Size(75, 23);
			this.btn_ReadTable.TabIndex = 6;
			this.btn_ReadTable.Text = "Read Table";
			this.btn_ReadTable.UseVisualStyleBackColor = true;
			this.btn_ReadTable.Click += new System.EventHandler(this.btn_ReadTable_Click);
			// 
			// btn_Update
			// 
			this.btn_Update.Location = new System.Drawing.Point(177, 286);
			this.btn_Update.Name = "btn_Update";
			this.btn_Update.Size = new System.Drawing.Size(75, 23);
			this.btn_Update.TabIndex = 17;
			this.btn_Update.Text = "Update";
			this.btn_Update.UseVisualStyleBackColor = true;
			this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
			// 
			// btn_Delete
			// 
			this.btn_Delete.Location = new System.Drawing.Point(258, 286);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(75, 23);
			this.btn_Delete.TabIndex = 18;
			this.btn_Delete.Text = "Delete";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// btn_Read
			// 
			this.btn_Read.Location = new System.Drawing.Point(96, 286);
			this.btn_Read.Name = "btn_Read";
			this.btn_Read.Size = new System.Drawing.Size(75, 23);
			this.btn_Read.TabIndex = 16;
			this.btn_Read.Text = "Read";
			this.btn_Read.UseVisualStyleBackColor = true;
			this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
			// 
			// btn_MonthDisplay
			// 
			this.btn_MonthDisplay.Location = new System.Drawing.Point(489, 206);
			this.btn_MonthDisplay.Name = "btn_MonthDisplay";
			this.btn_MonthDisplay.Size = new System.Drawing.Size(91, 23);
			this.btn_MonthDisplay.TabIndex = 19;
			this.btn_MonthDisplay.Text = "Month Display";
			this.btn_MonthDisplay.UseVisualStyleBackColor = true;
			this.btn_MonthDisplay.Click += new System.EventHandler(this.btn_MonthDisplay_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(486, 190);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(39, 13);
			this.label9.TabIndex = 21;
			this.label9.Text = "Debug";
			// 
			// btn_ExecPath
			// 
			this.btn_ExecPath.Location = new System.Drawing.Point(489, 235);
			this.btn_ExecPath.Name = "btn_ExecPath";
			this.btn_ExecPath.Size = new System.Drawing.Size(91, 23);
			this.btn_ExecPath.TabIndex = 20;
			this.btn_ExecPath.Text = "Show RunPath";
			this.btn_ExecPath.UseVisualStyleBackColor = true;
			this.btn_ExecPath.Click += new System.EventHandler(this.btn_ExecPath_Click);
			// 
			// tortilleriaDonTitoDBDataSet
			// 
			this.tortilleriaDonTitoDBDataSet.DataSetName = "TortilleriaDonTitoDBDataSet";
			this.tortilleriaDonTitoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// GMCRUD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 323);
			this.Controls.Add(this.btn_ExecPath);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btn_MonthDisplay);
			this.Controls.Add(this.btn_Read);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_Update);
			this.Controls.Add(this.btn_ReadTable);
			this.Controls.Add(this.dtp_actualizadoen);
			this.Controls.Add(this.dtp_creadoen);
			this.Controls.Add(this.btn_Create);
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
			this.Controls.Add(this.dgv_Display);
			this.Name = "GMCRUD";
			this.Text = "GMCRUD";
			((System.ComponentModel.ISupportInitialize)(this.dgv_Display)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_Display;
		private TortilleriaDonTitoDBDataSet tortilleriaDonTitoDBDataSet;
		private System.Windows.Forms.TextBox tbox_id;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbox_nombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbox_apellido;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbox_telefono;
		private System.Windows.Forms.TextBox tbox_correo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbox_rfc;
		private System.Windows.Forms.Button btn_Create;
		private System.Windows.Forms.DateTimePicker dtp_creadoen;
		private System.Windows.Forms.DateTimePicker dtp_actualizadoen;
		private System.Windows.Forms.Button btn_ReadTable;
		private System.Windows.Forms.Button btn_Update;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_Read;
		private System.Windows.Forms.Button btn_MonthDisplay;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btn_ExecPath;
	}
}