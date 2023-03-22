using System;
using System.Collections.Generic;
using System.Text;

namespace _22PMbootcamp
{
    public static class Operations
    {
        public static void Arithmetic()
        {
            int a = 9;
            int b = 6;
            int c;

            a++;
            b--;

            c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;

            c = a % b;

            a += b;
            a -= b;
            a *= b;
            a /= b;

            a /= 7;
        }
        public static void Comparison()
        {
            int a = 10;
            int b = 42;
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
        }
        public static void Logic()
        {
            bool hasSword = true;
            bool hasMagic = false;

            if (hasMagic) Console.WriteLine("Has a magic amulet");
            if (!hasMagic) Console.WriteLine("Dose not have magic amulet");
            if (hasMagic && hasSword) Console.WriteLine("VERY DANGEROUS... has both magic and weapon!");
            if (hasMagic || hasSword) Console.WriteLine("Can attack with magic OR with sword OR both!");
            if (hasMagic ^ hasSword) Console.WriteLine("Only has ONE form of attack...");
            if (!hasSword && !hasMagic) Console.WriteLine("Run....you don't have any form of attack");
        }
        public static void Ternary()
        {
            int a = 18;
            int b = 42;
            int c;

            c = (a == b) ? a : b;
            Console.WriteLine(c);

            string Answer = (a % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine("{0} is {1}", a, Answer);
            
        }
    }
}
