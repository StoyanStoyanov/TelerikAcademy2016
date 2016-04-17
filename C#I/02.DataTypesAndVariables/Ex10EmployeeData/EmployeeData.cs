namespace Ex10EmployeeData
{
    /* 10. A marketing company wants to keep record of its employees. Each record would have the following characteristics:
        First name
        Last name
        Age (0...100)
        Gender (m or f)
        Personal ID number (e.g. 8306112507)
        Unique employee number (27560000…27569999)
        Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
    */

    using System;

    public class EmployeeData
    {
        static void Main()
        {
            string firstName = "Pesho";
            string lastName = "Peshov";
            byte age = 55;
            char gender = 'm';
            ulong personalID = 8306112507;
            uint uniqueEmpoyeeNumber = 27569999;

            Console.WriteLine("Employee first name: {0}", firstName);
            Console.WriteLine("Employee last name: {0}", lastName);
            Console.WriteLine("Employee age: {0}", age);
            Console.WriteLine("Employee gender: {0}", gender);
            Console.WriteLine("Employee personal ID: {0}", personalID);
            Console.WriteLine("Employee unique number: {0}", uniqueEmpoyeeNumber);
        }
    }
}
