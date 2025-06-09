using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class List
    {
        Element Head { get; set; }
        public Element Tail { get; private set; }
        public int Length { get; private set; }
        public List()
        {
            Head = null;
            Tail = null;
            Length = 0;
            Console.WriteLine($"LConstr:\t{GetHashCode()}");
        }
        public int GetHead()
        {
            if(Head == null)
                throw new IndexOutOfRangeException("Error!!!Head Pysto!");

            return Head.Data;
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Length = 0;
        }
       
        public void PushFront(int Data)
        {
            Element newElement = new Element(Data);
           if(Head == null)
            {
                Head = newElement;
                Tail = newElement;
            }
            else
            {
                newElement.pNext = Head;
                Head.pPrev = newElement;
                Head = newElement;
            }
            Length++;
        }
        public void PushBack(int Data)
        {
            Element newElement = new Element(Data);
            if (Head == null)
            {
                Head = newElement;
                Tail = newElement;
            }
            else
            {
                newElement.pPrev = Tail;
                Tail.pNext = newElement;
                Tail = newElement;
            }
            Length++;
        }
        //public void Insert(int Data, int Index)
        //{
        //    Element newElement = new Element(Data, Head);
        //    if (Index > Length || Index < 0)
        //    {
        //        throw new IndexOutOfRangeException("Error!!!Exit not normal");
        //        //Console.WriteLine("Error!Exit");
        //        //return;
        //    }

        //    if (Index == 0)
        //    {
        //        PushFront(Data);
        //        return;
        //    }

        //    Element Temp = Head;
        //    for (int i = 0; i < Index - 1; i++)
        //    {
        //        if (Temp.pNext == null) break;
        //        Temp = Temp.pNext;
        //    }
        //    Temp.pNext = new Element(Data, Temp.pNext);
        //    Length++;
        //}
        public void PopFront()
        {
            if (Head == null) return;

            if (Head==Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = Head.pNext;
                Head.pPrev = null;
            }

            Length--;
        }

        public void PopBack()
        {
            if (Tail == null) return;

            if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail = Tail.pPrev;
                Tail.pNext = null;
            }

            Length--;
        }

        public void Print()
        {
            Element current = Head;
            while(current != null)
            {
                Console.Write(current.Data + " ");
                current = current.pNext;
            }
            Console.WriteLine();
        }
    }
}
