

using System.Collections;
using ShortestPath;
public enum DirectionType
{
    Directed,
    Undirected
}
class Graph : IEnumerable
{
    internal Vertex[] vertices;
    PartiallyOrderedTree pot; 
    public Graph (int [] nodes)
    {
        vertices = new Vertex[nodes.Length];
        pot = new PartiallyOrderedTree(this);
        for (int i = 0; i < vertices.Length; i++)
        {
            this.vertices[i] = new Vertex(nodes[i]);
            vertices[i].Index = i + 1;
        }
    }
    public void AddEdge(int source, int destination, double cost, DirectionType direction)
    { 
	    vertices[source].neighbors.Add(new Edge(destination, cost)); 
        if (direction == DirectionType.Undirected) 
            vertices[destination].neighbors.Add(new Edge(source, cost)); 
	} 

    IEnumerator IEnumerable.GetEnumerator()
    {
        foreach (var vertex in vertices)
        yield return vertex;
    }
    public void Display() 
    {
        foreach (var o in this)
            Console.WriteLine(o);

        pot.Display();

    }
    public void FindShortestPath()
	{
	    int u, v;
	    List<Edge> successors;
        vertices[0].Distance = 0;
	    this.Display();
	    while (pot.last > 1)
	    {
	        v = pot.queue[1];
	        pot.Swap(1, pot.last);
	        --pot.last;
	        pot.BubbleDown(1);
	        successors = vertices[v].neighbors;
	        foreach (Edge edge in successors)
	        {
	            u = edge.Destination;
	            if (vertices[u].Distance > vertices[v].Distance + edge.Cost)
	            {
                    vertices[u].Distance = vertices[v].Distance + edge.Cost;
                    pot.BubbleUp(vertices[u].Index);
                }
            }
	        this.Display();
	    }
	    --pot.last;
	    this.Display();
	}


}