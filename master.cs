using Microsoft.VisualBasic.FileIO;
using System.Drawing;

namespace Party_Shift
{
    public class master
    {
        static bool ParkPolice()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--- PARK PATROL: 02:00 AM ---");
            Console.ResetColor();
            Console.WriteLine("A flashlight hits your eyes. The law is here.");
            Console.WriteLine("Officer: 'Halt! You're stumbling through the grass.'");
            Console.WriteLine("-----------------------------------------------------------");
            Thread.Sleep(2500);
            Console.Clear();

            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"INTERROGATION PROGRESS: {i} / 5");
                Console.WriteLine("-----------------------------------");

                string correct = "";

                if (i == 1)
                {
                    Console.WriteLine("Officer: 'How much have you had to drink tonight?'");
                    Console.WriteLine("1. Just a soda... *Burp* \n2. Nothing, Officer. \n3. *SSHA-OESJ* \n4. *Ghulp*");
                    correct = "2";
                }
                else if (i == 2)
                {
                    Console.WriteLine("Officer: 'You look lost. Where are you headed?'");
                    Console.WriteLine("1. To the moon! \n2. My house is... that way? \n3. Just around the corner, sir. \n4. *Stares blankly*");
                    correct = "3";
                }
                else if (i == 3)
                {
                    Console.WriteLine("Officer: 'Can you say the alphabet backwards for me?'");
                    Console.WriteLine("1. Z... Y... X... W... \n2. A B C D E... \n3. No, that's impossible even sober. \n4. *Vomits*");
                    correct = "1";
                }
                else if (i == 4)
                {
                    Console.WriteLine("Officer: 'Do you have any identification on you?'");
                    Console.WriteLine("1. I am a sovereign citizen! \n2. *Hands him a candy wrapper* \n3. I forgot it at the party. \n4. Yes, here it is.");
                    correct = "4";
                }
                else if (i == 5)
                {
                    Console.WriteLine("Officer: 'Final question... do I look like a joke to you?'");
                    Console.WriteLine("1. *Burp* Yes. \n2. No, sir. \n3. You look like my dad. \n4. SSHA-OESJ-BURP!!");
                    correct = "2";
                }

                Console.Write("\nYour Choice (1-4): ");
                string input = Console.ReadLine();

