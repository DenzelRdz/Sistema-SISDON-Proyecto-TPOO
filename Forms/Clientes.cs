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
            // TODO: esta línea de código carga datos en la tabla 'tortilleriaDonTitoDBDataSet.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.tortilleriaDonTitoDBDataSet.cliente);

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
			try
			{
				conn.Open();
				OleDbCommand acCommand = new OleDbCommand();
				acCommand.Connection = conn;
				acCommand.CommandText = "INSERT INTO cliente (idCliente, nombreCliente, apellidoCliente, telefonoCliente, correoCliente, creadoEn, actualizadoEn, rfcCliente) VALUES ('" + tbox_id.Text + "','" + tbox_nombre.Text + "','" + tbox_apellido.Text + "','" + tbox_telefono.Text + "','" + tbox_correo.Text + "','" + dtp_creadoen.Text + "','" + dtp_actualizadoen.Text + "','" + tbox_rfc.Text + "')";
				acCommand.ExecuteNonQuery();
				conn.Close();

				MessageBox.Show("Se creó correctamente la información");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn.Close();
			}
		}

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
			DialogResult dr = MessageBox.Show("¿Estas seguro que quieres eliminar este registro?", "Eliminar Registro", MessageBoxButtons.YesNo);
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

					MessageBox.Show("Se borró correctamente");
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
			try
			{
				conn.Open();
				OleDbCommand acCommand = new OleDbCommand();
				acCommand.Connection = conn;
				acCommand.CommandText = "UPDATE cliente SET nombreCliente='" + tbox_nombre.Text + "', apellidoCliente='" + tbox_apellido.Text +  "', telefonoCliente='" + tbox_telefono.Text + "', correoCliente='" + tbox_correo.Text + "', creadoEn='" + dtp_creadoen.Text + "', actualizadoEn='" + dtp_actualizadoen.Text + "', rfcCliente='" + tbox_rfc.Text + "' WHERE idCliente=" + txt_idbuscar.Text + "";
				acCommand.ExecuteNonQuery();
				conn.Close();

				MessageBox.Show("Se actualizó correctamente");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn.Close();
			}
		}

        private void btn_leer_Click(object sender, EventArgs e)
        {
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
    }
}
