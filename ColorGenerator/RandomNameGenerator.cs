using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ColorGenerator
{
    public class RandomNameGenerator
    {
        public static string GenNew(List<string> descriptorName, List<string> ColorList)
        {//randomizes the list 
            Random random = new Random(DateTime.Now.Second);
            int color = random.Next(ColorList.Count);
            int descriptor = random.Next(descriptorName.Count);

            //concatenates a word from each list
            return $"{descriptorName[descriptor]} {ColorList[color]} ";
        }
        public static void RGen(List<string> descriptorName, List<string> ColorList)
        {
            int a = 1;
            do
            {
                Console.WriteLine(GenNew(descriptorName, ColorList));
                // Wait to allow the timer to advance
                Thread.Sleep(2000 + 500);
                a++;
            }
            while (a < 4);
        }
        public static void ClGen(List<string> ColorList)
        {
            string input = Console.ReadLine();
            ColorList.Insert(10, input);
            if (ColorList.Contains(input))
            {
                Console.WriteLine("You have entered " + input);
                Console.WriteLine("\nYour entry has been added!");
            }
            else
            {
                Console.WriteLine("THE ENTRY HAS NOT BEEN ADDED!");
            }
        }
    }
}
