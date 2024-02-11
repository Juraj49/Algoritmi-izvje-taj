using System.Reflection.Metadata.Ecma335;
using System.Collections;

class Student
{

    public string name;
    public double grade;
    
    public Student(string ime,double ocjena)
    {
        name=ime;
        grade=ocjena;
    }
    public override string ToString()
    {
        return name+grade;
    }
}