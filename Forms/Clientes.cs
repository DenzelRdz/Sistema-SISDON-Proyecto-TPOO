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
	public partial class Clientes : Form
	{
		private OleDbConnection conn = new OleDbConnection();
		string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);


		public Clientes()
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


			HideAllErrorMessages();

		}



		private void Clientes_Load(object sender, EventArgs e)
		{
			LoadTabla();

		}

		private void LoadTabla()
		{
			try
			{
				conn.Open();
				OleDbCommand acCommand = new OleDbCommand();
				acCommand.Connection = conn;
				acCommand.CommandText = "SELECT * FROM cliente";
				OleDbDataAdapter acAdapter = new OleDbDataAdapter(acCommand);
				DataTable dt = new DataTable();
				acAdapter.Fill(dt);
				dgv_Display.DataSource = dt;
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn.Close();
			}

		}

		private void HideAllErrorMessages()
		{
			lblNombreError.Visible = false;
			lblApellidosError.Visible = false;
			lblTelefonoError.Visible = false;
			lblCorreoError.Visible = false;
			lblRFCError.Visible = false;
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



		private bool ValidateInputsRUD()
        {
			if (string.IsNullOrWhiteSpace(txt_idbuscar.Text))
            {
				MessageBox.Show("Por favor, escriba el id que desee eliminar, modificar o leer.");
				return false;
			}

			return true;


		}

		private bool ValidateInputs()
		{
            bool allValid = true;

            // Validar nombre
            ValidateTextBox(tbox_nombre, lblNombreError,
                text => !string.IsNullOrWhiteSpace(text) && text.All(char.IsLetter) && text.Length <= 50,
                "El nombre debe contener solo letras y tener un máximo de 50 caracteres.");
            if (lblNombreError.Visible) allValid = false;

            // Validar apellido
            ValidateTextBox(tbox_apellido, lblApellidosError,
                text => !string.IsNullOrWhiteSpace(text) && text.All(char.IsLetter) && text.Length <= 50,
                "El apellido debe contener solo letras y tener un máximo de 50 caracteres.");
            if (lblApellidosError.Visible) allValid = false;

            // Validar número de teléfono
            ValidateTextBox(tbox_telefono, lblTelefonoError,
                text => text.Length == 10 && text.All(char.IsDigit),
                "El número de teléfono debe tener exactamente 10 dígitos y contener solo números.");
            if (lblTelefonoError.Visible) allValid = false;

            // Validar correo electrónico
            ValidateTextBox(tbox_correo, lblCorreoError,
                text => text.Contains("@") && text.Length >= 5,
                "El correo electrónico debe tener al menos 5 caracteres y contener un símbolo '@'.");
            if (lblCorreoError.Visible) allValid = false;

            // Validar contraseña
            ValidateTextBox(tbox_rfc, lblRFCError,
                text => text.Length == 13,
                "La contraseña debe tener 13 caracteres.");
            if (lblRFCError.Visible) allValid = false;

            return allValid;
        }


		private void btn_Nuevo_Click(object sender, EventArgs e)
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
					using (OleDbCommand cmd = new OleDbCommand("INSERT INTO cliente (nombreCliente, apellidoCliente, telefonoCliente, correoCliente, creadoEn, actualizadoEn, rfcCliente) VALUES (?, ?, ?, ?, ?, ?, ?)", conn))
					{
						cmd.Parameters.AddWithValue("@nombreCliente", tbox_nombre.Text);
						cmd.Parameters.AddWithValue("@apellidoCliente", tbox_apellido.Text);
						cmd.Parameters.AddWithValue("@telefonoCliente", tbox_telefono.Text);
						cmd.Parameters.AddWithValue("@correoCliente", tbox_correo.Text);
						cmd.Parameters.AddWithValue("@creadoEn", dtp_creadoen.Text);
						cmd.Parameters.AddWithValue("@actualizadoEn", dtp_actualizadoen.Text);
						cmd.Parameters.AddWithValue("@rfcCliente", tbox_rfc.Text);

						cmd.ExecuteNonQuery();
						
					}
				}
				LoadTabla();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void btn_Eliminar_Click(object sender, EventArgs e)
		{

			if (!ValidateInputsRUD())
			{
				return;
			}
			DialogResult dr = MessageBox.Show("¿Estas seguro que quieres eliminar el registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				try
				{
					conn.Open();
					OleDbCommand acCommand = new OleDbCommand();
					acCommand.Connection = conn;
					acCommand.CommandText = "DELETE FROM cliente WHERE idCliente=" + txt_idbuscar.Text + "";
					acCommand.ExecuteNonQuery();
					conn.Close();

					LoadTabla();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					conn.Close();
				}
			}
		}

		private void btn_Modificar_Click(object sender, EventArgs e)
		{
			if (!ValidateInputsRUD())
			{
				return;
			}

			if (!ValidateInputs())
			{
				return;
			}


			try
			{
				conn.Open();
				OleDbCommand acCommand = new OleDbCommand();
				acCommand.Connection = conn;
				acCommand.CommandText = "UPDATE cliente SET nombreCliente='" + tbox_nombre.Text + "', apellidoCliente='" + tbox_apellido.Text + "', telefonoCliente='" + tbox_telefono.Text + "', correoCliente='" + tbox_correo.Text + "', creadoEn='" + dtp_creadoen.Text + "', actualizadoEn='" + dtp_actualizadoen.Text + "', rfcCliente='" + tbox_rfc.Text + "' WHERE idCliente=" + txt_idbuscar.Text + "";
				acCommand.ExecuteNonQuery();
				conn.Close();

				LoadTabla();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn.Close();
			}
		}

		private void btn_leer_Click(object sender, EventArgs e)
		{
			if (!ValidateInputsRUD())
			{
				return;
			}
			try
			{
				conn.Open();
				OleDbCommand acCommand = new OleDbCommand();
				acCommand.Connection = conn;
				acCommand.CommandText = "SELECT * FROM cliente WHERE idCliente = ?";
				acCommand.Parameters.AddWithValue("?", txt_idbuscar.Text);

				OleDbDataReader acReader = acCommand.ExecuteReader();
				while (acReader.Read())
				{
					tbox_id.Text = acReader["idCliente"].ToString();
					tbox_nombre.Text = acReader["nombreCliente"].ToString();
					tbox_apellido.Text = acReader["apellidoCliente"].ToString();
					tbox_telefono.Text = acReader["telefonoCliente"].ToString();
					tbox_correo.Text = acReader["correoCliente"].ToString();
					string creadoEnStr = acReader["creadoEn"].ToString();
					string actualizadoEnStr = acReader["actualizadoEn"].ToString();
					if (DateTime.TryParse(creadoEnStr, out DateTime creadoEnDate))
					{ dtp_creadoen.Value = creadoEnDate; }
					if (DateTime.TryParse(actualizadoEnStr, out DateTime actualizadoEnDate))
					{ dtp_actualizadoen.Value = actualizadoEnDate; }
					tbox_rfc.Text = acReader["rfcCliente"].ToString();
				}

				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn.Close();
			}
		}

		private void btn_leertabla_Click(object sender, EventArgs e)
		{
			try
			{
				conn.Open();
				OleDbCommand acCommand = new OleDbCommand();
				acCommand.Connection = conn;
				acCommand.CommandText = "SELECT * FROM cliente";
				OleDbDataAdapter acAdapter = new OleDbDataAdapter(acCommand);
				DataTable dt = new DataTable();
				acAdapter.Fill(dt);
				dgv_Display.DataSource = dt;
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn.Close();
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void txt_idbuscar_TextChanged(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void tortilleriaDonTitoDBDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void btn_limpiar_Click(object sender, EventArgs e)
		{
			tbox_nombre.Clear();
			tbox_apellido.Clear();
			tbox_telefono.Clear();
			tbox_correo.Clear();
			tbox_rfc.Clear();
		}

		private void dgv_Display_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgv_Display.Rows[e.RowIndex];

				tbox_id.Text = row.Cells["idCliente"].Value.ToString();
				tbox_nombre.Text = row.Cells["nombreCliente"].Value.ToString();
				tbox_apellido.Text = row.Cells["apellidoCliente"].Value.ToString();
				tbox_telefono.Text = row.Cells["telefonoCliente"].Value.ToString();
				tbox_correo.Text = row.Cells["correoCliente"].Value.ToString();
				string creadoEnStr = row.Cells["creadoEn"].ToString();
				string actualizadoEnStr = row.Cells["actualizadoEn"].ToString();
				if (DateTime.TryParse(creadoEnStr, out DateTime creadoEnDate))
				{ dtp_creadoen.Value = creadoEnDate; }
				if (DateTime.TryParse(actualizadoEnStr, out DateTime actualizadoEnDate))
				{
					dtp_actualizadoen.Value = actualizadoEnDate;
					tbox_rfc.Text = row.Cells["rfcCliente"].Value.ToString();
				}
			}
		}

        private void btn_buscar_Click(object sender, EventArgs e)
        {
			string searchTerm = tbox_buscar.Text.Trim();

			try
			{
				using (OleDbConnection conn = new OleDbConnection())
				{
					conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + "\\TortilleriaDonTitoDB.accdb";
					conn.Open();

					// Construir la consulta SQL dinámicamente según el término de búsqueda
					string query = "SELECT * FROM cliente WHERE " +
								   "idCliente LIKE @searchTerm OR " +
								   "nombreCliente LIKE @searchTerm OR " +
								   "apellidoCliente LIKE @searchTerm OR " +
								   "telefonoCliente LIKE @searchTerm OR " +
								   "rfcCliente LIKE @searchTerm OR " +
								   "correoCliente LIKE @searchTerm";

					using (OleDbCommand cmd = new OleDbCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

						OleDbDataAdapter da = new OleDbDataAdapter(cmd);
						DataTable dt = new DataTable();
						da.Fill(dt);

						if (dt.Rows.Count == 0)
						{
							MessageBox.Show("No se encontraron resultados.");
							tbox_buscar.Clear();
							LoadTabla(); 
						}
						else
						{
							dgv_Display.DataSource = dt;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

        private void tbox_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbox_nombre_TextChanged(object sender, EventArgs e)
        {
			ValidateTextBox(tbox_nombre, lblNombreError,
			   text => !string.IsNullOrWhiteSpace(text) && text.All(char.IsLetter) && text.Length <= 50,
			   "El nombre debe contener solo letras y tener un máximo de 50 caracteres.");
		}

        private void tbox_apellido_TextChanged(object sender, EventArgs e)
        {
			ValidateTextBox(tbox_apellido, lblApellidosError,
			   text => !string.IsNullOrWhiteSpace(text) && text.All(char.IsLetter) && text.Length <= 50,
			   "El apellido debe contener solo letras y tener un máximo de 50 caracteres.");
		}

        private void tbox_telefono_TextChanged(object sender, EventArgs e)
        {
			ValidateTextBox(tbox_telefono, lblTelefonoError,
				text => text.Length == 10 && text.All(char.IsDigit),
				"El número de teléfono debe tener exactamente 10 dígitos y contener solo números.");
		}

        private void tbox_correo_TextChanged(object sender, EventArgs e)
        {
			ValidateTextBox(tbox_correo, lblCorreoError,
			   text => text.Contains("@") && text.Length >= 5,
			   "El correo electrónico debe tener al menos 5 caracteres y contener un símbolo '@'.");
		}

        private void tbox_rfc_TextChanged(object sender, EventArgs e)
        {
			ValidateTextBox(tbox_rfc, lblRFCError,
				text => text.Length == 13,
				"El RFC debe tener 13 caracteres.");
		}
    }
}
