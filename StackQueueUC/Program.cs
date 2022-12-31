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
                "\nChoose 1): To Creating a Stack  \n");
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
                default:
                    break;
            }
        }
    }

}