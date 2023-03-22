using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22PMbootcamp
{
    internal class WordCounter
    {
            public static void CharacterCounter(string[] args)
            {
                string inputstring = "Please let your students know that if there is an issue with an order the BEST practice is to email me at" +
        " landeg@mukilteo.wednet.edu with their First and Last name as well as their order ID, it can " +
        "be located underneath the date on the receipt they receive after an order is complete, and clearly state the " +
        "issue with their order so that we can work to get those orders fixed the NEXT day of service. Although we would " +
        "love for each student to have their orders fulfilled completely the day of ordering, it is just not possible with " +
        "the current amount of orders we are receiving. Please avoid sending students to the Training Grounds Window to fix " +
        "an order. Thank you so much for supporting our programs " +
        "and showing our students grace and patience through this process.";
                char[] charsToTrim = { ',', '.', '/', '<', '>', '?', ';', ':', '[', ']', '{', '}', '!', '#', '$', '%', '^', '&', '*', '(', ')', ' ' };
                string Text = inputstring.Trim(charsToTrim).ToUpper();
                var count = 0;
                var charGroups = (from s in Text
                                  group s by s into g
                                  select new
                                  {
                                      c = g.Key,
                                      count = g.Count(),
                                  }).OrderBy(c => c.count);
                foreach (var x in charGroups)
                {
                    Console.WriteLine(x.c + ": " + x.count);
                    count = x.count;
                }

                Console.Read();

            }
    }
}
