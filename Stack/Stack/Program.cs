
using System.Linq.Expressions;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack=new();
            stack.Push("Kim");
            stack.Push("Iva");
            stack.Push("Bob");
            stack.Push("Ana");
            stack.Display();
            while(true)
            {
                try
                {
                    stack.Pop();
                    stack.Display();
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
