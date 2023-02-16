using Grind75.Utility;
using Grind75.Week1;

namespace Grind75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode s1 = new TreeNode(1,null,null);
            TreeNode s2 = new TreeNode(3,null,null);
            TreeNode s3 = new TreeNode(2,s1,s2);
            TreeNode s4 = new TreeNode(6,null,null);
            TreeNode s5 = new TreeNode(9,null,null);
            TreeNode s6 = new TreeNode(7,s4,s5);
            TreeNode root = new TreeNode(4,s3,s6);

            InvertBinaryTree.InvertTreeQueue(root);
            
        }
    }
}