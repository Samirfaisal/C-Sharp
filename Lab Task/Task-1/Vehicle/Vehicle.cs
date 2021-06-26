using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        private string registrationNo;
        private string regristrationDate;
        private string vechicleColor;
       
        public string GetRegistrationNo()
        {
            return this.registrationNo;
        }
        public void SetRegistrationNo(string registrationNo)
        {
            this.registrationNo = registrationNo;
        }
        public string GetDate()
        {
            return this.regristrationDate;
        }
        public void SetDate(string regristrationDate)
        {
            this.regristrationDate = regristrationDate;
        }
        public string GetColor()
        {
            return this.vechicleColor;
        }
        public void SetColor(string vechicleColor)
        {
            this.vechicleColor = vechicleColor;
        }
       

        public Vehicle()
        {

        }
        public Vehicle(string registrationNo, string regristrationDate, string vechicleColor)
        {
            this.SetRegistrationNo(registrationNo);
            this.SetDate(regristrationDate);
            this.SetColor(vechicleColor);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Registration no : {0}", this.GetRegistrationNo());
            Console.WriteLine("Registration date : {0} ", this.GetDate());
            Console.WriteLine("Vehicle color : {0}", this.GetColor());
            
        }
    }
}
