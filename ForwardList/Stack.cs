using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForwardList
{
    internal class Stack 
    {

        private ForwardList forwardList { get; set; }
        public Stack() 
        {
            forwardList = new ForwardList();
        }
        public void Push(int Data) => forwardList.PushFront(Data);

        public void Pop()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("Error!!!PYSTO");

            forwardList.PopFront();
        }
        public void Clear()
        {
            forwardList.Clear();
            Console.WriteLine("Clear PYSTO");
        }
        
        public bool IsEmpty() => forwardList.Length == 0;
        public int Peek()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("Error!!!PYSTO");

            Console.WriteLine($"Peek: \t{forwardList.GetHead()}");
            return forwardList.GetHead();
        }
        public void PrintStack() => forwardList.Print();
        public void Length()
        {
           Console.WriteLine($"Length: \t{forwardList.Length}");
        }

    }
}
