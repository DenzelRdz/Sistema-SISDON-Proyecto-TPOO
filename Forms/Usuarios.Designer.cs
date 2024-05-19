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
            this.chkbxViewPassword = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblErrorUsername = new System.Windows.Forms.Label();
            this.lblErrorLastname = new System.Windows.Forms.Label();
            this.lblErrorPhoneNumber = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.dtpUpdatedAt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dGVemployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(210, 350);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(178, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(403, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 350);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(185, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(74, 38);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(249, 20);
            this.txtid.TabIndex = 3;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(74, 75);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(249, 20);
            this.txtusername.TabIndex = 4;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(74, 110);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(249, 20);
            this.txtlastname.TabIndex = 5;
            this.txtlastname.TextChanged += new System.EventHandler(this.txtlastname_TextChanged);
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(74, 146);
            this.txtphonenumber.MaxLength = 10;
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(249, 20);
            this.txtphonenumber.TabIndex = 6;
            this.txtphonenumber.TextChanged += new System.EventHandler(this.txtphonenumber_TextChanged);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(74, 183);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(249, 20);
            this.txtmail.TabIndex = 7;
            this.txtmail.TextChanged += new System.EventHandler(this.txtmail_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(74, 220);
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
            this.dGVemployees.Location = new System.Drawing.Point(12, 379);
            this.dGVemployees.Name = "dGVemployees";
            this.dGVemployees.Size = new System.Drawing.Size(765, 288);
            this.dGVemployees.TabIndex = 9;
            this.dGVemployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVemployees_CellClick);
            this.dGVemployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVemployees_CellContentClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblID.Location = new System.Drawing.Point(8, 41);
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
            this.lblusername.Location = new System.Drawing.Point(8, 78);
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
            this.lbllastname.Location = new System.Drawing.Point(8, 113);
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
            this.lblphonenumber.Location = new System.Drawing.Point(8, 149);
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
            this.lblmail.Location = new System.Drawing.Point(8, 186);
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
            this.lblpassword.Location = new System.Drawing.Point(8, 223);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(64, 13);
            this.lblpassword.TabIndex = 15;
            this.lblpassword.Text = "Contraseña:";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // btnclean
            // 
            this.btnclean.Location = new System.Drawing.Point(594, 350);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(182, 23);
            this.btnclean.TabIndex = 16;
            this.btnclean.Text = "Limpiar";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // chkbxViewPassword
            // 
            this.chkbxViewPassword.AutoSize = true;
            this.chkbxViewPassword.Location = new System.Drawing.Point(225, 246);
            this.chkbxViewPassword.Name = "chkbxViewPassword";
            this.chkbxViewPassword.Size = new System.Drawing.Size(98, 17);
            this.chkbxViewPassword.TabIndex = 17;
            this.chkbxViewPassword.Text = "Ver contraseña";
            this.chkbxViewPassword.UseVisualStyleBackColor = true;
            this.chkbxViewPassword.CheckedChanged += new System.EventHandler(this.chkbxViewPassword_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(74, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(543, 20);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(623, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSearch.Location = new System.Drawing.Point(6, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(43, 13);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Buscar:";
            // 
            // lblErrorUsername
            // 
            this.lblErrorUsername.AutoSize = true;
            this.lblErrorUsername.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUsername.Location = new System.Drawing.Point(329, 78);
            this.lblErrorUsername.Name = "lblErrorUsername";
            this.lblErrorUsername.Size = new System.Drawing.Size(35, 13);
            this.lblErrorUsername.TabIndex = 22;
            this.lblErrorUsername.Text = "label2";
            this.lblErrorUsername.Click += new System.EventHandler(this.lblErrorUsername_Click);
            // 
            // lblErrorLastname
            // 
            this.lblErrorLastname.AutoSize = true;
            this.lblErrorLastname.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLastname.Location = new System.Drawing.Point(329, 113);
            this.lblErrorLastname.Name = "lblErrorLastname";
            this.lblErrorLastname.Size = new System.Drawing.Size(35, 13);
            this.lblErrorLastname.TabIndex = 23;
            this.lblErrorLastname.Text = "label3";
            this.lblErrorLastname.Click += new System.EventHandler(this.lblErrorLastname_Click);
            // 
            // lblErrorPhoneNumber
            // 
            this.lblErrorPhoneNumber.AutoSize = true;
            this.lblErrorPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPhoneNumber.Location = new System.Drawing.Point(329, 149);
            this.lblErrorPhoneNumber.Name = "lblErrorPhoneNumber";
            this.lblErrorPhoneNumber.Size = new System.Drawing.Size(35, 13);
            this.lblErrorPhoneNumber.TabIndex = 24;
            this.lblErrorPhoneNumber.Text = "label4";
            this.lblErrorPhoneNumber.Click += new System.EventHandler(this.lblErrorPhoneNumber_Click);
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(329, 186);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(35, 13);
            this.lblErrorEmail.TabIndex = 25;
            this.lblErrorEmail.Text = "label5";
            this.lblErrorEmail.Click += new System.EventHandler(this.lblErrorEmail_Click);
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(329, 223);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(35, 13);
            this.lblErrorPassword.TabIndex = 26;
            this.lblErrorPassword.Text = "label6";
            this.lblErrorPassword.Click += new System.EventHandler(this.lblErrorPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(8, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Creado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(8, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Actualizado:";
            // 
            // dtpCreatedAt
            // 
            this.dtpCreatedAt.Enabled = false;
            this.dtpCreatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedAt.Location = new System.Drawing.Point(74, 269);
            this.dtpCreatedAt.Name = "dtpCreatedAt";
            this.dtpCreatedAt.Size = new System.Drawing.Size(249, 20);
            this.dtpCreatedAt.TabIndex = 31;
            this.dtpCreatedAt.ValueChanged += new System.EventHandler(this.dtpCreatedAt_ValueChanged);
            // 
            // dtpUpdatedAt
            // 
            this.dtpUpdatedAt.Enabled = false;
            this.dtpUpdatedAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdatedAt.Location = new System.Drawing.Point(74, 303);
            this.dtpUpdatedAt.Name = "dtpUpdatedAt";
            this.dtpUpdatedAt.Size = new System.Drawing.Size(249, 20);
            this.dtpUpdatedAt.TabIndex = 32;
            this.dtpUpdatedAt.ValueChanged += new System.EventHandler(this.dtpUpdatedAt_ValueChanged);
            // 
            // USUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 679);
            this.Controls.Add(this.dtpUpdatedAt);
            this.Controls.Add(this.dtpCreatedAt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.lblErrorPhoneNumber);
            this.Controls.Add(this.lblErrorLastname);
            this.Controls.Add(this.lblErrorUsername);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.chkbxViewPassword);
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
        private System.Windows.Forms.CheckBox chkbxViewPassword;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblErrorUsername;
        private System.Windows.Forms.Label lblErrorLastname;
        private System.Windows.Forms.Label lblErrorPhoneNumber;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCreatedAt;
        private System.Windows.Forms.DateTimePicker dtpUpdatedAt;
    }
}