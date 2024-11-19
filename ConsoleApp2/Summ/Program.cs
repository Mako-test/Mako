
namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length:");
            int length= int.Parse(Console.ReadLine());
            int[] array = new int[length];

            Console.WriteLine($"Now, Enter {length} numbers:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the order of the number you want to sum digits for.");
            int index = int.Parse(Console.ReadLine());

            int result = Summerize (array, index);
            Console.WriteLine($"Here's your result: {result}");
        }

        static int Summerize(int[] array, int index)
        {
            int number = 0;

            //    var sum = array[index].ToString().Select(x => int.Parse(x.ToString())).ToArray().Sum();

            //    return number;

            string element = array[index].ToString();

            foreach (char i in element)
            {
                number += int.Parse(i.ToString());
    }

            return number;
        }
    }
}