

namespace Program
{
    class Program
    {
        static void Main(string [] args)
        {
            int [] array={9,8,4,11,5,7,3,1};
            for(int i=0;i<array.Length;i++)
            {
                System.Console.WriteLine(array[i]);
            }
            Selection.Sort(array,0);
            for(int i=0;i<array.Length;i++)
            {
                System.Console.WriteLine(array[i]);
            }
        }
    }
}