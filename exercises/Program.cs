using System;

namespace exercises
{
    class Program
    {
        static void Main()
        {
            double number = 3.14;
            double Enumb = 2.7;
            Console.WriteLine("S1.1. " + number);


            Console.WriteLine("S1.2. " + Enumb);


            Console.WriteLine("S1.3. Введите число: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели  число " + input);


            Console.WriteLine("S1.4. Введите число: ");
            int alsoInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(alsoInput + " - вот какое число вы ввели");


            Console.WriteLine("S1.5. " + 1 + " " + 13 + " " + 49);


            Console.WriteLine("S1.6. " + 7 + "  " + 15 + "  " + 100);


            Random randomFirst = new Random();
            Random randomSecond = new Random();
            Random randomThird = new Random();
            Random randomFourth = new Random();
            Console.WriteLine("S1.7. " + randomFirst.Next(100) + "  " + randomSecond.Next(100) + "  " + randomThird.Next(100));


            Console.WriteLine("S1.8. " + randomFirst.Next(100) + " " + randomSecond.Next(100) + " " + randomThird.Next(100) + " " + randomFourth.Next(100));


            Console.WriteLine("S1.9. " + 50 + "\n" + 100);


            Console.WriteLine("S1.10. " + 5 + "\n" + 10 + "\n" + 21);
        }
    }
}