
class Edge
{
    public int Destination{get;set;}
    public double Cost{get;set;}

    public Edge(int dest,double cos)
    {
        this.Destination=dest;
        this.Cost=cos;
    }
    public override string ToString()
    {
        return "["+Destination+ " "+Cost+"]";
    }

}