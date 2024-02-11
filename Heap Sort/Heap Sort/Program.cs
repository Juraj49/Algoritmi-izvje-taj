


namespace HeapSort
{
    class Program
    {
        static void Main(string [] args)
        {
            int [] array ={5,6,8,3,4,2,1,7,3,5,4,4,8};
            foreach (int i in array)
                Console.Write(i + " ");
            Console.WriteLine("");
            Heap.Sort(array);
            foreach (int i in array)
                Console.Write(i + " ");
            Console.WriteLine("");
        }
    }
}
