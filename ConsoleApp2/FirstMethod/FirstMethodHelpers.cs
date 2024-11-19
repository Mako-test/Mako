
internal class Program
    {
        static void Main(string[] args)
        {
            summarizedNumber();
        }

    private static void summarizedNumber(int[] array, int index)
    {
        array = new int[5];
        index = int.Parse(Console.ReadLine());

        for (int i = 0; i < array.Length; i++)
        {

            int input = int.Parse(Console.ReadLine());

            array[i] = input;

        }
        int number = 0;
        string mystr = array[index].ToString();

        foreach (char i in mystr)
        {
            number += int.Parse(i.ToString());
        }

        return number;

    }
