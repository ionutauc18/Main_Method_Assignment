using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class MainMethod
    {
        // First method that takes an integer
        public int numResult(int number)
        {
            return number + 20;
        }

        // Second method that takes a decimal
        public int numResult(decimal number)
        {
            // Converting the decimal in to a integer
            int numInt = Convert.ToInt32(number);
            // Performing a math operation with the converted decimal
            return numInt * 1;
        }

        // Third method using a string
        public int numResult(string number)
        {
            // converting the string in to a integer
            int numInt = Convert.ToInt32(number);
            return numInt % 24;
        }
    }
}
