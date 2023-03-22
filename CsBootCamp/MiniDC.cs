using System;
using System.Collections.Generic;
using System.Text;

namespace _22PMbootcamp
{
    public static class MiniDC
    {
        public static void StartDC()
        {
            Console.Clear();
            Console.WriteLine("Mini Dungeon Crawler. Welcome to D'nal!");
            Console.Write("\n\tWhat is your name, dear player? >");
            string pName = Console.ReadLine();
            Player player = new Player(0, pName, 70);

            Player[] monster = new Player[6];
            monster[0] = new Player(0, "", 0);
            monster[1] = new Player(1, "GOONBYGUY", 25);
            monster[2] = new Player(2, "WIZYARDMAN", 5);
            monster[3] = new Player(3, "MR POKE U WITH MY STABY STICK", 125);
            monster[4] = new Player(4, "Anti vaxxers", -1);
            monster[5] = new Player(5, "I GOTTA ROCK", 20);

            int MaxX = 11;
            int maxY = 11;

            Location[,] location = new Location[MaxX, maxY];

            location[5, 5] = new Location("Home", "You fight off a horde of goblins.", 4);
            location[4, 4] = new Location("Getel", "A small magic town", 2);
            location[7, 7] = new Location("A huge cavern", "A DUDE WITH A POKEY STICK", 3);
            location[9, 7] = new Location("A Weeping Willow", "The branches of the willow sooth you.", 0);

            int pX = 5;
            int pY = 5;

            Random dice = new Random();

            while (true)
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine("HEALTH: {0}", player.Health);
                Console.WriteLine("LOCATION: {0},{1}", pX, pY);
                
                if (location[pX,pY] != null)
                {
                    Console.WriteLine(" *** {0} *** ", location[pX, pY].LocationName);
                    Console.WriteLine(" *** {0} *** ", location[pX, pY].Description);

                    if (location[pX, pY].MonsterID != 0)
                    {
                        int mID = location[pX, pY].MonsterID;
                        Console.WriteLine(" !!! You encounter {0} with health of {1} !!!", monster[mID].Name, monster[mID].Health);

                        int damageToPlayer = dice.Next(1, 20);
                        int damageToMonster = dice.Next(40, 60);

                        player.Health -= damageToPlayer;
                        monster[mID].Health -= damageToMonster;

                        Console.WriteLine("!!! You take {0} damage and your health is {1} !!!", damageToPlayer, player.Health);
                        Console.WriteLine("{0} takes {1} damage and their health is now {2}", monster[mID].Name, damageToMonster, monster[mID].Health);
                        if( player.Health <= 0)
                        {
                            Console.WriteLine("You have taken substantial EMOTIONAL DAMAGE.");
                            return;
                        }
                        if ( monster[mID].Health <= 0)
                        {
                            Console.WriteLine(" !!! YOU SENT {0} TO JESUS !!!", monster[mID].Name);
                            location[pX, pY].MonsterID = 0;
                            location[pX, pY] = null;
                        }
                    }
                }

                if(pX == 9 && pY == 7)
                {
                    Console.WriteLine("your depression is cured");
                    player.Health = 40;
                    player.Health += 3;
                    player.Health += dice.Next(-1, 4);
                    if (player.Health > 60) player.Health = 60;
                }

                Console.Write("Your wish is my command > ");
                string cmd = Console.ReadLine().ToLower().Trim();
                if ( cmd == "q" || cmd == "quit")
                {
                    Console.WriteLine("Thank you for playing dont come back.");
                    return;
                }

                if (cmd == "w") pY--;
                if (cmd == "s") pY++;
                if (cmd == "a") pX--;
                if (cmd == "d") pX++;

                pX = Math.Clamp(pX, 0, MaxX - 1);
                if (pY < 1) pY = maxY - 1;
                if (pY > maxY) pY = 0;

                if (cmd == "m") Location.DrawMap(location, pX, pY);

                try
                {
                    if (cmd == "save") DataManagment.SavePlayerData(player);
                }
                catch
                {
                    Console.WriteLine("Could not save player data");
                }


                try
                {
                    if (cmd == "load") player = DataManagment.LoadPlayerData(player);
                }
                catch
                {
                    Console.WriteLine("Could not restore player data");
                }
            }
        }
    }
}