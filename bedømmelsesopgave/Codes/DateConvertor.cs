using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bedømmelsesopgave.Codes
{
    internal struct DateConvertor
    {
        public int AntalDage { get; set; }
        

        public DateConvertor(DateTime slut){

            //TimeSpan ts = slut - DateTime.Now;
            TimeSpan ts = slut - DateTime.Now;
            AntalDage = ts.Days;

        }
        
    }
}
