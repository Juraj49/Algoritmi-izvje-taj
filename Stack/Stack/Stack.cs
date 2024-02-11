
using System;
using System.Collections.Generic;
class Stack
{
    List list;
    public Stack()
    {
        list=new List();
    }
    public void Push(object a)
    {
        list.InsertFront(a);
    }
    public object Pop()
    {
        return list.RemoveFront();
    }
    public bool IsEmpty(){return list.IsEmpty();}
    public void Display() { list.Display(); }
    
}
