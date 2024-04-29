namespace Sistema_SISDON_Proyecto_TPOO.Forms
{
	partial class Dev_Menu
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
			this.label1 = new System.Windows.Forms.Label();
			this.cmb_MenuSelect = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tortilleriaDonTitoDBDataSet = new Sistema_SISDON_Proyecto_TPOO.TortilleriaDonTitoDBDataSet();
			((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(108, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Menu de Seleccion de Pantallas:";
			// 
			// cmb_MenuSelect
			// 
			this.cmb_MenuSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_MenuSelect.FormattingEnabled = true;
			this.cmb_MenuSelect.Location = new System.Drawing.Point(111, 127);
			this.cmb_MenuSelect.Name = "cmb_MenuSelect";
			this.cmb_MenuSelect.Size = new System.Drawing.Size(157, 21);
			this.cmb_MenuSelect.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(111, 164);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Acceder";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tortilleriaDonTitoDBDataSet
			// 
			this.tortilleriaDonTitoDBDataSet.DataSetName = "TortilleriaDonTitoDBDataSet";
			this.tortilleriaDonTitoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// Dev_Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 298);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cmb_MenuSelect);
			this.Controls.Add(this.label1);
			this.Name = "Dev_Menu";
			this.Text = "Dev_Menu";
			this.Load += new System.EventHandler(this.Dev_Menu_Load);
			((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmb_MenuSelect;
		private System.Windows.Forms.Button button1;
		private TortilleriaDonTitoDBDataSet tortilleriaDonTitoDBDataSet;
	}
}