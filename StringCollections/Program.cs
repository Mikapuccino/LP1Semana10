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

            list = new List<string>() {string1,
            string2,
            string3,
            string4,
            string5};

            stack = new Stack<string>() {string1,
            string2,
            string3,
            string4,
            string5};

            queue = new Queue<string>() {string1,
            string2,
            string3,
            string4,
            string5};

            hashset = new HashSet<string>() {string1,
            string2,
            string3,
            string4,
            string5};
        }
    }
}
