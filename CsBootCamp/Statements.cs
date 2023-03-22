using System;
using System.Collections.Generic;
using System.Text;

namespace _22PMbootcamp
{
    public static class Statements
    {
        public static void BranchingIf()
        {
            int a = 3;

            if (a < 4)
            {
                Console.WriteLine("Number is less than 4");
                Console.WriteLine("more stuff...");
            }
            else if (a >=4 && a <= 10)
            {
                Console.WriteLine("Number is between 4 and 10 (inclusive)");
            }
            else
            {
                Console.WriteLine("Number is greater than 10.");
            }

            int b = 10;

            if (b > 5)  
                Console.WriteLine("b is bigger than 5");
        }

        public static void Switching()
        {
            int d = 238975;
            string day = "";

            switch (d % 7)
            {
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tusday";
                    break;
                case 3:
                    day = "Wensday";
                    break;
                case 4:
                    day = "Thursaday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                default:
                    day = "Weekend";
                    break;
            }
            Console.WriteLine("Day {0} is a {1}", d, day);
        }
            public static void ForLoop()
            {
                for (int i = 2; i <= 145; i+=2)
                {
                    Console.WriteLine("The value of i is {0}", i);
                }

                for (int i = 0; i<10; i++)
                {
                    Console.WriteLine("Outer Loop {0}", i);
                    for (int j = 0; j<5; j++)
                        {
                            Console.WriteLine("\tInner Loop {0}", j);
                        }
                }
            }

        public static void WhileLoops()
        {
            int Health = 0;
            while (Health < 10)
            {
                Console.WriteLine("The value of 1 is {0}", Health);
                Health += 3;
            }

            int Mana = 0;
            do
            {
                Console.WriteLine("The value of j is {0}", Mana);
                Mana++;
            } while (Mana < 5);

            do
            {
                Console.WriteLine("Enter command: > ");
            } while (Console.ReadLine() != "q");
        }

        public static void LoopingArrays()
        {
            string[] Bosses = new string[4];
            Bosses[0] = "Nito";
            Bosses[1] = "Gwyn";
            Bosses[2] = "Pygmy";

            Console.WriteLine("Reamaining bosses:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\t{0}", Bosses[i]);
            }
        }

        public static void ForEachIteration()
        {
            List<string> potions = new List<string>();
            potions.Add("Health");
            potions.Add("Mana");
            potions.Add("Strength");
            potions.Add("Dexterity");

            Console.WriteLine("List of potions you got:");

            foreach( string p in potions)
            {
                Console.WriteLine("\t{0}", p);
            }
        }
    }
}
