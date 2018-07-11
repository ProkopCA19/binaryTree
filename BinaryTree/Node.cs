using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        public Node right;
        public Node left;
        public int data;



        //Constructor
        public Node(int data)
        {
            right = null;
            left = null;
            this.data = data;

        }




    }
}
