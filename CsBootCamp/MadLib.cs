using System;
using System.Collections.Generic;
using System.Text;

namespace _22PMbootcamp
{
    public static class MadLib
    {
        public static void Execute()
        {
            Console.WriteLine("Adjective please: >");
            string adj1 = Console.ReadLine();
            Console.WriteLine("Another adjective please: >");
            string adj2 = Console.ReadLine();
            Console.WriteLine("yet another adjective please: >");
            string adj3 = Console.ReadLine();
            Console.WriteLine("Again yet another adjective please: >");
            string adj4 = Console.ReadLine();
            Console.WriteLine("Noun, please: >");
            string noun1 = Console.ReadLine();
            Console.WriteLine("Another noun, please: >");
            string noun2 = Console.ReadLine();
            Console.WriteLine("Amount of days please: >");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------\n\n");
            Console.WriteLine("A bad trip is when you go to a {0} place ", adj1);
            Console.WriteLine("with your {0} friends. After you", adj2);
            Console.WriteLine("Usually feel {0} or very {1}.", adj3, adj4);
            Console.WriteLine("The {0} place is ussually in a {1} or a {2}.", adj1, noun1, noun2);
            Console.WriteLine("You can ussually stay anywhere");
            Console.WriteLine("between 1 to {0} days", num);

            string TimeFrame = (num < 5) ? "short" : "long";
            Console.WriteLine("Which is a {0} amount of days", TimeFrame);

            int TimeInHours = num * 24;
            Console.WriteLine("Also {0} hours", TimeInHours);
        }
    }
}
