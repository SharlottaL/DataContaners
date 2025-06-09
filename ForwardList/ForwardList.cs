using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ForwardList
{
    internal class ForwardList : IEnumerable
    {

        Element Head { get; set; }
        public int Length { get; private set; }
        public ForwardList()
        {
            Head = null;
            Console.WriteLine($"LConstr:\t{GetHashCode()}");
        }
        public int GetHead()
        {
            if (Head == null)
                throw new IndexOutOfRangeException("Error!!!Head Pysto!");
            return Head.Data;
        }
        public void Clear()
        {
            Head = null;
            Length = 0;
        }
        public void Add(int Data)
        {
            if (Head == null)
            {
                PushFront(Data);
                return;
            }
            Element Temp = Head;
            while (Temp.pNext != null) Temp = Temp.pNext;

            Temp.pNext = new Element(Data);

            Length++;
        }

        public IEnumerator GetEnumerator()
        {
            Element Temp = Head;
            while (Temp != null)
            {
                yield return Temp.Data;  
                Temp = Temp.pNext;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void PushFront(int Data)
        {
            // 1)Создаём новый элемент:
            //Element New = new Element(Data);
            ////2)
            //New.pNext = Head;
            //Head = New;
            Head = new Element(Data, Head);
            Length++;

        }
        public void PushBack(int Data)
        {
            if (Head == null)
            {
                PushFront(Data);
                return;
            }

            Element Temp = Head;
            while (Temp.pNext != null) Temp = Temp.pNext;

            Temp.pNext = new Element(Data);
            Length++;
        }
        public void Insert(int Data, int Index)
        {
            if (Index > Length || Index < 0)
            {
                throw new IndexOutOfRangeException("Error!!!Exit not normal");
                //Console.WriteLine("Error!Exit");
                //return;
            }

            if (Index == 0)
            {
                PushFront(Data);
                return;
            }

            Element Temp = Head;
            for (int i = 0; i < Index - 1; i++)
            {
                if (Temp.pNext == null) break;
                Temp = Temp.pNext;
            }
            Temp.pNext = new Element(Data, Temp.pNext);
            Length++;
        }
        public void PopFront()
        {
            if (Head == null)
                throw new IndexOutOfRangeException("Error!!!PYSTO");
            
            if (Head != null)
                Head = Head.pNext;
            Length--;
        }

        public void PopBack()
        {
            if (Head == null || Head.pNext == null)
            {
                PopFront();
                return;
            }
            Element Temp = Head;
            while (Temp.pNext.pNext != null) Temp = Temp.pNext;

            Temp.pNext = null;
            Length--;
        }


        public void Print()
        {
            for (Element Temp = Head; Temp != null; Temp = Temp.pNext)
            {
                Console.WriteLine($"{Temp.Data}\t");
            }
        }
    }
}
