
using System;
using System.Collections;
using System.Collections.Generic;
class Queue {
    List list;
    public Queue()
    {
        list=new List();
    }
    public void EnQueue(object a)
    {
        list.InsertEnd(a);
    }
    public void Dequeue()
    {
        list.RemoveFront();
    }
 
    public bool IsEmpty() { return list.IsEmpty(); }
    public void Display() { list.Display(); }
}