using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Task_WPF
{
    public enum Categories
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string Name { get; set; }
        public int Prise { get; set; }
        public int Image { get; set; }
        public Categories Category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
