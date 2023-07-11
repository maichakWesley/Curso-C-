using Course.Entities;
using System.Collections.Generic;

using System;

namespace Course.Entities
{
    class Worker
    {
        public string Name {get; set;}
        public WorkerLevel Level {get; set;}
        public double BadeSalary {get; set;}
        public Department Department {get; set;}
        public List<HourContract> Contracts {get; set;} = new List<HourContract>();

        public Worker(){

        }

        public Worker(string name, WorkerLevel level, double badeSalary, Department department){

            Name = name;
            Level = level;
            BadeSalary = badeSalary;
            Department = department;

        }

        public void AddContract(HourContract contract){
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract){
            Contracts.Remove(contract);
        }

        public double Income(int year, int month){
            double sum = BadeSalary;

            foreach(HourContract contract in Contracts){
                if(contract.Date.Year == year && contract.Date.Month == month){
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }


    }
}