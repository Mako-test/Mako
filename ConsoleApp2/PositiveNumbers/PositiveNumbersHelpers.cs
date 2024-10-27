internal static class PositiveNumbersHelpers
{
    public static void Main(string[] args, int jami)
    {
        Console.WriteLine("Enter Any number");

        int firstNumber = 0;
        int Jami;

        do
        {
            int Number = int.Parse(Console.ReadLine());
            Jami = firstNumber + Number;

        }
        while (jami >= 0);

        do
        {

            Console.WriteLine("Jamia: " + Jami);

        }
        while (jami < 0);

        //    else
        //    {
        //        Console.WriteLine("Jamia: " + Jami);
        //    }
        //}


    }
}