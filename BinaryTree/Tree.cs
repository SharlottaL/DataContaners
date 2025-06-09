using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinaryTree
{
    internal class Tree
    {
        static readonly int BASE_INTERVAL = 3;
        public Element Root { get; protected set; }
        public Tree()
        {
            Root = null;
            //Console.WriteLine("TC");
        }
        ~Tree()
        {
            //Console.WriteLine("TD");
        }
        //public IEnumerator<T> GetEnumerator()
        //{
        //    return Root;
        //}
        public int Depth()
        {
            return Depth(Root);
        }
        int Depth(Element Root)
        {
            if (Root == null) return 0;
            int lDepth = Depth(Root.pLeft);
            int rDepth = Depth(Root.pRith);
            return (lDepth > rDepth ? lDepth : rDepth) + 1;
        }

        public void DepthPrint(int Depth)
        {
            DepthPrint(Root, Depth);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        void DepthPrint(Element Root, int Depth)
        {
            int interval = BASE_INTERVAL * (this.Depth(this.Root) - Depth);
            if (Root == null)
            {
                Console.Write("".PadLeft(interval));
                return;
            }

            if (Depth == 0)
            {
                Console.Write(Root.Data.ToString().PadLeft(interval));
            }
            else
            {
                DepthPrint(Root.pLeft, Depth - 1);
                DepthPrint(Root.pRith, Depth - 1);
            }
        }
        public void TreePrint(int Depth = 0)
        {
            if (Root == null) return;
            if (this.Depth(this.Root) - Depth == 0) return;
            int interval = BASE_INTERVAL * (this.Depth() - Depth);
            Console.Write("".PadLeft(interval));
            PrintInterval(this.Depth(this.Root) - Depth);
            DepthPrint(Depth);
            TreePrint(Depth + 1);
        }
        void PrintInterval(int count)
        {
            for (int i = 0; i < count; i++) Console.Write("    ");
        }
        public double Avg()
        {
            return (double)Sum(Root) / Count(Root);
        }
        public void Insert(int Data)
        {
            if (this.Root == null) this.Root = new Element(Data);
            else Insert(Data, Root);
        }
        private void Insert(int Data, Element Root)
        {
            if (this.Root == null) this.Root = new Element(Data);
            if (Root == null) return;
            if (Data < Root.Data)
            {
                if (Root.pLeft == null) Root.pLeft = new Element(Data);
                else Insert(Data, Root.pLeft);
            }
            else
            {
                if (Root.pRith == null) Root.pRith = new Element(Data);
                else Insert(Data, Root.pRith);
            }

        }

        public void Clear() => Root = null;
        public void Erase(int Data)
        {
            Element Root = this.Root;
            Erase(Data, Root, null);
        }
        void Erase(int Data, Element Root, Element Parent)
        {
            if (Root == null) return;
            Erase(Data, Root.pLeft, Root);
            Erase(Data, Root.pRith, Root);
            if (Data == Root.Data)
            {
                if (Root.pLeft == Root.pRith)
                {
                    if (Root.Equals(Parent.pLeft)) Parent.pLeft = null;
                    if (Root.Equals(Parent.pRith)) Parent.pRith = null;
                }
                else
                {
                    if (Count(Root.pLeft) > Count(Root.pRith))
                    {
                        Root.Data = MaxValue(Root.pLeft);
                        Erase(MaxValue(Root.pLeft), Root.pLeft, Root);
                    }
                    else
                    {
                        Root.Data = MinValue(Root.pRith);
                        Erase(MinValue(Root.pRith), Root.pRith, Root);
                    }
                }
            }
            //if(Root != null)Erase(Data, Root.pLeft);
            //if(Root != null)Erase(Data, Root.pRight);
        }
        public void Balance()
        {
            Balance(Root);
        }
        void Balance(Element Root)
        {
            if (Root == null) return;
            //Balance(Root.pLeft);
            //Balance(Root.pRight);
            if (Math.Abs(Count(Root.pLeft) - Count(Root.pRith)) < 2) return;
            if (Count(Root.pLeft) > Count(Root.pRith))
            {
                if (Root.pRith == null) Root.pRith = new Element(Root.Data);
                else Insert(Root.Data, Root.pRith);
                Root.Data = MaxValue(Root.pLeft);
                Erase(MaxValue(Root.pLeft), Root.pLeft, Root);
            }
            else
            {
                if (Root.pLeft == null) Root.pLeft = new Element(Root.Data);
                else Insert(Root.Data, Root.pLeft);
                Root.Data = MinValue(Root.pRith);
                Erase(MinValue(Root.pRith), Root.pRith, Root);
            }
            Balance(Root.pLeft);
            Balance(Root.pRith);
            Balance(Root);
        }
        public int MinValue()
        {
            if (Root == null) return 0;
            else return MinValue(Root);
        }
        private int MinValue(Element Root)
        {
            if (Root == null) return 0;
            else return Root.pLeft == null ? Root.Data : MinValue(Root.pLeft);
        }
        public int MaxValue()
        {
            if (Root == null) return 0;
            else return MaxValue(Root);
        }
        private int MaxValue(Element Root)
        {
            if (Root == null) return 0;
            else return Root.pRith == null ? Root.Data : MaxValue(Root.pRith);
        }
        public int Count()
        {
            return Count(Root);
        }
        private int Count(Element Root)
        {
            return Root == null ? 0 : Count(Root.pLeft) + Count(Root.pRith) + 1;
        }
        public int Sum()
        {
            return Sum(Root);
        }
        private int Sum(Element Root)
        {
            return Root == null ? 0 : Sum(Root.pLeft) + Sum(Root.pRith) + Root.Data;
        }
        public void Print()
        {
            if (Root == null) return;
            Print(Root);
        }
        private void Print(Element node)
        {
            if (node == null) return;
            Print(node.pLeft);
            Console.Write(node.Data + "  ");
            Print(node.pRith);
        }
    }
}
