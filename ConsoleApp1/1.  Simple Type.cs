using System;

public class Program1
{
    private static void Main1()
    {
        Student K = new Student();
        K.Name = "Yogesh";
        K.Department = Department.Civil;
        K.FavouriteSeason = FavouriteSeason.Rain;
        K.Grade = Grade.D;

        Student L = new Student();
        L.Name = "Sumita";
        L.Department = Department.Electrical;
        L.FavouriteSeason = FavouriteSeason.Winter;
        L.Grade = Grade.C;

        Console.WriteLine(L.FavouriteSeason);

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

public enum Department                                                      // By Default int and 0,1,2,3
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