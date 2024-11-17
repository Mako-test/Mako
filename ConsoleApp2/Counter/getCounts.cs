
namespace Counterr
{
    public class getCounts
    {
        static void Main()
        {
            Counter count1 = new Counter();
            Console.WriteLine(" first value" + Counter.GetCount());
            Counter count2 = new Counter();
            Console.WriteLine(" Second value" + Counter.GetCount());
            Counter count3 = new Counter();
            Console.WriteLine(" Third value" + Counter.GetCount());
            Counter count4 =  new Counter();
            Console.WriteLine(" Fourth value" + Counter.GetCount());

            Counter.ResetCount();
            if (Counter.count == 0)
            {
                Console.WriteLine(Counter.count);
            }
        }

       


        

    }
    

}