using System;

namespace FortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Печенье с предсказаниями"

            //"win a Jackpot"
            //"fall in love"
            //"get a love letter"
            //"miss the bus"
            //"see a unicorn in the street"

            //приложение показывает в консоли предсказание для пользователя,
            //выбранное случайным образом из приведенного выше списка

            Console.WriteLine("Fortune Cookies");
            Console.WriteLine();
            Console.WriteLine("If you want to know what awaits you tonight then press enter!");
            Console.ReadLine();

            string[] cookies = {"Win a Jackpot", "Fall in love", "Get a love letter", "Miss the bus", "See a unicorn in the street"};

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, cookies.Length);

            Console.WriteLine($"Prediction for tonight: {cookies[randomIndex]}");
            Console.WriteLine();

            Console.WriteLine($"If you want to know what awaits you tomorrow then press enter again!");
            Console.ReadLine();

            string[] cookie = { "Win a Jackpot", "Fall in love", "Get a love letter", "Miss the bus", "See a unicorn in the street" };
            int randIndex = rnd.Next(0, cookie.Length);

            Console.WriteLine($"Prediction for tomorrow: {cookie[randIndex]}");
            Console.WriteLine();
            Console.WriteLine("Don't worry, be happy! ;)");

        }
    }
}
