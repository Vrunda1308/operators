using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MethodClassAssignment.Utilities
{
    // Define a class named 'SimpleMath'
    public class SimpleMath
    {
        // A void method that performs a math operation on the first integer and displays the second integer
        public void PerformOperation(int num1, int num2)
        {
            // Example math operation (addition)
            int result = num1 + 10;
            // Display the second integer
            Console.WriteLine("The second integer is: " + num2);
            // Optionally display the result of the operation
            Console.WriteLine("Result of num1 + 10 is: " + result);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the SimpleMath class
            SimpleMath math = new SimpleMath();

            // Call the method with positional parameters
            math.PerformOperation(5, 3);

            // Call the method specifying the parameters by name
            math.PerformOperation(num1: 15, num2: 8);
        }
    }
}