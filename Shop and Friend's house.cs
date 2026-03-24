using System;
using System.Collections.Generic;
using System.Text;

namespace Party_Shift
{
    internal class Shop_and_Friend_s_house
    {

        public List<string> OpenShop(ref int playerMoney)
        {
            List<string> inventory = new List<string>();
            bool shopping = true;

            while (shopping)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--- 24/7 Shop > At Jamie's ---");
                Console.ResetColor();

                Console.WriteLine($"Your Wallet: ${playerMoney}");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("1.  Premium Chips      ($25)   6.  Craft Beer (6pk) ($80)  [Light]");
                Console.WriteLine("2.  Organic Nuts       ($20)   7.  Imported Cider   ($60)  [Light]");
                Console.WriteLine("3.  Energy Drink Pack  ($45)   8.  Top-Shelf Vodka  ($150) [Heavy]");
                Console.WriteLine("4.  Party Dip Bowl     ($35)   9.  Aged Whiskey     ($200) [Heavy]");
                Console.WriteLine("5.  Family Size Pizza  ($60)   10. Gold Tequila     ($125) [Heavy]");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("0.  DONE SHOPPING (Leave for the party)");
                Console.Write("\nSelect item (1-10): ");

                string choice = Console.ReadLine();
                string item = "";
                int price = 0;

                switch (choice)
                {
                    case "1": item = "Chips"; price += 25; break;
                    case "2": item = "Nuts"; price += 20; break;
                    case "3": item = "Energy Drinks"; price += 45; break;
                    case "4": item = "Dip"; price += 35; break;
                    case "5": item = "Pizza"; price += 60; break;
                    case "6": item = "Beer"; price += 80; break;
                    case "7": item = "Cider"; price += 60; break;
                    case "8": item = "Vodka"; price += 150; break;
                    case "9": item = "Whiskey"; price += 200; break;
                    case "10": item = "Tequila"; price += 125; break;
                    case "0": shopping = false; continue;
                    default: continue;
                }
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("======= YOUR RECEIPT =======");
            Console.ResetColor();

            if (inventory.Count > 0)
            {
                foreach (string item in inventory)
                {
                    Console.WriteLine($"- {item}");
                }
            }
            else
            {
                Console.WriteLine("- ABSOLUTELY NOTHING (Cheapskate!)");
            }

            Console.WriteLine("============================");
            Console.WriteLine($"Remaining Funds: ${playerMoney}");
            Console.WriteLine("\nPress any key to head to the party...");
            Console.ReadKey();
            Console.Clear();
            return inventory;
        }
        public bool VisitFriendHouse(List<string> you_brought)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--- VISITING YOUR FRIEND'S HOUSE ---");
            Console.ResetColor();
            Console.WriteLine("Your friend invites you in for a quick hangout before the party.");
            Console.WriteLine("You chat about the upcoming event, share some laughs, and maybe even get a sneak peek at their outfit.");
            Console.WriteLine("You help with preperations... your friend and you are happy that you brought:");
            foreach (string item in you_brought) 
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine("It's a nice break from the chaos of preparation and helps boost your mood for the night ahead.");
            Console.WriteLine("\nPress any key to continue to the party...");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("When everyone arrives, you fire up the music and everything starts blasting");
            Console.WriteLine("The party is in full swing, and you find yourself dancing, chatting, and having a great time with your friends.");
            bool isdrunk = false;
            foreach (string item in you_brought)
            {
                if (item == "Aged Whiskey" || item == "Top-Shelf Vodka" || item == "Gold Tequila")
                {
                    Console.WriteLine($"Your {item} is a heavy-hitter!");
                    Console.WriteLine("You quickly lose control of yourself and consume too much!");
                    isdrunk = true;
                }
            }
            return isdrunk;
            
        }
    }
}