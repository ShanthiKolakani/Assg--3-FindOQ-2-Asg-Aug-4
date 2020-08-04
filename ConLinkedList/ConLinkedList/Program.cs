using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConLinkedList
{
    class Program
    {
        static void Main() {
            LinkedList<String> list = new LinkedList<String>();
            list.AddLast("one");
            list.AddLast("two");
            list.AddLast("three");
            list.AddLast("four");
            list.AddLast("five");
            list.AddLast("six");
            list.AddLast("seven");
            Console.WriteLine("-------elements in the linkedlist---------------");
            foreach (var st in list)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine("--------------using Enumerator-------------------");
            LinkedList<string>.Enumerator ll = list.GetEnumerator();
            while (ll.MoveNext())
            {
                Console.WriteLine(ll.Current);
            }
            Console.WriteLine("_________________________remove paricualr element-------------------");
            list.Remove("one");
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("_______________________remove at first-------------------------");
            list.RemoveFirst();
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("_______________________________Removes at last------------------------------");
            list.RemoveLast();
            foreach (var e in list)
            {
                Console.WriteLine(e); }
            Console.Read();
        }
    }
}




 
