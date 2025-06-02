using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Element
    {
        public int Data { get; set; }
        public Element pNext { get; set; }
        public Element pPrev { get; set; }
        public Element(int Data, Element pNext = null, Element pPrev = null)
        {
            this.Data = Data;
            this.pNext = pNext;
            this.pPrev = pPrev;
            Console.WriteLine($"EConstr{GetHashCode()}");
        }
        ~Element()
        {
            Console.WriteLine($"EDestr{GetHashCode()}");
        }
    }
}
