using System.Collections.Generic;
namespace Course.Entities
{
    class Employee
    {
        public string Name {get; set;}
        public int Hours {get; set;}
        public double ValuePorHour {get; set;}

        public Employee(){


        }

        public Employee(string name, int hours, double valuePorHours){

            Name = name;
            Hours = hours;
            ValuePorHour = valuePorHours;
        }

        public virtual double Payment(){
            return Hours * ValuePorHour;
        }
    }
}