using System;

public class Enums
{
    public static void Main2()
    {
        Gender G = (Gender)Season.Winter;

        Gender K = Gender.Male;

        Gender L = (Gender)1;
        Console.WriteLine(L);

        Gender M = (Gender)Season.Summer;
        Console.WriteLine(M);

        Gender L5 = (Gender)15;
        Console.WriteLine(L5);

        Console.ReadLine();
    }
}

public enum Gender : int
{
    Unknown = 1,                           // Gender.Unknown = 1;    Unknown = (Gender)1
    Male = 2,
    Female = 3
}

public enum Season : int
{
    Winter = 1,
    Spring = 2,
    Summer = 3
}