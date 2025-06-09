//#define TREEONE
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
#if TREEONE
            Console.Write("input size tree");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            Tree tree = new Tree();
            for (int i = 0; i < n; i++)
            {
                tree.Insert(rand.Next(100));
            }
            //tree.Print();

            //Console.WriteLine($"Min Value tree{tree.MinValue()}");

            //Console.WriteLine($"Min naideno{stop - start}");
            //Console.WriteLine($"Max Value tree{tree.MaxValue()}");
            //Console.WriteLine($"Colichestvo Value tree{tree.Count()}");
            //Console.WriteLine($"Sum Value tree{tree.Sum()}");
            //Console.WriteLine($"Depth tree{tree.Depth()}");
            Console.WriteLine("Несбалансированное дерево:");
            tree.Print();

             // Балансируем

            
            TreePerfomanse<int>.Measure("Min Value tree", tree.MinValue);
            TreePerfomanse<int>.Measure("Max Value tree", tree.MaxValue);
            TreePerfomanse<int>.Measure("Colichestvo Value tree", tree.Count);
            TreePerfomanse<int>.Measure("Sum Value tree", tree.Sum);
            TreePerfomanse<int>.Measure("Depth tree", tree.Depth);
            tree.Balance();
            Console.WriteLine("\nСбалансированное дерево:");
            tree.Print();
            Console.WriteLine($"Глубина после балансировки: {tree.Depth()}");
            //TreePerfomanse<double>.Measure("Avg tree", tree.Avg);
            //Console.Write("Input Value");
            //int value = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Delete Value tree");
            //tree.Erase(value);
            //tree.Print();
            //Console.WriteLine($"Clear Value tree");
            //tree.Clear();
            //tree.Print();

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
#endif
            //            Tree tree = new Tree()
            //            {
            //50, 25,75,16,32,70,80
            //            }
            Tree tree = new Tree();
            //tree.Insert(50);
            //tree.Insert(25);
            //tree.Insert(75);
            //tree.Insert(16);
            //tree.Insert(32);
            //tree.Insert(70);
            //tree.Insert(80);

            tree.Insert(55);
            tree.Insert(34);
            tree.Insert(21);
            tree.Insert(13);
            tree.Insert(8);
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(2);
            tree.Insert(1);



            tree.Print();
            Console.WriteLine("\n----------------------------------\n");

            //tree.DepthPrint(2);

            tree.TreePrint();
            //tree.Erase(50);
            tree.Balance();
            tree.TreePrint();
            Console.ReadLine();
        }
       
    }
}
