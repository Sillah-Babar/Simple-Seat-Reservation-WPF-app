using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppProject
{
    [Serializable()]
    class seats
    {
        public int value { get; set; }
        public string name { get; set; }
        public seats(int z, String n)
        {
            value = z;
            name = n;
        }
    }
}
