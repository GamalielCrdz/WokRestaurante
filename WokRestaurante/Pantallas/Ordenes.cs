using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokRestaurante.Conexions;
using WokRestaurante.Pantallas;

namespace WokRestaurante
{
    public partial class Form1 : Form
    {
        OrdenConexion ordenConexion = new OrdenConexion();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = ordenConexion.getOrdenFromDb();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.dataLabel.Text = "Fecha:" + DateTime.Now.ToShortDateString();
            this.hourLabel.Text = "Hora: " + DateTime.Now.ToLongTimeString();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Detalles detalles = new Detalles();
            detalles.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
