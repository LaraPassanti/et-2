using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace età_2
{
    internal class Persona
    {
        public DateTime datadinascita { get; set; }


        public int Età()
        {
            DateTime oggi = DateTime.Today;
            if(oggi.Month < datadinascita.Month) { return oggi.Year - datadinascita.Year -1 ;  }
            if(oggi.Month > datadinascita.Month) { return oggi.Year - datadinascita.Year ; }
            else 
            {
                if(oggi.Day > datadinascita.Day || oggi.Day==datadinascita.Day) { return oggi.Year - datadinascita.Year; }
                else { return oggi.Year - datadinascita.Year - 1; }
            }
            
        }
    }
}
