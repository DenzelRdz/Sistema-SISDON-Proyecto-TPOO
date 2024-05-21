using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_SISDON_Proyecto_TPOO.Forms
{
	public partial class Inventario : Form
	{
        private OleDbConnection conn = new OleDbConnection();
        string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        public Inventario()
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

            ConfigureDateTimePickers();
            HideAllErrorMessages();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

        }

        private void LoadData()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection())
                {
                    conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\TortilleriaDonTitoDB.accdb";
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM inventario", conn))
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;

                        if (dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];
                            textBoxId.Text = row["idProducto"].ToString();
                            textBoxName.Text = row["nombreProducto"].ToString();
                            textBoxPrice.Text = row["precioProducto"].ToString();
                            textBoxExistence.Text = row["existenciaProducto"].ToString();
                            textBoxDesc.Text = row["descripcionProducto"].ToString();
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
            lblErrorProductName.Visible = false;
            lblErrorPrice.Visible = false;
            lblErrorExistence.Visible = false;
            lblErrorDescription.Visible = false;
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
            ValidateTextBox(textBoxName, lblErrorProductName,
                text => !string.IsNullOrWhiteSpace(text) && text.All(char.IsLetter) && text.Length <= 50,
                "El nombre debe contener solo letras y tener un máximo de 50 caracteres.");
            if (lblErrorProductName.Visible) allValid = false;

            // Validar precio
            ValidateTextBox(textBoxPrice, lblErrorPrice,
                text => text.Length > 0 && text.All(char.IsDigit),
                "El precio debe ser un numero"); ;
            if (lblErrorPrice.Visible) allValid = false;

            // Validar existencia
            ValidateTextBox(textBoxExistence, lblExistence,
                text => text.Length > 0 && text.All(char.IsDigit),
                "La existencia debe ser un digito igual o mayor a 0.");
            if (lblExistence.Visible) allValid = false;

            // Validar descripcion
            ValidateTextBox(textBoxDesc, lblDescription,
                text => !string.IsNullOrWhiteSpace(text) && text.All(char.IsLetter) && text.Length <= 200,
                "El nombre debe contener solo letras y tener un máximo de 200 caracteres.");
            if (lblDescription.Visible) allValid = false;

            return allValid;
        }

        private void ConfigureDateTimePickers()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBoxId.Text = row.Cells["idProducto"].Value.ToString();
                textBoxName.Text = row.Cells["nombreProducto"].Value.ToString();
                textBoxPrice.Text = row.Cells["precioProducto"].Value.ToString();
                textBoxExistence.Text = row.Cells["existenciaProducto"].Value.ToString();
                textBoxDesc.Text = row.Cells["descripcionProducto"].Value.ToString();
                dateTimePicker1.Text = row.Cells["creadoEn"].Value.ToString();
                dateTimePicker2.Text = row.Cells["actualizadoEn"].Value.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(textBoxName, lblErrorProductName,
                text => !string.IsNullOrWhiteSpace(text) && text.All(char.IsLetter) && text.Length <= 50,
                "El nombre debe contener solo letras y tener un máximo de 50 caracteres.");
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(textBoxPrice, lblErrorPrice,
                text => !string.IsNullOrWhiteSpace(text) && text.All(char.IsLetter) && text.Length <= 50,
                "El precio debe ser un numero");
        }

        private void textBoxExistence_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(textBoxExistence, lblErrorExistence,
                text => text.Length == 10 && text.All(char.IsDigit),
                "La existencia debe ser un digito igual o mayor a 0.");
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(textBoxDesc, lblErrorDescription,
                text => text.Contains("@") && text.Length >= 5,
                "El nombre debe contener solo letras y tener un máximo de 200 caracteres.");
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
                    using (OleDbCommand cmd = new OleDbCommand("INSERT INTO inventario (nombreProducto, precioProducto, existenciaProducto, descripcionProducto, creadoEn, actualizadoEn) VALUES (?, ?, ?, ?, ?, ?)", conn))
                    {
                        cmd.Parameters.AddWithValue("@nombreProducto", textBoxName.Text);
                        cmd.Parameters.AddWithValue("@precioProducto", textBoxPrice.Text);
                        cmd.Parameters.AddWithValue("@existenciaProducto", textBoxExistence.Text);
                        cmd.Parameters.AddWithValue("@descripcionProducto", textBoxDesc.Text);
                        cmd.Parameters.AddWithValue("@creadoEn", dateTimePicker1);
                        cmd.Parameters.AddWithValue("@actualizadoEn", dateTimePicker2);

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
                    using (OleDbCommand cmd = new OleDbCommand("DELETE FROM inventario WHERE idProducto = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("@idProducto", textBoxId.Text);

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
                    using (OleDbCommand cmd = new OleDbCommand("UPDATE inventario SET nombreProducto = ?, precioProducto = ?, existenciaProducto = ?, descripcionProducto = ?, actualizadoEn = ? WHERE idEmpleado = ?", conn))
                    {
                        cmd.Parameters.AddWithValue("@nombreProducto", textBoxName.Text);
                        cmd.Parameters.AddWithValue("@precioProducto", textBoxPrice.Text);
                        cmd.Parameters.AddWithValue("@existenciaProducto", textBoxExistence.Text);
                        cmd.Parameters.AddWithValue("@descripcionProducto", textBoxDesc.Text);
                        cmd.Parameters.Add("@actualizadoEn", OleDbType.Date).Value = DateTime.Now;
                        cmd.Parameters.AddWithValue("@idProducto", textBoxId.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro actualizado exitosamente");
                    }
                }
                LoadData();  // Reload data after editing a record
                dateTimePicker2.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnclean_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxName.Clear();
            textBoxPrice.Clear();
            textBoxExistence.Clear();
            textBoxDesc.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            HideAllErrorMessages();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();

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
                            textBoxSearch.Clear();
                            LoadData(); // Volver a cargar todos los datos en el DataGridView
                        }
                        else
                        {
                            dataGridView1.DataSource = dt;
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
