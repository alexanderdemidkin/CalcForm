using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static app2.Simple_calc_UI;

namespace app2
{
    public partial class KvUrCalc : Form
    {
        public int num_a = 1;
        public int num_b = 1;
        public int num_c = 1;

       



        public KvUrCalc()
        {
            InitializeComponent();
        }

      

        public static int Disc(int a,int b,int c )
        {
           int d;
            d = Convert.ToInt32(Math.Pow(b, 2)) - 4 * a * c;
            return d; 
            
        }
        public static double Res(int a, int b, int d,int p)
        {
            double res;
            if (p == 1) 
            {
                res = (Convert.ToDouble(-b) + Math.Sqrt(d)) / Convert.ToDouble(2 * a);
            }
            else if (p == 2)
            {
                res = (Convert.ToDouble(-b) - Math.Sqrt(d)) / Convert.ToDouble(2 * a);
            }
            else
            {
                res = 0;
            }
           
            return res  ;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            StrUr(num_a, num_b, num_c);
        }
        public void StrUr(int a,int b,int c)
        {
            textBox4.Text = a + "X^2 + " + b + "x + " + c + "= 0";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string st1 = textBox5.Text;
            num_a = Convert.ToInt32(Vvod_UI(st1));
            StrUr(num_a, num_b, num_c);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string st1 = textBox7.Text;
            num_b = Convert.ToInt32(Vvod_UI(st1));
            StrUr(num_a, num_b, num_c);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string st1 = textBox6.Text;
            num_c = Convert.ToInt32(Vvod_UI(st1));
            StrUr(num_a, num_b, num_c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d = Disc(num_a,num_b,num_c);
            textBox3.Text = Convert.ToString(d);
            double x1 = Res(num_a, num_b, d, 1);
            textBox1.Text = Convert.ToString(x1);
            double x2 = Res(num_a, num_b, d, 2);
            textBox2.Text = Convert.ToString(x2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
