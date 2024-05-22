using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_SISDON_Proyecto_TPOO.Forms
{
	public partial class VisualizacionVentas : Form
	{
		private OleDbConnection conn = new OleDbConnection();
		string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
		public VisualizacionVentas()
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

		private void VisualizacionVentas_Load(object sender, EventArgs e)
		{
			try
			{
				conn.Open();
				OleDbCommand command = new OleDbCommand("SELECT venta.idVenta, venta.idCliente, detalle_venta.idProducto, detalle_venta.cantidadProducto, detalle_venta.precioUnitarioProducto, detalle_venta.idEmpleado, venta.fechaVenta, venta.creadoEn FROM venta INNER JOIN detalle_venta ON venta.idVenta = detalle_venta.idVenta", conn);
				OleDbDataAdapter adapter = new OleDbDataAdapter(command);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				dgv_Visualizacion.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
				{
					conn.Close();
				}
			}

		}
	}
}
