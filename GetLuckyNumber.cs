using System;

namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int result = GetLuckyNumber(13);
            Console.WriteLine("Lucky number for the number 13 is: "+result);
            Console.ReadKey();
        }

        public static int GetLuckyNumber(int n)
        {
            var count = 0;
            for (var i = 1; i <= n; i++)
            {
                count += CheckForNumberByPosition(i);
            }

            return count;
        }

        public static int CheckForNumberByPosition(int num)
        {
            if (num.ToString().Contains("13") || num.ToString().Contains("4"))
            {
                return 2;
            }
            return 1;
        }

    }
}
