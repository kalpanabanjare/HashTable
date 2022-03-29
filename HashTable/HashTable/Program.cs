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
            //string sentence = "To be or not to be";
            string sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = sentence.ToLower().Split(" ");            
            string Remove_Word = "avoidable";
            foreach (string word in words)
            {
                if (word != Remove_Word)
                {
                    int value = LinkedHashMap.Get(word);
                    if (value == default)
                    {
                        value = 1;
                    }
                    else value += 1;
                    LinkedHashMap.Add(word, value);
                }
            }
            int frequency = LinkedHashMap.Get(Remove_Word);
            Console.WriteLine("frequency of avoidable is: " + frequency);
            Console.WriteLine("\n\"{0}\" comes {1} times in the given paragraph now", Remove_Word, frequency);        
        }
    }
}