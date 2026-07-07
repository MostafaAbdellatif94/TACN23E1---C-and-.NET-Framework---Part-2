using System;

// Main program class.
class Program
{
    // Entry point of the application.
    static void Main(string[] args)
    {
        // Create the first Employee object.
        Employee employee1 = new Employee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe"
        };

        // Create the second Employee object.
        Employee employee2 = new Employee
        {
            Id = 1,
            FirstName = "Jane",
            LastName = "Smith"
        };

        // Compare the two Employee objects using the overloaded == operator.
        bool areEqual = employee1 == employee2;

        // Display the comparison result.
        Console.WriteLine("Are the employees equal? " + areEqual);

        // Pause the console window.
        Console.ReadLine();
    }
}
