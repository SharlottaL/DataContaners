using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Element
    {
       public int Data { get; set; }
        public Element pLeft { get; set; }
        public Element pRith { get; set; }
        //private Element Root { get; set; }
        public Element (int Data, Element pLeft = null, Element pRigth = null)
        {
            this.Data = Data;
            this.pLeft = pLeft;
            this.pRith = pRigth;
            Console.WriteLine("EC");
        }
        ~Element()
        {
            Console.WriteLine("ED");
        }
    }
}
