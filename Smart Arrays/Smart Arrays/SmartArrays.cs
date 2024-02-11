using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Transactions;

class SmartArray
{
    int size;
    public static int last=-1;
    static int [] array;

    public SmartArray(int a)
    {
        size=a;
        array=new int[size];
    }

    
    public int Length
    {
        get{return last+1;}
    }


    public void Add(int item)
    {
        if (last == (size - 1))
        {
        Array resized =Array.CreateInstance (typeof(int), size * 2);
        Array.Copy (array, resized, size);

        array = (int []) resized;
        size = array.Length;
        }
        array[++last] = item;
    }
    public void Remove(int item)
    {
        if(item==array[last])
        {
            last--;
        }
        else
        {
            int i=0;
            while(array[i]!=item)
            {
                i++;
                if(i>this.Length)
                throw new Exception("Parameter is out of range.");
            }
            Array a = Array.CreateInstance(typeof(int), last+1 );
            Array.Copy(array, a, i);
            Array.Copy(array, i + 1, a, i, last - i  );
            array = (int[])a;
            last--;
        }
        for(int k=0;k<this.Length;k++)
        {
            System.Console.Write(array[k]+" ");
        }
        System.Console.WriteLine("");
    }
    public int this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }
    }
    public IEnumerator GetEnumerator()
    {
        return new SmartEnumerator(this);
    }
    private class SmartEnumerator : IEnumerator, IDisposable
    {
        public static int index=-1;
        public SmartArray smarty;

        public object Current
        {
            get{return smarty[index];}
        } 

        public SmartEnumerator(SmartArray smarty)
        {
            this.smarty = smarty;
        }
        public bool MoveNext()
        {
            index++;
            return index < smarty.Length;
        }
        public void Reset()
        {
            throw new NotSupportedException();
        }
        public void Dispose() { }
        

    }

}
