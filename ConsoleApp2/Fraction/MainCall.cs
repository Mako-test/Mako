
namespace Fraction
{
    class Program
    {
        static void Main()
        {
            Fraction number1 = new Fraction(3, 6);
            Fraction number2 = new Fraction(1, 3);


            Console.WriteLine("Number 1: " + number1);
            Console.WriteLine("Number 2: " + number2);

            Fraction result = number1 + number2;
            Console.WriteLine("Sum: " + result);


            if (number1 == number2)
            {
                Console.WriteLine("fractions are equal ");
            }
            else
            {
                Console.WriteLine(" fractions are not equal");
            }
        }
    }
}