                if (input == correct)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n>> Officer: '...Understable. Continue.'");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n>> Officer: 'That's enough. Hands behind your back.'");
                    Console.WriteLine("You've been taken into custody for 24 hours.");
                    Console.ResetColor();
                    Thread.Sleep(3000);
                    return false;
                }
            }

            return true;
        }
        public static bool GoToLocation(string loc, string r, string rst)
        {
            if (loc.ToLower() == r || loc.ToLower() == rst)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
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
            main_parts mp = new main_parts();

            Console.Title = "Shift to Party";
            mp.TitleScR();

            Console.ForegroundColor = ConsoleColor.Blue;
            CenterText("==============================================================================================");
            CenterText("                                   [ PRESS ANY KEY TO BEGIN ]                                 ");
            CenterText("==============================================================================================");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            mp.TitleScR();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            CenterText("==============================================================================================");
            CenterText(@"                                 \/ !Give your name please! \/                                ");
            Console.Write(new string(' ', ((Console.WindowWidth / 2) - 2)));
            string name = Console.ReadLine();
            Console.Clear();

            //Wake up and greet the user, also go to work
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Guten Morgen, I mean Good Morning {name}! Welcome to your TOTALY normal day");
            Thread.Sleep(2250);
            Console.Write("You wake up and get ready for work");
            ThreeDots();
            Thread.Sleep(1000);

            string job = SelectJob();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You work as a: {job}!");
            Work work = new Work();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
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
            Thread.Sleep(1000);

            
            Random random = new Random();
            for (int i = 0; i <= random.Next(3, 5); i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Map Loading"); Thread.Sleep(500); ThreeDots(); Thread.Sleep(750); Console.Clear();
                mp.MakeMap();
            }
            for (int i = 0; i <= random.Next(3, 5); i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("POI's Loading"); Thread.Sleep(500); ThreeDots(); Thread.Sleep(750); Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            mp.GiveMap();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("This is your small neigboorhood!");
            Console.WriteLine("You can go to the park, the shop, the random building, or your work(as where you need to)!");
            Thread.Sleep(6700);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            mp.GiveMap();
            Console.ResetColor();
            string location = "";
            bool correct_location = false;

            for (int attempts = 1; attempts <= 3; attempts++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Attempt {attempts}/3 - Where would you want to go: ");
                Console.ResetColor();

                location = Console.ReadLine();
                correct_location = GoToLocation(location, "work", "w");

                if (correct_location)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Off to work we go!");
                    Thread.Sleep(1500);
                    Console.ResetColor();
                    break;
                }
                else if (attempts < 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can't go there yet, you need to go to work!");
                    Console.ResetColor();
                }
            }

            
            if (!correct_location)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;

                CenterText("     ██     ██  ██████  ██████  ███████ ████████ ");
                CenterText("     ██     ██ ██    ██ ██   ██ ██         ██    ");
                CenterText("     ██  █  ██ ██    ██ ██████  ███████    ██    ");
                CenterText("     ██ ███ ██ ██    ██ ██   ██      ██    ██    ");
                CenterText("      ███ ███   ██████  ██   ██ ███████    ██    ");
                CenterText("                                                 ");
                CenterText(" ███████ ███    ██ ██████  ██ ███    ██  ██████  ");
                CenterText(" ██      ████   ██ ██   ██ ██ ████   ██ ██       ");
                CenterText(" █████   ██ ██  ██ ██   ██ ██ ██ ██  ██ ██   ███ ");
                CenterText(" ██      ██  ██ ██ ██   ██ ██ ██  ██ ██ ██    ██ ");
                CenterText(" ███████ ██   ████ ██████  ██ ██   ████  ██████  ");
                CenterText("==============================================================================================");
                CenterText("                                 YOU GOT FIRED FOR BEING LATE                                 ");
                CenterText("==============================================================================================");
                Console.ResetColor();
                Thread.Sleep(2000);
                Console.Clear();
                CenterText("==============================================================================================");
                CenterText("                             Press any key to accept your fate...                             ");
                CenterText("==============================================================================================");
                Console.ReadKey();
                Environment.Exit(0);
            }


            Console.Clear();
            Console.WriteLine("You finally go to work"); ThreeDots();
            Thread.Sleep(1000);
            
            int balance = work.SelectJob(job);
            
            if (balance <= 0)
            {
                Console.WriteLine("You did so badly at your job that you got fired, better luck next time!");
                CenterText("     ██     ██  ██████  ██████  ███████ ████████ ");
                CenterText("     ██     ██ ██    ██ ██   ██ ██         ██    ");
                CenterText("     ██  █  ██ ██    ██ ██████  ███████    ██    ");
                CenterText("     ██ ███ ██ ██    ██ ██   ██      ██    ██    ");
                CenterText("      ███ ███   ██████  ██   ██ ███████    ██    ");
                CenterText("                                                 ");
                CenterText(" ███████ ███    ██ ██████  ██ ███    ██  ██████  ");
                CenterText(" ██      ████   ██ ██   ██ ██ ████   ██ ██       ");
                CenterText(" █████   ██ ██  ██ ██   ██ ██ ██ ██  ██ ██   ███ ");
                CenterText(" ██      ██  ██ ██ ██   ██ ██ ██  ██ ██ ██    ██ ");
                CenterText(" ███████ ██   ████ ██████  ██ ██   ████  ██████  ");
                CenterText("==============================================================================================");
                CenterText("                                 YOU GOT FIRED FOR BEING BAD                                  ");
                CenterText("==============================================================================================");
                Console.ResetColor();
                Thread.Sleep(2000);
                Console.Clear();
                CenterText("==============================================================================================");
                CenterText("                             Press any key to accept your fate...                             ");
                CenterText("==============================================================================================");
                Environment.Exit(0);
            }
            Console.WriteLine($"You made {balance} dollars at your job! Not bad for a day of work!");
            Console.WriteLine("You have a party at your friends house later, you should go buy something after work!");
            mp.GiveMap();
            
            while (!GoToLocation(Console.ReadLine(), "shop", "s"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                mp.GiveMap();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("You can't go there yet, you need to go to the shop!");
                ThreeDots();
                Console.ResetColor();
                Console.Clear();
            }
            Shop_and_Friend_s_house safh = new Shop_and_Friend_s_house();
            List<string> party_supplies = safh.OpenShop(ref balance);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You go to the shop and buy some supplies for the party!"); ThreeDots();
            Console.WriteLine($"You have {balance} dollars left after shopping!"); ThreeDots();
            Console.ResetColor();
            Console.WriteLine("You have to go to your friends' house to help with preperations!");
            Thread.Sleep(2500);
            mp.GiveMap();
            while (!GoToLocation(Console.ReadLine(), "friend's house", "f"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                mp.GiveMap();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("You need to go to your friend's house!");
                ThreeDots();
                Console.ResetColor();
                Console.Clear();
            }
            Console.WriteLine("You go to the party, bringing");ThreeDots();
            Thread.Sleep(1000);
            bool secret = safh.VisitFriendHouse(party_supplies);
            while (!GoToLocation(Console.ReadLine(), "home", "h"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                mp.GiveMap();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("You have to return home!");
                ThreeDots();
                Console.ResetColor();
                Console.Clear();
            }
            if (secret)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("The world begins to spin... the streetlights look like blurry stars.");
                Console.WriteLine("You wander off the sidewalk and into the grass of the City Park.");
                Thread.Sleep(2000);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[ ! ] SUDDENLY: A blinding white light hits your face.");
                Console.ResetColor();
                Thread.Sleep(1500);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\"HALT! Stay right where you are!\"");
                Console.WriteLine("Two officers step out from the shadows, notebooks in hand.");
                Console.ResetColor();
                Thread.Sleep(2000);

                Console.WriteLine("\nYou're dizzy, but you need to focus. One wrong word and it's over.");
                Console.WriteLine("------------------------------------------------------------------");
                Thread.Sleep(2500);
                Console.Clear();

                switch (ParkPolice())
                {
                    case true:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You passed the park patrol's interrogation and are free to go");
                        ThreeDots();
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        
                        CenterText("You finally reach your front door and fumble with the keys.");
                        CenterText("The world is spinning, but you're safe.");
                        CenterText("You collapse onto your bed, clothes still on.");
                        Thread.Sleep(2000);

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        CenterText("Your head is pounding... tomorrow's migraine is going to be legendary.");
                        CenterText("But for now... sleep.");
                        Thread.Sleep(2500);

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;

                        
                        CenterText("  ██████   ██████   ██████  ██████      ███████ ███    ██ ██████  ██ ███    ██  ██████  ");
                        CenterText(" ██       ██    ██ ██    ██ ██   ██     ██      ████   ██ ██   ██ ██ ████   ██ ██       ");
                        CenterText(" ██   ███ ██    ██ ██    ██ ██   ██     █████   ██ ██  ██ ██   ██ ██ ██ ██  ██ ██   ███ ");
                        CenterText(" ██    ██ ██    ██ ██    ██ ██   ██     ██      ██  ██ ██ ██   ██ ██ ██  ██ ██ ██    ██ ");
                        CenterText("  ██████   ██████   ██████  ██████      ███████ ██   ████ ██████  ██ ██   ████  ██████  ");
                        Console.WriteLine($"Good night {name}!");
                        Console.ResetColor();
                        CenterText("\nPress any key to finish your story...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    case false:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        CenterText("The handcuffs click shut. The cold steel is a wake-up call.");
                        CenterText("You spend the night on a hard plastic bench in a holding cell.");
                        CenterText("The fluorescent lights never turn off.");
                        Thread.Sleep(3000);

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        
                        CenterText(" ███████ ███████  ██████ ██████  ███████ ████████      ███████ ███    ██ ██████  ██ ███    ██  ██████  ");
                        CenterText(" ██      ██      ██      ██   ██ ██         ██         ██      ████   ██ ██   ██ ██ ████   ██ ██       ");
                        CenterText(" ███████ █████   ██      ██████  █████      ██         █████   ██ ██  ██ ██   ██ ██ ██ ██  ██ ██   ███ ");
                        CenterText("      ██ ██      ██      ██   ██ ██         ██         ██      ██  ██ ██ ██   ██ ██ ██  ██ ██ ██    ██ ");
                        CenterText(" ███████ ███████  ██████ ██   ██ ███████    ██         ███████ ██   ████ ██████  ██ ██   ████  ██████  ");

                        Console.ResetColor();
                        CenterText("\n[ STATUS: IN CUSTODY FOR 24 HOURS ]");
                        Console.WriteLine($"Hope you sleep well {name}"); ThreeDots(); 
                        CenterText("Press any key to exit...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }




            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            CenterText("You return home safely");
            CenterText("No problems at the party, tho everyone tought you were boring for not bringing heavy alchohol"); ThreeDots();
            CenterText("You go to bed in peace and get ready for the next day"); ThreeDots();
            Thread.Sleep(3000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("  ██████   ██████   ██████  ██████      ███████ ███    ██ ██████  ██ ███    ██  ██████  ");
            CenterText(" ██       ██    ██ ██    ██ ██   ██     ██      ████   ██ ██   ██ ██ ████   ██ ██       ");
            CenterText(" ██   ███ ██    ██ ██    ██ ██   ██     █████   ██ ██  ██ ██   ██ ██ ██ ██  ██ ██   ███ ");
            CenterText(" ██    ██ ██    ██ ██    ██ ██   ██     ██      ██  ██ ██ ██   ██ ██ ██  ██ ██ ██    ██ ");
            CenterText("  ██████   ██████   ██████  ██████      ███████ ██   ████ ██████  ██ ██   ████  ██████  ");
            Console.WriteLine($"Good night {name}!");
            CenterText("\nPress any key to finish your story...");
            Console.ReadKey();
            Environment.Exit(0);


        }
    }
}
