
class Heap
{
    private int size;
    public int last;
    public int [] priorities;

    public Heap(int size) 
    {
        this.size = size;
        priorities = new int[size + 1];
        last = 0;
    }
    public void Insert(int priority)
    {
        if(last==size)
            throw new Exception("Queue is full");
        priorities[++last]=priority;
        BubbleUp(last);
    }
    public int Retrieve()
    {
        if(last==0)
            throw new Exception("Queue is empty");
        int priority=priorities[1];
        priorities[1]=priorities[last--];
        BubbleDown(1);
        return priority;
    }
    public void BubbleUp(int i)
    {
        if (i == 1) return;
            int parent = i/2;
        if (priorities[i] > priorities[parent])
        {
            Swap (i, parent);
            BubbleUp (parent);
        }
    }
	public void BubbleDown(int i)
	{
	    int child = 2 * i;
	    if (child < last &&priorities[child] < priorities[child + 1])
	        child++;
        if (child <= last &&priorities[i] < priorities[child])
	    {
	        Swap(i, child);
	        BubbleDown(child);
	    }
    }
    public void Swap(int first, int second)
    {
        int temp=this.priorities[second];
        this.priorities[second]=this.priorities[first];
        this.priorities[first]=temp;
    }
    public void Display() 
    {
        for (int i = 1; i <= last; i++ )
            Console.Write(priorities[i] + " ");
        Console.WriteLine();
    }
}