using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            bool result;

            tree.Add(50);
            tree.Add(30);
            tree.Add(80);
            tree.Add(20);
            tree.Add(27);
            tree.Add(18);
            tree.Add(60);
            tree.Add(70);

            result = tree.Search(1);
            Console.WriteLine(result);
            Console.ReadLine();



        }
    }
}
