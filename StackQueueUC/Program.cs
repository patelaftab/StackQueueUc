﻿using StackQueueUC;

namespace StackQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stack And Queue Program ");
            Console.WriteLine("===============================");
            Console.WriteLine("Choose a option from below\n" +
                "\nChoose 1): To Creating a Stack  " +
                "\nChoose 2): To Remove Top Element From a Stack \n " +
                "\nChoose 3): To Creating a Queue With Enqueue \n " +
                "\nChoose 4): To Remove Top Element With Dequeue  \n ");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    LinkedListStack stackObject = new LinkedListStack();
                    stackObject.Push(70);
                    stackObject.Push(30);
                    stackObject.Push(56);
                    stackObject.Display();
                    break;
                case 2: //UC2 stack. Add 56 30 70 .  (peek -display top most element) (pop -removing top-most element)
                    LinkedListStack stackObject1 = new LinkedListStack();
                    stackObject1.Push(70);
                    stackObject1.Push(30);
                    stackObject1.Push(56);
                    stackObject1.Display(); //IsEmpty() internally calling Pop() and Pop() internally calling Peek().
                    Console.WriteLine("Is list is empty? " + stackObject1.isEmpty());
                    stackObject1.Display();
                    break;
                case 3: //UC3 queue. Add sequence 56 30 70 and displaying .
                    LinkedListQueue queueObj = new LinkedListQueue();
                    queueObj.Enque(56);
                    queueObj.Enque(30);
                    queueObj.Enque(70);
                    queueObj.Display();
                    break;
                case 4: //UC4 Deque. 
                    LinkedListQueue queueObj1 = new LinkedListQueue();
                    queueObj1.Enque(56);
                    queueObj1.Enque(30);
                    queueObj1.Enque(70);
                    queueObj1.Display();
                    queueObj1.Deque();
                    queueObj1.Display();
                    queueObj1.Deque();
                    queueObj1.Display();
                    queueObj1.Deque();
                    queueObj1.Display();
                    break;
                default:
                    Console.WriteLine("Choose A Valid Option");
                    break;
            }
        }
    }

}