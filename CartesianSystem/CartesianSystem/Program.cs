using System;

namespace CartesianSystem
{
    class Program
    {
        //Constant variables
        public static int x1,y1,x2,y2;
        static void Main(string[] args)
        {
            //For loop to get two line values
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

                //Compute the Line length for end points (x1,x2) and (y1,y2)
                ComputeLenthFunctions obj = new ComputeLenthFunctions();
                obj.LineLength(x1, y1, x2, y2, i);

            }
            // Check whether two lines are same or not
            EqualsMethod obj1 = new EqualsMethod();
            obj1.ComputeEquals();

        }
    }
   
    public class ComputeLenthFunctions
    { 
        //Function to compute length
        public void LineLength(int x1 , int y1, int x2, int y2,int i)
        {
            //Formula to calculate a length
            double sqrt = Math.Sqrt( Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) );
            string val = Convert.ToString(Math.Round(sqrt, 2));

            //Printing value to the console
            Console.WriteLine("Line length of (x1,y1) and(x2,y2) is :  "+val);
            Console.WriteLine("\n");

            //Function call to push length values in an array
            GlobalData.PushData(val,i);
        }
    }

    public class EqualsMethod 
    {
        public void ComputeEquals()
        {
            //Check whether two line is equal using "Equals" method
            if (GlobalData.lineItems[0].Equals(GlobalData.lineItems[1])== true)
            {
                Console.WriteLine("Length of both (x1,y1)(x2,y2) and (x3,y3)(x4,y4) is same");

            }
            else
            {
                //Compare two line to check which is greater using "CompareTo" method
                Console.WriteLine("Length of both (x1,y1)(x2,y2) and (x3,y3)(x4,y4) is different \n");
                //Ternary operator
                string cmp =((GlobalData.lineItems[0]).CompareTo(GlobalData.lineItems[1])>0)? "Line 1 is greater than line 2": "Line 2 is greater than line 1";
                Console.WriteLine(cmp);

            }
        }
    }

    public static class GlobalData
    {
        //Array to store value of lines
        public static string[] lineItems = new string[2];
        public static void PushData(string val, int ind)
        {
            //Inserting value to the array
            lineItems[ind] = val;
        }
    }

}
