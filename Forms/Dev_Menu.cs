using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Sistema_SISDON_Proyecto_TPOO.Forms
{
	public partial class Dev_Menu : Form
	{
		public Dev_Menu()
		{
			InitializeComponent();
		}

		private void Dev_Menu_Load(object sender, EventArgs e)
		{
			Type[] typelist = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "Sistema_SISDON_Proyecto_TPOO.Forms");
			foreach (Type type in typelist)
			{
				if (type.IsSubclassOf(typeof(Form)))
				{
					cmb_MenuSelect.Items.Add(type.Name);
				}
			}

			if (cmb_MenuSelect.Items.Count > 0)
			{
				cmb_MenuSelect.SelectedIndex = 0;
			}

		}

		private Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
		{
			return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string formName = cmb_MenuSelect.SelectedItem.ToString();
			Type formType = Type.GetType("Sistema_SISDON_Proyecto_TPOO.Forms." + formName);
			Form form = (Form)Activator.CreateInstance(formType);
			this.Hide();
			form.Closed += (s, args) => this.Close();
			form.Show();
		}
	}
}
