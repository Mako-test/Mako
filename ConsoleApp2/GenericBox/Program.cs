namespace GenericBox
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Some Examples");

           

            Box<string> Box1 = new Box<string>();
            Box1.SetValue("This Box is empty");
            Console.WriteLine($"\nIs there something in the box? -  {Box1.GetValue()}");

            Box<double> Box2 = new Box<double>();
            Box2.SetValue(53.11);
            Console.WriteLine($"\nVolume of the Box2 - {Box2.GetValue()}");

            Box<int> Box3 = new Box<int>();
            Box3.SetValue(5);
            Console.WriteLine($"\nweight of Box3 - {Box3.GetValue()} kg");

            List<int> List1 = new List<int> { 55,33,11,46,84,22};
            int List1Amount = Utility.GetListCount(List1);
            Console.WriteLine($"\nAmount of the Boxes in List 1 - {List1Amount}");

            List<string> List2 = new List<string> { "RedBox", "YellowBox", "GreenBox", "BlackBox" };
            int List2Amount = Utility.GetListCount(List2);
            Console.WriteLine($"\nAmount of the Boxes in List 2 -  {List2Amount}");

            List<double> List3 = new List<double> { 55.1,33.1,11.1};
            double List3Amount = Utility.GetListCount(List3);
            Console.WriteLine($"\nAmount of the Boxes in List 3 - {List3Amount}");
        }
    }

}