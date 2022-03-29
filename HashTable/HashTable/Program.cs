using System;
using System.Collections.Generic;

namespace Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We find frequency from hashmap!");
            LinkedHashMap<string, int> LinkedHashMap = new LinkedHashMap<string, int>(5);
            string sentence = "To be or not to be";
            string[] words = sentence.ToLower().Split(" ");
            foreach (string word in words)
            {
                int value = LinkedHashMap.Get(word);
                if (value == default)
                {
                    value = 1;
                }
                else value += 1;
                LinkedHashMap.Add(word, value);
            }
            int frequency = LinkedHashMap.Get("to");
            Console.WriteLine(frequency);
        }
    }
}