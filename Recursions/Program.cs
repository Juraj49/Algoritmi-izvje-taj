using System.Diagnostics;

namespace Recursions

{
    class Program
    {
        static int Factorial( int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        static int Fibonnacci(int i)
        {
            if(i<2)
            return i;
            else
            return Fibonnacci(i-1)+Fibonnacci(i-2);
        }

        static int FibonacciIter(int a)
        {
            if(a<2)
            return a;
            else
            {
                int temp=0,q=0,w=1;
                for(int j=0;j<a;j++)
                {
                    temp=q;
                    q=w;
                    w=temp+w; 
                }
                return q;
            }
        }

        static void Main(string[] args)
        {
            long result;
            result=Factorial(6);
            System.Console.WriteLine("result of factorial= {0}",result);
            Stopwatch stopwatch=new Stopwatch();
            stopwatch.Start();
            result=Fibonnacci(40);
            stopwatch.Stop();
            System.Console.WriteLine("result of fibonaci= {0},time={1}",result,stopwatch.Elapsed);

            stopwatch.Reset();
            stopwatch.Start();
            result=FibonacciIter(40);
            stopwatch.Stop();
            System.Console.WriteLine("result of fibonaciIter= {0},time={1}",result,stopwatch.Elapsed);

        }
    }
}
