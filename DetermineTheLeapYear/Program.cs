using System;

namespace DetermineTheLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите год для определения високосности:");
                var input = int.Parse(Console.ReadLine());
                DetermineTheLeapYear(input);

                Console.WriteLine();

                Console.WriteLine("Enter - продолжить");
                Console.WriteLine("/exit - выйти");
                var str = Console.ReadLine();

                if (str == "/exit")
                {
                    break;
                }

                Console.Clear();
            }
        }

        static int DetermineTheLeapYear(int year)
        {
            if(year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        Console.WriteLine("Год високосный (366 дней). День программста 12 сентября.");
                    }
                    else
                    {
                        Console.WriteLine("Год не високосный год (365 дней). День программста 13 сентября.");
                    }
                }
                else
                {
                    Console.WriteLine("Год високосный (366 дней). День программста 12 сентября.");
                }
            }
            else
            {
                Console.WriteLine("Год не високосный год (365 дней). День программста 13 сентября.");
            }
            return year;
        }
    }
}
