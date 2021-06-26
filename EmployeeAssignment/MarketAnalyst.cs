using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
    class MarketAnalyst : Employee
    {
        private uint commission;
        internal uint Commission
        {
            get { return this.commission; }
            set { this.commission = value; }
        }
        internal MarketAnalyst(string name, string id, DateOfBirth birthDate, JoinDate joiningDate, string bloodGroup, EmployeeAddress address, uint salary, uint commission)
            : base(name, id, birthDate, joiningDate, bloodGroup, address, salary)
        {
            this.Commission = commission;
        }
        internal override void PrintAllDetails()
        {
            base.PrintAllDetails();
            Console.WriteLine("Commission : {0} Tk", this.Commission);
        }
        internal override void TotalIncome()
        {
            Console.WriteLine("Income : {0}", this.Salary + this.Commission);
        }
    }
}
