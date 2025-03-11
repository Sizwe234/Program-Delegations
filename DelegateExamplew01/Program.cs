using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamplew01
{
   public class Program
    {
        // define a delegate
        public delegate int MathOperations(int a, int b);

        // Define methods that match delegate signature
        public static int Add(int a, int b) => a + b;

        public static int Subtract(int a, int b) => a - b;  // Push To GitHub
        
        public static void Main()
        {
            // Assign methods to delegate
            MathOperations operation = Add;
            Console.WriteLine("Addition: "+ operation(5,3));

            operation = Subtract;
            Console.WriteLine("Subtraction: "+ operation(5,3));
        }
    }
}
