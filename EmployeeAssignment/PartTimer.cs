using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
    class PartTimer : Employee
    {
        internal PartTimer(string name, string id, DateOfBirth birthDate, JoinDate joiningDate, string bloodGroup, EmployeeAddress address, uint salary)
            : base(name, id, birthDate, joiningDate, bloodGroup, address, salary)
        {
            
        }
        internal override void PrintAllDetails()
        {
            base.PrintAllDetails();
        }
    }
}
