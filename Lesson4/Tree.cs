using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Tree : ITree
    {
        TreeNode root;

        public void AddItem(int value)
        {
            TreeNode newNode = new TreeNode { Value = value };

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                TreeNode currentNode = root;
                TreeNode parent;

                while (true)
                {
                    parent = currentNode;
                    if (value < currentNode.Value)
                    {
                        currentNode = currentNode.LeftChild;
                        if (currentNode == null)
                        {
                            parent.LeftChild = newNode;
                            newNode.Parent = parent;
                            break;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.RightChild;
                        if (currentNode == null)
                        {
                            parent.RightChild = newNode;
                            newNode.Parent = parent;
                            break;
                        }
                    }
                }
            }
        }

        public TreeNode GetNodeByValue(TreeNode node, int value)
        {
            if (node == null)
                return null;
            switch (value.CompareTo(node.Value))
            {
                case 1:
                    return GetNodeByValue(node.RightChild, value);
                case -1:
                    return GetNodeByValue(node.LeftChild, value);
                case 0:
                    return node;
                default:
                    return null;
            }
        }

        public TreeNode GetRoot()
        {
            return root;
        }

        public int Print(TreeNode node, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(node.Value);

            var loc = y;

            if (node.RightChild != null)
            {
                Console.SetCursorPosition(x + 2, y);
                Console.Write("--");
                y = Print(node.RightChild, x + 4, y);
            }

            if (node.LeftChild != null)
            {
                while (loc <= y)
                {
                    Console.SetCursorPosition(x, loc + 1);
                    Console.Write(" |");
                    loc++;
                }
                y = Print(node.LeftChild, x, y + 2);
            }
            return y;
        }


        public void RemoveItem(TreeNode nodeToDelete)
        {

            if (nodeToDelete == null)
                return;
            TreeNode currenNode = new();

            if (nodeToDelete.Value == root.Value)
            {
                root = root.RightChild;
                root.Parent = null;
               
                root.LeftChild.LeftChild = nodeToDelete.LeftChild;
                root.LeftChild.LeftChild.Parent = root.LeftChild;
                return;
            }

            if (nodeToDelete.LeftChild != null && nodeToDelete.RightChild != null)
            {
                if (nodeToDelete.Value < nodeToDelete.Parent.Value)
                {
                    nodeToDelete.Parent.LeftChild = nodeToDelete.RightChild;             
                    nodeToDelete.RightChild.Parent = nodeToDelete.Parent;                 
                }
                else if (nodeToDelete.Value > nodeToDelete.Parent.Value)
                {
                    nodeToDelete.Parent.RightChild = nodeToDelete.RightChild;
                    nodeToDelete.RightChild.Parent = nodeToDelete.Parent;
                }
                if (nodeToDelete.RightChild.LeftChild != null)         
                {
                    currenNode = nodeToDelete.RightChild;         
                    currenNode = currenNode.LeftChild;
                    currenNode.LeftChild = nodeToDelete.LeftChild;        
                    nodeToDelete.LeftChild.Parent = currenNode;       
                }
                if (nodeToDelete.RightChild.LeftChild == null)
                {
                    currenNode = nodeToDelete.RightChild;
                    currenNode.LeftChild = nodeToDelete.LeftChild;
                    nodeToDelete.LeftChild.Parent = nodeToDelete.RightChild;

                    
                }


            }
            else if (nodeToDelete.LeftChild == null && nodeToDelete.RightChild == null)
            {
                currenNode = nodeToDelete.Parent;
                if (nodeToDelete.Parent.Value < nodeToDelete.Value)
                    currenNode.RightChild = null;
                else
                    currenNode.LeftChild = null;
            }
            else if (nodeToDelete.LeftChild != null && nodeToDelete.RightChild == null)
            {
                currenNode = nodeToDelete.Parent;
                currenNode.RightChild = nodeToDelete.LeftChild;
                nodeToDelete.LeftChild.Parent = currenNode;
            }
            else if (nodeToDelete.LeftChild == null && nodeToDelete.RightChild != null)
            {
                currenNode = nodeToDelete.Parent;
                currenNode.RightChild = nodeToDelete.RightChild;
                nodeToDelete.RightChild.Parent = currenNode;
            }


        }
    }
}
