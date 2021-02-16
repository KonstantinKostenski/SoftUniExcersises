using System;

namespace employee_data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string secondName = "Jonson";
            byte age = 27;
            char gender = 'f';
            long id = 8306112507;
            int employeeNumber = 27563571;
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {secondName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {id}");
            Console.WriteLine($"Unique Employee number: {employeeNumber}");

        }
    }
}
