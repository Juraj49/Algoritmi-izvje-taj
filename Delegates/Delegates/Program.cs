// See https://aka.ms/new-console-template for more information

 delegate void Invoker (int i);
namespace Delegates
{
    class Program
    {
        static void Method(Invoker invoker, int value)
        {
        invoker(value);
        }
        static void Display(int i)
        {
        Console.WriteLine("Displaying " + i);
        }
        static void Print(int i)
        {
        Console.WriteLine("Printing " + i);
        }

        static void Main(string[] args)
        {
            Invoker invoker= new Invoker(Display);
           // Invoker invoker=Display; -->druga metoda, jednistavnija i brža
            invoker(1);
           //Method(invoker,1); -->druga metoda ali duža 
            invoker=Print;
            invoker(2);
            invoker +=Display;
            invoker(3);
            Method(Display,4);
            Method(Print,5);
            invoker = delegate(int i)
            {
            Console.WriteLine("Anonymousing " + i);
            };
            invoker(6);
            invoker = i => Console.WriteLine("Lamdaing " + i);
            invoker(7);
            
        }
    }
}
