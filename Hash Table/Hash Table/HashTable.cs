

using System.Reflection.Metadata.Ecma335;

class HashTable
{
    public Node [] buckets;
    private int length;
    public HashTable(int a)
    {
        length=a;
        buckets=new Node[length];
    }
    public void Display()
    {
        for(int i=0;i<length;i++)
        {
            System.Console.WriteLine(i);
            Node nx=buckets[i];
            while(nx!=null)
            {
                System.Console.WriteLine(nx.Name+nx.Value); 
                nx=nx.Next; 
            }
        }
    }
    private int Hash(string str)
    {
        int a=Convert.ToInt32(str[0]);
        return a%length;
    }
    public void Insert(string name,int value)
    {
        Node nx=new Node(name,value,null);
        Node nt=buckets[Hash(name)];
        Node previous=null;
        if(nt==null)
        {
            buckets[Hash(name)]=nx;
        }
        else
        { 
            while(nt!=null)
            {
                previous=nt;
                nt=nt.Next;
            }
            previous.Next=nx;
        }
        
    }
    public int Search(string name)
    {
        Node nx=buckets[Hash(name)];
        while(nx!=null)
        {
            if(nx.Name==name)
            {
                return nx.Value;
            }
            nx=nx.Next;
        }
        return 1;
    }
    /*public void Delete(string name)
    {
        Node previous=null;
        Node nx=buckets[Hash(name)];
        Node [] array=new Node[10];
        Node c;
        int i=0;
        while(nx!=null)
        {
            if(nx.Name==name)
            {
                if(nx.Next!=null)
                {
                    if(previous!=null)
                    {
                        previous.Next=nx.Next;
                        int j=0;
                        buckets[Hash(name)]=array[0];
                        while(array[j+1]!=null)
                        {
                           previous=array[j];
                           nx=array[j+1];
                           previous.Next=nx;
                           j++;
                        }
                    }
                    else
                    {
                        buckets[Hash(name)]=nx.Next;
                    }
                    break;
                }
                else
                {
                    if(previous!=null)
                    {
                        buckets[Hash(name)]=array[0];
                        int j=0;
                        while(array[j+1]!=null)
                        {
                           previous=array[j];
                           nx=array[j+1];
                           previous.Next=nx;
                           j++;
                        }
                        break;
                    }
                    else
                    {
                        buckets[Hash(name)]=null;
                        break;
                    }
                }
            }
            previous=nx;
            nx=nx.Next;
            c=previous;
            c.Next=null;
            array[i]=c;
            i++;
            if(nx==null)
            {
                throw new Exception("Node with wanted key is not present!");
            }
        }    
    }*/
     public void Delete(string name)
    {
        Node nx=buckets[Hash(name)];
        Node previous=null;
        while(nx!=null)
        {
            if(nx.Name==name)
            {
                if(previous==null)
                {
                    buckets[Hash(name)]=nx.Next;
                }
                else
                {
                    previous.Next=nx.Next;
                }
                break;
            }
            if(nx.Next==null)
            {
                throw new Exception("Node with wanted key is not present!");
            }
            previous=nx;
            nx=nx.Next;
        }
    }
}

