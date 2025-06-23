namespace Testt
{
    public class Student<T>
    {
        public T ID { get; set; }
        public string Name { get; set; }

        public Student(T id, string name)
        {
            ID = id;
            Name = name;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Student<int>> students = new List<Student<int>>
        {
            new Student<int>(1001, "Palesa"),
            new Student<int>(1002, "Thabiso"),
            new Student<int>(1003, "Naledi")
        };

            Dictionary<int, List<string>> borrowedBooks = new Dictionary<int, List<string>>
        {
            { 1001, new List<string> { "C# Fundamentals", "LINQ in Action" } },
            { 1002, new List<string> { "Database Systems", "Operating Systems" } },
            { 1003, new List<string> { "Algorithms in C#", "Clean Code", "Design Patterns" } }
        };

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} (ID: {student.ID}) has borrowed:");

                foreach (var book in borrowedBooks[student.ID])
                {
                    Console.WriteLine($"  - {book}");
                }
                Console.WriteLine();
            }
        }
    }
}
