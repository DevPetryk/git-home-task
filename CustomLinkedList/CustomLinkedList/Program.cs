using System;

namespace CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** My custom Linked List *****");

            // String list.
            Console.WriteLine("\nString values");
            LinkedList<string> listString = new LinkedList<string>();
            listString.Add("Hello");
            listString.Add("World");

            // Show List after add.
            foreach (var s in listString)
            {
                Console.WriteLine(s);
            }

            // Delete itemes 'World'.
            listString.Delete("World");

            // Show List after delete.
            Console.WriteLine("\nShow list after delete values 'World'");
            foreach (var s in listString)
            {
                Console.WriteLine(s);
            }

            // Integer list.
            Console.WriteLine("\nInt values");
            LinkedList<int> listInt = new LinkedList<int>();
            listInt.Add(1);
            listInt.Add(2);
            listInt.Add(3);
            listInt.Add(4);
            listInt.Add(5);
            listInt.Add(6);
            listInt.Add(7);

            // Show List after add.
            foreach (var i in listInt)
            {
                Console.WriteLine(i);
            }

            // Delete itmes 1,2.
            listInt.Delete(1);
            listInt.Delete(2);

            // Show List after delete.
            Console.WriteLine("\nShow list after delete values 1, 2");
            foreach (var i in listInt)
            {
                Console.WriteLine(i);
            }


            // Double list.
            Console.WriteLine("\nDouble values");
            LinkedList<double> listDouble = new LinkedList<double>()
            {
                2.2,
                2.3,
                2.4
            };

            // Show List after add.
            foreach (var d in listDouble)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine($"Number of elements in list double before clear: {listDouble.Count}"); 

            listDouble.Clear();

            Console.WriteLine($"Number of elements in list double after clear: {listDouble.Count}");
        }
    }
}
