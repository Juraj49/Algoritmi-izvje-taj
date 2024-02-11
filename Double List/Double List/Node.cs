
class Node
{
    public object Element {private set; get;}
    public Node Next {set;get;}
    public Node Prev {set;get;}
    public Node()
    {
        Element=null;
        Next=null;
        Prev=null;
    }
    public Node(object el,Node nx,Node pr)
    {
        Element=el;
        Next=nx;
        Prev=pr;
    }
    
}