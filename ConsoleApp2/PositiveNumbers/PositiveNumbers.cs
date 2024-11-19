

using static System.Runtime.InteropServices.JavaScript.JSType;

internal class PositiveNumbers

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Any number");

        int jami=0;
        while (true)
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 0)
            {
                jami += number;
            }
            else
            {
                Console.WriteLine("Jamia: " + jami);
                break;
            }
        }
    }
}
