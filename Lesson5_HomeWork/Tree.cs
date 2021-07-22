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

        public TreeNode QueueSearch(TreeNode node, int numToFind)
        {
            if (node == null)
            {
                return null;
            }

            Queue<TreeNode> testQueue = new();
            TreeNode nodeToFind = new();
            testQueue.Enqueue(node);
            Console.Write(node.Value+" ");
            while (testQueue.Count > 0)
            {
                nodeToFind = testQueue.Dequeue();
                
                if (nodeToFind.Value == numToFind)
                {
                    Console.WriteLine($"\nNode {numToFind} was found");
                    return nodeToFind;
                }
                else
                {
                    if (nodeToFind.LeftChild != null)
                    {
                        testQueue.Enqueue(nodeToFind.LeftChild);
                        Console.Write(nodeToFind.LeftChild.Value + " ");
                    }
                    if (nodeToFind.RightChild != null)
                    {
                        testQueue.Enqueue(nodeToFind.RightChild);
                        Console.Write(nodeToFind.RightChild.Value + " ");
                    }
                }
            }
            Console.WriteLine($"\nNode {numToFind} not Found");
            return null;
        }
        public TreeNode StackSearch(TreeNode node, int numToFind)
        {
            if (node == null)
            {
                return null;
            }
            Stack<TreeNode> testStack = new();
            TreeNode currentNode = node;

            while (currentNode != null || testStack.Count != 0)
            {
                while (currentNode != null)
                {
                    Console.Write(currentNode.Value + " ");
                    if (currentNode.Value == numToFind)
                    {
                        Console.WriteLine($"\nNode {numToFind} was found");
                        return currentNode;
                    }
                    if (currentNode.RightChild != null)
                        testStack.Push(currentNode.RightChild);

                    currentNode = currentNode.LeftChild;
                }
                if (testStack.Count != 0)
                {
                    currentNode = testStack.Pop();
                }
            }
            Console.WriteLine($"\nNode {numToFind} not Found");
            return null;
        }
    }
}
