using System;
using System.Collections;
using System.Linq;

namespace arrayDeno
{
    internal class ExampleStack
    {

        static void Main(string[] args)
        {
            // WorkingWithStacks();
            // WorkingWithQueue();
            //Assigmint1();
            //WorkingWithHashtable();

            Console.Read();
        }

        private static void WorkingWithHashtable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("a", 1);
            ht.Add("b", 2);
            ht.Add(3, "fazal");
            ht.Add(4, "mca");

            ht.Remove("a");
            ht.Add(5, "rum");
            ht.Add(6, "biotech");

            Console.WriteLine("Oroiginal array");

            foreach (DictionaryEntry entry in ht)
            {

                Console.WriteLine(entry.Key + " " + entry.Value);
            }

            Hashtable copyhastable = new Hashtable(ht);

            Console.WriteLine("copied hashtable");
            foreach (DictionaryEntry entry in copyhastable)
            {

                Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }

        private static void Assigmint1()
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add(22);
            al.Add("12");
            al.Add(new DateTime());
            al.Add("Fazal");
            al.Add("hello");
            al.Add(7234.4f);
            al.Add(123);
            al.Add(876);
            al.Add(10);
            al.Add(82.7373d);
            al.Add(79867575);
            al.Add(true);
            //foreach (var i in al)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("-------------");

            //bool elemConatin= al.Contains("Fazal");
            // Console.WriteLine("arraylist contain element " + elemConatin);
            // Console.WriteLine("-------------");
            // al.Remove("Fazal");
            // Console.WriteLine("after removing the element the arry list is");
            // foreach (var i in al)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine("----------------");





            Console.WriteLine("------------------");

            object[] arr = al.ToArray(typeof(object)) as object[];

            Console.WriteLine("after copying the arraylist elements into new array :");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------");
            var a = arr.OfType<int>().ToArray();
            Console.WriteLine("array containing only int value ");
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("sorted array");

            Array.Sort(a);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Reversed array ");
            Array.Reverse(a);
            foreach (var j in a)
            {
                Console.WriteLine(j);
            }
        }

        private static void WorkingWithQueue()
        {
            Queue q = new Queue();
            q.Enqueue(12);
            q.Enqueue(21);
            q.Enqueue(22);
            q.Enqueue(13);
            q.Enqueue("FAzal");
            q.Enqueue("SAurabh");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------");
            object objPeek = q.Peek();
            Console.WriteLine("Element at peek of queue is " + objPeek);
            Console.WriteLine("-------------------");
            object objDeque = q.Dequeue();
            Console.WriteLine("the deleted element is " + objDeque);
            Console.WriteLine("--------------");
        }

        private static void WorkingWithStacks()
        {
            Stack mtStack = new Stack();
            mtStack.Push(1);
            mtStack.Push("Fazal");
            mtStack.Push(25);
            mtStack.Push("Bca");
            mtStack.Push("Hardoi");
            mtStack.Push(7985939982);

            foreach (var item in mtStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------");
            object o = mtStack.Peek();
            Console.WriteLine("Element at top " + o);

            Console.WriteLine("------------------");

            int[] arr1 = new int[] { 1, 32, 54, 65, 66, 33, 2, 5445, 464, 643 };
            Console.WriteLine("*******************");
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}



            int[] arr = (int[])arr1.Clone();
            Console.WriteLine("===========");
            foreach (int i in arr)
                Console.WriteLine(i);
            int minValue = arr.Min();
            Console.WriteLine("Min value in cloned array is " + minValue);
            int maxValue = arr.Max();
            Console.WriteLine("Max value in cloned arr is " + maxValue);

            double avgOfElement = arr1.Average();
            Console.WriteLine("Avg of arr element is " + avgOfElement);



            //object o1= mtStack.Clone();
            //Console.WriteLine("the cloned copy of stack is " + o1);
        }
    }
}
