using System.Text;
using System.Collections.Generic;

namespace ShortestPath;
class Vertex
{
    public int Source{get;set;}
    public double Distance{get;set;}
    public int Index{get;set;}
    public List<Edge> neighbors;
    public Vertex(int a)
    {
        this.Source=a;
        this.Distance=double.MaxValue;
        neighbors=new List<Edge>();
    }
    public void AddEdge(int number, double cost)
    {
        neighbors.Add(new Edge(number, cost));
    }
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder ();
        string distance = string.Format ("{0,2}",
            (Distance == double.MaxValue) ? -1.0 : Distance);

        builder.Append("Q" + Index + " N" + Source + "(" + distance + ") --> ");
        foreach (var edge in neighbors)
            builder.Append (edge);
        return builder.ToString();
    }

}