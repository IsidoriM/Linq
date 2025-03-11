using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Phone[] Phones { get; set; }
    }
}
