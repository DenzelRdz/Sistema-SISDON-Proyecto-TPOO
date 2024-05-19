using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace Sistema_SISDON_Proyecto_TPOO.Forms
{
	public partial class USUARIOS : Form
	{
        private OleDbConnection conn = new OleDbConnection();
        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        public USUARIOS()
		{
            InitializeComponent();
            try
            {
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\TortilleriaDonTitoDB.accdb";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Ocultar todos los mensajes de error al inicio
            ConfigureDateTimePickers();
            HideAllErrorMessages();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            LoadData();
            dGVemployees.CellClick += new DataGridViewCellEventHandler(dGVemployees_CellClick);

        }

        private void LoadData()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection())
                {
                    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\TortilleriaDonTitoDB.accdb";
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM empleado", conn))
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dGVemployees.DataSource = dt;

                        if (dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];
                            txtid.Text = row["idEmpleado"].ToString();
                            txtusername.Text = row["nombre"].ToString();
                            txtlastname.Text = row["apellido"].ToString();
                            txtphonenumber.Text = row["telefono"].ToString();
                            txtmail.Text = row["correo"].ToString();
                            txtpassword.Text = row["contrasena"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void HideAllErrorMessages()
        {
            lblErrorUsername.Visible = false;
            lblErrorLastname.Visible = false;
            lblErrorPhoneNumber.Visible = false;
            lblErrorEmail.Visible = false;
            lblErrorPassword.Visible = false;
        }

        private void ValidateTextBox(System.Windows.Forms.TextBox textBox, System.Windows.Forms.Label label, Func<string, bool> validationFunc, string errorMessage)
        {
            if (!validationFunc(textBox.Text))
            {
                label.Text = errorMessage;
                label.Visible = true;
            }
            else
            {
                label.Visible = false;
            }
        }
        private bool ValidateInputs()
        {
            bool allValid = true;

            // Validar nombre
            ValidateTextBox(txtusername, lblErrorUsername,
                text => !string.IsNullOrWhiteSpace(text) && text.All(char.IsLetter) && text.Length <= 50,
                "El nombre debe contener solo letras y tener un máximo de 50 caracteres.");
            if (lblErrorUsername.Visible) allValid = false;

            // Validar apellido
            ValidateTextBox(txtlastname, lblErrorLastname,
                text => !string.IsNullOrWhiteSpace(text) && text.All(char.IsLetter) && text.Length <= 50,
                "El apellido debe contener solo letras y tener un máximo de 50 caracteres.");
            if (lblErrorLastname.Visible) allValid = false;

            // Validar número de teléfono
            ValidateTextBox(txtphonenumber, lblErrorPhoneNumber,
                text => text.Length == 10 && text.All(char.IsDigit),
                "El número de teléfono debe tener exactamente 10 dígitos y contener solo números.");
            if (lblErrorPhoneNumber.Visible) allValid = false;

            // Validar correo electrónico
            ValidateTextBox(txtmail, lblErrorEmail,
                text => text.Contains("@") && text.Length >= 5,
                "El correo electrónico debe tener al menos 5 caracteres y contener un símbolo '@'.");
            if (lblErrorEmail.Visible) allValid = false;

            // Validar contraseña
            ValidateTextBox(txtpassword, lblErrorPassword,
                text => text.Length >= 4,
                "La contraseña debe tener al menos 4 caracteres.");
            if (lblErrorPassword.Visible) allValid = false;

            return allValid;
        }

        private void ConfigureDateTimePickers()
        {
            dtpCreatedAt.Format = DateTimePickerFormat.Custom;
            dtpCreatedAt.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            dtpUpdatedAt.Format = DateTimePickerFormat.Custom;
            dtpUpdatedAt.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dGVemployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGVemployees.Rows[e.RowIndex];

                txtid.Text = row.Cells["idEmpleado"].Value.ToString();
                txtusername.Text = row.Cells["nombre"].Value.ToString();
                txtlastname.Text = row.Cells["apellido"].Value.ToString();
                txtphonenumber.Text = row.Cells["telefono"].Value.ToString();
                txtmail.Text = row.Cells["correo"].Value.ToString();
                txtpassword.Text = row.Cells["contrasena"].Value.ToString();
                dtpCreatedAt.Text = row.Cells["creadoEn"].Value.ToString();
                dtpUpdatedAt.Text = row.Cells["actualizadoEn"].Value.ToString();
            }
        }

        private void lblmail_Click(object sender, EventArgs e)
        {

        }

        private void lblphonenumber_Click(object sender, EventArgs e)
        {

        }

        private void lbllastname_Click(object sender, EventArgs e)
        {

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtusername, lblErrorUsername,
                text => !string.IsNullOrWhiteSpace(text) && text.All(char.IsLetter) && text.Length <= 50,
                "El nombre debe contener solo letras y tener un máximo de 50 caracteres.");
        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtlastname, lblErrorLastname,
                text => !string.IsNullOrWhiteSpace(text) && text.All(char.IsLetter) && text.Length <= 50,
                "El apellido debe contener solo letras y tener un máximo de 50 caracteres.");
        }

        private void txtphonenumber_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtphonenumber, lblErrorPhoneNumber,
                text => text.Length == 10 && text.All(char.IsDigit),
                "El número de teléfono debe tener exactamente 10 dígitos y contener solo números.");
        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtmail, lblErrorEmail,
                text => text.Contains("@") && text.Length >= 5,
                "El correo electrónico debe tener al menos 5 caracteres y contener un símbolo '@'.");
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '•'; // Mostrar puntos negros
            ValidateTextBox(txtpassword, lblErrorPassword,
                text => text.Length >= 4,
                "La contraseña debe tener al menos 4 caracteres.");
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }
            try
            {
                using (OleDbConnection conn = new OleDbConnection())
                {
                    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\TortilleriaDonTitoDB.accdb";
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand("INSERT INTO empleado (nombre, apellido, telefono, correo, contrasena, creadoEn, actualizadoEn) VALUES (?, ?, ?, ?, ?, ?, ?)", conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtusername.Text);
                        cmd.Parameters.AddWithValue("@apellido", txtlastname.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtphonenumber.Text);
                        cmd.Parameters.AddWithValue("@correo", txtmail.Text);
                        cmd.Parameters.AddWithValue("@contrasena", txtpassword.Text);
                        cmd.Parameters.AddWithValue("@creadoEn", dtpCreatedAt);
                        cmd.Parameters.AddWithValue("@actualizadoEn", dtpUpdatedAt);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro agregado exitosamente");
                    }
                }
                LoadData();  // Reload data after adding a record
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                using (OleDbConnection conn = new OleDbConnection())
                {
                    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\TortilleriaDonTitoDB.accdb";
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand("DELETE FROM empleado WHERE idEmpleado = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("@idEmpleado", txtid.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro eliminado exitosamente");
                    }
                }
                LoadData();  // Reload data after deleting a record
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }
            try
            {
                using (OleDbConnection conn = new OleDbConnection())
                {
                    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\TortilleriaDonTitoDB.accdb";
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand("UPDATE empleado SET nombre = ?, apellido = ?, telefono = ?, correo = ?, contrasena = ?, actualizadoEn = ? WHERE idEmpleado = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtusername.Text);
                        cmd.Parameters.AddWithValue("@apellido", txtlastname.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtphonenumber.Text);
                        cmd.Parameters.AddWithValue("@correo", txtmail.Text);
                        cmd.Parameters.AddWithValue("@contrasena", txtpassword.Text);
                        cmd.Parameters.Add("@actualizadoEn", OleDbType.Date).Value = DateTime.Now;
                        cmd.Parameters.AddWithValue("@idEmpleado", txtid.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro actualizado exitosamente");
                    }
                }
                LoadData();  // Reload data after editing a record
                dtpUpdatedAt.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtusername.Clear();
            txtlastname.Clear();
            txtphonenumber.Clear();
            txtmail.Clear();
            txtpassword.Clear();
            dtpCreatedAt.Value = DateTime.Now;
            dtpUpdatedAt.Value = DateTime.Now;
            HideAllErrorMessages();
        }

        private void chkbxViewPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (chkbxViewPassword.Checked)
            {
                txtpassword.PasswordChar = '\0'; // Mostrar texto plano
            }
            else
            {
                txtpassword.PasswordChar = '•'; // Mostrar puntos negros
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            try
            {
                using (OleDbConnection conn = new OleDbConnection())
                {
                    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\TortilleriaDonTitoDB.accdb";
                    conn.Open();

                    // Construir la consulta SQL dinámicamente según el término de búsqueda
                    string query = "SELECT * FROM empleado WHERE " +
                                   "idEmpleado LIKE @searchTerm OR " +
                                   "nombre LIKE @searchTerm OR " +
                                   "apellido LIKE @searchTerm OR " +
                                   "telefono LIKE @searchTerm OR " +
                                   "correo LIKE @searchTerm";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No se encontraron resultados.");
                            txtSearch.Clear();
                            LoadData(); // Volver a cargar todos los datos en el DataGridView
                        }
                        else
                        {
                            dGVemployees.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblErrorUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorLastname_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorPassword_Click(object sender, EventArgs e)
        {

        }

        private void dGVemployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dGVemployees.Rows[e.RowIndex];

                txtid.Text = row.Cells["idEmpleado"].Value.ToString();
                txtusername.Text = row.Cells["nombre"].Value.ToString();
                txtlastname.Text = row.Cells["apellido"].Value.ToString();
                txtphonenumber.Text = row.Cells["telefono"].Value.ToString();
                txtmail.Text = row.Cells["correo"].Value.ToString();
                txtpassword.Text = row.Cells["contrasena"].Value.ToString();
                dtpCreatedAt.Text = row.Cells["creadoEn"].Value.ToString();
                dtpUpdatedAt.Text = row.Cells["actualizadoEn"].Value.ToString();
            }
        }

        private void dtpCreatedAt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpUpdatedAt_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
