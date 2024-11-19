namespace MathHelper
{
    public class MathOperations
    {
        static void Main ()
        {
            int a = 24;
            int b = 2;

        Console.WriteLine($"Sum of {a} and {b} is " + MathHelper.Add(a, b));
        Console.WriteLine($"Subtract of {a} and {b} is" + MathHelper.Subtract(a, b));
        Console.WriteLine($"Multiplication of {a} and {b} is "+ MathHelper.Multiply(a, b));
        Console.WriteLine($"Division of {a} and {b} is " + MathHelper.Divide(a, b));
        }

    }
}