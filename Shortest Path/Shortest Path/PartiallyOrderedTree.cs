
using System.Collections;

namespace ShortestPath;
class PartiallyOrderedTree : IEnumerable
{
    internal int[] queue;
    Graph graph;
    public int last;
    public PartiallyOrderedTree(Graph graf)
    {
        this.graph=graf;
        last=graph.vertices.Length;
        queue=new int[last+1];
        queue[0]=-1;
        for(int i = 0; i < last; i++)
        {
            this.queue[i+1]=i;
        }
    }
    public void Swap(int a, int b)
    {
        if (a < 0 || a >=queue.Length || b < 0 || b >=queue.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid indices for swap operation.");
            }

            int temp = queue[a];
            queue[a] = queue[b];
            queue[b] = temp;

            int tempindex=graph.vertices[queue[a]].Index;
            graph.vertices[queue[a]].Index=graph.vertices[queue[b]].Index;
            graph.vertices[queue[b]].Index=tempindex;
    }
    double GetPriority(int a) 
    {
        return graph.vertices[queue[a]].Distance;
    }
    public void BubbleUp(int indx)
    {
         while (indx > 1)
            {
                int parentIndex = indx / 2;
                if (GetPriority(indx) < GetPriority(parentIndex))
                {
                    Swap(indx, parentIndex);
                    indx=parentIndex;
                    continue;
                }
                break;
            }
    }
    public void BubbleDown(int indx)
    {
        while (2 * indx <= last)
            {
                int childIndex = 2 * indx;
                if (childIndex < last && GetPriority(childIndex + 1) < GetPriority(childIndex))
                {
                    childIndex++;
                }

                if (childIndex<=last&&GetPriority(indx) > GetPriority(childIndex))
                {
                    Swap(indx, childIndex);
                    indx = childIndex;
                    continue;
                }
                break;
            }
    }


    IEnumerator IEnumerable.GetEnumerator()
    {
        foreach (var priority in queue)
        {
        yield return priority;
        }
    }
    public void Display() {
        Console.Write("Queued: ");
        for (int i = 1; i <= last; i++)
            Console.Write(queue[i] + " ");
        Console.WriteLine();

        Console.Write("Settled: ");
        for (int i = last+1; i < queue.Length; i++)
            Console.Write(queue[i] + " ");
        Console.WriteLine();
    }
}
