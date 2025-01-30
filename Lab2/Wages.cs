using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Wages: Employee
    {
        private double rate;
        private double hours;

        public double Rate { get { return rate; } }
        public double Hours { get { return hours; } }

        public Wages() { }

        public Wages(string id, string name, string address, string phone, long sin, string dateofBirth, string department, double rate, double hours) :
            base(id, name, address, phone, sin, dateofBirth, department)
        {
            this.rate = rate;
            this.hours = hours;
        }

        public override double CalculatePay()
        {
            double overtime = 0;
            if (hours > 40)
            {
                double overtimeHours = hours - 40;
                overtime = rate * overtimeHours * 1.5;
            }
            return rate* hours + overtime;
        }
               
        }
           
        
    }

