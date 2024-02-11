// See https://aka.ms/new-console-template for more information


namespace Compares 
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student ("Ivo", 4.1),
                new Student ("Ana", 4.9),
                new Student ("Iva", 4.3),
                new Student ("Bob", 4.5),
                new Student ("Joe", 4.7)
            };

            System.Console.WriteLine(students[0]);
            System.Console.WriteLine(students[1]);
            System.Console.WriteLine(students[2]);
            System.Console.WriteLine(students[3]);
            System.Console.WriteLine(students[4]);

            StudentComparer comparer = new StudentComparer(StudentComparerType.Name);

            Bubble.Sort(students, comparer);

            System.Console.WriteLine("Name");
            System.Console.WriteLine(students[0]);
            System.Console.WriteLine(students[1]);
            System.Console.WriteLine(students[2]);
            System.Console.WriteLine(students[3]);
            System.Console.WriteLine(students[4]);

            StudentComparer compareG =new StudentComparer(StudentComparerType.Grade);

            Bubble.Sort(students,compareG);

            System.Console.WriteLine("Grade");
            System.Console.WriteLine(students[0]);
            System.Console.WriteLine(students[1]);
            System.Console.WriteLine(students[2]);
            System.Console.WriteLine(students[3]);
            System.Console.WriteLine(students[4]);
        }
    }
}
