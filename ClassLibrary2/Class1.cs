using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public interface  IProperyUpdaters : INotifyPropertyChanged
    {
         string Day_Name { get; set; }
    
         bool TextBoxProperty { get; set; }
     
    }
}
