using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class TreeNode
    {

        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }
        public TreeNode Parent { get; set; }
        public int Value { get; set; }
        
    }
    public interface ITree
    {
        TreeNode GetRoot();
        TreeNode QueueSearch(TreeNode node, int numToFind);
        TreeNode StackSearch(TreeNode node, int numToFind);
        void AddItem(int value); // добавить узел
    }
}





