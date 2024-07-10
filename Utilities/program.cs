using System;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate two objects of the Employee class
        Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" };

        // Compare the two Employee objects using the overloaded '==' operator
        bool areEqual = emp1 == emp2;

        // Display the result of the comparison
        Console.WriteLine("Are both employees equal? " + areEqual);
    }
}
