namespace Line_Comparision
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WEL - COME to Line Comparision ");

            Console.Write("Enter X1 Co-ordinate : ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter X2 Co-ordinate : ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Y1 Co-ordinate : ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Y2 Co-ordinate : ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            CalculateLCompare line = new CalculateLCompare(x1 , x2, y1, y2);
            line.CalculateLengthOfLine();
        }
    }
}