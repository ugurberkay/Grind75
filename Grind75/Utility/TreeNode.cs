using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind75.Utility
{
    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val,TreeNode? left,TreeNode? right) 
        {
            this.val = val;
            this.left = left;
            this.right = right;
        
        }
    }
}
