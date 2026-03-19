using Microsoft.VisualBasic.FileIO;
using System.Drawing;

namespace Party_Shift
{
    public class master
    {
        public static void CenterText(string text)
        {
            int windowWidth = Console.WindowWidth;
            int textLength = text.Length;
            int spaces = Math.Max(0, (windowWidth - textLength) / 2);
            Console.WriteLine(new string(' ', spaces) + text);
        }
        static string SelectJob()
        {
            Random rnd = new Random();
            string job = "";
            switch (rnd.Next(1, 6))
            {
                
                case 1:
                    job = "cashier";
                    break;
                case 2:
                    job = "math tutor";
                    break;
                case 3:
                    job = "data verifier";
                    break;
                case 4:
                    job = "coffee barista";
                    break;
                case 5:
                    job = "warehouse worker";
                    break;
            }
            return job;
        }
        static void ThreeDots()
        {
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(675);
                Console.Write(".");
            }
        }
        static void Main(string[] args)
        {

            Console.Title = "Shift to Party";
            main_parts.TitleScR();

            Console.ForegroundColor = ConsoleColor.Blue;
            CenterText("==============================================================================================");
            CenterText("                                   [ PRESS ANY KEY TO BEGIN ]                                 ");
            CenterText("==============================================================================================");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            main_parts.TitleScR();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            CenterText("==============================================================================================");
            CenterText(@"                                 \/ !Give your name please! \/                                ");
            Console.Write(new string(' ', ((Console.WindowWidth / 2) - 2)));
            string name = Console.ReadLine();
            CenterText("==============================================================================================");
            Console.Clear();

            //Wake up and greet the user, also go to work
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Guten Morgen, I mean Good Morning {name}! Welcome to your TOTALY normal day");
            Thread.Sleep(2250);
            Console.Write("You wake up and get ready for work");
            ThreeDots();
            Thread.Sleep(1000);


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You work as a: {SelectJob()}!");
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write($"I bet you enjoy it");
            ThreeDots();
            Thread.Sleep(2000);
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Just go to your job!");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Everyone knows nobody enjoys working");
            ThreeDots();
            Console.ResetColor();
            Console.Clear();

        }
    }
}
