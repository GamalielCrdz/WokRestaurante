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
    }
}
