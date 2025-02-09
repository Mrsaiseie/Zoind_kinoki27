using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form4 fm = new Form4();
            fm.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox11.SelectAll();
            textBox11.Focus();
            textBox11.Copy();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox12.SelectAll();
            textBox12.Focus();
            textBox12.Copy();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Focus();
            textBox1.Copy();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
            textBox2.Focus();
            textBox2.Copy();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.SelectAll();
            textBox3.Focus();
            textBox3.Copy();
        }
    }
}
