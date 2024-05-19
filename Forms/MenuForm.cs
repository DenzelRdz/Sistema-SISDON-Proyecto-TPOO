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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btncerrarpanel = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrarSistema = new System.Windows.Forms.Button();
            this.paneltodo = new System.Windows.Forms.Panel();
            this.paneltitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(220, 768);
            this.panelmenu.TabIndex = 2;
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.paneltitulo.Controls.Add(this.lbltitulo);
            this.paneltitulo.Controls.Add(this.btncerrarpanel);
            this.paneltitulo.Controls.Add(this.btnMinimizar);
            this.paneltitulo.Controls.Add(this.btnCerrarSistema);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(220, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(804, 50);
            this.paneltitulo.TabIndex = 1;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(220, 5);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(104, 37);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "INICIO";
            // 
            // btncerrarpanel
            // 
            this.btncerrarpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btncerrarpanel.FlatAppearance.BorderSize = 0;
            this.btncerrarpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrarpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrarpanel.ForeColor = System.Drawing.Color.White;
            this.btncerrarpanel.Location = new System.Drawing.Point(0, 0);
            this.btncerrarpanel.Name = "btncerrarpanel";
            this.btncerrarpanel.Size = new System.Drawing.Size(50, 50);
            this.btncerrarpanel.TabIndex = 1;
            this.btncerrarpanel.Text = "←";
            this.btncerrarpanel.Click += new System.EventHandler(this.btncerrarpanel_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(704, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(50, 50);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrarSistema
            // 
            this.btnCerrarSistema.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarSistema.FlatAppearance.BorderSize = 0;
            this.btnCerrarSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSistema.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSistema.Location = new System.Drawing.Point(754, 0);
            this.btnCerrarSistema.Name = "btnCerrarSistema";
            this.btnCerrarSistema.Size = new System.Drawing.Size(50, 50);
            this.btnCerrarSistema.TabIndex = 3;
            this.btnCerrarSistema.Text = "X";
            this.btnCerrarSistema.Click += new System.EventHandler(this.btnCerrarSistema_Click);
            // 
            // paneltodo
            // 
            this.paneltodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.paneltodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltodo.Location = new System.Drawing.Point(220, 50);
            this.paneltodo.Name = "paneltodo";
            this.paneltodo.Size = new System.Drawing.Size(804, 718);
            this.paneltodo.TabIndex = 0;
            // 
            // MenuForm
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.paneltodo);
            this.Controls.Add(this.paneltitulo);
            this.Controls.Add(this.panelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
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
        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            //  OpenChildForm(new CerrarSesionForm(), sender);
        }
    }
}
