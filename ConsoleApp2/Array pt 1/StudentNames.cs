using System.Xml.Linq;

internal class StudentsArray

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Name");

        string [] students = new string[3];


        

        for (int i = 0; i < students.Length; i++)
        {
            string name = (Console.ReadLine());
            students[i] = name;
        }
        Console.WriteLine("");

        Console.WriteLine("Studentlist");
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine(students[i]);
        }



    }
}