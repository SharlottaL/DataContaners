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
        Element Tail { get; set; }
        public int Length { get; private set; }
        public List()
        {
            Head = null;
            Tail = null;
            Console.WriteLine($"LConstr:\t{GetHashCode()}");
        }
        ~List()
        {
            Head = null;
            Tail = null;
            Length = 0;
            Console.WriteLine($"LDestr:\t{GetHashCode()}");
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Length = 0;
        }
       
        public void PushFront(int Data)
        {
            Head = new Element(Data, Head);
            //Tail = new Element(Data, Head);
            Length++;

        }
        //public void PushBack(int Data)
        //{
        //    Element New = new Element(Data);
        //    if (Head == null)
        //    {
        //        PushFront(Data);
        //        return;
        //    }
        //    ////Element Temp = Tail;
        //    ////while (Temp.pPrew != null) Temp = Temp.pPrew;

        //    ////Temp.pPrew = new Element(Data);
        //    ////Tail.pNext = New;
        //    ////New.pPrew = Tail;
        //    ////////2)
        //    //////New.pNext = Head;
        //    ////Tail = New;
        //    ////Element Temp = Head;
        //    ////while (Temp.pNext != null) Temp = Temp.pNext;

        //    ////Temp.pNext = new Element(Data);


        //    ////Length++;
        //    ////}
        //    ////Element Temp = Head;
        //    ////while (Tail.pNext != null) Tail = Tail.pPrew;

        //    ////Tail.pNext = new Element(Data);

        //    ////Tail = new Element(Data, Head);
        //    ////Head = new Element(Data, Head);
        //    //else
        //    //{
        //    //    // 3.1. Привязываем новый элемент после текущего хвоста
        //    //    Tail.pNext = New;

        //    //    // 3.2. Устанавливаем обратную ссылку нового элемента
        //    //    New.pPrew = Tail;

        //    //    // 3.3. Обновляем хвост списка
        //    //    Tail = New;
        //    //}

        //    //// 4. Увеличиваем счетчик элементов
        //    //Length++;
        //    Tail = new Element(Data, Head);
        //    Length++;
        //}
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
            if (Head != null)
            {
                Head = Head.pNext;
                Head.pPrev = null;
            }
            Length--;
        }

        public void PopBack()
        {
            if (Tail != null)
            {
                Tail = Head.pPrev; // Перемещаем хвост назад
               Tail.pNext = null;
            }
            Length--;
        }

        public void Print()
        {
            for (Element Temp = Head; Temp != null; Temp = Temp.pNext)
            {
                Console.WriteLine($"{Temp.Data}\t");
                Console.WriteLine();
                Console.WriteLine($"Col{Length}");
            }
        }
    }
}
