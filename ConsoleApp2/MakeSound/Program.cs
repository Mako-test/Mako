namespace makeSound
{
    public interface IAnimal
    {
        string MakeSound();
    }

        public abstract class Animal : IAnimal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Animal(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public abstract string MakeSound();
        }

        public class Dog : Animal
        {
            public Dog(string name, int age) : base(name, age) { }

            public override string MakeSound()
            {
                return "Dog says: Woof-Woof";
            }
        }

        public class Cat : Animal
        {
            public Cat(string name, int age) : base(name, age) { }

            public override string MakeSound()
            {
                return "Cat says: Meoow";
            }
        }

        public class Cow : Animal
        {
            public Cow(string name, int age) : base(name, age) { }

            public override string MakeSound()
            {
                return "Cow says: Moo";
            }
        }

    class Program
    {
        static void Main()
        {
            IAnimal[] animals = new IAnimal[]
            {
            new Dog("Lucy", 7),
            new Cat("Fluffy", 3),
            new Cow("Chrelo",2 )
            };


            for (int i = 0; i < animals.Length; i++)

            {
                Console.WriteLine(animals[i].MakeSound());
            }
        }
    }

}