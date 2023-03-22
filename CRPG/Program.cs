using System;
using System.Linq;



// Marcus Garman 2022

namespace CRPG
{
    class Program
    {

        private static Player _Player = new Player("bagel", 10, 10, 20, 0, 1);

        static void Main(string[] args)
        {
            GameEngine.Initialize();
            _Player.MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
            //crpg v0003 vid 03 1:59 issue found unsolved
            InventoryItem sword = new InventoryItem(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 1);
            InventoryItem club = new InventoryItem(World.ItemByID(World.ITEM_ID_CLUB), 1);
            _Player.Inventory.Add(sword);
            //_Player.Inventory.Add(club);
            InventoryItem aPass = new InventoryItem(World.ItemByID(World.ITEM_ID_ADVENTURER_PASS), 1);
            _Player.Inventory.Add(aPass);

            while (true)
            {
                Console.Write("> ");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    continue;
                }
                string cleanedInput = userInput.ToLower();

                if(cleanedInput == "exit")
                {
                    break;
                }
                ParseInput(cleanedInput);
            }
        }
        public static void ParseInput(string input)
        {
            if (input.Contains("help"))
            {
                Console.WriteLine("Help is coming later... maybe");
            } 
            else if (input.Contains("look") || input == "l")
            {
                DisplayCurrentLocation();
            }
            else if (input.Contains("north") || input == "n")
            {
                _Player.MoveNorth();
            }
            else if (input.Contains("east") || input == "e")
            {
                _Player.MoveEast();
            }
            else if (input.Contains("south") || input == "s")
            {
                _Player.MoveSouth();
            }
            else if (input.Contains("west") || input == "w")
            {
                _Player.MoveWest();
            } else if (input.Contains("debug"))
            {
                GameEngine.DebugInfo();
            }else if (input == "inventory" || input == "i")
            {
                Console.WriteLine("\nCurrent Inventory:");
                foreach (InventoryItem invItem in _Player.Inventory)
                {
                    Console.WriteLine("\t{0} : {1}", invItem.Details.Name, invItem.Quantity);
                }
            }else if (input == "stats")
            {
                Console.WriteLine("\nStats for {0}", _Player.Name);
                Console.WriteLine("\tCurrent HP: \t{0}", _Player.CurrentHitPoints);
                Console.WriteLine("\tMaximum HP: \t{0}", _Player.MaximumHitPoints);
                Console.WriteLine("\tXP:\t\t{0}", _Player.ExperiencePoints);
                Console.WriteLine("\tLevel:\t\t{0}", _Player.Level);
                Console.WriteLine("\tGold:\t\t{0}", _Player.Gold);
            }else if (input == "quests")
            {
                if(_Player.Quests.Count == 0)
                {
                    Console.WriteLine("You do not have any quests.");
                }
                else
                {
                    foreach (PlayerQuest playerQuest in _Player.Quests)
                    {
                        Console.WriteLine("{0}: {1}", playerQuest.Details.Name,
                            playerQuest.IsCompleted ? "Completed" : "Incomplete");
                    }
                }
            }else if (input.Contains("attack") || input == ("a"))
            {
                if(_Player.CurrentLocation.MonsterLivingHere == null)
                {
                    Console.WriteLine("There is nothing here to attack");
                }
                else
                {
                    if(_Player.CurrentWeapon == null)
                    {
                        Console.WriteLine("You are not equiped with a weapon.");
                    }
                    else
                    {
                        _Player.UseWeapon(_Player.CurrentWeapon);
                    }
                }
            }else if (input.StartsWith("equip ") || input.StartsWith("e "))
            {
                _Player.UpdateWeapons();
                string inputWeaponName = input.Substring(6).Trim();
                if (string.IsNullOrEmpty(inputWeaponName))
                {
                    Console.WriteLine("You must enter the name of the weapon to equip");
                }
                else
                {
                    Weapon weaponToEquip = _Player.Weapons.SingleOrDefault(x => x.Name.ToLower() == inputWeaponName 
                    || x.NamePlural.ToLower() == inputWeaponName);
                    if(weaponToEquip == null)
                    {
                        Console.WriteLine("You do not have the weapon {0}", inputWeaponName);
                    }
                    else
                    {
                        _Player.CurrentWeapon = weaponToEquip;
                        Console.WriteLine("You equip your {0}", _Player.CurrentWeapon.Name);
                    }
                }
            }else if (input == "weapons")
            {
                _Player.UpdateWeapons();
                Console.WriteLine("List of weapons:");
                foreach (Weapon w in _Player.Weapons)
                {
                    Console.WriteLine("\t{0}", w.Name);
                }
            }

            else
            {
                Console.WriteLine("I dont understand. Sorry");
            }
        }

        public static void DisplayCurrentLocation()
        {
            Console.WriteLine("\nYou are at: {0}", _Player.CurrentLocation.Name);
            if(_Player.CurrentLocation.Description != "")
            {
                Console.WriteLine("\t{0}\n+", _Player.CurrentLocation.Description);
            }
        }
    }
}
