using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            double[][] course = new double[3][];
            course[0] = new double[2] { 75.00, 80.00 };
            course[1] = new double[3] { 78.00, 82.00, 75.00 };
            course[2] = new double[1] { 85.00 };

            int courseR = 0, courseC ;
            double total = 0;     
            while (courseR<course.Length)
            {
                courseC = 0;
                while(courseC<course[courseR].Length)
                {
                    total += course[courseR][courseC];
                    courseC++;
                }
                courseR++;   
            }
            Console.WriteLine("Total Mark : {0}", total);
            double avg;
            avg = total / course.Length;
            Console.WriteLine("Avg Mark : {0}", avg);
        }
    }
}
