using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(textBox1.Text);
            var num2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (num1 + num2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(textBox1.Text);
            var num2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (num1 - num2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(textBox1.Text);
            var num2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (num1 * num2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(textBox1.Text);
            var num2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (num1 / num2).ToString();
        }
    }
}
