using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {           
            Employee[] employeeArr = new Employee[4];
            employeeArr[0] = new ItExecutive("Tailor", "E-0001", new DateOfBirth(06, 09, 1990), new JoinDate(11, 03, 2017), "AB+", new EmployeeAddress("Bogura Sadar", "Bogura", "01619252319"), 35000, 7500);
            employeeArr[1] = new HrManager("Miran", "E-0002", new DateOfBirth(16, 05, 1996), new JoinDate(12, 05, 2019), "B+", new EmployeeAddress("Cumilla", "Cumilla", "01734526255"), 25000, 2500);
            employeeArr[2] = new MarketAnalyst("Abrar", "E-0003", new DateOfBirth(03, 12, 1990), new JoinDate(25, 11, 2018), "O+", new EmployeeAddress("Khulna Sadar", "Khulna", "01893526273"), 45000, 8500);
            employeeArr[3] = new PartTimer("Reza", "E-0004", new DateOfBirth(14, 01, 1998), new JoinDate(18, 01, 2020), "AB+", new EmployeeAddress("Batara", "Dhaka", "01378492273"), 10000);

            Console.WriteLine("********************* Employee Details *************************");
            Console.WriteLine();
            byte temp = 0;
            while(temp<employeeArr.Length)
            {
                employeeArr[temp].PrintAllDetails();
                employeeArr[temp].TotalIncome();
                Console.WriteLine();
                temp++;
            }           
        }
    }
}
