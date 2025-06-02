using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ForwardList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input size spiska: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Random rand = new Random(0);
            ForwardList list = new ForwardList()
            {
                3,5,8,13,21
            };
            
            foreach (int i in list)
            {
                Console.Write($"{i}\t");
            }
            //list.Print();
            ////list.Add(354);
            //list.PushFront(123);
            //for (int i = 0; i < n; i++)
            //{
            //    //list.PushFront(rand.Next(100));
            //    list.PushBack(rand.Next(100));
            //}
            ////list.PushBack(234);
            //list.Print();
            //// list.PopFront();
            //// list.PopBack();
            //Console.WriteLine("Input index");
            //int index = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input value");
            //int value = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    list.Insert(value, index);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //list.Print();
            Console.ReadLine();
        }
    }
}
