using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class PartTime: Employee
    {
        private double rate;
        private double hours;

        public double Rate { get { return rate; } }
        public double Hours {  get { return hours; } }

        public PartTime() { }

        public PartTime(string id, string name, string address, string phone, long sin, string dateofBirth, string department, double rate, double hours):
            base(id, name, address,  phone, sin,  dateofBirth, department)
        {
            this.rate = rate;
            this.hours = hours;
        }
        

        }
    }

