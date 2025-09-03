using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database
{
  
    public class DayIdentifier
    {
        public int Id { get; set; }
        public string DayName { get; set; }
        public IList<Water_Specifics> Water_Specifics { get; set; }
    }
}
