using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAndReturnValues
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator calc = new SimpleCalculator();
           
            Console.WriteLine(calc.FindMaxOfThree(3,4,5));
            Console.ReadLine();
        }
    }
}
