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
	public partial class GMCRUD : Form
	{
		private OleDbConnection conn = new OleDbConnection();
		string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

		public GMCRUD()
		{
			InitializeComponent();
			try
			{
				conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+path+"\\TortilleriaDonTitoDB.accdb";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_Create_Click(object sender, EventArgs e)
		{
			try
			{
				conn.Open();
				OleDbCommand acCommand = new OleDbCommand();
				acCommand.Connection = conn;
				acCommand.CommandText = "INSERT INTO cliente (idCliente, nombreCliente, apellidoCliente, telefonoCliente, correoCliente, creadoEn, actualizadoEn, rfcCliente) VALUES ('" + tbox_id.Text + "','" + tbox_nombre.Text + "','" + tbox_apellido.Text + "','" + tbox_telefono.Text + "','" + tbox_correo.Text + "','" + dtp_creadoen.Text + "','" + dtp_actualizadoen.Text + "','" + tbox_rfc.Text + "')";
				acCommand.ExecuteNonQuery();
				conn.Close();

				MessageBox.Show("Connection Succesfull");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn.Close();
			}
		}

		private void btn_ReadTable_Click(object sender, EventArgs e)
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

		private void btn_Update_Click(object sender, EventArgs e)
		{
			try
			{
				conn.Open();
				OleDbCommand acCommand = new OleDbCommand();
				acCommand.Connection = conn;
				acCommand.CommandText = "UPDATE cliente SET nombreCliente='" + tbox_nombre.Text + "', apellidoCliente='" + tbox_apellido.Text + "', telefonoCliente='" + tbox_telefono.Text + "', correoCliente='" + tbox_correo.Text + "', creadoEn='" + dtp_creadoen.Text + "', actualizadoEn='" + dtp_actualizadoen.Text + "', rfcCliente='" + tbox_rfc.Text + "' WHERE idCliente=" + tbox_id.Text + "";
				acCommand.ExecuteNonQuery();
				conn.Close();

				MessageBox.Show("Connection Succesfull");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn.Close();
			}
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("¿Estas seguro que quieres eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
			if (dr == DialogResult.Yes)
			{
				try
				{
					conn.Open();
					OleDbCommand acCommand = new OleDbCommand();
					acCommand.Connection = conn;
					acCommand.CommandText = "DELETE FROM cliente WHERE idCliente=" + tbox_id.Text + "";
					acCommand.ExecuteNonQuery();
					conn.Close();

					MessageBox.Show("Connection Succesfull");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					conn.Close();
				}
			}
		}

		private void btn_Read_Click(object sender, EventArgs e)
		{
			try
			{
				conn.Open();
				OleDbCommand acCommand = new OleDbCommand();
				acCommand.Connection = conn;
				acCommand.CommandText = "SELECT * FROM cliente WHERE idCliente = ?";
				acCommand.Parameters.AddWithValue("?", tbox_id.Text);

				OleDbDataReader acReader = acCommand.ExecuteReader();
				while (acReader.Read())
				{
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

		//Debug
		private void btn_MonthDisplay_Click(object sender, EventArgs e)
		{
			try
			{
				conn.Open();
				OleDbCommand acCommand = new OleDbCommand();
				acCommand.Connection = conn;
				acCommand.CommandText = "SELECT creadoEn, actualizadoEn FROM cliente WHERE idCliente =" + tbox_id.Text + "";

				string debug_CreadoEn = "";
				string debug_ActualizadoEn = "";


				OleDbDataReader acReader = acCommand.ExecuteReader();
				while (acReader.Read())
				{
					debug_CreadoEn = acReader.GetDateTime(0).ToString("d");	
					//debug_CreadoEn = Convert.ToDateTime(acReader["creadoEn"]).ToString("d");
					debug_ActualizadoEn = Convert.ToDateTime(acReader["actualizadoEn"]).ToString("d");
				}
				MessageBox.Show($"Creado en: {debug_CreadoEn}\nActualizado en: {debug_ActualizadoEn}","DEBUG");


				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn.Close();
			}

		}

		private void btn_ExecPath_Click(object sender, EventArgs e)
		{
			string debug_path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
			MessageBox.Show(debug_path);
		}
	}
}
