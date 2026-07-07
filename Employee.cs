using System;

// Define the Employee class.
public class Employee
{
    // Property to store the employee's ID.
    public int Id { get; set; }

    // Property to store the employee's first name.
    public string FirstName { get; set; }

    // Property to store the employee's last name.
    public string LastName { get; set; }

    // Overload the == operator to compare Employee objects by their Id.
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if both references point to the same object.
        if (ReferenceEquals(emp1, emp2))
            return true;

        // Check if either object is null.
        if (emp1 is null || emp2 is null)
            return false;

        // Compare the Id properties.
        return emp1.Id == emp2.Id;
    }

    // Overload the != operator.
    // Comparison operators must always be overloaded in pairs.
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    // Override Equals to match the == operator.
    public override bool Equals(object obj)
    {
        if (obj is Employee employee)
        {
            return this.Id == employee.Id;
        }

        return false;
    }

    // Override GetHashCode whenever Equals is overridden.
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
