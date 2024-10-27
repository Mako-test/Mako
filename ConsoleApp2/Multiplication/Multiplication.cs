using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Multiplication

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter The number");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i < 11; i++)
        {
            
          Console.WriteLine(number + " x " + i + " = " + number * i);
        }
    }
    }