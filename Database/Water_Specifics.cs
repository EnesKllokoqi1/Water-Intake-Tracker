using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class Water_Specifics
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public  int DayIdentifierId { get; set; }
        public double Milliliters { get; set; }

        public DayIdentifier DayIdentifier { get; set; }
      

    }
}
