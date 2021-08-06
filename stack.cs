using System;
using System.Collections.Generic;
using System.Text;

namespace StackandQueue
{
    class stack
    {
        private Node top;
        public stack()
        {
            this.top = null;
        }
        public void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = this.top;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        public void Display()
        {
            Node temp = this.top;
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is Peek element of Stack", top.data);
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is Poped from the Stack", top.data);
            top = top.next;
        }
        public void ISEmpty()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            while (top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}