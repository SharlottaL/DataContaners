using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input size tree");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            Tree tree = new Tree();
            for(int i = 0; i<n;i++)
            {
                tree.Insert(rand.Next(100));
            }
            tree.Print();
            Console.WriteLine($"Min Value tree{tree.MinValue()}");
            Console.WriteLine($"Max Value tree{tree.MaxValue()}");
            Console.WriteLine($"Colichestvo Value tree{tree.Count()}");
            Console.WriteLine($"Sum Value tree{tree.Sum()}");
            Console.WriteLine($"Depth tree{tree.Depth()}");
            //Console.Write("Input Value");
            //int value = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Delete Value tree");
            //tree.Erase(value);
            //tree.Print();
            Console.WriteLine($"Clear Value tree");
            tree.Clear();
            tree.Print();

            //UniqueTree u_tree = new UniqueTree();
            //for (int i = 0; i < n; i++)
            //{
            //    u_tree.Insert(rand.Next(100));
            //}
            //u_tree.Print();
            //Console.WriteLine($"Min Value tree{u_tree.MinValue()}");
            //Console.WriteLine($"Max Value tree{u_tree.MaxValue()}");
            //Console.WriteLine($"Colichestvo Value tree{u_tree.Count()}");
            //Console.WriteLine($"Sum Value tree{u_tree.Sum()}");
            //Console.WriteLine($"Depth tree{u_tree.Depth()}");
            //Console.Write("Input Value");
            //int value = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine($"Delete Value tree{}");
            ////u_tree.Erase(value, u_tree.Root);
            ////u_tree.Clear();
            //// Console.WriteLine($"Clear Value tree");
            //u_tree.Print();
            Console.ReadLine();
        }
    }
}
