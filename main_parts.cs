using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Party_Shift
{
    public class main_parts
    {

        public void TitleScR()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            master.CenterText("  ██████  ██   ██ ██ ███████ ████████      ████████  ██████  ");
            master.CenterText(" ██       ██   ██ ██ ██         ██            ██    ██    ██ ");
            master.CenterText("  ██████  ███████ ██ █████      ██            ██    ██    ██ ");
            master.CenterText("       ██ ██   ██ ██ ██         ██            ██    ██    ██ ");
            master.CenterText("  ██████  ██   ██ ██ ██         ██            ██     ██████  ");
            master.CenterText("                                                             ");
            master.CenterText("          ██████   █████  ██████  ████████ ██    ██          ");
            master.CenterText("          ██   ██ ██   ██ ██   ██    ██     ██  ██           ");
            master.CenterText("          ██████  ███████ ██████     ██      ████            ");
            master.CenterText("          ██      ██   ██ ██   ██    ██       ██             ");
            master.CenterText("          ██      ██   ██ ██   ██    ██       ██             ");
            Console.ResetColor();
        }
        // 1 house, 2 store, 3 work, 4 park, 5 friend's house, 6 random building
        List<string> house_types = new List<string>();
        public void MakeMap()
        {
            
            house_types.Add("h"); // own house
            house_types.Add("s"); // neihborhood store
            house_types.Add("w"); // own workplace
            house_types.Add("p"); // neighborhood park
            house_types.Add("f"); // friend's house 
            house_types.Add("r"); // random building
            Random rnum = new Random();
            for (int i = rnum.Next(1, 15); i > 0; i--)
            {
                house_types.Shuffle();
            }
        }
        public void GiveMap()
{
            Console.Write($"    o-----o-----o-----o");
            Console.WriteLine();
            for (int j = 0; j <= 3; j += 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("    ");
                    Console.Write("| ");
                    for (int a = 0; a < 3; a++)
                    {

                        Console.Write($"{house_types[a + j]}{house_types[a + j]}{house_types[a + j]} | ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"    o-----o-----o-----o");
            }
            Console.WriteLine("h = house, s = store, w = work, p = park, f = friend's house, r = random building");
            Console.Write("Type where you want to go as a letter or its full name: ");
        }

    }
}

