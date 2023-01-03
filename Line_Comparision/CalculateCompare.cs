using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    public class CalculateCompare
    {
        public int X1, X2, Y1, Y2;
        public CalculateCompare(int x1, int x2, int y1, int y2)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
        }
        public static CalculateCompare UserInputForLine1()
        {
            Console.WriteLine("Enter 1st Line Co-Ordinates");
            Console.Write("Enter X1 Co-ordinate : ");
            int xx1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter X2 Co-ordinate : ");
            int xx2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Y1 Co-ordinate : ");
            int yy1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Y2 Co-ordinate : ");
            int yy2 = Convert.ToInt32(Console.ReadLine());

            return new CalculateCompare(xx1, xx2, yy1, yy2)
            {
                X1 = xx1,
                X2 = xx2,
                Y1 = yy1,
                Y2 = yy2
            };
        }
        public static CalculateCompare UserInputForLine2()
        {
            Console.WriteLine("Enter 2nd Line Co-Ordinates");
            Console.Write("Enter X1 Co-ordinate : ");
            int xl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter X2 Co-ordinate : ");
            int xl2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Y1 Co-ordinate : ");
            int yl1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Y2 Co-ordinate : ");
            int yl2 = Convert.ToInt32(Console.ReadLine());

            return new CalculateCompare(xl1, xl2, yl1, yl2)
            {
                X1 = xl1,
                X2 = xl2,
                Y1 = yl1,
                Y2 = yl2
            };
        }
        public double CalculateLengthOfLine()
        {
            Console.WriteLine("Co-ordinates of Line are \nX1 = " + X1 + "\nX2 = " + X2 + "\nY1 = " + Y1 + "\nY2 = " + Y2);
            double LengthOfLine = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Length of Line of given 4 Co-ordinates is : " + Math.Round(LengthOfLine, 5));
            return LengthOfLine;
        }
    }
}
