using System;
class Program
{
    static double FtC(int Grader)
    {
        return (Grader - 32) / 1.8;
        
    }
    static double CtF(int grader)
    {
        return (32 + grader) * 1.8;
    }
    static void Main()
    {
        Console.WriteLine("Välj åt vilket håll du vill omvandla:");
        Console.WriteLine("1. Farenheit till celsius.");
        Console.WriteLine("2. Celsius till Farenheit.");
        int val = int.Parse(Console.ReadLine());


        switch (val)
        {
            case 1:
                Console.Write("Hur många grader Farenheit ? ");
                int graderF = int.Parse(Console.ReadLine());
                double Celsius = FtC(graderF);

                Console.WriteLine("Det är " + Celsius + " grader celsius");
                break;
            case 2:
                Console.Write("Hur många grader Celsius ? ");
                int graderC = int.Parse(Console.ReadLine());
                double Farenheit = CtF(graderC);

                Console.WriteLine("Det är " + Farenheit + " grader farenheit");
                break;
        }
    }
}