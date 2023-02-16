using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind75.Week1
{
    internal class MergeTwoSorted
    {
       public LinkedList<int> MergeTwoLists(LinkedList<int> list1,LinkedList<int> list2)
        {
            LinkedList<int> result = new LinkedList<int>();

            while (list1.Count>0 && list2.Count>0)
            {
                if (list1.First.Value<=list2.First.Value)
                {
                    result.AddLast(list1.First.Value);
                    list1.RemoveFirst();
                }
                else
                {
                    result.AddLast(list2.First.Value);
                    list2.RemoveFirst();
                }
            }
            if (list1.Count>1)
            {
                while (list1.Count>0)
                {
                    result.AddLast(list1.First.Value);
                    list1.RemoveFirst(); 
                }
            }
            else if (list2.Count>0)
            {
                while (list2.Count>0)
                {
                    result.AddLast(list2.First.Value);
                    list2.RemoveFirst();
                }
            }

            return result;
        }

        //cant use recursive with c# linked list because cant change the next of the node
        //main logic is the check first nodes of list and go to the next of the node with recursive
        //1 2 4
        //1 3 4
        //Check 1's and change 1.next to Mergetwolists(node1.next,node2(first element)) etc.
       
    }
}
