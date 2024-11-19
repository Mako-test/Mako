internal class StudentGrades

{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter 3 student names");

        string[] students = new string[3];

        for (int i = 0; i < students.Length; i++)
        {
            students[i] = Console.ReadLine();
        }

        int[][] grades = new int[3][];

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine("\nStudent name: ");
            Console.WriteLine(students[i]);
            Console.WriteLine("Enter grades for Math and History");

            grades[i] = new int[2];

            for (int k = 0; k < grades[i].Length; k++)
            {
                grades[i][k] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nStudents And Grades");

        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine(students[i]);
            for (int k = 0; k < grades[i].Length; k++)
            {
                Console.WriteLine(grades[i][k]);
            }
        }
    }
}