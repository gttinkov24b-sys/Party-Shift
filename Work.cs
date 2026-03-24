using System;
using System.Collections.Generic;
using System.Threading;

namespace Party_Shift
{
    internal class Work
    {
        static int money;

        static int Casier()
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- BILLING & RETURNS: REGISTER #1 ---");
            Console.ResetColor();
            Console.WriteLine("The customer hands you a large bill ($150 over the total).");
            Console.WriteLine("Goal: Calculate the change correctly or they'll call the manager.");
            Console.WriteLine("Math: [Customer's Cash] - [Bill Amount] = [Your Answer]");
            Console.WriteLine("-------------------------------------------------------");
            Thread.Sleep(5250);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Let's see how you do...");
            Thread.Sleep(2100);
            Console.ResetColor();
            Console.Clear();

            for (int i = 0; i < 5; i++)
            {
                Random rng = new Random();
                int bill = rng.Next(10, 150);
                int cash_given = bill + 150;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[ REGISTER #1 ]");
                Console.ResetColor();
                Console.WriteLine($"The Bill is: ${bill}");
                Console.WriteLine($"Customer gave you: ${cash_given}");
                Console.Write("How much change do you give back: ");

                int input;
                int.TryParse(Console.ReadLine(), out input);

                if (input == (cash_given - bill))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct! $$$");
                    money += 100;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong! The drawer is short!");
                    money -= 25;
                }
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();
            }
            return money;
        }

        static int Data()
        {
            int money = 0;
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("--- CENTRAL DATA PROCESSING: STATION #402 ---");
            Console.ResetColor();
            Console.WriteLine("Goal: Type the security codes exactly as they appear.");
            Console.WriteLine("One typo means a pay cut. Precision is key.");
            Console.WriteLine("-----------------------------------------------------------");
            Thread.Sleep(5250);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("System Online...");
            Thread.Sleep(2100);
            Console.ResetColor();
            Console.Clear();

            Random rng = new Random();
            for (int i = 0; i < 5; i++)
            {
                string code = "NX-" + rng.Next(100, 999);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($">> UPLOADING DATA...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"ENTER CODE: {code}");
                Console.ResetColor();
                Console.Write("Type here: ");
                string input = Console.ReadLine().ToUpper();

                if (input == code)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Data Logged Successfully.");
                    money += 100;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ACCESS DENIED! System Breach.");
                    money -= 25;
                }
                Console.ResetColor();
                Thread.Sleep(1000);
                Console.Clear();
            }
            return money;
        }

        static int Tutor()
        {
            int money = 0;
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- THE AFTER-SCHOOL LEARNING CENTER ---");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A student needs help with their addition homework.");
            Console.WriteLine("Help them solve 5 problems correctly.");
            Console.ResetColor();
            Console.WriteLine("-----------------------------------------------------------");
            Thread.Sleep(5250);
            Console.Clear();

            Random rng = new Random();
            for (int i = 0; i < 5; i++)
            {
                int num1 = rng.Next(1, 50);
                int num2 = rng.Next(1, 50);
                int answer = num1 + num2;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[ HOMEWORK HELP ]");
                Console.ResetColor();
                Console.Write($"Question: {num1} + {num2} = ");

                int input;
                bool isValid = int.TryParse(Console.ReadLine(), out input);

                if (isValid && input == answer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The student understands! Great job teacher!");
                    money += 100;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong. The student is confused. Answer was {answer}.");
                    money -= 25;
                }
                Console.ResetColor();
                Thread.Sleep(1680);
                Console.Clear();
            }
            return money;
        }

        static int Warehouse()
        {
            int money = 0;
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("--- GROCERY CHECKOUT: BAGGING STATION ---");
            Console.ResetColor();
            Console.WriteLine("Sort the items! Type 'F' for Fragile or 'H' for Heavy.");
            Console.WriteLine("Don't squash the bread!");
            Console.WriteLine("-----------------------------------------------------------");
            Thread.Sleep(5250);
            Console.Clear();

            string[] items = { "EGGS (F)", "CANNED SOUP (H)", "BREAD (F)", "WATERMELON (H)" };
            Random rng = new Random();
            for (int i = 0; i < 5; i++)
            {
                string currentItem = items[rng.Next(items.Length)];
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"ITEM ON CONVEYOR: {currentItem}");
                Console.ResetColor();
                Console.Write("Bag it as (F) or (H)?: ");
                string input = Console.ReadLine().ToUpper();

                if (currentItem.Contains($"({input})") && (input == "F" || input == "H"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Perfectly packed!");
                    money += 100;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("CRUNCH! You broke it.");
                    money -= 25;
                }
                Console.ResetColor();
                Thread.Sleep(1680);
                Console.Clear();
            }
            return money;
        }

        static int Barista()
        {
            int money = 0;
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("--- THE MORNING BREW: COFFEE BAR ---");
            Console.ResetColor();
            Console.WriteLine("Goal: Remember the quantity and the drink.");
            Console.WriteLine("Example: '2 LATTES'. You must type it exactly!");
            Console.WriteLine("-----------------------------------------------------------");
            Thread.Sleep(5250);
            Console.Clear();

            string[] drinks = { "LATTES", "MOCHAS", "ESPRESSOS", "COFFEES" };
            Random rng = new Random();

            for (int i = 0; i < 5; i++)
            {
                int amount = rng.Next(1, 3);
                string drink = drinks[rng.Next(drinks.Length)];
                string fullOrder = $"{amount} {drink}";

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"CUSTOMER #{i + 1} / 5");
                Console.WriteLine("----------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Order: \"Can I get {fullOrder}, please?\"");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("----------------------------");
                Console.ResetColor();

                Thread.Sleep(3150);
                Console.Clear();

                Console.Write("Type the order to serve: ");
                string input = Console.ReadLine().ToUpper();

                if (input == fullOrder)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n>> ORDER READY! Customer tipped $100.");
                    money += 100;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n>> WRONG ORDER! (They wanted {fullOrder})");
                    money -= 25;
                }
                Console.ResetColor();
                Thread.Sleep(2100);
                Console.Clear();
            }
            return money;
        }

        public int SelectJob(string w)
        {
            switch (w.ToLower())
            {
                case "cashier": money = Casier(); break;
                case "math tutor": money = Tutor(); break;
                case "data verifier": money = Data(); break;
                case "coffee barista": money = Barista(); break;
                case "warehouse worker": money = Warehouse(); break;
            }
            return money;
        }
    }
}