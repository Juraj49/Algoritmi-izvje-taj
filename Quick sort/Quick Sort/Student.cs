
using Microsoft.VisualBasic;

class Student:IComparable
{
    private string name;
    private double grade;

    public Student( string a,double i)
    {
        this.name=a;
        this.grade=i;
    }

   public override string ToString()
   {
        return $"{name} - Grade: {grade}";
   }
   public static bool CompareName(object a, object b)
   {
        return ((Student)a).name.CompareTo(((Student)b).name) > 0;
   }
   public static bool CompareGrade(object a, object b)
   {
        return ((Student)a).grade < ((Student)b).grade;
   }

    public int CompareTo(object a)
    {
        Student A=(Student)a;
        return name.CompareTo(A.name);
    }

}