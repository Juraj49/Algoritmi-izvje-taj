

class Node
{
    public Object Element {private set; get;}
    public Node Next{get;set;}

    public Node(Object el,Node nx)
    {
        Element=el;
        Next=nx;
    }
    
}