using System;

public class Elia
{
    public static void Main2()
    {
        Customer[] customers = new Customer[3];
        customers[0] = new Customer() { Name = "Mark", Gender = Gender.Male };
        customers[1] = new Customer() { Name = "Marry", Gender = Gender.Unknown };
        customers[2] = new Customer() { Name = "Sita", Gender = Gender.Female };

        foreach (Customer customer in customers)
        {
            Console.WriteLine("Name = {0} && Gender = {1}", customer.Name, customer.Gender);
        }

        Console.ReadLine(); 
    }
}

public enum Gender
{
    Unknown = 0,
    Male = 1,
    Female = 2
}

public class Customer
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
}