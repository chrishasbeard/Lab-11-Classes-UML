using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11__UML_Diagram
{
    class Staff : Person
    {
        private string School { get; set; }
        private double Pay { get; set; }

        public Staff (string school, double pay, string name, string address) : base(name, address)
        {
            this.School = school;
            this.Pay = pay;
        }

        public Staff (string name, string address) : base(name, address) 
        {

        }

        public override string ToString()
        {
            return base.ToString() + $" is part of the staff at {School}, and will make {Pay} per year.";
        }
    }
}
