


namespace QuickSort
{
    class Program
    {
        static void Main(string [] args)
        {
            Student[] students =
            {
                    new Student ("Ivo", 4.1),
                    new Student ("Ana", 4.9),
                    new Student ("Iva", 4.3),
                    new Student ("Bob", 4.5),
                    new Student ("Joe", 4.7),
                    new Student ("Tom", 4.4),
                    new Student ("Iko", 4.6),
            };
            for(int i=0;i<7;i++)
            {
                System.Console.WriteLine(students[i].ToString());
            }
            Quick.Partition(students,0,students.Length-1,Student.CompareName);
            for(int i=0;i<7;i++)
            {
                System.Console.WriteLine(students[i].ToString());
            }
            Quick.Sort(students,0,students.Length-1,Student.CompareName);
            for(int i=0;i<7;i++)
            {
                System.Console.WriteLine(students[i].ToString());
            }
             Quick.Sort(students,0,students.Length-1,Student.CompareGrade);
            for(int i=0;i<7;i++)
            {
                System.Console.WriteLine(students[i].ToString());
            }
            
        }
    }
}