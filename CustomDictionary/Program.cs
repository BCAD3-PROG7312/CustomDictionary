using System;
using System.Collections.Generic;
using System.Data;

namespace CustomDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<int, User> persons = new Dictionary<int, User>();
            persons.Add(92110, new User(92110, "John", "Doe", 5));
            persons.Add(21111, new User(21111, "Jane", "Doe", 4));
            persons.Add(51011, new User(51011, "Sam", "Doe", 3));
            persons.Add(37289, new User(37289, "Pat", "Doe", 5));
            persons.Add(5678, new User(5678, "Joe", "Doe", 1));
            
            foreach (KeyValuePair<int,User> kv in persons)
            {
                Console.WriteLine(kv.Key + " - " + kv.Value.FirstName);
            }
            
            Console.WriteLine("User at index 5678: " + persons[5678].FirstName);
            
            persons.Remove(5678);
            Console.WriteLine("Removed");

            foreach (KeyValuePair<int, User> kv in persons)
            {
                Console.WriteLine(kv.Key + " - " + kv.Value.FirstName);
            }
            
            SimpleDictionary<int,string> simpleDictionary = new SimpleDictionary<int, string>();

            simpleDictionary.Add(92110, "John");
            simpleDictionary.Add(21111, "Jane");
            simpleDictionary.Add(51011, "Sam");
            simpleDictionary.Add(37289, "Pat");
            simpleDictionary.Add(5678, "Joe");
            
            simpleDictionary[5679] = "Ron";

            Console.WriteLine(simpleDictionary.ToString());
            
            Console.Write("Trying to remove key 2993 : ");
            Console.WriteLine(simpleDictionary.Remove(2993));
            
            Console.Write("Trying to remove key 5679 : ");
            Console.WriteLine(simpleDictionary.Remove(5679));
            
            Console.WriteLine("Dictionary:");
            
            Console.WriteLine(simpleDictionary);
            
            Console.WriteLine("Retreiving key 5678");
            Console.WriteLine(simpleDictionary[5678]);
            
            Console.WriteLine("sorting...");
            simpleDictionary.Sort();

            Console.WriteLine("Dictionary sorted by key:");
            Console.WriteLine(simpleDictionary);
        }
    }
}
