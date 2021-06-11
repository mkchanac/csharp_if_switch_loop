using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter5_10
{
    class Program
    {
        static void Main()
        {
            const double GallonToLiter = 3.7854;
            string inValue;
            double cPriceL, aPriceL;
            Write("Enter the gas price at Canadian Fuel ($ per liter): ");
            inValue = ReadLine();
            cPriceL = double.Parse(inValue);
            Write("Enter the gas price at American Fuel ($ per gallon): ");
            inValue = ReadLine();
            aPriceL = double.Parse(inValue) / GallonToLiter;
            WriteLine("------------------------------------------------------------------------------------------------------------");

            if (aPriceL > cPriceL) 
            {
                Write("Canadian Fuel is cheaper. The price of Canadian is {0:C3} per liter, price for American is {1:C3} per liter.", cPriceL, aPriceL);
            }
            else
                Write("American Fuel is cheaper. The price of American is {0:C3} per liter, price for Candian is {1:C3} per liter.", aPriceL, cPriceL);


            ReadKey();
        }
    }
}
