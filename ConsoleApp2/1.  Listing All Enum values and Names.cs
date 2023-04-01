using System;

public class Program
{
    private static void Main1()
    {
        Student K = new Student();
        K.Name = "Yogesh";
        K.Department = Department.Mechanical;
        K.FavouriteSeason = FavouriteSeason.Rain;
        K.Grade = Grade.D;

        Student L = new Student();
        L.Name = "Sumita";
        L.Department = Department.Electrical;
        L.FavouriteSeason = FavouriteSeason.Winter;
        L.Grade = Grade.C;

        Console.WriteLine(Enum.GetUnderlyingType(typeof(FavouriteSeason)));

        string[] Name = Enum.GetNames(typeof(Department));

        for (int i = 0; i < Name.Length; i++)
        {
            Console.WriteLine(Name[i]);
        }

        int[] Value = (int[])Enum.GetValues(typeof(Department));

        for (int i = 0; i < Value.Length; i++)
        {
            Console.WriteLine(Value[i]);
        }

        Console.WriteLine();

        Console.ReadLine();
    }
}

public class Student
{
    public string Name;
    public Department Department { get; set; }
    public FavouriteSeason FavouriteSeason { get; set; }
    public Grade Grade { get; set; }
}

public enum Department
{
    Mechanical,
    Electrical,
    Computer,
    Civil
}

public enum FavouriteSeason : long
{
    Summer = 10,
    Rain = 25,
    Winter
}

public enum Grade : short
{
    A,
    B,
    C = 40,
    D
}