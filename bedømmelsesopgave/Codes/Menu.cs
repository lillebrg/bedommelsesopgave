﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bedømmelsesopgave.Codes
{

    internal class Menu
    {
        static void main(string[] args)
        {
            bool ShowMenu = true;

            while (ShowMenu)
            {
                ShowMenu = MainMenu();
            }
        }
        public static bool MainMenu()
        {
            do
            {

                Console.WriteLine("Dage Tilbage Indtil Ferie");
                Console.WriteLine((new DateConvertor(new DateTime(2022, 2, 11))).AntalDage);
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("bedømmelses opgave");
                Console.WriteLine("1) for fag");
                Console.WriteLine("2) for elev");
                Console.WriteLine("3) for lærer");
                Console.WriteLine("4) exit");
                Console.WriteLine("\r\nvælg en: ");
                string vælger = Console.ReadLine();

                switch (vælger)
                {
                    case "1":
                        {
                            Search.Fag();
                            break;
                        }


                    case "2":
                        {
                            Search.Elever();
                            break;
                        }

                    case "3":
                        {
                            Search.Lærer();
                            break;
                        }

                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Tak for denne gang!");
                            System.Threading.Thread.Sleep(1500);
                            Environment.Exit(0);
                            break;
                        }

                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Denne mulighed findes ikke, prøv igen!");
                            System.Threading.Thread.Sleep(2500);
                            break;
                        }
                }


            } while (true);

        }

    }
}

