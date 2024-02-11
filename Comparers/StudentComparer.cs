using System.Reflection.Metadata.Ecma335;
using System.Collections;
using System.Runtime.InteropServices;

enum StudentComparerType { Name, Grade }
class StudentComparer :IComparer
{
    private StudentComparerType criterion;


    public StudentComparer(StudentComparerType criterion) 
    {
    this.criterion = criterion;
    }

    public int Compare(object a, object b)
    {
        Student A=(Student)a;
        Student B=(Student)b;
        if (criterion == StudentComparerType.Name)
        {
            return A.name.CompareTo(B.name);
        }
        if(criterion == StudentComparerType.Grade)
        {
             return A.grade.CompareTo(B.grade);
        }
        else 
        throw new Exception("Not supported!");
        
    }
}