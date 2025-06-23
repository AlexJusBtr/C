
using System;
using System.Globalization;
using System.IO;
using System.Xml.Linq;

namespace Clinic_Patient_Management_System
{
    public class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Condition { get; set; }

        //constructer
        public Patient(string name, int age, string condition)
        {
            Name = name;
            Age = age;
            Condition = condition;
        }
    }

    internal class Program
    {
        private static List<Patient> patients = new List<Patient>();
        static void Main(string[] args)
        {
            int choiceMenu = 0;
            do {
                    Console.Clear();
                    Console.WriteLine("Main Menu: " +
                        "\n1: Add Patient " +
                        "\n2: Remove Patient " +
                        "\n3: Search Patient " +
                        "\n4: Display All Patients " +
                        "\n5: Exit " +
                        "\nEnter your choice: ");
                    choiceMenu = Convert.ToInt32(Console.ReadLine());
                    switch (choiceMenu)
                    {
                        case 1:
                        Console.Clear();
                        addPatient();
                        break;

                        case 2:
                        Console.Clear();
                        remPatient();
                        break;

                        case 3:
                        Console.Clear();
                        searchPatient();
                        break;                    

                        case 4:
                        Console.Clear();
                        dispPatients();
                        break;

                        case 5:
                        Console.Clear();
                        printPatients();
                        break;

                        case 6:
                        Console.Clear();
                        Console.WriteLine("Farewell!");
                        break;
                        default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid number from the given menu");
                        Console.ReadKey();
                        break;
                    }
               } while (choiceMenu != 6);
        }

        private static void addPatient()
        {
            Console.WriteLine("Enter patient details:");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine().ToLower();
            while (string.IsNullOrWhiteSpace(name) || name.Any(char.IsDigit))
            {
                Console.WriteLine("Please enter a valid name (no numbers or empty input): ");
                name = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Age: ");
            string input = Console.ReadLine();
            int age;
            while (!int.TryParse(input, out age))
            {
                Console.WriteLine("Please enter a valid integer for age: ");
                input = Console.ReadLine();
            }

            Console.WriteLine("Medical Condition: ");
            string condition = Console.ReadLine().ToLower();
            while (string.IsNullOrWhiteSpace(condition) || condition.Any(char.IsDigit))
            {
                Console.WriteLine("Please enter a valid name (no numbers or empty input): ");
                condition = Console.ReadLine().ToLower();
            }

            Patient patient = new Patient(name, age, condition);

            patients.Add(patient);

            Console.WriteLine("Patient Added Successfully.");
            Console.ReadKey();
        }
        private static void remPatient()
        {
            bool notFound = true;
            Console.WriteLine("Enter the name of the patient to remove: ");
            string name = Console.ReadLine().ToLower();
            while (string.IsNullOrWhiteSpace(name) || name.Any(char.IsDigit))
            {
                Console.WriteLine("Please enter a valid name (no numbers or empty input): ");
                name = Console.ReadLine().ToLower();
            }

            foreach (Patient patient in patients)
            {
                if (patient.Name == name)
                {
                    patients.Remove(patient);
                    notFound = false;
                    Console.WriteLine("Patient Removed Successfully.");
                    Console.ReadKey();
                    break;
                } 
            }
            if (notFound)
            {
                Console.WriteLine("There is no such patient.");
                Console.ReadKey();
            }
        }
        private static void searchPatient()
        {
            bool notFound = true;
            Console.WriteLine("Enter the name of the patient to search: ");
            string name = Console.ReadLine().ToLower();
            while (string.IsNullOrWhiteSpace(name) || name.Any(char.IsDigit))
            {
                Console.WriteLine("Please enter a valid name (no numbers or empty input): ");
                name = Console.ReadLine().ToLower();
            }

            foreach (Patient patient in patients)
            {
                if (patient.Name == name) 
                {
                    Console.WriteLine($"Found: Name: {patient.Name}, Age: {patient.Age}, Condition: {patient.Condition}");
                    notFound = false;
                    Console.ReadKey();
                }
            }
            if (notFound)
            {
                Console.WriteLine("There is no such patient.");
                Console.ReadKey();
            }
        }
        private static void dispPatients()
        {
            if (patients.Count == 0)
            {
                Console.WriteLine("No patient records to display.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Registered Patients:");
                foreach (Patient patient in patients)
                {
                    Console.WriteLine($"Name: {patient.Name}, Age: {patient.Age}, Condition: {patient.Condition}");
                }
                Console.ReadKey();
            }
        }
        private static void printPatients()
        {
            if (patients.Count == 0)
            {
                Console.WriteLine("No patient records to print.");
                Console.ReadKey();
                return;
            }
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "patient_information.txt");
            try
            {
                // Create or overwrite the file and write patient details
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Registered Patients:");
                    foreach (Patient patient in patients)
                    {
                        writer.WriteLine($"- Name: {patient.Name}, Age: {patient.Age}, Condition: {patient.Condition}");
                    }
                }

                // Display success message with the file path
                Console.WriteLine($"Patient information printed to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
/*/string userInput = Console.ReadLine();
Console.WriteLine();

// Writing to a file (overwrites if exists)
File.WriteAllText(filePath, userInput);
Console.WriteLine($"Text written to {filePath}");

// Appending to the file
string additionalText = "\nThis is appended text.";
File.AppendAllText(filePath, additionalText);
Console.WriteLine("Additional text appended to file.");

// Reading from the file
Console.WriteLine("\nReading file contents:");
string fileContent = File.ReadAllText(filePath);
Console.WriteLine(fileContent);

// Reading file line by line
Console.WriteLine("\nReading file line by line:");
string[] lines = File.ReadAllLines(filePath);
foreach (string line in lines)
{
    Console.WriteLine($"Line: {line}");
}/*/


/*/private static void printPatientInfoToFile()
{
if (patients.Count == 0)
            {
                Console.WriteLine("No patient records to print.");
                Console.ReadKey();
                return;
            }
    string filePath = "patient_information.txt";
    try
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            if (patients.Count == 0)
            {
                writer.WriteLine("No patient records to display.");
            }
            else
            {
                writer.WriteLine("Registered Patients:");
                foreach (Patient patient in patients)
                {
                    writer.WriteLine($"Name: {patient.Name}, Age: {patient.Age}, Condition: {patient.Condition}");
                }
            }
        }
        Console.WriteLine($"Patient information printed to {Path.GetFullPath(filePath)}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error writing to file: {ex.Message}");
    }
    Console.ReadKey();
}/*/
