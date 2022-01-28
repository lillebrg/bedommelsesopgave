using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bedømmelsesopgave.Codes
{
    enum searchcriteria
    {
        Fag,
        Lærer,
        Elev
    }
    internal class Search
    {
        
       
        public static void Fag()
        {
            
            Console.WriteLine("skriv det fag du skal bruge data til");
            Console.WriteLine("");
            Console.WriteLine("muligheder:");
            Console.WriteLine("");
            Console.WriteLine("-Grundlæggende programmering");
            Console.WriteLine("-Database programmering");
            Console.WriteLine("-Studieteknik");
            string fagoptions = null;
            try {fagoptions = Console.ReadLine(); }
            catch (NullReferenceException)
            {
                Console.WriteLine("Denne linjie kan ikke være null, Prøv igen");
                System.Threading.Thread.Sleep(2500);
                Fag();
            }

            int rowsIn2DArray = H1.MyArray.GetLength(0);
            int columnCount = H1.MyArray.GetLength(1);

            for (int j = 0; j < rowsIn2DArray; j++)
            {
                for (int k = 0; k < columnCount; k++)
                {
                    if (k == 0)
                    {
                        string item = H1.MyArray[j, k].ToString();
                        if (fagoptions == item)
                        {
                            Console.WriteLine(H1.MyArray[j,1]);
                            List<Elever> elever = (List<Elever>)H1.MyArray[j, 2];
                            foreach (Elever elev in elever)
                            {
                                Console.WriteLine($"Elev: {elev.fornavn_} {elev.efternavn_}");
                                
                            }
                        }
                    }
                    
                }
            }
        }

        public static void Elever()
        {
            Console.WriteLine("skriv den elev du skal finde info om:");
            Console.WriteLine("");
            string eleveroptions = null;
            try { eleveroptions = Console.ReadLine(); }
            catch (NullReferenceException)
            {
                Console.WriteLine("Denne linjie kan ikke være null, Prøv igen");
                System.Threading.Thread.Sleep(2500);
                Fag();
            }
            int rowsIn2DArray = H1.MyArray.GetLength(0);
            int columnCount = H1.MyArray.GetLength(1);

            for (int j = 0; j < rowsIn2DArray; j++)
            {
                for (int k = 0; k < columnCount; k++)
                {
                    if (k == 2)
                    {
                        List<Elever> item = (List<Elever>)H1.MyArray[j, k];
                        Elever matchelever = item.FirstOrDefault(elev => (elev.fornavn_ + " " + elev.efternavn_) == eleveroptions);
                        if (matchelever != null)
                        {
                            Console.WriteLine(H1.MyArray[j, 0]);
                            Console.WriteLine(H1.MyArray[j, 1]); 
                        }
                    }

                }
            }

        }


        public static void Lærer()
        {
            Console.Clear();
            Console.WriteLine("skriv den lærer du skal finde info om:");
            Console.WriteLine("");
            string læreroptions = null;
            try { læreroptions = Console.ReadLine(); }
            catch (NullReferenceException)
            {
                Console.WriteLine("Denne linjie kan ikke være null, Prøv igen");
                System.Threading.Thread.Sleep(2500);
                Fag();
            }
            int rowsIn2DArray = H1.MyArray.GetLength(0);
            int columnCount = H1.MyArray.GetLength(1);

            for (int j = 0; j < rowsIn2DArray; j++)
            {
                for (int k = 0; k < columnCount; k++)
                {
                    if (k == 1)
                    {
                        string item = H1.MyArray[j, k].ToString();
                        if (item == læreroptions)
                        {
                            Console.WriteLine(H1.MyArray[j, 0]);
                            List<Elever> elever = (List<Elever>)H1.MyArray[j, 2];
                            foreach (Elever elev in elever)
                            {
                                Console.WriteLine($"elev: {elev.fornavn_} {elev.efternavn_}");
                            }

                        }
                     
                    }

                }
            }
            Console.ReadKey();
        }
    }
}
