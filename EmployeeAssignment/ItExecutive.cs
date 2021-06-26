using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
    class ItExecutive : Employee
    {
        private uint projectBonus;
        internal uint ProjectBonus
        {
            get { return this.projectBonus; }
            set { this.projectBonus = value; }
        }
        internal ItExecutive(string name, string id, DateOfBirth birthDate, JoinDate joiningDate, string bloodGroup, EmployeeAddress address, uint salary, uint projectBonus)
            : base(name,id,birthDate,joiningDate,bloodGroup,address,salary)
        {
            this.ProjectBonus = projectBonus;
        }
        internal override void PrintAllDetails()
        {
            base.PrintAllDetails();
            Console.WriteLine("Project bonus : {0} Tk", this.ProjectBonus);
        }
        internal override void TotalIncome()
        {
            Console.WriteLine("Income : {0}", this.Salary + this.ProjectBonus);
        }

    }
}
