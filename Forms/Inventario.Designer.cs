namespace Sistema_SISDON_Proyecto_TPOO.Forms
{
	partial class Inventario
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
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tortilleriaDonTitoDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tortilleriaDonTitoDBDataSet = new Sistema_SISDON_Proyecto_TPOO.TortilleriaDonTitoDBDataSet();
            this.inventarioTableAdapter = new Sistema_SISDON_Proyecto_TPOO.TortilleriaDonTitoDBDataSetTableAdapters.inventarioTableAdapter();
            this.inventarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.lblExistence = new System.Windows.Forms.Label();
            this.textBoxExistence = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblUpdatedAt = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblErrorProductName = new System.Windows.Forms.Label();
            this.lblErrorPrice = new System.Windows.Forms.Label();
            this.lblErrorExistence = new System.Windows.Forms.Label();
            this.lblErrorDescription = new System.Windows.Forms.Label();
            this.btnclean = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadoEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualizadoEn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "inventario";
            this.inventarioBindingSource.DataSource = this.tortilleriaDonTitoDBDataSetBindingSource;
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
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // inventarioBindingSource1
            // 
            this.inventarioBindingSource1.DataMember = "inventario";
            this.inventarioBindingSource1.DataSource = this.tortilleriaDonTitoDBDataSetBindingSource;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(31, 482);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(63, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Buscar:";
            this.lblSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(212, 479);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(644, 26);
            this.textBoxSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(968, 470);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(181, 44);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(31, 528);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id:";
            this.lblId.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(212, 525);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(317, 26);
            this.textBoxId.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 572);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Nombre:";
            this.lblName.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(212, 569);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(317, 26);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(31, 617);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(57, 20);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Precio:";
            this.lblPrice.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(212, 614);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(317, 26);
            this.textBoxPrice.TabIndex = 9;
            // 
            // lblExistence
            // 
            this.lblExistence.AutoSize = true;
            this.lblExistence.Location = new System.Drawing.Point(31, 662);
            this.lblExistence.Name = "lblExistence";
            this.lblExistence.Size = new System.Drawing.Size(85, 20);
            this.lblExistence.TabIndex = 10;
            this.lblExistence.Text = "Existencia:";
            this.lblExistence.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxExistence
            // 
            this.textBoxExistence.Location = new System.Drawing.Point(212, 659);
            this.textBoxExistence.Name = "textBoxExistence";
            this.textBoxExistence.Size = new System.Drawing.Size(317, 26);
            this.textBoxExistence.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(31, 708);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(96, 20);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Text = "Descripción:";
            this.lblDescription.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(212, 705);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(317, 26);
            this.textBoxDesc.TabIndex = 13;
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(31, 755);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(65, 20);
            this.lblCreatedAt.TabIndex = 14;
            this.lblCreatedAt.Text = "Creado:";
            this.lblCreatedAt.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 750);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(317, 26);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // lblUpdatedAt
            // 
            this.lblUpdatedAt.AutoSize = true;
            this.lblUpdatedAt.Location = new System.Drawing.Point(31, 802);
            this.lblUpdatedAt.Name = "lblUpdatedAt";
            this.lblUpdatedAt.Size = new System.Drawing.Size(96, 20);
            this.lblUpdatedAt.TabIndex = 16;
            this.lblUpdatedAt.Text = "Actualizado:";
            this.lblUpdatedAt.Click += new System.EventHandler(this.label8_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(212, 797);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(317, 26);
            this.dateTimePicker2.TabIndex = 17;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // lblErrorProductName
            // 
            this.lblErrorProductName.AutoSize = true;
            this.lblErrorProductName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorProductName.Location = new System.Drawing.Point(552, 572);
            this.lblErrorProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorProductName.Name = "lblErrorProductName";
            this.lblErrorProductName.Size = new System.Drawing.Size(51, 20);
            this.lblErrorProductName.TabIndex = 23;
            this.lblErrorProductName.Text = "label2";
            // 
            // lblErrorPrice
            // 
            this.lblErrorPrice.AutoSize = true;
            this.lblErrorPrice.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrice.Location = new System.Drawing.Point(552, 617);
            this.lblErrorPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorPrice.Name = "lblErrorPrice";
            this.lblErrorPrice.Size = new System.Drawing.Size(51, 20);
            this.lblErrorPrice.TabIndex = 24;
            this.lblErrorPrice.Text = "label2";
            // 
            // lblErrorExistence
            // 
            this.lblErrorExistence.AutoSize = true;
            this.lblErrorExistence.ForeColor = System.Drawing.Color.Red;
            this.lblErrorExistence.Location = new System.Drawing.Point(552, 662);
            this.lblErrorExistence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorExistence.Name = "lblErrorExistence";
            this.lblErrorExistence.Size = new System.Drawing.Size(51, 20);
            this.lblErrorExistence.TabIndex = 25;
            this.lblErrorExistence.Text = "label2";
            // 
            // lblErrorDescription
            // 
            this.lblErrorDescription.AutoSize = true;
            this.lblErrorDescription.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDescription.Location = new System.Drawing.Point(552, 708);
            this.lblErrorDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorDescription.Name = "lblErrorDescription";
            this.lblErrorDescription.Size = new System.Drawing.Size(51, 20);
            this.lblErrorDescription.TabIndex = 26;
            this.lblErrorDescription.Text = "label2";
            // 
            // btnclean
            // 
            this.btnclean.Location = new System.Drawing.Point(885, 870);
            this.btnclean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(273, 35);
            this.btnclean.TabIndex = 32;
            this.btnclean.Text = "Limpiar";
            this.btnclean.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 870);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(278, 35);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(598, 870);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(267, 35);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(309, 870);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(267, 35);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.precioProducto,
            this.existenciaProducto,
            this.descripcionProducto,
            this.creadoEn,
            this.actualizadoEn});
            this.dataGridView1.DataSource = this.inventarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.MinimumWidth = 8;
            this.idProducto.Name = "idProducto";
            this.idProducto.Width = 150;
            // 
            // nombreProducto
            // 
            this.nombreProducto.DataPropertyName = "nombreProducto";
            this.nombreProducto.HeaderText = "nombreProducto";
            this.nombreProducto.MinimumWidth = 8;
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Width = 150;
            // 
            // precioProducto
            // 
            this.precioProducto.DataPropertyName = "precioProducto";
            this.precioProducto.HeaderText = "precioProducto";
            this.precioProducto.MinimumWidth = 8;
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.Width = 150;
            // 
            // existenciaProducto
            // 
            this.existenciaProducto.DataPropertyName = "existenciaProducto";
            this.existenciaProducto.HeaderText = "existenciaProducto";
            this.existenciaProducto.MinimumWidth = 8;
            this.existenciaProducto.Name = "existenciaProducto";
            this.existenciaProducto.Width = 150;
            // 
            // descripcionProducto
            // 
            this.descripcionProducto.DataPropertyName = "descripcionProducto";
            this.descripcionProducto.HeaderText = "descripcionProducto";
            this.descripcionProducto.MinimumWidth = 8;
            this.descripcionProducto.Name = "descripcionProducto";
            this.descripcionProducto.Width = 150;
            // 
            // creadoEn
            // 
            this.creadoEn.DataPropertyName = "creadoEn";
            this.creadoEn.HeaderText = "creadoEn";
            this.creadoEn.MinimumWidth = 8;
            this.creadoEn.Name = "creadoEn";
            this.creadoEn.Width = 150;
            // 
            // actualizadoEn
            // 
            this.actualizadoEn.DataPropertyName = "actualizadoEn";
            this.actualizadoEn.HeaderText = "actualizadoEn";
            this.actualizadoEn.MinimumWidth = 8;
            this.actualizadoEn.Name = "actualizadoEn";
            this.actualizadoEn.Width = 150;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 968);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblErrorDescription);
            this.Controls.Add(this.lblErrorExistence);
            this.Controls.Add(this.lblErrorPrice);
            this.Controls.Add(this.lblErrorProductName);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lblUpdatedAt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblCreatedAt);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.textBoxExistence);
            this.Controls.Add(this.lblExistence);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tortilleriaDonTitoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.BindingSource tortilleriaDonTitoDBDataSetBindingSource;
        private TortilleriaDonTitoDBDataSet tortilleriaDonTitoDBDataSet;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private TortilleriaDonTitoDBDataSetTableAdapters.inventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.BindingSource inventarioBindingSource1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label lblExistence;
        private System.Windows.Forms.TextBox textBoxExistence;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblUpdatedAt;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblErrorProductName;
        private System.Windows.Forms.Label lblErrorPrice;
        private System.Windows.Forms.Label lblErrorExistence;
        private System.Windows.Forms.Label lblErrorDescription;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn creadoEn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualizadoEn;
    }
}