using Grind75.Utility;
using Grind75.Week1;

namespace Grind75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();
            MyQueueWithOne newqueue=new MyQueueWithOne();

            queue.Push(1);
            queue.Push(2);
            queue.Peek();
            queue.Pop();
            queue.Empty();


            newqueue.Push(1);
            newqueue.Push(2);
            newqueue.Push(3);
            newqueue.Push(4);
            newqueue.Pop();
            newqueue.Pop();
            newqueue.Pop();
            newqueue.Pop();
        }
    }
}