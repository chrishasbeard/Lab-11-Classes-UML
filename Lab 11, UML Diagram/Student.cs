using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11__UML_Diagram
{
    class Student : Person
    {
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public Student(string program, int year, double fee, string name, string address) : base(name, address)
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }

        public Student (string name, string address) : base(name, address)
        {

        }

        public override string ToString()
        {
            return base.ToString() + $"and is in {Program}, graduating in the class of {Year}, but still owes {Fee} dollars.";
        }

    }
}
