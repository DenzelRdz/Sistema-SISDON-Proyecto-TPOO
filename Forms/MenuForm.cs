//NO EDITAR ESTE CÓDIGO NI TAMPOCO EL FORMULARIO MenuForm.Designer.cs NI MenuForm.resx NI MenuForm.cs
//NO EDITAR ESTE CÓDIGO NI TAMPOCO EL FORMULARIO MenuForm.Designer.cs NI MenuForm.resx NI MenuForm.cs
//NO EDITAR ESTE CÓDIGO NI TAMPOCO EL FORMULARIO MenuForm.Designer.cs NI MenuForm.resx NI MenuForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_SISDON_Proyecto_TPOO.Forms
{
    public partial class MenuForm : Form
    {
        private Button CurrentButton;
        private Random random;
        private int tempindex;
        private Form activeform;
        private Panel panelmenu;
        private Panel paneltitulo;
        private Panel paneltodo;
        private Label lbltitulo;
        private Button btncerrarpanel;
        private Button btnMinimizar;
        private Button btnCerrarSistema;

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public MenuForm()
        {
            InitializeComponent();
            random = new Random();
            btncerrarpanel.Visible = false;
            btnMinimizar.Visible = true;
            btnCerrarSistema.Visible = true;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Agrega los eventos de ratón al paneltitulo
            this.paneltitulo.MouseDown += new MouseEventHandler(this.paneltitulo_MouseDown);
            this.paneltitulo.MouseMove += new MouseEventHandler(this.paneltitulo_MouseMove);
            this.paneltitulo.MouseUp += new MouseEventHandler(this.paneltitulo_MouseUp);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void InitializeComponent()
        {
            this.panelmenu = new Panel();
            this.paneltitulo = new Panel();
            this.paneltodo = new Panel();
            this.lbltitulo = new Label();
            this.btncerrarpanel = new Button();

            this.SuspendLayout();

            // panelmenu
            this.panelmenu.Dock = DockStyle.Left;
            this.panelmenu.BackColor = Color.FromArgb(30, 38, 70);
            this.panelmenu.Size = new Size(220, this.ClientSize.Height);
            this.panelmenu.Controls.AddRange(new Control[]
            {
            CreateMenuButton("Clientes", btnclientes_Click),
            CreateMenuButton("Usuarios", btnusuarios_Click),
            CreateMenuButton("Inventario", btninventario_Click),
            CreateMenuButton("Realizar Venta", btnrealizarventa_Click),
            CreateMenuButton("Registro de Ventas", btnregistroventas_Click),
            CreateMenuButton("Realizar Pedido", btnrealizarpedido_Click),
            CreateMenuButton("Registro de Pedidos", btnregistropedidos_Click)
            });

            // paneltitulo
            this.paneltitulo.Dock = DockStyle.Top;
            this.paneltitulo.BackColor = Color.FromArgb(30, 38, 70);
            this.paneltitulo.Size = new Size(220, 50); // Increase height
            this.btnMinimizar = new Button();
            this.btnMinimizar.Dock = DockStyle.Right;
            this.btnMinimizar.Size = new Size(50, 30);
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.ForeColor = Color.White;
            this.btnMinimizar.Click += new EventHandler(this.btnMinimizar_Click);


            // btnCerrarSistema
            this.btnCerrarSistema = new Button();
            this.btnCerrarSistema.Dock = DockStyle.Right;
            this.btnCerrarSistema.Size = new Size(50, 30);
            this.btnCerrarSistema.Text = "X";
            this.btnCerrarSistema.ForeColor = Color.White;
            this.btnCerrarSistema.Click += new EventHandler(this.btnCerrarSistema_Click);

            // Adding controls to paneltitulo
            this.paneltitulo.Controls.Add(this.lbltitulo);
            this.paneltitulo.Controls.Add(this.btncerrarpanel);
            this.paneltitulo.Controls.Add(this.btnMinimizar);
            this.paneltitulo.Controls.Add(this.btnCerrarSistema);

            // lbltitulo
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.ForeColor = Color.White;
            this.lbltitulo.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new Point(
                (this.paneltitulo.Width - this.lbltitulo.PreferredSize.Width) + 122, // Center horizontally
                5); // Adjust vertical position as needed
            this.lbltitulo.Text = "INICIO";
            this.paneltitulo.Controls.Add(this.lbltitulo);


            // btncerrarpanel
            this.btncerrarpanel.Dock = DockStyle.Left;
            this.btncerrarpanel.Size = new Size(50, 30);
            this.btncerrarpanel.Text = "←";
            this.btncerrarpanel.ForeColor = Color.White;
            this.btncerrarpanel.Click += new EventHandler(this.btncerrarpanel_Click);


            this.btnMinimizar.FlatStyle = FlatStyle.Flat;
            this.btnCerrarSistema.FlatStyle = FlatStyle.Flat;
            this.btncerrarpanel.FlatStyle = FlatStyle.Flat;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnCerrarSistema.FlatAppearance.BorderSize = 0;
            this.btncerrarpanel.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSistema.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.btncerrarpanel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

            // paneltodo
            this.paneltodo.Dock = DockStyle.Fill;
            this.paneltodo.BackColor = Color.FromArgb(39, 41, 61);

            // MenuForm
            this.ClientSize = new Size(1024, 768);
            this.Controls.Add(this.paneltodo);
            this.Controls.Add(this.paneltitulo);
            this.Controls.Add(this.panelmenu);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paneltitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        // Previous code...

        // Dragging events
       

        private void paneltitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void paneltitulo_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private Button CreateMenuButton(string text, EventHandler onClick)
        {
            var button = new Button
            {
                Text = text,
                Dock = DockStyle.Top,
                Height = 60,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Gainsboro,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };
            button.FlatAppearance.BorderSize = 0;
            button.Click += onClick;
            return button;
        }

        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (CurrentButton != (Button)btnsender)
                {
                    dissablebutton();
                    Color color = SelectThemeColor();
                    CurrentButton = (Button)btnsender;
                    CurrentButton.BackColor = color;
                    CurrentButton.ForeColor = Color.White;
                    CurrentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    paneltitulo.BackColor = color;
                    //Panel logo background color adjustment (if any)
                    btncerrarpanel.Visible = true;
                }
            }
        }

        private void dissablebutton()
        {
            foreach (Control previousbtn in panelmenu.Controls)
            {
                if (previousbtn.GetType() == typeof(Button))
                {
                    previousbtn.BackColor = Color.FromArgb(30, 38, 70);
                    previousbtn.ForeColor = Color.Gainsboro;
                    previousbtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private Color SelectThemeColor()
        {
            // Example color list; replace with your own colors
            var colorList = new List<string> { "#3F51B5", "#009688", "#FF5722", "#607D8B", "#FF9800", "#9C27B0", "#2196F3", "#EA676C", "#E41A4A", "#5978BB", "#018790", "#0E3441", "#00B0AD", "#721D47", "#EA4833", "#EF937E", "#F37521", "#A12059", "#126881", "#8BC240" };
            int index = random.Next(colorList.Count);
            while (tempindex == index)
            {
                index = random.Next(colorList.Count);
            }
            tempindex = index;
            string color = colorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void OpenChildForm(Form childform, object btnsender)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            ActivateButton(btnsender);
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.paneltodo.Controls.Add(childform);
            this.paneltodo.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lbltitulo.Text = childform.Text;
        }

        private void btncerrarpanel_Click(object sender, EventArgs e)
        {
            if (activeform != null)
            {
                activeform.Close();
                Reset();
            }
        }

        private void Reset()
        {
            dissablebutton();
            lbltitulo.Text = "INICIO";
            paneltitulo.BackColor = Color.FromArgb(30, 38, 70);
            // Panel logo background color adjustment (if any)
            CurrentButton = null;
            btncerrarpanel.Visible = false;
        }

        // Event handlers for menu buttons
        private void btnclientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Clientes(), sender);
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new USUARIOS(), sender);
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventario(), sender);
        }

        private void btnrealizarventa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GMCRUD(), sender);
        }

        private void btnregistroventas_Click(object sender, EventArgs e)
        {
            // OpenChildForm(new RegistroVentasForm(), sender);
        }

        private void btnrealizarpedido_Click(object sender, EventArgs e)
        {
            //   OpenChildForm(new RealizarPedidoForm(), sender);
        }

        private void btnregistropedidos_Click(object sender, EventArgs e)
        {
            //  OpenChildForm(new RegistroPedidosForm(), sender);
        }
    }
}
