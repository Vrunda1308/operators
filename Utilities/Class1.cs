using System;

// Define the Employee class with Id, FirstName, and LastName properties
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the '==' operator to compare Employee objects by their Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        return emp1.Id == emp2.Id;
    }

    // Overload the '!=' operator to compare Employee objects by their Id
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return emp1.Id != emp2.Id;
    }

    // Override the Equals method to use our new '==' operator logic
    public override bool Equals(object obj)
    {
        if (obj is Employee other)
        {
            return this == other;
        }
        return false;
    }

    // Override GetHashCode method to allow a type to work correctly in a hash table
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
