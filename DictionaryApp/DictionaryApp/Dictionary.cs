using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Dictionary
    {
         static void Main(string[] args)
            {
                Dictionary<int, string> dict = new Dictionary<int, string>();
                dict.Add(1, "apples");
                dict.Add(2, "strawbarry");
                dict.Add(3, "kiwi");
                dict.Add(4, "draganfruit");

                Console.WriteLine("Printing Dictionary Element");
                foreach (var a in dict)
                {
                    Console.WriteLine(a);
                }
                Console.WriteLine();

            Console.WriteLine("......................COUNT ................................");

            Console.WriteLine("Count of element in dictionary : {0}", dict.Count);
            Console.WriteLine();

            Console.WriteLine("$#$#$#$#$#$#$#$#$#$# CONTAINSKEY  $#$#$#$#$#$#$#$#$$#$#");

            Console.WriteLine("Checking index 1 in dict : {0}", dict.ContainsKey(1));

            Console.WriteLine(".......................... CONTAINSVALUE ........................");

            Console.WriteLine("Checking Value Guntur in dict : {0}", dict.ContainsValue("Guntur"));
            Console.WriteLine();

            Console.WriteLine("$#$#$#$#$#$#$#$#$#$# CONTAINSKEY  $#$#$#$#$#$#$#$#$$#$#");

            Console.WriteLine("Checking index 5 in dict : {0}", dict.ContainsKey(5));
            Console.WriteLine("");
                dict.Clear();


            foreach (var a in dict)
            {
                Console.WriteLine(a);
            }

            Dictionary<string, string> dict2 = new Dictionary<string, string>()
            {
                { "apple","strawbarry" },
            {"goa", "kiwi" },
                { "to", "draganfruit" }
             };
             foreach(KeyValuePair<string, string> el in dict2)
            {
                Console.WriteLine("{0} and {1}", el.Key, el.Value);
            }
           
            Console.Read();

            }
        }
    }











