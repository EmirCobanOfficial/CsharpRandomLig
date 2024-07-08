namespace CsharpRandomLig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" && textBox2.Text == "2")
            {
                Form2 oyun = new Form2();
                oyun.Show();
                this.Hide();
            }
        }
    }
}
