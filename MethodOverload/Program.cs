using System;
using System.Linq;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Add(1,1,1,1,1));
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool check)
        {
            int sum = num1 + num2;
            if (check == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (check == true && sum <= 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return "Your bool is false!";
            }

        }

        // This method will allow you to input as many arguments as you want. It stores these args in an array.
        public static int Add(params int[] array)
        {
            return array.Sum();
        }

    }
}

