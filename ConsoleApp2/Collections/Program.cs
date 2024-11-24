using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    public class data
    {
        static void Main()
        {
            //*****ArrayList*****
            Console.WriteLine("***ARRAY LIST***\n");
            var arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add("Mako");
            arrayList.Add("TEST");
            arrayList.Insert(5, 5);
            Console.WriteLine("Third Element of the first List is : " + arrayList[4]);
            arrayList.Remove("TEST");
            // Console.WriteLine(arrayList[4]); //უნდა დააეროროს
            Console.WriteLine("\nThe first List:");
            foreach (var firstList in arrayList)
            {
                Console.WriteLine(firstList);
            }

            ////*****List*****
            Console.WriteLine("\n***LISTS***\n");
            List<double> numbers = new List<double>() { double.MinValue, 3.5, 99, 4.10, 6, double.MaxValue };
            numbers.Add(5);
            numbers.Add(22);
            numbers.Remove(6);
            numbers.AddRange(new List<double>() { 22.1, 21, 33.5 });
            numbers.Sort();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //******Dictionary*****
            Console.WriteLine("\n***DICTIONARIES***\n");

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Black", "Dress");
            dictionary.Add("Printed", "T-Shirt");
            dictionary.Add("Yellow", "Sundress");
            dictionary.Add("Green", "Top");
            dictionary.Remove("Yellow");

            Console.WriteLine("\nMy wardrobe:");
            foreach (var color in dictionary.Keys)
            {
                Console.WriteLine($"Color: {color}, Cloth: {dictionary[color]}");
            }

            //*****SortedList*****

            Console.WriteLine("\n***SORTED LISTS***\n");


            SortedList<int, string> employers = new SortedList<int, string>();
            employers.Add(3, "Mako");
            employers.Add(4, "Lika");
            employers.Add(1, "Tamuna");
            employers.Add(8, "Someone");
            employers.Add(2, "Ana");
            employers.RemoveAt(4);
            string valueAtIndex2 = employers.Values[0];
            Console.WriteLine("First Employer in the List is: " + valueAtIndex2);

            foreach (var list in employers)
            {
                Console.WriteLine(list);
            }

            //*****Stack*****
            Console.WriteLine("\n***STACKS***\n");

            Stack<int> loto = new Stack<int>();
            loto.Push(1);
            loto.Push(20);
            loto.Push(30);
            loto.Push(16);
            loto.Push(21);

            while (loto.Count > 1)
            {
                loto.Pop();
                Console.WriteLine(loto.Peek());
            }

            //*****Queue*****
            Console.WriteLine("\n***QUEUES***\n");

            Queue<int> blackFridayQueue = new Queue<int>();
            blackFridayQueue.Enqueue(1000);
            blackFridayQueue.Enqueue(2000);
            blackFridayQueue.Enqueue(3000);
            blackFridayQueue.Enqueue(4000);

            while (blackFridayQueue.Count > 1)
            {
                blackFridayQueue.Dequeue();
                Console.WriteLine(blackFridayQueue.Peek());
            }

            Console.WriteLine("Last Person's Queue Number is : " + blackFridayQueue.Peek());

            //*****SortedDictionary*****
            Console.WriteLine("\n***SORTED DICTIONARIES***\n");

            SortedDictionary<string, string> shoppingList = new SortedDictionary<string, string>();
            shoppingList.Add("5", "Bottle of Water");
            shoppingList.Add("10", "Napkins");
            shoppingList.Add("1", "Brain");
            shoppingList.Add("2", "Breads");

            shoppingList.Remove("2");

            Console.WriteLine("\nYour Shopping List");
            foreach (var product in shoppingList.Keys)
            {
                Console.WriteLine($"Amount: {product}, Product: {shoppingList[product]}");
            }


            //*****HashSet*****
            Console.WriteLine("\n***HASH SETS***\n");

            HashSet<string> uniqueStudents = new HashSet<string>();
            uniqueStudents.Add("Mako V");
            uniqueStudents.Add("Tamuna B");
            uniqueStudents.Add("Nini K");
            uniqueStudents.Add("Tamuna B");
            uniqueStudents.Add("Ana J");
            uniqueStudents.Add("Ana J");
            uniqueStudents.Add("Likuna A");                ;
            uniqueStudents.Add("Mako V");
            uniqueStudents.Add("Ana J");
            uniqueStudents.UnionWith(new HashSet<string> { "Likuna A", "Nini K" , "Mariam Kh" });

            Console.WriteLine("\nUnique Student's list:");
            foreach (var students in uniqueStudents)
            {
                Console.WriteLine(students);
            }
        }
    }

}
