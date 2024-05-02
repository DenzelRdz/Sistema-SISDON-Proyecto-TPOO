using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_SISDON_Proyecto_TPOO.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Xiomara\Source\Repos\Sistema-SISDON-Proyecto-TPOO\TortilleriaDonTitoDB.accdb"); 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dev_Menu dev_Menu = new Dev_Menu();
            this.Hide();
            dev_Menu.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtClave.Clear();
        }
    }
}
