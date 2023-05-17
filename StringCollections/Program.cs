using System;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Ola";
            string string2 = "mundo";
            string string3 = "Ola";
            string string4 = "Hello";
            string string5 = "world";

            // Create list with all strings
            list = new List<string>() {string1,
            string2,
            string3,
            string4,
            string5};

            // Create stack with all strings
            stack = new Stack<string>() {string1,
            string2,
            string3,
            string4,
            string5};

            // Create queue with all strings
            queue = new Queue<string>() {string1,
            string2,
            string3,
            string4,
            string5};

            // Create hashset with all strings
            hashset = new HashSet<string>() {string1,
            string2,
            string3,
            string4,
            string5};

            // Prints list
            Console.WriteLine("List: ");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-");

            // Prints stack
            Console.WriteLine("Stack: ");
            
            foreach (string s in stack)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-");

            // Prints queue
            Console.WriteLine("Queue: ");
            
            foreach (string s in queue)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-");

            // Prints hashset
            Console.WriteLine("HashSet: ");
            
            foreach (string s in hashset)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-");
        }
    }
}
