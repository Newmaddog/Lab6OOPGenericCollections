using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6OOPGenericCollections
{
    internal class Employee
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal string Gender { get; set; }
        internal double Salary { get; set; }

        public Employee(int id, string name, string gender, double salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"ID: {Id} \nName: {Name} \nGender: {Gender} \nSalary{Salary}";
        }
    }
}
