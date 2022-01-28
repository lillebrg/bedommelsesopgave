using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bedømmelsesopgave.Codes
{
    internal interface IHovedForløb
    {
        public object [,] CourseInfo { get; set; }
        public record SearchResult(object obj1, object obj2);
    }
}
