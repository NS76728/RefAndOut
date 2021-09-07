using System;

namespace RefandOut
{
    class Program
    {
        //TODO impliment this ref method by returning a bool and subtracting from the parameter.
        //So it will have two outputs. the bool of true if health is > 0. and also set x to decrease by 1.
        //TODO Call the method in the main and make sure the method changes the number of a initialized variable and returns a bool.
        public static bool SubtractHealth(ref int x)
        {
            int health = 100;
            bool T=false;
            if (health>0)
            {
                T = true;
                x--;
            }
            return T;

      
        }

        //TODO create method that uses the out keyword. Call the method in the main.
        

        public static int Sum(int x, int y, out  bool even)
        {
            int sum = x + y;
            if (sum % 2 == 0)
                even = true;
            else
                even = false;

            return sum;
        }


        static void Main(string[] args)
        {

            int x = 25;
            Console.WriteLine(SubtractHealth(ref x));
            Console.WriteLine("----------------------------------");
            bool even;
            Console.WriteLine(Sum(27,54, out even));
    
        }

    }
}
