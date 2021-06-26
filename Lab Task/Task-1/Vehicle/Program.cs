using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle oneVehicle = new Vehicle();
            oneVehicle.SetRegistrationNo("1223");
            oneVehicle.SetDate("25 March, 2001");
            oneVehicle.SetColor("Red");
            oneVehicle.PrintInfo();

            Console.WriteLine();

            Vehicle twoVehicle = new Vehicle("2204", "11 August, 2007", "Blue");
            twoVehicle.PrintInfo();
        }
    }
}
