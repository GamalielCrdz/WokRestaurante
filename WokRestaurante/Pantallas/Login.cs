using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WokRestaurante.Pantallas
{
    public partial class Login : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(this.textBoxName.Text == "") || !(this.textBoxPassword.Text == ""))
            {
                if(this.textBoxName.Text.Equals("admin") && this.textBoxPassword.Text.Equals("admin"))
                {
                    Form1 ordenes = new Form1();
                    ordenes.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("La contrasena o el usuario no son correctos");
                }
            }
            else
            {
                MessageBox.Show("Favor de llenar los campos");
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
