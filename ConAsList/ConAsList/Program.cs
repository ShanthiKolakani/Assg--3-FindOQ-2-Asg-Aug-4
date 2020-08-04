using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAsList
{
    class Program
    {
        static void Main()
        {
            LinkedList<string> lList = new LinkedList<string>();

            lList.AddLast("fox");
            lList.AddFirst("the");

            Console.WriteLine("-----------------Elements in the linkedlist-------------------");
            foreach (var st in lList)
            {
                Console.WriteLine(st);
            }


            Console.WriteLine("--------------Using Enumerator-------------------");
            LinkedList<string>.Enumerator Le = lList.GetEnumerator();
            while (Le.MoveNext())
            {
                Console.WriteLine(Le.Current);
            }
            var s1 = lList.AddFirst("quick");
            lList.AddAfter(s1, "brown");
            Console.WriteLine(".....LinkedList after adding new nodes...");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu);
            }
            var s2 = lList.AddLast("jumps");
            lList.AddAfter(s2, "over");
            Console.WriteLine("......LinkedList after adding new string......");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu);
            }

            Console.WriteLine("....LinkedList after adding new string...");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu);
            }
            var s3 = lList.AddLast("lazy");
            lList.AddBefore(s3, "the");
            Console.WriteLine("...LinkedList after adding new string...");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu);
            }
            var newNode = lList.AddLast("fox");
            lList.AddBefore(newNode, "lazy");
            Console.WriteLine("....LinkedList after adding new string...");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu);
            }
            lList.AddFirst("the");

            Console.WriteLine("....LinkedList after adding new nodes...");
            foreach (var stu in lList)
            {
                Console.WriteLine(stu);
            }



        }

    }
}
