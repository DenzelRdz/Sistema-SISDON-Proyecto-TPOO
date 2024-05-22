using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
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
		string globalEmpleadoNombre = "";
		string globalClienteNombre = "Invitado";
		double globalTotalPrecio = 0; //Bad implementation
		double globalTotalCambio = 0; //Bad implementation

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
						while (acReader.Read()) { 
							lbl_Empleado_Status.Text = "Bienvenido " + acReader["nombre"].ToString();
							globalEmpleadoNombre = acReader["nombre"].ToString();
						}
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
			if ((cantidadProd > 999) || (cantidadProd <= 0)) { isIntCantidadProd = false; }
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
						if (cantidadProd > existenciaProducto)
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
						foreach (DataGridViewRow row in dgv_TablaDeProductos.Rows)
						{
							PrecioTotal += Double.Parse(row.Cells["precioFinal"].Value?.ToString());
						}
						lbl_TotalPrecio.Text = "Total: $" + PrecioTotal + "MXN";
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
						while (acReader.Read()) { 
							lbl_StatusCliente.Text = "Bienvenido " + acReader["nombreCliente"].ToString();
							globalClienteNombre = acReader["nombreCliente"].ToString();
						}
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
			if (MetodoDePago == 1)
			{
				int CantidadDeEfectivo;
				int.TryParse(tbox_CantidadDeEfectivo.Text, out CantidadDeEfectivo);
				if (CantidadDeEfectivo <= 0)
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
					globalTotalPrecio = TotalEfectivo;
					globalTotalCambio = CantidadDeEfectivo - TotalEfectivo;
					FuncionRealizarVenta(1);
				}
			}
			else if (MetodoDePago == 2)
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

				if (((CantidadActual - CantidadAComprar) >= 0) && (readError == false))
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
			if (e.KeyCode == Keys.Enter)
			{
				btn_LogInEmpleado_Click(sender, e);
			}
		}

		// Clase Factura y DetalleVenta
		public class Factura
		{
			public string NombreEmpresa { get; set; }
			public string DireccionEmpresa { get; set; }
			public string CorreoEmpresa { get; set; }
			public string TelefonoEmpresa { get; set; }
			public string NombreCliente { get; set; }
			public int IdCliente { get; set; }
			public int NumeroVenta { get; set; }
			public DateTime FechaVenta { get; set; }
			public List<DetalleVenta> Detalles { get; set; }
			public double SubTotal { get; set; }
			public double IGV { get; set; }
			public double Total { get; set; }
		}

		public class DetalleVenta
		{
			public string Producto { get; set; }
			public int Cantidad { get; set; }
			public double PrecioUnitario { get; set; }
			public double Total => Cantidad * PrecioUnitario;
		}

		// Métodos en RealizarVenta
		private Factura GenerarFactura()
		{
			var factura = new Factura
			{
				NombreEmpresa = "Tortillas de Harina Don Tito",
				DireccionEmpresa = "Calle Violeta 239, Colonia Unidad Tres Caminos, Guadalupe, Nuevo León",
				CorreoEmpresa = "dontito@gmail.com",
				TelefonoEmpresa = "8115446545",
				NombreCliente = lbl_StatusCliente.Text.Replace("Bienvenido ", ""),
				IdCliente = globalClienteID,
				NumeroVenta = 1,
				FechaVenta = DateTime.Now,
				Detalles = new List<DetalleVenta>(),
				SubTotal = 0,
				IGV = 0,
				Total = 0
			};

			foreach (DataGridViewRow row in dgv_TablaDeProductos.Rows)
			{
				if (row.Cells["idProducto"].Value != null)
				{
					var detalle = new DetalleVenta
					{
						Producto = row.Cells["nombreProducto"].Value.ToString(),
						Cantidad = Convert.ToInt32(row.Cells["cantidadProducto"].Value),
						PrecioUnitario = Convert.ToDouble(row.Cells["precioUnitarioProducto"].Value)
					};
					factura.Detalles.Add(detalle);
					factura.SubTotal += detalle.Total;
				}
			}

			factura.IGV = factura.SubTotal * 0.18;
			factura.Total = factura.SubTotal + factura.IGV;

			return factura;
		}

		private void ImprimirFactura(Factura factura)
		{
			PrintDocument pd = new PrintDocument();
			pd.PrintPage += (sender, args) => PrintPageHandler(sender, args, factura);
			PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog
			{
				Document = pd
			};
			printPreviewDialog.ShowDialog();
		}

		private void PrintPageHandler(object sender, PrintPageEventArgs e, Factura factura)
		{
			Graphics g = e.Graphics;
			Font font = new Font("Arial", 12);
			Font fontBold = new Font("Arial", 12, FontStyle.Bold);
			Font fontTitle = new Font("Arial", 18, FontStyle.Bold);
			int startX = 50;
			int startY = 50;
			int offsetY = 40;

			// Cargar el logo desde los recursos
			Image logo = Sistema_SISDON_Proyecto_TPOO.Properties.Resources.increible;

			// Definir el tamaño deseado para el logo
			int logoWidth = 100; // Ancho del logo en píxeles
			int logoHeight = 100; // Alto del logo en píxeles

			// Calcular la posición del logo en el centro superior
			int logoX = (e.PageBounds.Width / 2) - (logoWidth / 2);
			int logoY = startY;

			// Dibujar el logo en el centro superior con el tamaño ajustado
			g.DrawImage(logo, logoX, logoY, logoWidth, logoHeight);
			offsetY += logoHeight + 20;

			// Dibujar título y datos de la empresa
			g.DrawString("Factura", fontTitle, Brushes.Black, startX, startY + offsetY);
			offsetY += 40;

			g.DrawString(factura.NombreEmpresa, fontBold, Brushes.Black, startX, startY + offsetY);
			offsetY += 20;
			g.DrawString(factura.DireccionEmpresa, font, Brushes.Black, startX, startY + offsetY);
			offsetY += 20;
			g.DrawString(factura.CorreoEmpresa, font, Brushes.Black, startX, startY + offsetY);
			offsetY += 20;
			g.DrawString(factura.TelefonoEmpresa, font, Brushes.Black, startX, startY + offsetY);
			offsetY += 40;

			// Dibujar datos del cliente y la venta
			g.DrawString($"Cliente: {factura.NombreCliente}", fontBold, Brushes.Black, startX, startY + offsetY);
			offsetY += 20;
			g.DrawString($"ID Cliente: {factura.IdCliente}", font, Brushes.Black, startX, startY + offsetY);
			offsetY += 20;
			g.DrawString($"Fecha: {factura.FechaVenta}", font, Brushes.Black, startX, startY + offsetY);
			offsetY += 40;

			// Dibujar encabezados de la tabla de productos
			g.DrawString("Producto", fontBold, Brushes.Black, startX, startY + offsetY);
			g.DrawString("Cantidad", fontBold, Brushes.Black, startX + 200, startY + offsetY);
			g.DrawString("Precio Unitario", fontBold, Brushes.Black, startX + 300, startY + offsetY);
			g.DrawString("Total", fontBold, Brushes.Black, startX + 450, startY + offsetY);
			offsetY += 20;

			// Dibujar detalles de los productos
			foreach (var detalle in factura.Detalles)
			{
				g.DrawString(detalle.Producto, font, Brushes.Black, startX, startY + offsetY);
				g.DrawString(detalle.Cantidad.ToString(), font, Brushes.Black, startX + 200, startY + offsetY);
				g.DrawString(detalle.PrecioUnitario.ToString("C"), font, Brushes.Black, startX + 300, startY + offsetY);
				g.DrawString(detalle.Total.ToString("C"), font, Brushes.Black, startX + 450, startY + offsetY);
				offsetY += 20;
			}

			// Dibujar totales
			offsetY += 40;
			g.DrawString($"Sub Total: {factura.SubTotal:C}", fontBold, Brushes.Black, startX, startY + offsetY);
			offsetY += 20;
			g.DrawString($"IGV: {factura.IGV:C}", fontBold, Brushes.Black, startX, startY + offsetY);
			offsetY += 20;
			g.DrawString($"Total: {factura.Total:C}", fontBold, Brushes.Black, startX, startY + offsetY);
		}

		private void btn_Factura_Click(object sender, EventArgs e)
		{
			var factura = GenerarFactura();
			ImprimirFactura(factura);
		}

		//Codigo del TICKET
		public class CreaTicket
		{
			public static StringBuilder line = new StringBuilder();
			string ticket = "";
			string parte1, parte2;

			public static int max = 40;
			int cort;
			public static string LineasGuion()
			{
				string LineaGuion = "-------------------------------------------------";   // agrega lineas separadoras -

				return line.AppendLine(LineaGuion).ToString();
			}


			public static void EncabezadoVenta()
			{
				string LineEncavesado = "          Prod          Cant    Precio     Total";   // agrega lineas de  encabezados
				line.AppendLine(LineEncavesado);
			}
			public void TextoIzquierda(string par1)                          // agrega texto a la izquierda
			{
				max = par1.Length;
				if (max > 40)                                 // **********
				{
					cort = max - 40;
					parte1 = par1.Remove(40, cort);        // si es mayor que 40 caracteres, lo corta
				}
				else { parte1 = par1; }                      // **********
				line.AppendLine(ticket = parte1);

			}
			public void TextoDerecha(string par1)
			{
				ticket = "";
				max = par1.Length;
				if (max > 40)                                 // **********
				{
					cort = max - 40;
					parte1 = par1.Remove(40, cort);           // si es mayor que 40 caracteres, lo corta
				}
				else { parte1 = par1; }                      // **********
				max = 40 - par1.Length;                     // obtiene la cantidad de espacios para llegar a 40
				for (int i = 0; i < max; i++)
				{
					ticket += " ";                          // agrega espacios para alinear a la derecha
				}
				line.AppendLine(ticket += parte1 + "\n");                //Agrega el texto

			}
			public void TextoCentro(string par1)
			{
				ticket = "";
				max = par1.Length;
				if (max > 40)                                 // **********
				{
					cort = max - 40;
					parte1 = par1.Remove(40, cort);          // si es mayor que 40 caracteres, lo corta
				}
				else { parte1 = par1; }                      // **********
				max = (int)(40 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
				for (int i = 0; i < max; i++)                // **********
				{
					ticket += " ";                           // Agrega espacios antes del texto a centrar
				}                                            // **********
				line.AppendLine(ticket += parte1 + "\n");

			}
			public void TextoExtremos(string par1, string par2)
			{
				max = par1.Length;
				if (max > 18)                                 // **********
				{
					cort = max - 18;
					parte1 = par1.Remove(18, cort);          // si par1 es mayor que 18 lo corta
				}
				else { parte1 = par1; }                      // **********
				ticket = parte1;                             // agrega el primer parametro
				max = par2.Length;
				if (max > 18)                                 // **********
				{
					cort = max - 18;
					parte2 = par2.Remove(18, cort);          // si par2 es mayor que 18 lo corta
				}
				else { parte2 = par2; }
				max = 40 - (parte1.Length + parte2.Length);
				for (int i = 0; i < max; i++)                 // **********
				{
					ticket += " ";                            // Agrega espacios para poner par2 al final
				}                                             // **********
				line.AppendLine(ticket += parte2 + "\n");                   // agrega el segundo parametro al final

			}
			public void AgregaTotales(string par1, double total)
			{
				max = par1.Length;
				if (max > 25)                                 // **********
				{
					cort = max - 25;
					parte1 = par1.Remove(25, cort);          // si es mayor que 25 lo corta
				}
				else { parte1 = par1; }                      // **********
				ticket = parte1;
				parte2 = total.ToString("c");
				max = 40 - (parte1.Length + parte2.Length);
				for (int i = 0; i < max; i++)                // **********
				{
					ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
				}                                            // **********
				line.AppendLine(ticket += parte2 + "\n");

			}

			// se le pasan los Aticulos  con sus detalles
			public void AgregaArticulo(string Articulo, double precio, int cant, double subtotal)
			{
				if (cant.ToString().Length <= 3 && precio.ToString("c").Length <= 10 && subtotal.ToString("c").Length <= 11) // valida que cant precio y total esten dentro de rango
				{
					string elementos = "", espacios = "";
					bool bandera = false;
					int nroEspacios = 0;

					if (Articulo.Length > 40)                                 // **********
					{
						//cort = max - 16;
						//parte1 = Articulo.Remove(16, cort);          // corta a 16 la descripcion del articulo
						nroEspacios = (3 - cant.ToString().Length);
						espacios = "";
						for (int i = 0; i < nroEspacios; i++)
						{
							espacios += " ";
						}
						elementos += espacios + cant.ToString();

						// colocamos el precio a la derecha
						nroEspacios = (10 - precio.ToString().Length);
						espacios = "";

						for (int i = 0; i < nroEspacios; i++)
						{
							espacios += " ";
						}
						elementos += espacios + precio.ToString();

						//colocar el subtotal a la dercha
						nroEspacios = (11 - subtotal.ToString().Length);
						espacios = "";

						for (int i = 0; i < nroEspacios; i++)
						{
							espacios += " ";
						}
						elementos += espacios + subtotal.ToString();

						int CaracterActual = 0;// indica en que caracter se quedo
						for (int Longtext = Articulo.Length; Longtext > 16; Longtext++)
						{
							if (bandera == false)
							{
								line.AppendLine(Articulo.Substring(CaracterActual, 16) + elementos);
								bandera = true;
							}
							else
							{
								line.AppendLine(Articulo.Substring(CaracterActual, 16));

							}
							CaracterActual += 16;
						}
						line.AppendLine(Articulo.Substring(CaracterActual, Articulo.Length - CaracterActual));


					}
					else
					{
						for (int i = 0; i < (16 - Articulo.Length); i++)
						{
							espacios += " ";

						}
						elementos = Articulo + espacios;
						nroEspacios = (3 - cant.ToString().Length);
						espacios = "";
						for (int i = 0; i < nroEspacios; i++)
						{
							espacios += " ";
						}
						elementos += espacios + cant.ToString();

						// colocamos el precio a la derecha
						nroEspacios = (10 - precio.ToString().Length);
						espacios = "";

						for (int i = 0; i < nroEspacios; i++)
						{
							espacios += " ";
						}
						elementos += espacios + precio.ToString();

						//colocar el subtotal a la dercha
						nroEspacios = (11 - subtotal.ToString().Length);
						espacios = "";

						for (int i = 0; i < nroEspacios; i++)
						{
							espacios += " ";
						}
						elementos += espacios + subtotal.ToString();
						line.AppendLine(elementos);

					}
				}
				else
				{
					//  MessageBox.Show("Valores fuera de rango");

				}
			}

			public void ImprimirTiket(string stringimpresora)
			{
				RawPrinterHelper.SendStringToPrinter(stringimpresora, line.ToString());
				line = new StringBuilder();

			}
		}

		#region Clase para enviar a imprsora texto plano
		public class RawPrinterHelper
		{
			// Structure and API declarions:
			[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
			public class DOCINFOA
			{
				[MarshalAs(UnmanagedType.LPStr)]
				public string pDocName;
				[MarshalAs(UnmanagedType.LPStr)]
				public string pOutputFile;
				[MarshalAs(UnmanagedType.LPStr)]
				public string pDataType;
			}
			[DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
			public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

			[DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
			public static extern bool ClosePrinter(IntPtr hPrinter);

			[DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
			public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

			[DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
			public static extern bool EndDocPrinter(IntPtr hPrinter);

			[DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
			public static extern bool StartPagePrinter(IntPtr hPrinter);

			[DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
			public static extern bool EndPagePrinter(IntPtr hPrinter);

			[DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
			public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

			// SendBytesToPrinter()
			// When the function is given a printer name and an unmanaged array
			// of bytes, the function sends those bytes to the print queue.
			// Returns true on success, false on failure.
			public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
			{
				Int32 dwError = 0, dwWritten = 0;
				IntPtr hPrinter = new IntPtr(0);
				DOCINFOA di = new DOCINFOA();
				bool bSuccess = false; // Assume failure unless you specifically succeed.

				di.pDocName = "My C#.NET RAW Document";
				di.pDataType = "RAW";
				// di.pOutputFile = @"C:\Users\Roland\Documents\Visual Studio 2015\Projects\pjtVentas\Ventas";

				// Open the printer.
				if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
				{
					// Start a document.
					if (StartDocPrinter(hPrinter, 1, di))
					{
						// Start a page.
						if (StartPagePrinter(hPrinter))
						{
							// Write your bytes.
							bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
							EndPagePrinter(hPrinter);
						}
						EndDocPrinter(hPrinter);
					}
					ClosePrinter(hPrinter);
				}
				// If you did not succeed, GetLastError may give more information
				// about why not.
				if (bSuccess == false)
				{
					dwError = Marshal.GetLastWin32Error();
				}
				return bSuccess;
			}

			public static bool SendStringToPrinter(string szPrinterName, string szString)
			{
				IntPtr pBytes;
				Int32 dwCount;
				// How many characters are in the string?
				dwCount = szString.Length;
				// Assume that the printer is expecting ANSI text, and then convert
				// the string to ANSI text.
				pBytes = Marshal.StringToCoTaskMemAnsi(szString);
				// Send the converted ANSI string to the printer.
				SendBytesToPrinter(szPrinterName, pBytes, dwCount);
				Marshal.FreeCoTaskMem(pBytes);
				return true;
			}
		}
		#endregion


		//Codigo de ticket
		private void btn_Ticket_Click(object sender, EventArgs e)
		{
			CreaTicket Ticket1 = new CreaTicket();

			Ticket1.TextoCentro("TORTILLERIA DONTITO"); //imprime una linea de descripcion
			Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
			Ticket1.TextoCentro("No Fac: 0120102");
			Ticket1.TextoCentro("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
			Ticket1.TextoCentro("Dirección: Violeta 239 Unidad Tres Caminos Guadalupe Nuevo León");
			Ticket1.TextoCentro("Número: 81-85-65-19-60");
			Ticket1.TextoCentro("Le Atendio: " + globalEmpleadoNombre);
			Ticket1.TextoCentro("Cliente: " + globalClienteNombre);
			CreaTicket.LineasGuion();

			CreaTicket.EncabezadoVenta();
			CreaTicket.LineasGuion();
			foreach (DataGridViewRow r in dgv_TablaDeProductos.Rows)
			{
				// PROD                     //PrECIO                                    CANT                         TOTAL
				Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
			}


			CreaTicket.LineasGuion();
			Ticket1.TextoIzquierda(" ");
			Ticket1.AgregaTotales("Total", globalTotalPrecio); // imprime linea con total
			Ticket1.AgregaTotales("Efectivo Entregado:", globalTotalPrecio + globalTotalCambio);
			Ticket1.AgregaTotales("Efectivo Devuelto:", globalTotalCambio);
			Ticket1.AgregaTotales("IVA: ", globalTotalPrecio * 1.16);


			// Ticket1.LineasTotales(); // imprime linea 

			Ticket1.TextoCentro("**********************************");
			Ticket1.TextoCentro("*     GRACIAS POR PREFERIRNOS    *");

			Ticket1.TextoCentro("**********************************");
			Ticket1.TextoIzquierda(" ");
			string impresora = "Microsoft XPS Document Writer";
			Ticket1.ImprimirTiket(impresora);

			MessageBox.Show("Se generó un ticket");
		}


		private void btn_PagoConTarjeta_Click(object sender, EventArgs e)
		{
			ComprobarMetodoDePagoYRealizarVenta(2);
		}
	}
}
