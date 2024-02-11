
using System;
class BIIList
{
    public Node head;
    private int count;
    public int Count()
    {
        return count;
    }
    public BIIList()
    {
        Node dummy=new Node(null,head,head);
        head=dummy;
    }
    private bool IsEmpty () 
    {
        if (count == 0) 
        return true;
        return false;
    }
    public void Append(object data) 
    {
        if(IsEmpty())
        {
            head=new Node(data,head,head);
            Node node=new(data,head,head);
            head=node;
            count++;
        }
        else
        {
            Node current=new Node();
            current=head;
            Node next=new Node();
            while(current.Next!=head)
            {
                current=current.Next;
            }
            Node node=new Node(data,head,current);
            head.Prev=node;
            current.Next=node;
            count++;
        }
    }
    private Node Find(object data) 
    {
        if(head.el==data)
            return head;
        else
        {
            Node node=new();
            node=head;
            while(node.Next!=head)
            {
                node=node.Next;
                if(node.el==data)
                {
                    return node;
                }
            }
            return null;
        }
    }
    public void Remove(object data) 
    {
        Node previous=new();
        Node next=new();
        if(head==data)
        {
            previous=head.Prev;
            next=head.Next;
            previous.Next=next;
            next.Prev=previous;
            head=next;
            count--;  
        }
        else
        {
            Node node=new();
            node=head;
            while(node.Next!=head)
            {
                node=node.Next;
                if(node==data)
                {
                    previous=node.Prev;
                    next=node.Next;
                    previous.Next=next;
                    next.Prev=previous;
                    count--;
                    break;
                }
            }
            throw new Exception("That element is not in the list!");
        }
    }
    public bool Search(object data) 
    {
       if(Find(data)!=null)
       {
            return true;
       }
       return false;
    }
    public void Display() 
    {
        if(IsEmpty())
        {
            System.Console.WriteLine("List is empty");
        }
        else
        {
            System.Console.WriteLine(head);
            Node node=new();
            node=head;
            while(node.Next!=head)
            {
                node=node.Next;  
                System.Console.WriteLine(node); 
            }
        }
    }


}