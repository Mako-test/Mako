namespace StackAndHeap
{



    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }
      

    }
    public class ChangePerson { 
    static void Main()
        {
            string Name = "Mako";
            int Age = 30;

            Person firstPerson = new Person(Name, Age);

            Console.WriteLine("\nfirst Person's Name : " + Name);
            Console.WriteLine("\nfirst Person's Age : " + Age);


           Person secondPerson = new Person(Name, Age);

            secondPerson.Name = "Mariam";
            secondPerson.Age = 29;

            Console.WriteLine("\nsecond Person's Name : " + secondPerson.Name);
            Console.WriteLine("\nsecond Person Age : " + secondPerson.Age);




        }

    }



}


//using System;

//class Person
//{
//    // Person კლასის ველები
//    public string Name;  // სახელი
//    public int Age;      // ასაკი

//    // კონსტრუქტორი, რომელიც იღებს სახელს და ასაკს
//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    // მეთოდი, რომელიც გამოტანს პირთან დაკავშირებულ ინფორმაციას
//    public void Display()
//    {
//        Console.WriteLine("Name: " + Name);
//        Console.WriteLine("Age: " + Age);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // შექმენით ცვლადები სახელისა და ასაკისთვის
//        string name = "Giorgi";
//        int age = 25;

//        // შექმენით Person კლასის ობიექტი და მიუერთეთ მას ცვლადები
//        Person person1 = new Person(name, age);

//        // გამოტანა თავდაპირველი მონაცემების
//        Console.WriteLine("Person1:");
//        person1.Display();

//        // შექმენით ახალი ცვლადი და ასახავთ person1 ობიექტს
//        Person person2 = person1;

//        // შეცვალეთ person2 ველები
//        person2.Name = "Mariam";
//        person2.Age = 30;

//        // გამოტანა შეცვლილი მონაცემების
//        Console.WriteLine("\n Person2:");
//        person2.Display();

//        // person1 ობიექტის მონაცემები შეიცვალა, რადგან person2 მხოლოდ მითითებას შეიცავდა
//        Console.WriteLine("\nFirst PersonAfterChange");
//        person1.Display();
//    }
//}