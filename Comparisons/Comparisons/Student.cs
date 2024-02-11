

using System.Buffers;
using System.Collections;

class Student
{
    private string name;
    private double grade;

    public Student(string ime, double ocjena)
    {
        name=ime;
        grade=ocjena;
    }
    public override string ToString()
    {
        return name+grade;
    }
    public static bool CompareName(object a, object b)
    {
        Student A=(Student)a;
        Student B=(Student)b;
         if( A.name.CompareTo(B.name) >0)
        return false;
        else 
        return true;
    }
    public static bool CompareGrade(object a, object b)
    {
        Student A=(Student)a;
        Student B=(Student)b;
        if( A.grade.CompareTo(B.grade) < 0)
        return false;
        else
        return true;
    }

}