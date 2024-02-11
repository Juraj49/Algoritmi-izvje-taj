
using System.ComponentModel.DataAnnotations;

namespace Searching
{
    class Program
    {
        static int SequentialSearch(int[] b,int a)
        {
            for(int i=0;i<b.Length;i++)
            {
                if(a==b[i])
                {
                    return i+1;
                }
            }
            
            return -1;
        }
        static int BinarySearch(int[] b,int a)
        {
            int start=0,end=b.Length-1,mid=(b.Length-1)/2;
            while(start<=end)
            {
                if(a==b[mid])
                {
                    return mid+1;
                }
                else if(b[mid]>a)
                {
                    end=mid-1;
                    mid=(start+end)/2;
                }
                else
                {
                    start=mid+1;
                    mid=(start+end)/2;
                }
            }
            return-1;
        }
        static int BinarySearch(int[] b,int a, int c, int d)
        {
            int start=c, end=d, mid=(c+d)/2;
            while(start<=end)
            {
            if(a==b[mid])
            {
                return mid+1;
            }
            else if(b[mid]>a)
            {
                end=mid-1;
                return BinarySearch(b,a,start,end);
            }
            else 
            {
                start=mid+1;
                return BinarySearch(b,a,start,end);
            }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] c={1,2,3,5,113,5634,674,3214,4,234,7};
            System.Console.WriteLine(SequentialSearch(c,113));
            int [] d={1,2,3,4,5,7,8,9,10,12,13,14,15};
            System.Console.WriteLine(BinarySearch(d,7));
            System.Console.WriteLine(BinarySearch(d,8,1,9));

        }
    }
}