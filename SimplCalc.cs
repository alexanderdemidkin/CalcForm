using System;
using System.Windows.Forms;
using static app2.Simple_calc_UI;

namespace app2
{
    public partial class SimplCalc : Form
    {
        public double Number1 = 0;
        public double Number2 = 0;
        public SimplCalc()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Op(1, Number1, Number2);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Op(2, Number1, Number2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Op(3, Number1, Number2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Op(4, Number1, Number2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Op(5, Number1, Number2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Op(6, Number1, Number2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            Number1 =  Vvod_UI(str);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string str = textBox2.Text;
            Number2 = Vvod_UI(str);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
