using Grind75.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind75.Week1
{
    internal class InvertBinaryTree
    {
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root==null)
            {
                return null;
            }
            TreeNode right=InvertTree(root.right);
            TreeNode left=InvertTree(root.left);
            root.left = right;
            root.right=left;
            return root;

        }

        public static TreeNode InvertTreeQueue(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode? temp;
            while (queue.Count > 0)
            {
                temp=queue.Peek().left;
                queue.Peek().left= queue.Peek().right;
                queue.Peek().right= temp;
                if (queue.Peek().left!=null)
                {
                    queue.Enqueue(queue.Peek().left);
                }
                if (queue.Peek().right != null)
                {
                    queue.Enqueue(queue.Peek().right);
                }
                queue.Dequeue();
            }
            return root;
        }
    }
}
