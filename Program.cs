using StackandQueue.Queue;
using StackandQueue.Stack;
using System;

namespace StackandQueueProblem
{
    class Program
    {
        static readonly LinkedListStack linkedListStack = new LinkedListStack();
        static readonly LinkedListQueue queue = new LinkedListQueue();
       
        public static void StackMenu()
        {
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            Console.WriteLine("----------------------------");
            linkedListStack.Display();
            Console.WriteLine("----------------------------");
            linkedListStack.Peek();
            linkedListStack.Pop();
            Console.WriteLine("----------------------------");
            linkedListStack.Display();
            Console.WriteLine("----------------------------");
            linkedListStack.ISEmpty();
            Console.WriteLine("----------------------------");
            linkedListStack.Display();
            Console.WriteLine("----------------------------");
        }
        public static void QueueMenu()
        {
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            Console.WriteLine("----------------------------");
            queue.Dequeue();
            queue.Display();
            Console.WriteLine("----------------------------");
        }
        static void Main(string[] args)
        {
            Program.StackMenu();
            Program.QueueMenu();
        }
    }
}