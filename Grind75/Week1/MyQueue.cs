using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grind75.Week1
{
    public class MyQueue
    {
        Stack<int> stack1=new Stack<int>();
        Stack<int> stack2 = new Stack<int>();
        public MyQueue() { }
        public void Push(int x) 
        {
            while (stack1.Count>0)
            {
                stack2.Push(stack1.Pop());  
            }
            stack1.Push(x);
            while (stack2.Count>0)
            {
                stack1.Push(stack2.Pop());
            }


        }
        public void Pop() 
        { 
            stack1.Pop();
        }
        public void Peek()
        {
            stack1.Peek();
        }
        public void Empty()
        {
            stack1.Clear();
        }
    }

    public class MyQueueWithOne
    {
        Stack<int> stack = new Stack<int>();
        public MyQueueWithOne() { }
        public void Push(int x)
        {
            stack.Push(x);
        }
        public int Pop()
        {
            if (stack.Count==0)
            {
                Environment.Exit(0);
            }
            int top=stack.Pop();
            if (stack.Count==0)
            {
                return top;
            }
            int item = Pop();
            stack.Push(top);
            return item;
        }

    }
}
