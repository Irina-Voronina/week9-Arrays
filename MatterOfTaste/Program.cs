using System;

namespace MatterOfTaste
{
    class Program
    {
        static void Main(string[] args)
        {
            //"О вкусах не спорят"
            //любимые цвета компьбтера - red, green, blue
            //компьтер просит ввести название любимого цвета пользователя
            //если введенный пользователем цвет совпадает с одним из любимых цветов компьютера,
            //компьютер выводит на экран "We are perfect together",
            //если любимый цветне пользователя не совпадает с предпочтениями компьютера, на экран
            //выводится фраза "Every man to his taste".


            Console.WriteLine("Matter of taste)");
            Console.WriteLine();
            Console.WriteLine("Enter your favorite color:");
            
            string userInput = Console.ReadLine().ToLower();
            string[] colors = {"red", "green", "blue"};


                if (userInput == "red" || userInput == "green" || userInput == "blue")
                {
                    Console.WriteLine($"I love {userInput} color!");
                    Console.WriteLine("We are perfect together!");
                }

                else
                {
                    Console.WriteLine($"Boo, I don't like {userInput} color!");
                    Console.WriteLine("Every man to his taste...");
                }

            Console.WriteLine();
            Console.WriteLine("Have a nice day!");
            

        }
        
        
    }
}
