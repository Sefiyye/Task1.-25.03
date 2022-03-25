using System;

namespace Task_25._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Number is Odd?: " + IsOdd(num));
            Console.WriteLine("Number is Even?: " + IsEven(num));
        }
        public static bool IsEven(int numbe)
        {
            bool check = false;
            if (numbe % 2 == 0)
            {
                check = true;
            }
            return check;
        }
        public static bool IsOdd(int number)
        {
            bool TrueOrFalse = false;

            if (number % 2 != 0)
            {
                TrueOrFalse= true;
            }
            return TrueOrFalse;
        }
    }
}
