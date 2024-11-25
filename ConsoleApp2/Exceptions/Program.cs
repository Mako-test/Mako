using Exceptions;

namespace Exceptions

{
    public class ErrorMessage : Exception
    {
        public int StatusCode { get; set; }

        public ErrorMessage(string message, int statusCode) : base(message)
        {
            StatusCode = statusCode;
        }
    }
    public class calculations
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter first number for calculation:");
                    var numb1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nEnter second number:");
                    var numb2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nEnter symbol of operation you want to do:");
                    var op = Console.ReadLine();

                    var answer = 0;

                    switch (op)
                    {
                        case "+": answer = numb1 + numb2; break;
                        case "-": answer = numb1 - numb2; break;
                        case "/": answer = numb1 / numb2; break;
                        case "*": answer = numb1 * numb2; break;
                        default: throw new InvalidOperationException("Wrong Operation!\n");
                    }
                    Console.WriteLine("Answer is : " + answer);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format!");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ErrorMessage ex)
                {
                    Console.WriteLine($"Error Message: {ex.Message}, Status Code: {ex.StatusCode}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exeption: {ex.Message}");
                }
            }
        }
    }
}   