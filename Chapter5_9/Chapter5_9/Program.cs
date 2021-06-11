using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapter5_9
{
    class Program
    {
        static void Main()
        {
            string inValue;
            double salesFigure, profitRatio, totalProfit;

            Write("Enter the sales figure ($): ");
            inValue = ReadLine();
            salesFigure = double.Parse(inValue);

            profitRatio = DetermineProfitRatio(salesFigure);
            totalProfit = ComputeTotalProfit(salesFigure,profitRatio);
            WriteLine("***************************************************");
            WriteLine("Summary of Organization Sales and Profit");
            DisplayResult(salesFigure,profitRatio,totalProfit);

            ReadKey();
        }
        public static double DetermineProfitRatio(double sF) 
        {
            double pF;
            
            if (sF < 0) 
            {
                pF = 0;
                WriteLine("Invalid sales figure. 0 is stored in Profit Ratio");
            }
                
            else
                if (sF < 1000.01)
                pF = 3.0 / 100;
            else
                if (sF < 5000.01)
                pF = 3.5 / 100;
            else
                if (sF <= 10000)
                pF = 4.0 / 100;
            else
                pF = 4.5 / 100;

            return pF;
        }

        public static double ComputeTotalProfit(double sF,double pF) 
        {
            double tP;

            tP = sF * pF;

            return tP;
        }

        public static void DisplayResult(double sF, double pR, double tP) 
        {
            WriteLine("Sales Figure: {0:C2}", sF);
            WriteLine("Profit Ratio: {0:P1}", pR);
            WriteLine("Total Profit: {0:C2}", tP);
        
        }

    }
}
