using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinaryTree
{
    internal class Tree
    {
        private Element Root { get; set; }
        public Tree()
        {
            Root = null;
            Console.WriteLine("TC");
        }
        ~Tree()
        {
            Console.WriteLine("TD");
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

        public int Depth()
        {
            if (Root == null) return 0;
            else return Depth(Root);
        }
        private int Depth(Element Root)
        {
            if (Root == null) return 0;
            else return (Depth(Root.pLeft) > Depth(Root.pRith)) ? Depth(Root.pLeft) + 1 : Depth(Root.pRith) + 1;
        }
        public void Clear() => Root = null;

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
            Console.WriteLine(node.Data);
            Print(node.pRith);
        }
    }
}
