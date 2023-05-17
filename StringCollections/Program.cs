using System;
using System.Collections.Generic;

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
            List<string> list = new List<string>() {string1,
            string2,
            string3,
            string4,
            string5};

            // Create stack with all strings
            Stack<string> stack = new Stack<string>();
            stack.Push(string1);
            stack.Push(string2);
            stack.Push(string3);
            stack.Push(string4);
            stack.Push(string5);

            // Create queue with all strings
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(string1);
            queue.Enqueue(string2);
            queue.Enqueue(string3);
            queue.Enqueue(string4);
            queue.Enqueue(string5);

            // Create hashset with all strings
            HashSet<string> hashset = new HashSet<string>();
            hashset.Add(string1);
            hashset.Add(string2);
            hashset.Add(string3);
            hashset.Add(string4);
            hashset.Add(string5);

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
