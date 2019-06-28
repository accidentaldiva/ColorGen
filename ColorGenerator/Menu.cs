using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ColorGenerator
{
    public static class Menu
    {
        public static void MenuChoice()
        {
            var answerA = "1";
            var answerB = "2";
            Console.WriteLine("Would you like to create a new color name (Please enter 1) \nOR add to the list (Please enter 2) ");
            var pick = Console.ReadLine();
            if (pick == answerA)
            {
                Console.WriteLine("Please select your base color:\n Enter 0 for Red\n 1 for Orange\n 2 for Yellow\n 3 for Green\n 4 for Blue\n 5 for Purple\n 6 or Random Color");
                string colorChoice = Console.ReadLine();

                switch (colorChoice)
                {
                    case "0":
                        {
                            RandomNameGenerator.RGen(Red.descriptorName, Red.ColorList);
                        }
                        break;

                    case "1":
                        {
                            RandomNameGenerator.RGen(Orange.descriptorName, Orange.ColorList);
                        }
                        break;

                    case "2":
                        {
                                RandomNameGenerator.RGen(Yellow.descriptorName, Yellow.ColorList);
                        }
                        break;

                    case "3":
                        {
                            RandomNameGenerator.RGen(Green.descriptorName, Green.ColorList);
                        }
                        break;

                    case "4":
                        {
                            RandomNameGenerator.RGen(Blue.descriptorName, Blue.ColorList);
                        }
                        break;

                    case "5":
                        {
                            RandomNameGenerator.RGen(Purple.descriptorName, Purple.ColorList);
                        }
                        break;


                    case "6":
                        {
                            RandomNameGenerator.RGen(RandomColor.descriptorName, RandomColor.ColorList);
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("You have ended an invalid entry! Please try again!");
                        }
                        break;
                }
            }
            else if (pick == answerB)
            {
                Console.WriteLine("Please select your list color:\n Enter 0 for Red\n 1 for Orange\n 2 for Yellow\n 3 for Green\n 4 for Blue\n 5 for Purple\n 6 or Random Color to add to the list of names");
                string colorList = Console.ReadLine();
                switch (colorList)
                {
                    case "0":
                        {
                            Console.WriteLine("Please enter word to add to the Color List for Red");
                            RandomNameGenerator.ClGen(Red.ColorList);
                        }
                        break;

                    case "1":
                        {
                                Console.WriteLine("Please enter word to add to the Color List for Orange");
                                RandomNameGenerator.ClGen(Orange.ColorList);
                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine("Please enter word to add to the Color List for Yellow");
                            RandomNameGenerator.ClGen(Yellow.ColorList);
                        }
                        break;

                    case "3":
                        {
                            Console.WriteLine("Please enter word to add to the Color List for Green");
                            RandomNameGenerator.ClGen(Green.ColorList);
                        }
                        break;

                    case "4":
                        {
                            Console.WriteLine("Please enter word to add to the Color List for Blue");
                            RandomNameGenerator.ClGen(Blue.ColorList);
                        }
                        break;

                    case "5":
                        {
                            Console.WriteLine("Please enter word to add to the Color List for Purple");
                            RandomNameGenerator.ClGen(Purple.ColorList);
                        }
                        break;

                    case "6":
                        {
                            Console.WriteLine("Please enter word to add to the Color List for Random selections");
                            RandomNameGenerator.ClGen(Red.ColorList);
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("You have ended an invalid entry! Please try again!");
                        }
                        break;
                }
            }
            else
                {
                Console.WriteLine("You have ended an invalid entry! Please try again!");
                }
            }

        

    }
    }

