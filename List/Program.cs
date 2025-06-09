using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input size spiska: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            // Random rand = new Random(0);
            // List list = new List();
            // for (int i = 0; i < n; i++)
            // {
            //     list.PushFront(rand.Next(100));
            //     //list.PushBack(rand.Next(100));
            // }

            // //list.PrintBackward();
            // list.PopFront();
            // list.PopBack();
            // list.PushBack(234);
            // //list.PrintBackward();

            // //Console.WriteLine("Input index");
            // //int index = Convert.ToInt32(Console.ReadLine());
            // //Console.WriteLine("Input value");
            // //int value = Convert.ToInt32(Console.ReadLine());
            // //try
            // //{
            // //    list.Insert(value, index);
            // //}
            // //catch (Exception ex)
            // //{
            // //    Console.WriteLine(ex.Message);
            // //}
            // Console.WriteLine("///////////////////////////");
            // //list.Print();
            //// list.PrintBackward();
            // Console.WriteLine("///////////////////////////");
            // list.PrintForward();
            Queue queue  = new Queue();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            Random rand = new Random(0);
            for (int i = 0; i < 13; i++)
            {
                //list.PushFront(rand.Next(100));
                queue.Enqueue(rand.Next(100));
            }
            Console.WriteLine(queue);  // 30 -> 20 -> 10 -> null

            //Console.WriteLine(stack.Pop());  // 30
            //Console.WriteLine(stack.Peek()); // 20
            //Console.WriteLine(stack.Count);  // 2

            //Console.WriteLine("Clear");
            //stack.Clear();
            queue.PrintQueue();
            queue.Length();
            Console.WriteLine("Dequeue");
            queue.Dequeue();
            Console.WriteLine("Enqueue");
            queue.Enqueue(111);
            queue.Peek();
            queue.PrintQueue();
            queue.Length();
            Console.WriteLine("Clear");
            queue.Clear();
            queue.PrintQueue();
            Console.ReadLine();
        }
    }
}
