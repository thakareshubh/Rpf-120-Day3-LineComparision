using System;

namespace Uc_2_CheckEqualityOfTwoLine
{
    internal class Program
    {
        //variables
        double length_Of_Line1;
        double length_Of_Line2;
       
        //method for calculation and comparision
        public void Calc(double x1,double y1,double x2,double y2,double x3,double y3,double x4,double y4)
        {
            double X=Math.Pow(x2 - x1, 2.0);
            double Y = Math.Pow(y2 - y1, 2.0);
            double A = Math.Pow(x4 - x3, 2);
            double B = Math.Pow(y4 - y3, 2);
            length_Of_Line1=Math.Sqrt(X+Y);
            length_Of_Line2=Math.Sqrt(A+B);
            if (length_Of_Line1==length_Of_Line2)
            {
                Console.WriteLine("lenghth of both line are equal");

            }
            else
            {
                Console.WriteLine("lenghth of line are not equal");
            }
        }
        public static void Main(String[] args)
        {   
            Program p=new Program();
            Console.WriteLine("enter x1,y1,x2,y2,x3.y3,x4,y4 values\n");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());
            double g = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            p.Calc(a, b, c, d,e,f,g,h);
           
        }
    }
}
