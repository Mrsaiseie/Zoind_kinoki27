namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form2 fm = new Form2();
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form3 fm = new Form3();
            fm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form6 fm = new Form6();
            fm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form7 fm = new Form7();
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
