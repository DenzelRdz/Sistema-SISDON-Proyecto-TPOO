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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private bool ValidateInputs()
        {
            // Validar que todos los campos estén llenados
            if (string.IsNullOrWhiteSpace(txtusername.Text) ||
                string.IsNullOrWhiteSpace(txtlastname.Text) ||
                string.IsNullOrWhiteSpace(txtphonenumber.Text) ||
                string.IsNullOrWhiteSpace(txtmail.Text) ||
                string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }

            // Validar nombre y apellido
            if (!txtusername.Text.All(char.IsLetter) || !txtlastname.Text.All(char.IsLetter) ||
                txtusername.Text.Length > 50 || txtlastname.Text.Length > 50)
            {
                MessageBox.Show("El nombre y el apellido deben contener solo letras y tener un máximo de 50 caracteres.");
                return false;
            }

            // Validar número de teléfono
            if (txtphonenumber.Text.Length != 10 || !txtphonenumber.Text.All(char.IsDigit))
            {
                MessageBox.Show("El número de teléfono debe tener exactamente 10 dígitos y contener solo números.");
                return false;
            }

            // Validar formato de correo electrónico
            if (!txtmail.Text.Contains("@") || txtmail.Text.Length < 5)
            {
                MessageBox.Show("El correo electrónico debe tener al menos 5 caracteres y contener un símbolo '@'.");
                return false;
            }

            // Validar longitud mínima de la contraseña
            if (txtpassword.Text.Length < 4)
            {
                MessageBox.Show("La contraseña debe tener al menos 4 caracteres.");
                return false;
            }

            return true;
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

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '•'; // Mostrar puntos negros
        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphonenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

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
                    using (OleDbCommand cmd = new OleDbCommand("INSERT INTO empleado (nombre, apellido, telefono, correo, contrasena) VALUES (?, ?, ?, ?, ?)", conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtusername.Text);
                        cmd.Parameters.AddWithValue("@apellido", txtlastname.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtphonenumber.Text);
                        cmd.Parameters.AddWithValue("@correo", txtmail.Text);
                        cmd.Parameters.AddWithValue("@contrasena", txtpassword.Text);

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
                    using (OleDbCommand cmd = new OleDbCommand("UPDATE empleado SET nombre = ?, apellido = ?, telefono = ?, correo = ?, contrasena = ? WHERE idEmpleado = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtusername.Text);
                        cmd.Parameters.AddWithValue("@apellido", txtlastname.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtphonenumber.Text);
                        cmd.Parameters.AddWithValue("@correo", txtmail.Text);
                        cmd.Parameters.AddWithValue("@contrasena", txtpassword.Text);
                        cmd.Parameters.AddWithValue("@idEmpleado", txtid.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro actualizado exitosamente");
                    }
                }
                LoadData();  // Reload data after editing a record
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
    }
}
