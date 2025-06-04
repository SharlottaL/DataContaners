using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class UniqueTree:Tree
    {
        private Element Root { get; set; }
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
            else if (Data > Root.Data)
            {
                if (Root.pRith == null) Root.pRith = new Element(Data);
                else Insert(Data, Root.pRith);
            }
        }

    }
}
