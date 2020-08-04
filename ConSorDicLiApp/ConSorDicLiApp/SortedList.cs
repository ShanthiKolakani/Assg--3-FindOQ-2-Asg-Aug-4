using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security;
using System.Dynamic;

namespace ConSorDicLiApp
{
    class SortedList
    {
        static void Main(string[] args)
        {

            var sorted = new SortedList<string, int>();
           // Console.WriteLine("############### Add #################");
            sorted.Add("apples", 4);
            sorted.Add("bananna",5);
            sorted.Add("orange", 6);
            sorted.Add("paniapple", 7);
            sorted.Add("papaya", 8);
            Console.WriteLine("-----------------COUNT-----------------");
            Console.WriteLine("No of items:{0}", sorted.Count);

            Console.WriteLine("################# CONTAINKEY#############");

            Console.WriteLine("There are books in the list:{0}", sorted.ContainsKey("orange"));

           // Console.WriteLine("################# CONTAINS #############");

           // Array obj = new Object[sorted.ContainsValue<string, int>];

           // Console.WriteLine("There are books in the list:{0}", sorted.Contain(8));

            Console.WriteLine("################# CONTAINSVALUE #############");
            Console.WriteLine("The value bananna contains in the sortedlist:" + sorted.ContainsValue(4));

            Console.WriteLine("################# KEYS #############");

            foreach(KeyValuePair<string,int> pair in sorted)
            {
                Console.WriteLine("{0} = {1}",pair.Key, pair.Value);
            }
             IList< int > ilvalue = sorted.Values;
            foreach (int i in ilvalue)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine( );

            Console.WriteLine("################# VALUES #############");

            IList<string> ilkey = sorted.Keys;
            foreach (string i in ilkey)
            {
                Console.Write(i + ",");
            }
            //Console.WriteLine("The index value of the key 1 is:" + sorted.i);
            Console.Read();


        }
    }
}
