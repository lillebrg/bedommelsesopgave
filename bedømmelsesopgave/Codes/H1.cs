using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bedømmelsesopgave.Codes
{

    public class H1
    {
        public static object[,] MyArray { get; set; }

        static H1()
        {
             List<Elever> GrundElever = new List<Elever>()
             {
                    new Elever() { elevid_ = 001, fornavn_ = "Hans", efternavn_ = "Knudsen", telefonnr_ = 24583322 },
                    new Elever() { elevid_ = 002, fornavn_ = "kasper", efternavn_ = "ravn", telefonnr_ = 24583322 },
                    new Elever() { elevid_ = 003, fornavn_ = "daniel", efternavn_ = "maillet", telefonnr_ = 24583322 }
             };

             List<Elever> DataElever = new List<Elever>()
             {
                    new Elever() { elevid_ = 004, fornavn_ = "Hans", efternavn_ = "Knudsen", telefonnr_ = 24583322 },
                    new Elever() { elevid_ = 005, fornavn_ = "Aske", efternavn_ = "Flamer", telefonnr_ = 24563322 },
                    new Elever() { elevid_ = 006, fornavn_ = "kasper", efternavn_ = "ravn", telefonnr_ = 24583322 },
                    new Elever() { elevid_ = 007, fornavn_ = "daniel", efternavn_ = "maillet", telefonnr_ = 24583322 }
             };

             List<Elever> Studieteknik = new List<Elever>()
             {
                    new Elever() { elevid_ = 008, fornavn_ = "Hans", efternavn_ = "Knudsen", telefonnr_ = 24583322 },
                    new Elever() { elevid_ = 009, fornavn_ = "åge", efternavn_ = "madsen", telefonnr_ = 24522322 },
                    new Elever() { elevid_ = 010, fornavn_ = "kasper", efternavn_ = "ravn", telefonnr_ = 24583322 },
                    new Elever() { elevid_ = 011, fornavn_ = "daniel", efternavn_ = "maillet", telefonnr_ = 24583322 }
             };

                MyArray = new object[,]
                {
                    {"Grundlæggende programmering","Niels",GrundElever, new int[] { 3, 4 } },

                    {"Database programmering","Henrik",DataElever, new int[] { 5 } },

                    {"Studieteknik","John", Studieteknik, new int[] { 6 } },
                };
        }
    }
}




//string fag = "Grundlæggende programmering";
//string lærer = "Niels";
//List <Students> elever = ElevId, ForNavn, EfterNavn, TelefonN;
//    int[] ugeNr = new int[] { 3, 4 };