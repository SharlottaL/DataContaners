using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Queue
    {
        private List list { get; set; }
        public Queue()
        {
            list = new List();
        }
        public void Enqueue(int Data) => list.PushBack(Data);

        public void Dequeue()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("Error!!!PYSTO");

            list.PopFront();
        }
        public void Clear()
        {
            list.Clear();
            Console.WriteLine($"Clear PYSTO");
        }

        public bool IsEmpty() => list.Length == 0;
        public int Peek()
        {
            if (list.Length == 0)
                throw new IndexOutOfRangeException("Error!!!PYSTO");

            Console.WriteLine($"Peek: \t{list.GetHead()}");
            return list.GetHead();
        }
        public void PrintQueue() => list.Print();
        public void Length() => Console.WriteLine($"Length: \t{list.Length}");
        
    }
}
