using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EmployeeAssignment
{
    struct DateOfBirth
    {
        private byte dateDay;
        private byte dateMonth;
        private uint dateYear;

        internal byte DateDay
        {
            get { return this.dateDay; }
            set { this.dateDay = value; }
        }
        internal byte DateMonth
        {
            get { return this.dateMonth; }
            set { this.dateMonth = value; }
        }
        internal uint DateYear
        {
            get { return this.dateYear; }
            set { this.dateYear = value; }
        }
        internal DateOfBirth(byte dateDay, byte dateMonth, uint dateYear)
        {
            this.dateYear = dateYear;
            this.dateDay = dateDay;
            this.dateMonth = dateMonth;

        }
        internal void ShowAllDetails()
        {
            Console.WriteLine("Date of birth : {0} - {1} - {2}", this.dateDay, this.dateMonth, this.dateYear);
        }
    }
    struct JoinDate
    {
        private byte day;
        private byte month;
        private uint year;
        internal byte Day
        {
            get { return this.day; }
            set { this.day = value; }
        }
        internal byte Month
        {
            get { return this.month; }
            set { this.month = value; }
        }
        internal uint Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
        internal JoinDate(byte day, byte month, uint year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        internal void AllDetails()
        {
            Console.WriteLine("Joining Date : {0} - {1} - {2}", this.Day, this.Month, this.Year);
        }
    }

    struct EmployeeAddress
    {
        private string thana;
        private string homeDistrict;
        private string phoneNo;
        internal string Thana
        {
            get { return this.thana; }
            set { this.thana = value; }
        }
        internal string HomeDistrict
        {
            get { return this.homeDistrict; }
            set { this.homeDistrict = value; }
        }
        internal string PhoneNo
        {
            get { return this.phoneNo; }
            set { this.phoneNo = value; }
        }
        internal EmployeeAddress(string thana, string homeDistrict, string phoneNo)
        {
            this.thana = thana;
            this.homeDistrict = homeDistrict;
            this.phoneNo = phoneNo;
        }
        internal void Details()
        {
            Console.WriteLine("Thana : {0}", this.Thana);
            Console.WriteLine("District : {0}", this.HomeDistrict);
            Console.WriteLine("Phone No : +088 {0}", this.PhoneNo);
        }
    }
    class Employee
    {
        private string name;
        private string id;
        private DateOfBirth birthDate;
        private JoinDate joiningDate;
        private string bloodGroup;
        private EmployeeAddress address;
        private uint salary;
        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        internal string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        internal DateOfBirth BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }
        internal JoinDate JoiningDate
        {
            get { return this.joiningDate; }
            set { this.joiningDate = value; }
        }
        internal string BloodGroup
        {
            get { return this.bloodGroup; }
            set { this.bloodGroup = value; }
        }
        internal EmployeeAddress Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        internal uint Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
        internal Employee(string name, string id, DateOfBirth birthDate, JoinDate joiningDate, string bloodGroup, EmployeeAddress address, uint salary)
        {
            this.Name = name;
            this.Id = id;
            this.BirthDate = birthDate;
            this.JoiningDate = joiningDate;
            this.BloodGroup = bloodGroup;
            this.Address = address;
            this.Salary = salary;
        }
        internal virtual void PrintAllDetails()
        {
            Console.WriteLine("Name : {0}", this.Name);
            Console.WriteLine("Id No : {0}", this.Id);
            this.birthDate.ShowAllDetails();
            this.joiningDate.AllDetails();
            Console.WriteLine("Blood Group : {0}", this.BloodGroup);
            this.address.Details();
            Console.WriteLine("Salary : {0} Tk", this.Salary);
        }
        internal virtual void TotalIncome()
        {
            Console.WriteLine("Income : {0}", this.Salary);
        }
    }
}
