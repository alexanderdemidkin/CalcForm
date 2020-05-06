
namespace app2
{
    class Simple_calc_Math
    {
        public static double Plus_Op(double a, double b)
        {
            double c;
            c = a + b;
            return c;
        }

        public static double Minus_Op(double a, double b)
        {
            double c;
            c = a - b;
            return c;
        }

        public static double Multi_Op(double a, double b)
        {
            double c;
            c = a * b;
            return c;
        }

        public static double Del_Op(double a, double b)
        {
            double c;
            c = a / b;
            return c;
        }

        public static double Ost_Op(double a, double b)
        {
            double c;
            c = a % b;
            return c;
        }

        public static double Perc_Op(double a, double b)
        {
            double c;
            c = b / 100 * a;
            return c;
        }
    }
}
