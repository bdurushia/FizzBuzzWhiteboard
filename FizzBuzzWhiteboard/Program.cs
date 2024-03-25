using System;

namespace FizzBuzzWhiteboard
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzer(200);
        }

        public static void FizzBuzzer(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i % 5 == 0 && i % 3 == 0 ? "FizzBuzz" : i % 5 == 0 ? "Buzz" : i % 3 == 0 ? "Fizz" : $"{i}");
            }
        } 
    }
}
