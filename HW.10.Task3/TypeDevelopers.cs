using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Task3
{
    class TypeDevelopers
    {
        private protected string _developerType;
        private protected int _salary;
        const int standartSalary = 500;
        public string DeveloperType { get; set; }
        public TypeDevelopers()
        {
            _developerType = DeveloperType;
        }
        public int GetSalary(string DeveloperType)
        {
            switch (DeveloperType)
            {
                case "Junior":
                    _developerType = "Junior";
                    _salary = standartSalary;
                    break;
                case "Middle":
                    _developerType = "Middle";
                    _salary = standartSalary * 3;
                    break;
                case "Senior":
                    _developerType = "Senior";
                    _salary = standartSalary * 5 + 300;
                    break;
                case "Team Leader":
                    _developerType = "Team Leader";
                    _salary = standartSalary * 8 + standartSalary;
                    break;
                case "Architect":
                    _developerType = "Architect";
                    _salary = standartSalary * 12 + standartSalary * 2;
                    break;
            }
            return _salary;
        }
        public override string ToString()
        {
            return $"{_developerType}";
        }
    }
}
