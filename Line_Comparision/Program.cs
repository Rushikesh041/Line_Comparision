namespace Line_Comparision
{
    public class Program
    {
        static void Main(string[] args)
        {
            var obj = CalculateCompare.UserInputForLine1();
            CalculateCompare line = new CalculateCompare(obj.X1, obj.X2, obj.Y1, obj.Y2);
            double length1 = line.CalculateLengthOfLine();

            var obj1 = CalculateCompare.UserInputForLine2();
            CalculateCompare line1 = new CalculateCompare(obj1.X1, obj1.X2, obj1.Y1, obj1.Y2);
            double length2 = line1.CalculateLengthOfLine();

            if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("Length of Line 1 is Greater than Length of Line 2");
            }
            else if (length1.CompareTo(length2) < 0)
            {
                Console.WriteLine("Length of Line 1 is smaller than Length of Line 2");
            }
            else if(length1.Equals(length2) == true)
            {
                Console.WriteLine("Length of Two Lines are Same");
            }
            else
            {
                Console.WriteLine("Enter Valid Co-Ordinates");
            }

        }
    }
}