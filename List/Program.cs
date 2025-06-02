using System;
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
            Console.WriteLine("Input size spiska: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random(0);
            List list = new List();
            for (int i = 0; i < n; i++)
            {
                list.PushFront(rand.Next(100));
                //list.PushBack(rand.Next(100));
            }
            //list.PushBack(234);
            list.Print();
            list.PopFront();
            list.PopBack();
            //Console.WriteLine("Input index");
            //int index = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input value");
            //int value = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    list.Insert(value, index);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            Console.WriteLine("///////////////////////////");
            list.Print();

            Console.ReadLine();
        }
    }
}
