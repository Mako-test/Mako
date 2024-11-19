
using Microsoft.VisualBasic;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {

            string name = "Mako";
            float year = 1994;
            string month = "July";
            float day = 16;
            float Age = 30;
            int MobNumber = 568919200;
            var JobCompany = "Credo Bank";
            var Position = "Business Analyst";
            bool IsMarried = false;


            Console.WriteLine("Hey, Here's some information about Me!");
            Console.WriteLine(" * My Name is - " + name);
            Console.WriteLine(" * Birth Date - " + day + " " + month + " " + year);
            Console.WriteLine(" * Age - " + Age);
            Console.WriteLine(" * My Mobile Number is - " + MobNumber);
            Console.WriteLine(" * I work in " + JobCompany + " as a " + Position);
            Console.WriteLine(" * Married - " + IsMarried);




        }

    }
}
