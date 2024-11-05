
namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int order= int.Parse(Console.ReadLine());
            int[] array = new int[order];

            Console.WriteLine($"Now, Enter {order} numbers:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the order of the number you want to sum digits for.");
            int index = int.Parse(Console.ReadLine());

            int result = summerize (array, index);
            Console.WriteLine($"Here's the result: {result}");
        }

        static int summerize(int[] array, int index)
        {
            int number = 0;
            string element = array[index].ToString();

            foreach (char i in element)
            {
                number += int.Parse(i.ToString());
            }

            return number;
        }
    }
}