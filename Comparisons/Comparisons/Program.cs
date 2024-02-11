// See https://aka.ms/new-console-template for more information

namespace Comparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {
            new Student ("Ivo", 4.1),
            new Student ("Ana", 4.9),
            new Student ("Iva", 4.3),
            new Student ("Bob", 4.5),
            new Student ("Joe", 4.7)
            };

            for(int i=0;i<5;i++)
            {
                System.Console.WriteLine(students[i]);
            }
            Bubble.Sort(students,Student.CompareName);
            System.Console.WriteLine("nakon usporedbe po imenu");
             for(int i=0;i<5;i++)
            {
                System.Console.WriteLine(students[i]);
            }

            Bubble.Sort(students,Student.CompareGrade);
            System.Console.WriteLine("nakon usporedbe po ocjeni");
            for(int i=0;i<5;i++)
            {
                System.Console.WriteLine(students[i]);
            }

        }
    }
}
