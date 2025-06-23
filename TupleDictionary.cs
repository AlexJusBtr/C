namespace DictionaryTuple
{
    class StudentRecordSystem
    {
        static void Main()
        {
            // Initialize the dictionary to store student records
            Dictionary<int, Tuple<string, double>> studentRecords = new Dictionary<int, Tuple<string, double>>();
 
            // Add students
            studentRecords.Add(101, new Tuple<string, double>("John", 85.5));
            studentRecords.Add(102, new Tuple<string, double>("Mary", 92.3));
            studentRecords.Add(103, new Tuple<string, double>("Alice", 78.4));

            // Retrieve a student by ID
            int searchId = 102;
            if (studentRecords.ContainsKey(searchId))
            {
                var student = studentRecords[searchId];
                Console.WriteLine($"Student ID: {searchId}, Name: {student.Item1}, Grade: {student.Item2}");
            }

            // Remove a student by ID
            int removeId = 103;
            if (studentRecords.ContainsKey(removeId))
            {
                studentRecords.Remove(removeId);
                Console.WriteLine($"Student with ID {removeId} has been removed.");
            }

            // Retrieve students with grades above 80
            Console.WriteLine("Students with grade above 80:");
            foreach (var record in studentRecords)
            {
                if (record.Value.Item2 > 80)
                {
                    Console.WriteLine($"ID: {record.Key}, Name: {record.Value.Item1}, Grade: {record.Value.Item2}");
                }
            }
        }
    }
}
