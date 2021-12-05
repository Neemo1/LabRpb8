using System;

namespace LabRob9
{
    class Program
    {
        class Calculation
        {

            public void Point(double[] m)
            {

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Введите точки\n" + i + "-точка: ");
                    string buf;
                    buf = Console.ReadLine();
                    m[i] = Convert.ToDouble(buf);
                }
            }
            public double longSides(double[] m1, double[] m2)
            {
                double Ls;
                Ls = Math.Sqrt(Math.Pow(m1[0] - m2[0], 2) + Math.Pow(m1[1] - m2[1], 2));
                return Ls;
            }
            public double Per(double a, double b, double c)
            {
                double P = a + b + c;
                return P;
            }
            public double MAX(double a, double b, double c)
            {
                double max = 0;
                if (a > b && a > c)
                {

                    max = a;
                    Console.WriteLine("У ABC");
                }
                if (b > a && b > c)
                {

                    max = b;
                    Console.WriteLine("У ABD");
                }
                if (c > a && c > b)
                {

                    max = c;
                    Console.WriteLine("У ACD");
                }
                return max;
            }
        }
        static void Main(string[] args)
        {
            double[] A = new double[2];
            double[] B = new double[2];
            double[] C = new double[2];
            double[] D = new double[2];
            Calculation calculation = new Calculation();
            calculation.Point(A);
            calculation.Point(B);
            calculation.Point(C);
            calculation.Point(D);
            Console.WriteLine("Точка А(" + A[0] + "; " + A[1] + ")");
            Console.WriteLine("Точка B(" + B[0] + "; " + B[1] + ")");
            Console.WriteLine("Точка C(" + C[0] + "; " + C[1] + ")");
            Console.WriteLine("Точка D(" + D[0] + "; " + D[1] + ")");

            double AB, BD, BC, CD, AC, AD;
            AB = calculation.longSides(A, B);
            BD = calculation.longSides(B, D);
            BC = calculation.longSides(B, C);
            CD = calculation.longSides(C, D);
            AC = calculation.longSides(A, C);
            AD = calculation.longSides(A, D);

            double ABC, ABD, ACD;
            Console.WriteLine("P(ABC) = {0}", ABC = calculation.Per(AB, BC, AC));
            Console.WriteLine("P(ABD) = {0}", ABD = calculation.Per(AB, BD, AD));
            Console.WriteLine("P(ACD) = {0}", ACD = calculation.Per(AC, CD, AD));

            Console.WriteLine("Найбольший периметр " + calculation.MAX(ABC, ABD, ACD));
        }

    }
}