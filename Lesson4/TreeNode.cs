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
        void AddItem(int value); // добавить узел
        void RemoveItem(TreeNode node); // удалить узел по значению
        TreeNode GetNodeByValue(TreeNode node, int value); //получить узел дерева по значению
        int Print(TreeNode node, int x, int y);//вывести дерево в консоль
    }
}

