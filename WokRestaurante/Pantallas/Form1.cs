using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokRestaurante.Pantallas;

namespace WokRestaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prueba1DataSet.Prueba' table. You can move, or remove it, as needed.
            this.pruebaTableAdapter.Fill(this.prueba1DataSet.Prueba);

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
    }
}
