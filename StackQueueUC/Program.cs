using StackQueueUC;

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
                "\nChoose 2): To Remove Top Element From a Stack");
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
                default:
                    break;
            }
        }
    }

}