using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer1 = Add(2, 2);
            var answer2 = Add(2466m, .2145m);
            var answer3 = Add(10, 20, true);

            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool c)
        {
            string message = "";
            int result;
            result = a + b;

            if (c == true)
            {
                

                if (result == 1)
                    message = $"{result} dollar";
                else
                    message = $"{result} dollars";

                return message;
            }
            else
                return $"{result}";

        }
    }
}
