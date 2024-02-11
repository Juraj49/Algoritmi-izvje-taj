

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue=new();
            queue.EnQueue("Ana");
            queue.EnQueue("Anita");
            queue.EnQueue("Marko");
            queue.EnQueue("Matija");
            queue.Display();
            while(true)
            {
                try
                {
                    queue.Dequeue();
                    queue.Display();
                }
                catch(Exception)
                {
                    System.Console.WriteLine("No more elements in the list");
                    break;
                }
            }
        }
    }
}


