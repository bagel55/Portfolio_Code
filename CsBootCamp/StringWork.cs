using System;
using System.Collections.Generic;
using System.Text;

namespace _22PMbootcamp
{
    public static class StringWork
    {
        public static void StringFeatures()
        {
            Console.WriteLine("HOW DENSE ARE YOU ENTER TEXT");
            string text = Console.ReadLine().Trim();
            if (String.IsNullOrEmpty(text))
            {
                Console.WriteLine("WHAT DID I JUST SAY YOU ABSOLUTE GOLDFISH");
            }
            else
            {
                Console.WriteLine("Thank you so much for entering text I will never be able to repay you this is more benificial than you can ever imagine you entered \"{0}\" ", text);
                string query = text.StartsWith("c#") ? "dose" : "dose not";
                Console.WriteLine("'{0}' {1} start with ", text, query);
                query = text.EndsWith("cool.") ? "dose" : "dose not";
                Console.WriteLine("'{0}' {1} end with cool.", text, query);
                query = text.Contains("is") ? "dose" : "dose not";
                Console.WriteLine("'{0}' {1} contail 'is'", text, query);
                // learn grep for text filtering
            }
        }

        public static void Manipulate()
        {
            Console.WriteLine("HOW DENSE ARE YOU ENTER TEXT");
            string text = Console.ReadLine().Trim();
            Console.WriteLine("Thank you so much for entering text I will never be able to repay you this is more benificial than you can ever imagine you entered \"{0}\" ", text);
            Console.WriteLine("your text is {0} characters long.", text.Length);
            text = text.Trim();
            Console.WriteLine("Your TRIMMED text is {0} characters long.", text.Length);
            string upper = text.ToUpper();
            string lower = text.ToLower();
            Console.WriteLine(upper);
            Console.WriteLine(lower);
            string huh = text.ToLowerInvariant();
            Console.WriteLine(huh);
            text = text.PadLeft(10,'*');
            Console.WriteLine(text);
            text = text.PadRight(30, '.');
            Console.WriteLine(text);
            // Other trimming varients      TrimStart()        TrimEnd()
        }

        public static void JoinAndCompare()
        {
            string[] a = new string[3] { "Alpha", "Beta", "Gamma" };
            string s = string.Concat(a[0], a[2], a[1], a[2]);
            Console.WriteLine(s);
            s = a[0] + a[1];
            Console.WriteLine(s);
            s = string.Join(" ", a[0], a[1], a[2]);
            Console.WriteLine(s);
            s = string.Join(" ", a);
            Console.WriteLine(s);

            int num = string.Compare("apples", "oranges");
            Console.WriteLine(num);

            Console.WriteLine("apples" != "oranges");
        }

        public static void FindingSubStrings()
        {
            string phrase = "The quick brown fox jumped over the lazy dog and the cat and the mouse.".ToLower();
            string searchTerm = "the";
            int num = phrase.IndexOf(searchTerm,0);
            Console.WriteLine(num);
        }

        public static void Formatting()
        {
            float number = 34.56f;
            string sN = number.ToString("xxxxxxx.xxxxxx");
            Console.WriteLine(sN);

            //splitting !!!!!!!!! VERY IMPORTANT
            string data = "Alpha,Bravo,Charlie,Delta,Echo,Foxtrot";
            string data2 = "This is a long sentence that I am writing.";
            string[] items = data.Split(',');
            string[] items2 = data2.Split(' ');
            //Console.WriteLine(items[3]);
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void DateStrings()
        {
            while (true)
            {
                DateTime now = DateTime.Now;
                //Console.WriteLine(now);
                //Console.WriteLine(now.DayOfWeek);
                //Console.WriteLine(now.DayOfYear);
                Console.WriteLine(Convert.ToString(now.ToBinary(), 2));
                //Console.WriteLine(now.ToBinary());
            }

            //DateTime birthday = new DateTime(2005, 5, 25);
            //Console.WriteLine(birthday.DayOfWeek);
            //Console.WriteLine(birthday.AddYears(50).DayOfWeek);
        }

        public static void HomeWorkName()
        {
            string name;
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            string trmname = name.Trim();
            if (trmname.StartsWith('b') == false || trmname.Length > 10)
            {
                do
                {
                    Console.WriteLine("Needs to start with b and have 10 or less characters.");
                    trmname = Console.ReadLine();
                } while (trmname.StartsWith('b') == false || trmname.Length > 10);
            }
            string upname = trmname.ToUpper();
            //////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Please enter a list of weapons seperated by comma's");
            string[] separatingStrings = { ",", " ,", ", " };
            string text = Console.ReadLine();
            string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            int n = 0;
            foreach (var word in words)
            {
                n++;
                System.Console.WriteLine("{0} {1}", n, word.Trim());
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter the year you were born");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Invalid value entered");
            }
            else
            {
                Console.WriteLine("You entered {0}", year);
            }
            Console.WriteLine("Enter the number of the month you were born");
            if (!int.TryParse(Console.ReadLine(), out int month))
            {
                Console.WriteLine("Invalid value entered");
            }
            else
            {
                Console.WriteLine("You entered {0}", month);
            }
            Console.WriteLine("Enter the day of the month you were born");
            if (!int.TryParse(Console.ReadLine(), out int day))
            {
                Console.WriteLine("Invalid value entered");
            }
            else
            {
                Console.WriteLine("You entered {0}", day);
            }
            DateTime birthday = new DateTime(year, month, day);
            Console.WriteLine("You were born on a {0}", birthday.DayOfWeek);
            ////////////////////////////////////////////////////////////////
            Console.WriteLine("Please enter a world name");
            string worldName = Console.ReadLine();
            for (int i = 0; i < worldName.Length; i++)
            {
                string letter = worldName.Substring(i, 1);
                if (i % 2 == 0)
                {
                    Console.Write(letter.ToUpper());
                }
                else
                {
                    Console.Write(letter.ToLower());
                }
            }
        }
    }
}
