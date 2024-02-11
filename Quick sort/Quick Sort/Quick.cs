
using System.ComponentModel.DataAnnotations;

class Quick
{
    public delegate bool Comparison(object a,object b);
    public static void Sort(object[] array,int left, int right,Comparison cmp)
    {
    if (left >= right) return;
    int last = Partition(array, left, right, cmp);
    Sort(array, left, last - 1, cmp);
    Sort(array, last + 1, right, cmp);
    }
    public static int Partition(object[] array,int left, int right,Comparison cmp)
    {
        object pivot= array[left];
        int j=right;
        for(int i=right;i>left;i--)
        {
            if(cmp(array[i],pivot))
            {
                Swap(array,i,j);
                j--;
            }
        }
        Swap(array,j,left);
        return j;
    }
    static void Swap(object[] array, int first, int second)
    {
        object temp=array[first];
        array[first]=array[second];
        array[second]=temp;
    }
}