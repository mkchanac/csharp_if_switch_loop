using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6_3
{
    class Program
    {
        static void Main()
        {
            int[] number = new int[1000];
            int[] oddNumber = new int[1000];
            int oddCnt = 0;
            string result = "";

            Random num = new Random();

            for (int i = 0; i < 1000; i++)          //generate 1000 random number
            {
                number[i]=num.Next(100000);
            }

            for (int i = 0; i < 1000; i++)         //find the odd number and store in array oddNumber, and count the no. of odd number.
            {      
                if (number[i] % 2 == 1) 
                {
                    oddNumber[oddCnt] = number[i];
                    oddCnt++;
                }            
            }

            int[] displayOddNumber = new int[oddCnt];  //so we can create the array of Odd number which has the correct length.

            int i = 0;        

            foreach (int x in oddNumber)     //eliminate the value 0 in OddNumber array, copy to the New DisplayOddNumber array.
            {
                if (x > 0)
                {
                    displayOddNumber[i] = x;
                    i++;
                }
            }

            foreach (int x in displayOddNumber) 
            {
                string xS = Convert.ToString(x);
                result += xS + "\t";
            }

            MessageBox.Show(result, "Odd Number", MessageBoxButtons.OK, MessageBoxIcon.Information);


            string max = Convert.ToString(displayOddNumber.Max());
            string min = Convert.ToString(displayOddNumber.Min());


            MessageBox.Show(max, "Maximum Number in Odd Number Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(min, "Minimum Number in Odd Number Set", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
