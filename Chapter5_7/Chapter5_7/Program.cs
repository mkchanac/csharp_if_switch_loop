using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter5_7
{
    class Program
    {
        static void Main()
        {
            string inValue;
            int monthN = 0;
            Write("Enter the Month Number <1-12>: ");
            inValue = ReadLine();
            if (int.TryParse(inValue, out monthN) == false || monthN < 1 || monthN >12) 
            {
                WriteLine("Invalid entry. 0 is stored as Month number and Day of Month.");
            }
            Month CMK = new Month(monthN);

            WriteLine(CMK);
            ReadKey();

        }
    }
}
