using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static double distance(double x1,double y1,double x2,double y2)
        {
            double result= Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result;
        }
        public static double perimeter(double a, double b, double c)
            {
               double result = a + b + c;
                    return result;
            }
        public static double area(double a, double b, double c, double P)
        {
            double p = P / 2;
            double result= Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return result;
        }
    static void Main(string[] args)
        {
            Double x1 = 0;
            Double x2 = 0;
            Double x3 = 0;
            Double y1 = 0;
            Double y2 = 0;
            Double y3 = 0;
            Double a;
            Double b;
            Double c;
            Double P;
            Double S;
            Console.Write("x1=");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2=");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x3=");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1=");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2=");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3=");
            y3 = Convert.ToDouble(Console.ReadLine());

            {
                double aSide = distance(x1, y1, y1, y2);
                double bSide = distance(x1, x3, y1, y3);
                double cSide = distance(x2, x3, y2, y3);
                double Perimeter = perimeter(aSide, bSide, cSide);
                Console.WriteLine("a:" + aSide);
                Console.WriteLine("b:" + bSide);
                Console.WriteLine("c:" + cSide);
                Console.WriteLine("P:" + Perimeter);
                double Square = area(aSide, bSide, cSide, Perimeter);
                Console.WriteLine("S:" + Square);
            }
            
        }

    }
}
