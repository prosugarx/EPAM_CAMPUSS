using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_CAMPUSS
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Fibonacci Sequence Generator Class
            var fibonacciGenerator = new FibonacciSequenceGenerator(0, 1);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(fibonacciGenerator.GetNext());
            }

            //  Integer Sequence Generator Class
            var integerGenerator = new IntegerSequenceGenerator(1, 2);
             Console.WriteLine(" Integer Sequence Generator Class:");
             for (int i = 0; i < 10; i++) 
             {
                Console.WriteLine(integerGenerator.GetNext());
             }

            // Double Sequence Generator Class
            var doubleGenerator = new DoubleSequenceGenerator(0.0, 1.0);
             Console.WriteLine("\nDouble Sequence Generator Class:");
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(doubleGenerator.GetNext());
            }



            // Char Sequence Generator Class
            var charGenerator = new CharSequenceGenerator('A', 'A');
                Console.WriteLine("Previous: " + charGenerator.Previous); // 'A'
                Console.WriteLine("Current: " + charGenerator.Current);  // 'B'
                Console.WriteLine("Char Sequence Generator Class:");
                for (int i = 0; i < 10; i++) 
                {
                    Console.WriteLine(charGenerator.GetNext());
                }

            // Generic Sequence Generator Class With Delegate
            var delegateGenerator = new DelegateSequenceGenerator<int>(1, 2, (prev, curr) => 6 * curr - 8 * prev);
                Console.WriteLine("\nGeneric Sequence Generator Class With Delegate:");
                for (int i = 0; i < 10; i++) 
                {
                    Console.WriteLine(delegateGenerator.GetNext());
                }
         
        }
    }
}
