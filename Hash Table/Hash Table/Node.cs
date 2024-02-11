
class Node
{
    public string Name{ get; set;}
    public int Value{ get; set;}
    public Node Next{get;set;}
    public Node()
    {
        Name=null;
        Value=0;
        Next=null;
    }
    public Node(string a,int b,Node nx)
    {
        Name=a;
        Value=b;
        Next=nx;
    }
    
}