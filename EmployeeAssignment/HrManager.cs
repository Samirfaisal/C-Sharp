using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
    class HrManager: Employee
    {
        private uint kpi;
        internal uint Kpi
        {
            get { return this.kpi; }
            set { this.kpi = value; }
        }
        internal HrManager(string name, string id, DateOfBirth birthDate, JoinDate joiningDate, string bloodGroup, EmployeeAddress address, uint salary,uint kpi)
            : base(name, id, birthDate, joiningDate, bloodGroup, address, salary)
        {
            this.Kpi = kpi;
        }
        internal override void PrintAllDetails()
        {
            base.PrintAllDetails();
            Console.WriteLine("Kpi : {0} Tk", this.Kpi);
        }
        internal override void TotalIncome()
        {
            Console.WriteLine("Income : {0}", this.Salary + this.Kpi);
        }
    }
}
