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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Focus();
            textBox1.Copy();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
            textBox2.Focus();
            textBox2.Copy();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
            textBox3.Focus();
            textBox3.Copy();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.SelectAll();
            textBox4.Focus();
            textBox4.Copy();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.SelectAll();
            textBox5.Focus();
            textBox5.Copy();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox6.SelectAll();
            textBox6.Focus();
            textBox6.Copy();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox7.SelectAll();
            textBox7.Focus();
            textBox7.Copy();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox8.SelectAll();
            textBox8.Focus();
            textBox8.Copy();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox9.SelectAll();
            textBox9.Focus();
            textBox9.Copy();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox10.SelectAll();
            textBox10.Focus();
            textBox10.Copy();
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

        private void button16_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form4 fm = new Form4();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
