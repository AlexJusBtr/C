namespace pracprac
{
    internal class Hashset
    {
        public class StudentEnrollment
        {
            public string StudentName { get; set; }
            public string Course { get; set; }
            public StudentEnrollment(string studentName, string course)
            {
                StudentName = studentName;
                Course = course;
            }
            public override bool Equals(object obj)
            {
                if (obj is StudentEnrollment other)
                {
                    return StudentName == other.StudentName && Course == other.Course;
                }
                return false;
            }
            public override int GetHashCode()
            {
                return HashCode.Combine(StudentName, Course);
            }

        }
        public static void Main()
        {
            HashSet<StudentEnrollment> enrollments = new HashSet<StudentEnrollment>();
            enrollments.Add(new StudentEnrollment("Alice", "Math"));
            enrollments.Add(new StudentEnrollment("Bob", "Science"));
            enrollments.Add(new StudentEnrollment("Alice", "History"));
            enrollments.Add(new StudentEnrollment("David", "Math"));
            enrollments.Add(new StudentEnrollment("Alice", "Math"));

            Console.WriteLine("Unique Student Enrollments:");
            foreach (var enrollment in enrollments)
            {
                Console.WriteLine($"Student: {enrollment.StudentName}, Course: {enrollment.Course}");
            }
            Console.ReadKey();
        }
    }
}
