internal class FirstMethod
{

    static void main()
    {
        Console.WriteLine("Enter numbers here");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
            for (int i = 0; i < n; i++)
        {

            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter one number");
        int index = int.Parse(Console.ReadLine());
       
        int summarizedNumber = calculateResult(array, index);
        Console.WriteLine("Sum = " + index + summarizedNumber);
        //return summarizedNumber;

    }

    public static int calculateResult (int[] array, int index)
    {
        int number = array[index];
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10; 
            number /= 10; 
        }
        return sum;


    }
}
