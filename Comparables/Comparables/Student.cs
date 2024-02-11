class Student : IComparable
{
    private string name;
    private double grade;

    public Student(string ime,double ocjena)
    {
        name=ime;
        grade=ocjena;
    }
    public override string ToString()
    {
        return name+grade;
    }
    public int CompareTo(object a)
    {
        Student A=(Student)a;
        return grade.CompareTo(A.grade);
    }

}