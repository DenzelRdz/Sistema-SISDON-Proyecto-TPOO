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
	public partial class RealizarVenta : Form
	{

		private OleDbConnection conn = new OleDbConnection();
		string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
		int globalClienteID = 6;

		public RealizarVenta()
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

		private void RealizarVenta_Load(object sender, EventArgs e)
		{

		}

		private void btn_LogInEmpleado_Click(object sender, EventArgs e)
		{
			int empleadoID;
			bool isIntEmpleadoID = int.TryParse(tbox_EmpleadoID.Text, out empleadoID);
			if (empleadoID <= 0) { isIntEmpleadoID = false; }
			if (isIntEmpleadoID)
			{
				try
				{
					conn.Open();
					OleDbCommand acCommand = new OleDbCommand();
					acCommand.Connection = conn;
					acCommand.CommandText = "SELECT nombre FROM empleado WHERE idEmpleado = ?";
					acCommand.Parameters.AddWithValue("?", tbox_EmpleadoID.Text);

					OleDbDataReader acReader = acCommand.ExecuteReader();
					if (!acReader.HasRows) {
						lbl_Empleado_Status.Text = "Por favor, ingrese un ID válido";
						lbl_Empleado_Status.ForeColor = Color.Red;
					}
					else {
						while (acReader.Read()) { lbl_Empleado_Status.Text = "Bienvenido " + acReader["nombre"].ToString(); }
						lbl_Empleado_Status.ForeColor = Color.Green;
					}
					conn.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					conn.Close();
				}
			}
			else
			{
				lbl_Empleado_Status.Text = "Por favor, ingrese un ID válido";
				lbl_Empleado_Status.ForeColor = Color.Red;
			}

		}

		private void tbox_CodigoProducto_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				EnterIDProducto();
			}
		}

		private void EnterIDProducto()
		{
			int productoID;
			bool isIntProductoID = int.TryParse(tbox_CodigoProducto.Text, out productoID);
			if (productoID <= 0) { isIntProductoID = false; }
			int cantidadProd;
			bool isIntCantidadProd = int.TryParse(tbox_CantidadProd.Text, out cantidadProd);
			if ((cantidadProd > 999)||(cantidadProd <= 0)) { isIntCantidadProd = false; }
			if (isIntProductoID)
			{
				if (isIntCantidadProd)
				{
					try
					{
						conn.Open();
						OleDbCommand acCommand = new OleDbCommand();
						acCommand.Connection = conn;
						acCommand.CommandText = "SELECT idProducto, nombreProducto, precioProducto, existenciaProducto FROM inventario WHERE idProducto = ?";
						acCommand.Parameters.AddWithValue("?", tbox_CodigoProducto.Text);

						int ID = 0, existenciaProducto = 0;
						string nombreProducto = "";
						double precioProducto = 0;

						OleDbDataReader acReader = acCommand.ExecuteReader();
						while (acReader.Read())
						{
							ID = (int)acReader["idProducto"];
							nombreProducto = acReader["nombreProducto"].ToString();
							Double.TryParse(acReader["precioProducto"].ToString(), out precioProducto);
							int.TryParse(acReader["existenciaProducto"].ToString(), out existenciaProducto);
							
						}
						//MessageBox.Show($"ID: {ID}\nNombre: {nombreProducto}\nPrecio: {precioProducto}\nExistencia: {existenciaProducto}");
						if(cantidadProd > existenciaProducto)
						{
							ErrorProducto($"No hay la cantidad suficiente en existencia [Quedan {existenciaProducto}]");
						}
						else
						{
							int n = dgv_TablaDeProductos.Rows.Add();
							dgv_TablaDeProductos.Rows[n].Cells[0].Value = ID;
							dgv_TablaDeProductos.Rows[n].Cells[1].Value = nombreProducto;
							dgv_TablaDeProductos.Rows[n].Cells[2].Value = cantidadProd;
							dgv_TablaDeProductos.Rows[n].Cells[3].Value = precioProducto;
							dgv_TablaDeProductos.Rows[n].Cells[4].Value = precioProducto * cantidadProd;

						}


						conn.Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						conn.Close();
					}
				}
				else
				{
					ErrorProducto("Por favor, ingrese una cantidad válida");
				}
			}
			else
			{
				ErrorProducto("Por favor, ingrese un código válido");
			}
		}

		private void ErrorProducto(string Mensaje)
		{
			MessageBox.Show(Mensaje);
			tbox_CodigoProducto.Text = "";
			tbox_CantidadProd.Text = "1";
		}

		private void btn_ReiniciarVenta_Click(object sender, EventArgs e)
		{
			dgv_TablaDeProductos.Rows.Clear();
			dgv_TablaDeProductos.Refresh();
		}

		private void btn_IngresarCliente_Click(object sender, EventArgs e)
		{
			int clienteID;
			bool isIntClienteID = int.TryParse(tbox_Cliente.Text, out clienteID);
			if (clienteID <= 0) { isIntClienteID = false; }
			if (isIntClienteID)
			{
				try
				{
					conn.Open();
					OleDbCommand acCommand = new OleDbCommand();
					acCommand.Connection = conn;
					acCommand.CommandText = "SELECT nombreCliente FROM cliente WHERE idCliente = ?";
					acCommand.Parameters.AddWithValue("?", tbox_Cliente.Text);

					OleDbDataReader acReader = acCommand.ExecuteReader();
					if (!acReader.HasRows)
					{
						lbl_StatusCliente.Text = "Por favor, ingrese un ID válido";
						lbl_StatusCliente.ForeColor = Color.Red;
					}
					else
					{
						while (acReader.Read()) { lbl_StatusCliente.Text = "Bienvenido " + acReader["nombreCliente"].ToString();}
						lbl_StatusCliente.ForeColor = Color.Green;
						globalClienteID = clienteID;
					}
					conn.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					conn.Close();
				}
			}
			else
			{
				lbl_StatusCliente.Text = "Por favor, ingrese un ID válido";
				lbl_StatusCliente.ForeColor = Color.Red;
			}
		}

		private void btn_PagoEnEfectivo_Click(object sender, EventArgs e)
		{
			int ProductoID = 0;
			string ProductoNombre = "";
			int ProductoCantidad = 0;
			double ProductoPrecio = 0;
			double ProductoTotal = 0;
			foreach (DataGridViewRow row in dgv_TablaDeProductos.Rows)
			{
				int.TryParse(row.Cells["idProducto"].Value?.ToString(), out ProductoID);
				ProductoNombre = row.Cells["nombreProducto"].Value?.ToString();
				int.TryParse(row.Cells["cantidadProducto"].Value?.ToString(), out ProductoCantidad);
				Double.TryParse(row.Cells["precioUnitarioProducto"].Value?.ToString(), out ProductoPrecio);
				Double.TryParse(row.Cells["precioFinal"].Value?.ToString(), out ProductoTotal);
				MessageBox.Show($"ID: {ProductoID}\nNombre: {ProductoNombre}\nCantidad: {ProductoCantidad}\nPrecio: {ProductoPrecio}\nTotal: {ProductoTotal}");

			}
			/*try
			{
				conn.Open();
				OleDbCommand acCommand = new OleDbCommand();
				acCommand.Connection = conn;
				acCommand.CommandText = "INSERT INTO detalle_venta (idProducto, cantidadProducto, precioUnitarioProducto, idEmpleado) VALUES ('" + tbox_id.Text + "','" + tbox_nombre.Text + "','" + tbox_apellido.Text + "','" + tbox_telefono.Text + "','" + tbox_correo.Text + "','" + dtp_creadoen.Text + "','" + dtp_actualizadoen.Text + "','" + tbox_rfc.Text + "')";
				acCommand.ExecuteNonQuery();
				conn.Close();

				MessageBox.Show("Connection Succesfull");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				conn.Close();
			}*/
		}
	}
}
