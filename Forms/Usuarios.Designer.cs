namespace Sistema_SISDON_Proyecto_TPOO.Forms
{
	partial class USUARIOS
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.dGVemployees = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnclean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVemployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(110, 272);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(53, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(169, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(110, 243);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(185, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(474, 78);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(249, 20);
            this.txtid.TabIndex = 3;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(474, 115);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(249, 20);
            this.txtusername.TabIndex = 4;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(474, 150);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(249, 20);
            this.txtlastname.TabIndex = 5;
            this.txtlastname.TextChanged += new System.EventHandler(this.txtlastname_TextChanged);
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(474, 186);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(249, 20);
            this.txtphonenumber.TabIndex = 6;
            this.txtphonenumber.TextChanged += new System.EventHandler(this.txtphonenumber_TextChanged);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(474, 223);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(249, 20);
            this.txtmail.TabIndex = 7;
            this.txtmail.TextChanged += new System.EventHandler(this.txtmail_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(474, 260);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(249, 20);
            this.txtpassword.TabIndex = 8;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dGVemployees
            // 
            this.dGVemployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVemployees.Location = new System.Drawing.Point(12, 328);
            this.dGVemployees.Name = "dGVemployees";
            this.dGVemployees.Size = new System.Drawing.Size(1151, 266);
            this.dGVemployees.TabIndex = 9;
            this.dGVemployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVemployees_CellContentClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblID.Location = new System.Drawing.Point(408, 81);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID:";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblusername.Location = new System.Drawing.Point(408, 118);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(47, 13);
            this.lblusername.TabIndex = 11;
            this.lblusername.Text = "Nombre:";
            this.lblusername.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbllastname.Location = new System.Drawing.Point(408, 153);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(47, 13);
            this.lbllastname.TabIndex = 12;
            this.lbllastname.Text = "Apellido:";
            this.lbllastname.Click += new System.EventHandler(this.lbllastname_Click);
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblphonenumber.Location = new System.Drawing.Point(408, 189);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(52, 13);
            this.lblphonenumber.TabIndex = 13;
            this.lblphonenumber.Text = "Teléfono:";
            this.lblphonenumber.Click += new System.EventHandler(this.lblphonenumber_Click);
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblmail.Location = new System.Drawing.Point(408, 226);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(41, 13);
            this.lblmail.TabIndex = 14;
            this.lblmail.Text = "Correo:";
            this.lblmail.Click += new System.EventHandler(this.lblmail_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblpassword.Location = new System.Drawing.Point(408, 263);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(64, 13);
            this.lblpassword.TabIndex = 15;
            this.lblpassword.Text = "Contraseña:";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // btnclean
            // 
            this.btnclean.Location = new System.Drawing.Point(238, 272);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(57, 23);
            this.btnclean.TabIndex = 16;
            this.btnclean.Text = "Limpiar";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // USUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 606);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.lblphonenumber);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dGVemployees);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Name = "USUARIOS";
            this.Text = "USUARIOS";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVemployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtpassword;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.DataGridView dGVemployees;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnclean;
    }
}