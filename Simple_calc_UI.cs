using System;
using System.Windows.Forms;
using static app2.Simple_calc_Math;
namespace app2
{
    public class Simple_calc_UI
    {



        public static double Vvod_UI(string st1)
        {
            double res;
            bool isDob = double.TryParse(st1, out res);
            if (isDob == true)
            {
                res = Convert.ToDouble(st1);
            }
            else
            {
                res = 0;
                MessageBox.Show("Вы ввели не число будет использован 0");
            }
            return res;
        }


        public static string Op(int a, double c1, double c2)
        {
            string result = "результат";
            if (a == 1)
            {
                double c = Plus_Op(c1, c2);
                result = c1 + " плюс " + c2 + " равно " + c;
            }
            else if (a == 2)
            {
                double c = Minus_Op(c1, c2);
                result = c1 + " минус " + c2 + " равно " + c;
            }
            else if (a == 3)
            {
                double c = Multi_Op(c1, c2);
                result = c1 + " умножить " + c2 + " равно " + c;
            }
            else if (a == 4)
            {
                double c = Del_Op(c1, c2);
                result = c1 + " разделить " + c2 + " равно " + c;
            }
            else if (a == 5)
            {
                double c = Ost_Op(c1, c2);
                result = "остаток от деления " + c1 + " на " + c2 + " равен " + c;
            }
            else if (a == 6)
            {
                double c = Perc_Op(c1, c2);
                result = c1 + " процентов от " + c2 + " равно " + c;
            }
            else
            {
                MessageBox.Show(" Введен неверный параметр");
            }

            return result;
        }


    }
}