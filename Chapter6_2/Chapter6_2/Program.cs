using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter6_2
{
    class Program
    {
        static void Main()
        {
            string inValue;
            double cost;
            double retailprice;
            Write("Enter the wholesale item price($): ");
            inValue = ReadLine();
            cost = double.Parse(inValue);
            Write("Mark up %\tRetail Price ");
            for (double i = 0.05; i < 0.10; i+=0.01) 
            {
                retailprice = cost * (1 + i);

                Write("\n{0:P}\t\t{1:C2}", i, retailprice);           
            
            }

            ReadKey();

        }
    }
}
