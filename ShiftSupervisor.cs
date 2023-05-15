using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_Data
{
    internal class ShiftSupervisor : Employee
    {
        public ShiftSupervisor(string name, int number, decimal annualSalary, decimal annualBonus) : base(name, number)
        {
            AnnualSalary = annualSalary;
            AnnualBonus = annualBonus;
        }

        public decimal AnnualSalary { get; set; }
        public decimal AnnualBonus { get; set; }
    }
}
