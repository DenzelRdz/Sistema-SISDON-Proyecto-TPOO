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
			// Validar que todos los campos estén llenados
			if (string.IsNullOrWhiteSpace(tbox_nombre.Text) ||
				string.IsNullOrWhiteSpace(tbox_apellido.Text) ||
				string.IsNullOrWhiteSpace(tbox_telefono.Text) ||
				string.IsNullOrWhiteSpace(tbox_correo.Text) ||
				string.IsNullOrWhiteSpace(tbox_rfc.Text))
				
			{
				MessageBox.Show("Por favor, complete todos los campos.");
				return false;
			}

			// Validar nombre y apellido
			if (tbox_nombre.Text.Length > 50 || tbox_apellido.Text.Length > 50) 
			{
				MessageBox.Show("El nombre y el apellido deben tener un máximo de 50 caracteres.");
				return false;
			}

			// Validar número de teléfono
			if (tbox_telefono.Text.Length != 10 || !tbox_telefono.Text.All(char.IsDigit))
			{
				MessageBox.Show("El número de teléfono debe tener exactamente 10 dígitos y contener solo números.");
				return false;
			}

			// Validar formato de correo electrónico
			if (!tbox_correo.Text.Contains("@") || tbox_correo.Text.Length < 5)
			{
				MessageBox.Show("El correo electrónico debe tener al menos 5 caracteres y contener un símbolo '@'.");
				return false;
			}

			// Validar longitud del RFC
			if (tbox_rfc.Text.Length != 13)
			{
				MessageBox.Show("El RFC es de 13 caracteres");
				return false;
			}

			return true;
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
    }
}
