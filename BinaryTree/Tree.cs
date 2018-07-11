using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree
    {

        public Node root;


        //constructor
        public Tree()
        {
            root = null;
           
        }




        public void Add(int data)
        {
          if(root == null)
          {
                root = new Node(data);
                return;
          }
            bool added = false;
            Node currentNode = root;
            do
            {
                if (data >= currentNode.data)
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = new Node(data);
                        added = true;
                    }
                    else
                        currentNode = currentNode.right;
                }
                if (data < currentNode.data)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = new Node(data);
                        added = true;
                    }
                    else
                        currentNode = currentNode.left;
                }
            } while (!added);
        }


        public bool Search(int data)
        {
            Node currentNode = root;
            while(currentNode !=null)
            {
                if (data == currentNode.data)
                {
                    return true;
                }
                else if (data > currentNode.data)
                {
                    if (currentNode.right == null)
                    {
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                   
                    }
                }
                if (data < currentNode.data)
                {
                    if (currentNode.left == null)
                    {
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                       
                    }
                }

            }

            return false;
        }



    }


}
