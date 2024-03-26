using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfItemsControlsApp
{
    internal class Employee
    {
        public string Name { get; set; } = "";
        public int Age { set; get; }

        public override string ToString()
        {
            return $"{Name} ({Age})";
        }
    }
}
