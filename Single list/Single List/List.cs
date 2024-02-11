
using System;
public class List
{
    private Node head;
    private Node tail;

    public List()
    {
        head=null;
        tail=null;
    }

    public bool IsEmpty()
    {
        return head==null;
    }

    public void InsertFront(object data)
    {
        if(IsEmpty())
        {
            head=new Node(data,null);
            tail=head;
        }
        else
        {
          Node node=new Node(data,head);
          head=node;
        }
    }

     public void InsertEnd(object data)
    {
        if(IsEmpty())
        {
            head=new Node(data,null);
            tail=head;
        }
        else
        {
            Node node=new Node(data,null);
            tail.Next=node;
            tail=node;
        }
    }
    public object RemoveFront()
    {
        if(head!=null && head.Next!=null)
        {
            Node el=head.Next;
            head=el;

        return head;
        }
        else if(head.Next==null)
        {
            head=null;
            return head;
        }
        else
        {
             throw new Exception("List is empty");
        }
    }
    public object RemoveEnd()
    {
        if(tail!=null)
        {
            Node el=head.Next;
            if(el!=tail)
            {
                while(el.Next!=tail)
                {
                    el=el.Next;
                }
                tail=el;
                el.Next=null;
            }
            else
            {
                el=null;
                head=tail;
            }
        }
        else
        {
            throw new Exception("List is empty");
        }
        return tail;
    }
    public void Display()
    {
        if(head!=null)
        {
        Node el=head;
        System.Console.WriteLine("head is:"+el.Element);
            int i=2;
            while(el.Next!=null)
            {
                el=el.Next;
                System.Console.Write("{0}.",i);
                System.Console.WriteLine("element in List is: "+el.Element);
                i++;
            }
        System.Console.WriteLine("There is no more elements in the list");
        }

    }
    


}