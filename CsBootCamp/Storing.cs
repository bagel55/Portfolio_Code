using System;
using System.Collections.Generic;
using System.Text;

namespace _22PMbootcamp
{
    public static class Storing
    {

        enum Enemies { Rockguy, Notrockguy, Zombieorsomthing, ProbablyADeadGuy, John, FridayButItWantsYouDead, John2};

        public static void DemoVariables()
        {
            int playerID = 444;
            uint playerHealth = 555;
            ulong playermoney = 477282739847;
            decimal pi = 3.3446238365743859873479m;
            Console.WriteLine(pi);
            bool isRich = true;
            string PlayerID = "13467";

            char FirstInitial = '2'; // can use ASC codes
            FirstInitial++;

            Console.WriteLine(FirstInitial);

            char beep = (char)0;
            Console.WriteLine(beep);
            while (true)
            {
                Console.WriteLine(beep);
                beep++;
                Console.ReadLine();
            }

        }
        public static void ReadingImput()
        {
            Console.Write("enter player name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}. It is good to have you starting the game", name);
            Console.Write("Enter character height: >");
            int height = Convert.ToInt32(Console.ReadLine() );
            int ageInMonths = height * 12;
            Console.WriteLine("Thanks you. You are {0} months old!", ageInMonths);
        }
        public static void UsingArrays()
        {
            string[] enemyName = new string[6];
            enemyName[0] = "Riley the Ravenous";
            enemyName[1] = "Joseph the Joker";
            enemyName[2] = "Joseph the Jugular";
            enemyName[3] = "Ron the Raptor";
            enemyName[4] = "Nathan the Nasty";
            enemyName[5] = "Ben the Buthcher";

            int[] enemyHealth = new int[5] { 10, 30, 35, 2, 90 };

            System.Random random = new System.Random();

            while (true)
            {
                int num = random.Next(6);
                Console.WriteLine("Rolled a {0}", num);
                enemyHealth[num]--;
                Console.WriteLine("{0} raised an axe and swung and now has {1} health", enemyName[num], enemyHealth[num]);
                Console.ReadLine();
            }
        }

        public static void ConstantsAndEnums()
        {
            const double PI = 3.1415926535;
            Console.WriteLine(PI);

            var Enemys = Enemies.Zombieorsomthing;
            if (Enemys == Enemies.John || Enemys == Enemies.John2)
            {
                Console.WriteLine("ITS JOHN!!");
            }
            else
            {
                Console.WriteLine("Still not john");
            }
        }
    }
}
