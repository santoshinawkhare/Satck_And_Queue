using System;

namespace StackAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Stack And Queue  Program!");

            /* UC1 stack = new UC1();
             stack.push(70);
             stack.push(30);
             stack.push(56);
             stack.Display();*/

            /*UC2 stack = new UC2();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.IsEmpty();
            stack.Display();*/

            //Queue Operations
            UC4 linkedListQueue = new UC4();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();

            //Stack Operations
            UC3 stack = new UC3();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.IsEmpty();
            stack.Display();
        }
    }
}
