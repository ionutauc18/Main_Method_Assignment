using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instatiate the MainMethod class
            MainMethod result = new MainMethod();
            // Calling first method that has a integer parameter
            Console.WriteLine(result.numResult(18));
            // Calinng second method that has a decimal parameter
            Console.WriteLine(result.numResult(5.1m));
            // Calling third method that has a string parameter
            Console.WriteLine(result.numResult("1992"));
            Console.ReadLine();
        }
        
    }
}
