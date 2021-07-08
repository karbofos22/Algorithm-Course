using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class LinkedList : ILinkedList
    {
        Node head; // головной/первый элемент
        Node tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        public void AddNode(int value)
        {
            var node = new Node { Value = value };

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.NextNode = node;
                node.PrevNode = tail;
            }
            tail = node;

            count++;
        }

        public void AddNodeAfter(Node newNode, int value)
        {
            var nodeToAdd = new Node { Value = value };
            var nextItem = newNode.NextNode;
            newNode.NextNode = nodeToAdd;
            nextItem.PrevNode = nodeToAdd;
            nodeToAdd.NextNode = nextItem;
            nodeToAdd.PrevNode = newNode;
            count++;
        }

        public Node FindNode(int searchValue)
        {
            Node currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(searchValue))
                    return currentNode;
                else
                    currentNode = currentNode.NextNode;
            }
            return null;
        }

        public int GetCount()
        {
            return count;
        }

        public Node RemoveNodeByIndex(int index)
        {
            if (index == 0)
            {
                var newHead = head.NextNode;
                newHead.PrevNode = null;
                head = newHead;
                count--;
                return head;
            }

            int currentIndex = 0;
            var currentNode = head;
            while (currentNode != null)
            {
                if (currentIndex == index)
                {
                    RemoveNode(currentNode);
                    return head;
                }
                currentNode = currentNode.NextNode;
                currentIndex++;
            }
            return head;
        }



        public void RemoveNode(Node nodeToRemove)
        {
            if (nodeToRemove == null)
                return;
            else
            {
                nodeToRemove.NextNode.PrevNode = nodeToRemove.PrevNode;
                nodeToRemove.PrevNode.NextNode = nodeToRemove.NextNode;
                count--;
            }
        }
    }
}



