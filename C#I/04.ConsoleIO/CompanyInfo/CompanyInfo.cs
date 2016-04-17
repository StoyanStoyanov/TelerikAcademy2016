// 02. A company has name, address, phone number, fax number, web site and manager. 
// The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

public class CompanyInfo
{
    public static void Main()
    {
        var company = Console.ReadLine();
        var address = Console.ReadLine();
        var phone = Console.ReadLine();
        var fax = Console.ReadLine();
        var website = Console.ReadLine(); 
        var managerFirstName = Console.ReadLine();
        var managerLastName = Console.ReadLine();
        var managerAge = Console.ReadLine();
        var managerPhone = Console.ReadLine();

        Console.WriteLine(company);
        Console.WriteLine("Address: {0}", address);
        Console.WriteLine("Tel. {0}", phone);
        Console.WriteLine("Fax: {0}", fax == "" ? "(no fax)" : fax);
        Console.WriteLine("Web site: {0}", website);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}
