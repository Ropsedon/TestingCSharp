using System;

namespace YouTube
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Whrite your number");
            string text = Console.ReadLine();
            int x = Convert.ToInt32(text);

            switch (x)
            {
                case 1:
                    Console.WriteLine("first one");
                    break;
                case 2:
                    Console.WriteLine("second one");
                    break;
                case 3:
                    Console.WriteLine("third one");
                    break;
                case 4:
                    Console.WriteLine("fourth one");
                    break;
                case 5:
                    Console.WriteLine("fifth one");
                    break;
                case 6:
                    Console.WriteLine("sixth one");
                    break;
                default:
                    Console.WriteLine("fin");
                    break;
            }

            Console.WriteLine("all");
            Console.ReadKey();
        }
    }
}
