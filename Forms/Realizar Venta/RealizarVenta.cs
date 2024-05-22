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
		int globalEmpleadoID = 0;

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
			ManejoDeInterfaz(0);
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
						globalEmpleadoID = empleadoID;
						ManejoDeInterfaz(1);
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
						double PrecioTotal = 0;
						foreach(DataGridViewRow row in dgv_TablaDeProductos.Rows)
						{
							PrecioTotal += Double.Parse(row.Cells["precioFinal"].Value?.ToString());
						}
						lbl_TotalPrecio.Text = "Total: $" + PrecioTotal +"MXN";
						tbox_CodigoProducto.Text = "";
						tbox_CantidadProd.Text = "1";

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
			//Reinicio de Tablas
			ManejoDeInterfaz(4);
			ManejoDeInterfaz(3);
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
			ComprobarMetodoDePagoYRealizarVenta(1);
		}

		private void ComprobarMetodoDePagoYRealizarVenta(int MetodoDePago)
		{
			if(MetodoDePago == 1)
			{
				int CantidadDeEfectivo;
				int.TryParse(tbox_CantidadDeEfectivo.Text, out CantidadDeEfectivo);
				if(CantidadDeEfectivo <= 0)
				{
					MessageBox.Show("Favor de ingresar una cantidad de efectivo valida");
				}
				else
				{
					double TotalEfectivo = 0;
					foreach (DataGridViewRow row in dgv_TablaDeProductos.Rows)
					{
						TotalEfectivo += Double.Parse(row.Cells["precioFinal"].Value?.ToString());
					}
					//MessageBox.Show($"Total: {TotalEfectivo}\nEfectivo: {CantidadDeEfectivo}\nCambio: {CantidadDeEfectivo - TotalEfectivo}");
					lbl_CambioDinero.Text = "Cambio: $" + (CantidadDeEfectivo - TotalEfectivo) + "MXN";
					FuncionRealizarVenta(1);
				}
			}
			else if(MetodoDePago == 2)
			{
				FuncionRealizarVenta(2);
			}
			else
			{
				//No visible
				MessageBox.Show("Por favor, seleccione un método de pago valido");
			}
		}

		private void FuncionRealizarVenta(int mdp)
		{
			int ProductoID = 0;
			string ProductoNombre = "";
			int CantidadAComprar = 0;
			double ProductoPrecio = 0;
			double ProductoTotal = 0;
			int CantidadActual = 0;
			bool enExistencia = true;
			foreach (DataGridViewRow row in dgv_TablaDeProductos.Rows)
			{
				ProductoID = 0;
				ProductoNombre = "";
				CantidadAComprar = 0;
				ProductoPrecio = 0;
				ProductoTotal = 0;
				CantidadActual = 0;
				enExistencia = false;
				bool readError = false;

				int.TryParse(row.Cells["idProducto"].Value?.ToString(), out ProductoID);
				ProductoNombre = row.Cells["nombreProducto"].Value?.ToString();
				int.TryParse(row.Cells["cantidadProducto"].Value?.ToString(), out CantidadAComprar);
				Double.TryParse(row.Cells["precioUnitarioProducto"].Value?.ToString(), out ProductoPrecio);
				Double.TryParse(row.Cells["precioFinal"].Value?.ToString(), out ProductoTotal);

				//Lectura de inventario
				try
				{
					conn.Open();
					OleDbCommand acCommand = new OleDbCommand();
					acCommand.Connection = conn;
					acCommand.CommandText = "SELECT * FROM inventario WHERE idProducto = ?";
					acCommand.Parameters.AddWithValue("?", ProductoID);

					OleDbDataReader acReader = acCommand.ExecuteReader();
					while (acReader.Read())
					{
						int.TryParse(acReader["existenciaProducto"].ToString(), out CantidadActual);
					}
					conn.Close();
				}
				catch (Exception ex)
				{
					readError = true;
					MessageBox.Show(ex.Message);
					conn.Close();
				}

				if (((CantidadActual - CantidadAComprar) >= 0)&&(readError == false))
				{
					bool CurrentSuccess = false;
					//Actualización de inventario
					try
					{
						conn.Open();
						OleDbCommand acCommand = new OleDbCommand();
						acCommand.Connection = conn;
						acCommand.CommandText = "UPDATE inventario SET existenciaProducto = existenciaProducto - ? WHERE idProducto = ?";
						acCommand.Parameters.AddWithValue("?", CantidadAComprar);
						acCommand.Parameters.AddWithValue("?", ProductoID);
						acCommand.ExecuteNonQuery();
						conn.Close();
						CurrentSuccess = true;
					}
					catch (Exception ex)
					{
						CurrentSuccess = false;
						MessageBox.Show(ex.Message);
						conn.Close();
					}
					if (CurrentSuccess)
					{
						//Venta
						int ventaID = 0;
						try
						{
							conn.Open();
							OleDbCommand acCommand = new OleDbCommand();
							acCommand.Connection = conn;
							acCommand.CommandText = "INSERT INTO venta (idCliente, idMetodoDePago, fechaVenta, creadoEn) VALUES (?, ?, ?, ?)";
							acCommand.Parameters.AddWithValue("?", globalClienteID);
							acCommand.Parameters.AddWithValue("?", mdp);
							acCommand.Parameters.AddWithValue("?", DateTime.Now.ToString("M/d/yyyy"));
							acCommand.Parameters.AddWithValue("?", DateTime.Now.ToString("M/d/yyyy"));

							acCommand.ExecuteNonQuery();

							// Retrieve the ID of the new venta record
							acCommand.CommandText = "SELECT @@IDENTITY";
							ventaID = (int)acCommand.ExecuteScalar();

							conn.Close();
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message);
							conn.Close();
						}
						//Detalle de venta
						try
						{
							conn.Open();
							OleDbCommand acCommand = new OleDbCommand();
							acCommand.Connection = conn;
							acCommand.CommandText = "INSERT INTO detalle_venta (idVenta, idProducto, cantidadProducto, precioUnitarioProducto, creadoEn, idEmpleado) VALUES (?, ?, ?, ?, ?, ?)";
							acCommand.Parameters.AddWithValue("?", ventaID);
							acCommand.Parameters.AddWithValue("?", ProductoID);
							acCommand.Parameters.AddWithValue("?", CantidadAComprar);
							acCommand.Parameters.AddWithValue("?", ProductoPrecio);
							acCommand.Parameters.AddWithValue("?", DateTime.Now.ToString("M/d/yyyy"));
							acCommand.Parameters.AddWithValue("?", globalEmpleadoID);
							acCommand.ExecuteNonQuery();
							conn.Close();
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message);
							conn.Close();
						}
						//MessageBox.Show($"Venta realizada con éxito\nProducto: {ProductoNombre}\nCantidad: {CantidadAComprar}\nTotal: {ProductoTotal}");
						ManejoDeInterfaz(2);
						lbl_VentaRealizadaConExito.Visible = true;
					}

				}
				else
				{
					MessageBox.Show($"No hay la cantidad suficiente en existencia [Quedan {CantidadActual}]");
				}
			}
		}
		private void ManejoDeInterfaz(int modo)
		{
			switch (modo)
			{
				//Bloqueo inicial
				case 0:
					gbox_Productos.Enabled = false;
					gbox_Venta.Enabled = false;
					gbox_Cliente.Enabled = false;
					gbox_Imprimir.Enabled = false;
					btn_ReiniciarVenta.Enabled = false;
					break;

				//Desbloqueo inicial
				case 1:
					gbox_Productos.Enabled = true;
					gbox_Venta.Enabled = true;
					gbox_Cliente.Enabled = true;
					gbox_Imprimir.Enabled = false;
					btn_ReiniciarVenta.Enabled = true;
					break;

				//Bloqueo despues de compra
				case 2:
					gbox_Productos.Enabled = false;
					gbox_Venta.Enabled = false;
					gbox_Cliente.Enabled = false;
					gbox_Imprimir.Enabled = true;
					btn_ReiniciarVenta.Enabled = true;
					break;
				//Desbloqueo despues de compra
				case 3:
					gbox_Productos.Enabled = true;
					gbox_Venta.Enabled = true;
					gbox_Cliente.Enabled = true;
					gbox_Imprimir.Enabled = false;
					btn_ReiniciarVenta.Enabled = true;
					break;
				//Reinicio de Tablas y Datos
				case 4:
					dgv_TablaDeProductos.Rows.Clear();
					dgv_TablaDeProductos.Refresh();
					tbox_CodigoProducto.Text = "";
					tbox_CantidadProd.Text = "1";
					tbox_Cliente.Text = "";
					tbox_CantidadDeEfectivo.Text = "";
					lbl_TotalPrecio.Text = "Total: $0MXN";
					lbl_CambioDinero.Text = "Cambio: $0MXN";
					lbl_VentaRealizadaConExito.Visible = false;
					break;

			}
			
		}

		private void tbox_EmpleadoID_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btn_LogInEmpleado_Click(sender, e);
			}
		}

		private void btn_Ticket_Click(object sender, EventArgs e)
		{

		}

		private void btn_Factura_Click(object sender, EventArgs e)
		{

		}
	}
}
