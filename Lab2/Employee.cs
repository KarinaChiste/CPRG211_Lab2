using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Employee
    {
        //private data
        private string id;
        private string name;
        private string address;
        private string phone;
        private long sin;
        private string dateOfBirth;
        private string department;

        //public property
        public string Id { get { return id; } }
        public string Name { get { return name; } }


        //constructor 
        public Employee() { }
        public Employee(string id, string name, string address, string phone, long sin, string dateofBirth, string department)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dateOfBirth = dateofBirth;
            this.department = department;

        }

        public override string ToString()
        {
            return $"ID: {id} Name:{name}";
        }

        public virtual double CalculatePay() {  return 0 ; }
    }
}
