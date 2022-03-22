using System;

namespace ExpressionBody
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    // the logic for any supported members such as a method or property consists of a single expression
    // member => expression  
    // Method Body Expresstion
    public class Employee
    {
        private string FirstName;
        private string LastName;
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string GetFullName() => $"{FirstName} {LastName}";
        public override string ToString() => $"{FirstName} {LastName}";
        public void DisplayName() => Console.WriteLine(GetFullName());
    }
    // constractor Body extression
    public class Location
    {
        private string locationName;
        public Location(string name) => locationName = name;
        public string Name
        {
            get => locationName;
            set => locationName = value;
        }
    }
    // Destractor Body Expression
    public class Destroyer
    {
        public override string ToString() => GetType().Name;
        ~Destroyer() => Console.WriteLine($"The {ToString()} destructor is executing.");
    }

    // Property get Body Expresion
    public class Position
    {
        private string PositionName;
        public Position(string name) => PositionName = name;
        public string Name
        {
            get => PositionName;
            set => PositionName = value;
        }
    }

    // Read-only properties Body Expression
    public class Post
    {
        private string PostName;
        public Post(string name) => PostName = name;
        public string Name => PostName;
    }

    // Property set Expression Bodied

    public class Customer
    {
        private string CustomerName;
        public Customer(string name) => CustomerName = name;
        public string Name
        {
            get => CustomerName;
            set => CustomerName = value;
        }
    }


    // Limitations
    //The Expression bodied members in C# don’t support a block of code like (if , while ,for , do , ...)

}
