// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;

namespace Parameters
{

    class Program
    {
        public static void Swap (ref int a, ref int b) 
        {
            int temp;
            temp=a;
            a=b;
            b=temp;
        }
        
        public static void Swap (ref int[] a) 
        {
            int temp;
            temp=a[2];
            a[2]=a[3];
            a[3]=temp;
        }
        static void Main(string[] args)
        {
            int a=1;
            int b=2;
            System.Console.WriteLine("a="+a);
            System.Console.WriteLine("b="+b);
            Swap(ref a,ref b);
            System.Console.WriteLine("a="+a);
            System.Console.WriteLine("b="+b);
            int[] ar= { 2, 3, 4, 1, 8, 6, 5, 7 };
            System.Console.WriteLine("prije Swap funckije");
            for(int i=0;i<ar.Length;i++)
            {
                System.Console.WriteLine(ar[i]);
            }
            Swap(ref ar);
            System.Console.WriteLine("nakon Swap funkcije:");
            for(int i=0;i<ar.Length;i++)
            {
                System.Console.WriteLine(ar[i]);
            }
        }
    }
}
