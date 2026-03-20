using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Party_Shift
{
    public class main_parts
    {

        public static void TitleScR()
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
        public void MakeMap()
        {
            Random ran_n = new Random();
            List<int> roads = new List<int>();
            for (int k = 0; k <= 15; k++)
            {
                roads.Add(ran_n.Next(100, 1000));
                roads.Shuffle();
            }

            List<string> house_types = new List<string>();
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


            Console.Write($"    {roads[0]} {roads[1]} {roads[2]} {roads[3]} {roads[4]}");
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
                Console.WriteLine($"    {roads[j + 5]} {roads[j + 6]} {roads[j + 7]} {roads[j + 8]} {roads[j + 9]}");

            }

    }
}

