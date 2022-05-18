using System;

namespace LoopingThroughTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apples", "bananas", "oranges", "pears", "plums", "pine-apple" };
            //fruits.Lehgth = 5
            //the index of the last element = array.Length - 1

            //fruits[6] = "kiwi"; - так не работает

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);

            }

            Console.WriteLine();
            //заменить апельсины (oranges) на мандарины (tangerines), не зная индекса апельсина
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == "oranges")
                {
                    fruits[i] = "tangerines";
                }
            }

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);

            }
        }
    }
}
