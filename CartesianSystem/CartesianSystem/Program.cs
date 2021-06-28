using System;

namespace CartesianSystem
{
    class Program
    {
        //Constant variables
        public static int x1,y1,x2,y2;
        static void Main(string[] args)
        {   
            // Get Coordinates "X" and "Y" from the user
            Console.WriteLine("Enter value for coordinate \"x1\" ");
            x1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for coordinate \"y1\" ");
            y1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for coordinate \"x2\" ");
            x2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for coordinate \"y2\" ");
            y2 = Int32.Parse(Console.ReadLine());

            ComputeLenthFunctions.LineLength(x1, y1,x2,y2);

        }
    }
    static class ComputeLenthFunctions
    { 
        public static void LineLength(int x1 , int y1, int x2, int y2)
        {
            double sqrt = Math.Sqrt( Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) );
            Console.WriteLine(Math.Round(sqrt,2));
        }
    }

}
