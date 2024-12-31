using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_OOP
{
    internal interface IOsoba
    {
        string imie { get; set; }
        string nazwisko { get; set; }
        string zwrocPelnaNazwe();    
}
}
