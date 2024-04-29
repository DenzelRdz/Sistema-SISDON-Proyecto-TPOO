using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_SISDON_Proyecto_TPOO.Forms
{
	public partial class GMCRUD : Form
	{
		public GMCRUD()
		{
			InitializeComponent();
		}

		private void GMCRUD_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'tortilleriaDonTitoDBDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.tortilleriaDonTitoDBDataSet.cliente);
            // TODO: This line of code loads data into the 'tortilleriaDonTitoDBDataSet.detalle_pedido' table. You can move, or remove it, as needed.
            this.detalle_pedidoTableAdapter.Fill(this.tortilleriaDonTitoDBDataSet.detalle_pedido);

        }
    }
}
