using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter6_8
{
    class Program
    {
        static void Main()
        {
            string moreTriangle="";
            string inValue;
            int fline, sline, tline; 
            do
            {
                Write("Enter the first segment length <integer>: ");
                inValue = ReadLine();
                while (int.TryParse(inValue, out fline) == false) 
                {
                    Write("Invalid entry, please re-enter the first segment length <integer>: ");
                    inValue = ReadLine();
                }

                Write("Enter the second segment length <integer>: ");
                inValue = ReadLine();
                while (int.TryParse(inValue, out sline) == false)
                {
                    Write("Invalid entry, please re-enter the second segment length <integer>: ");
                    inValue = ReadLine();
                }

                Write("Enter the third segment length <integer>: ");
                inValue = ReadLine();
                while (int.TryParse(inValue, out tline) == false)
                {
                    Write("Invalid entry, please re-enter the third segment length <integer>: ");
                    inValue = ReadLine();
                }
                WriteLine();

                if (fline + sline >= tline && sline + tline >= fline && fline + tline >= sline)
                            Write("The given length {0}, {1}, {2} of three segments can form a triangle.", fline, sline, tline);
                        else
                            Write("It does not form a triangle.");

                WriteLine();
                WriteLine("\nDo you want another combination for the triangle? <Y or N> ");
                moreTriangle = ReadLine();
                WriteLine();

            }
            while (moreTriangle == "Y" || moreTriangle =="y");


        }
    }
}
