using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace SmartArrays
{
class Program
{

    static void Main(string[] args)
    {
        SmartArray smarty=new SmartArray(6);
        for(int i=0;i<8;i++)
        {
            smarty.Add(i);
            System.Console.Write(smarty[i]+" ");
        }
        System.Console.WriteLine("");
        IEnumerator enumerator = smarty.GetEnumerator();
        while (enumerator.MoveNext()) {
            int i = (int) enumerator.Current;
            Console.Write(i + " ");
        }
        System.Console.WriteLine("");
        int a=smarty.Length;
        for(int j=0;j<a;j++)
        {
            System.Console.WriteLine("Removing {0}",j);
            smarty.Remove(j);
        }
        for(int k=0;k<smarty.Length;k++)
        {
            System.Console.WriteLine(smarty[k]);
        }
    }
}
}
