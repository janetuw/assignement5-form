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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void calculator(object sender, EventArgs e)
        {
            work.Controls.Clear();
            Form2 simple = new Form2();
            simple.TopLevel = false;
            work.Controls.Add(simple);
            simple.Show();
        }

        private void number(object sender, EventArgs e)
        {
            work.Controls.Clear();
            Form3 simple = new Form3();
            simple.TopLevel = false;
            work.Controls.Add(simple);
            simple.Show();
        }
    }
}
