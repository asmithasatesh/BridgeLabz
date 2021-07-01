using System;

namespace CartesianSystem
{
    class Program
    {
        //Constant variables
        public static int x1,y1,x2,y2;
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
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

                ComputeLenthFunctions obj = new ComputeLenthFunctions();
                obj.LineLength(x1, y1, x2, y2, i);

            }
            EqualsMethod obj1 = new EqualsMethod();
            obj1.ComputeEquals();

        }
    }
    public class ComputeLenthFunctions
    { 
        public void LineLength(int x1 , int y1, int x2, int y2,int i)
        {
            double sqrt = Math.Sqrt( Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) );
            string val = Convert.ToString(Math.Round(sqrt, 2));
            Console.WriteLine("Line length of (x1,y1) and(x2,y2) is :  "+val);
            GlobalData.PushData(val,i);
        }
    }

    public class EqualsMethod 
    {
        public void ComputeEquals()
        {
            if (GlobalData.lineItems[0].Equals(GlobalData.lineItems[1])== true)
            {
                Console.WriteLine("Length of both (x1,y1) and (x2,y2) is same");

            }
            else
            {
                Console.WriteLine("Length of both is different");
            }
        }
    }

    public static class GlobalData
    {
        public static string[] lineItems = new string[2];
        public static void PushData(string val, int ind)
        {
            lineItems[ind] = val;
        }
    }

}
