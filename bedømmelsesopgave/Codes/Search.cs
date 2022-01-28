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
            Console.Clear();
            Console.WriteLine("skriv det fag du skal bruge data til");
            Console.WriteLine("");
            Console.WriteLine("muligheder:");
            Console.WriteLine("");
            Console.WriteLine("-Grundlæggende programmering");
            Console.WriteLine("-Database programmering");
            Console.WriteLine("-Studieteknik");
            try { string fagoptions = Console.ReadLine(); }
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
                    string item = H1.MyArray[j, k].ToString();
                    Console.WriteLine(item);
                }
            }
        }

        public static void Elever()
        {
            Console.Clear();
            Console.WriteLine("skriv den elev du skal finde info om:");
            Console.WriteLine("");
           

        }


        public static void Lærer()
        {
            Console.Clear();
            Console.WriteLine("skriv den lærer du skal finde info om:");
            Console.WriteLine("");

        }
    }
}
