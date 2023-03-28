using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void manUsuario_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = textBox1.Text;
            string nombre = textBox2.Text;
            string telefono = textBox3.Text;
            string direccion = textBox4.Text;
            string email = textBox5.Text;
            string apellido = textBox6.Text;
            string fecha = dateTimePicker1.Value.ToShortDateString();

            dataGridView1.Rows.Add(dni, nombre, telefono, direccion, email, apellido, fecha);
        }
    }
}
