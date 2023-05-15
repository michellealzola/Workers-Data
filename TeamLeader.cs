using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers_Data
{
    internal class TeamLeader : ProductionWorker
    {
        public TeamLeader(string name, int number, int shiftNumber, decimal hourlyPay, decimal monthlyBonus, int trainigHoursRequired, int trainingHoursActual ) : base(name, number, shiftNumber, hourlyPay)
        {
            MonthlyBonus = monthlyBonus;
            TrainingHoursRequired = trainigHoursRequired;
            TrainingHoursActual = trainingHoursActual;
        }

        public decimal MonthlyBonus { get; set; }

        public decimal TrainingHoursRequired { get; set;}

        public decimal TrainingHoursActual { get; set; }
    }
}
