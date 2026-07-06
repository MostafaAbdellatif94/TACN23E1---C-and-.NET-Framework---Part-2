using System;

// Define an interface named IQuittable.
// Any class that implements this interface must provide a Quit() method.
public interface IQuittable
{
    // Declare a method that returns no value.
    void Quit();
}

// Define the Employee class.
// This class implements the IQuittable interface.
public class Employee : IQuittable
{
    // Property to store the employee's first name.
    public string FirstName { get; set; }

    // Property to store the employee's last name.
    public string LastName { get; set; }

    // Property to store the employee's ID.
    public int Id { get; set; }

    // Implement the Quit() method required by the interface.
    public void Quit()
    {
        Console.WriteLine($"{FirstName} {LastName} has resigned from the company.");
    }
}

// Main program class.
class Program
{
    // Entry point of the application.
    static void Main(string[] args)
    {
        // Create an Employee object using the interface type.
        // This demonstrates polymorphism.
        IQuittable employee = new Employee
        {
            FirstName = "John",
            LastName = "Doe",
            Id = 101
        };

        // Call the Quit() method through the interface reference.
        employee.Quit();

        // Pause the console window until the user presses Enter.
        Console.ReadLine();
    }
}
