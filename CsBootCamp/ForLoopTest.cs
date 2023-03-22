using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace _22PMbootcamp
{
    public static class ForLoopTest
    {

        //public static void Main1(string[] args)
        //{
        //    string HlWrld = "Hello World!";
        //    for (int i = 0; i <= 11; i++)
        //    {
        //        Console.WriteLine(HlWrld.Substring(i, 1));
        //    }
        //    Console.ReadKey();
        //}

        public static void HelloWrld(string[] args)
        {
            string HlWrld = "Hello World!";
            string HlWrldRev = "";
            for (int i = 11; i >= 0; i--)
            {
                HlWrldRev += HlWrld.Substring(i, 1);
            }
            Console.WriteLine(HlWrldRev);
            Console.ReadKey();
        }
    }
}

