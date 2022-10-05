using System;

namespace GoToStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Etitket
        step1:
            Console.WriteLine("Dogum Gununu Daxil Et");
            string dayStr = Console.ReadLine();
            int day;

            while (!int.TryParse(dayStr, out day) || day < 1 || day > 31)
            {
                Console.WriteLine("Duzgun Gun daxil Et");
                dayStr = Console.ReadLine();
            }

            Console.WriteLine("Ay-i Daxil Et:");
            string monthStr = Console.ReadLine();
            int month;
            while (!int.TryParse(monthStr, out month) || month < 1 || month > 12)
            {
                Console.WriteLine("Duzgun Ay daxil Et");
                monthStr = Console.ReadLine();
            }

            if (month == 2 && day >= 30)
            {
                Console.WriteLine("Ay ve Gun deyerlerini Duzgun Daxil Et");
                goto step1;
            }
            else
            {
                goto step2;
            }

            Console.WriteLine("ili Daixil Et");
            int year = int.Parse(Console.ReadLine());

        step2:
            Console.WriteLine("Step 2");
            //goto step3;
        }

        static void Test()
        {
            step3:
            Console.WriteLine("Step 3");

        }
    }
}
