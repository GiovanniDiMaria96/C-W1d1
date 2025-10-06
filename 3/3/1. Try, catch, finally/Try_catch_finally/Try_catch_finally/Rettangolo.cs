using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_catch_finally
{
    public class Rettangolo
    {
        public int Base { get; set; }
        public int Altezza { get; set; }
        public int Area()
        {
            return Base * Altezza / 2;
        }
    }
}
