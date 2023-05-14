using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_Data
{
    internal class ProductionWorker: Employee
    {
        public ProductionWorker(string name, int number, int shiftNumber, decimal hourlyPay) : base(name, number)
        {
            ShiftNumber = shiftNumber;
            HourlyPay = hourlyPay;
        }

        public int ShiftNumber { get; set; }

        public decimal HourlyPay { get; set; }
    }
}
