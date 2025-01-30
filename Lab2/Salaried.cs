using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Salaried: Employee
    {
        //private data
        private double salary;

        public double Salary { get { return salary; } }

        public Salaried() { }
        public Salaried(string id, string name, string address, string phone, long sin, string dateofBirth, string department, double salary):
            base(id, name, address, phone, sin, dateofBirth, department)
        {
            this.salary = salary;
        }
        public override double CalculatePay()
        {
            return salary;

        }

        public override string ToString() 
        {
            return $"Salary Employee: {Name}";
        }
    }
}
