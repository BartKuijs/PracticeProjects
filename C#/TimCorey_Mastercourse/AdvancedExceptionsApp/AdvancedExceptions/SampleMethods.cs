using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedExceptions
{
    public class SampleMethods
    {
        public static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling the SimpleMethod");
        }

        public static void DifferentMethod()
        {
            Console.WriteLine("This is the DifferentMethod working properly.");
        }

        public static void ComplexMethod(string name)
        {
            if (name.ToLower() == "tim")
            {
                throw new InsufficientMemoryException("Tim is to tall for this method. ");
            }
            else
            {
                throw new ArgumentException("This person isn't Tim. ");
            }
            
        }
    }
}
