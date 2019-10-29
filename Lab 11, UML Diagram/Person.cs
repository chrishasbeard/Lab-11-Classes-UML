using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11__UML_Diagram
{
    class Person
    {
        private string Name { get; set; }
        private string Address { get; set; }

        public Person(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        public Person()
        {

        }

        public override string ToString()
        {
            return ($"{Name} lives at {Address}");
        }
    }
}
