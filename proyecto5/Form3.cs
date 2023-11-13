using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace proyecto5
{
    public partial class Form3 : Form
    {
        conexionsqln cn = new conexionsqln();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.consultadt();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.insertarusuario(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            dataGridView1.DataSource = cn.consultadt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.modificarusuario(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            dataGridView1.DataSource = cn.consultadt();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.eliminarusuario(textBox3.Text);
            dataGridView1.DataSource = cn.consultadt();

        }
    }
}
