using System;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = Add(5, 5, true);
            Console.WriteLine(answer);
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

    }
}

