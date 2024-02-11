
class Selection
{
    public static void Sort(int [] a,int start)
    {
        int temp,min;
        for(int i=start;i<a.Length-1;i++)
        {
            min=i;
            for(int j=i+1;j<a.Length;j++)
            {
                if(a[j]<a[min])
                {
                    min=j;
                }
            }
            temp=a[min];
            a[min]=a[i];
            a[i]=temp;
        }
    }
}