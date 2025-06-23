using System.Xml;

namespace Artspace
{
    internal class XML
    {
        static void Main(string[] args)
        {
            //string filePath = "PatientCatalog.xml";
            XmlDocument doc = new XmlDocument();
            //doc.Load(filePath);
            XmlElement root = doc.CreateElement("PatientCatalog");
            doc.AppendChild(root);
            AddNewPatient(doc, "PT201", "Emily Johnson", "Female", 34, "Asthma");
            AddNewPatient(doc, "PT202", "Michael Smith", "Male", 47, "Type 2 Diabetes");
            AddNewPatient(doc, "PT203", "Sophia Brown", "Female", 29, "Anemia");
            AddNewPatient(doc, "PT204", "James Wilson", "Male", 53, "Hypertension");

            doc.Save("PatientCatalog.xml");
            Console.WriteLine("XML Document Created Successfully");
            
            static void AddNewPatient(XmlDocument doc, string id, string name, string gender, int age, string diagnosis)
            {
                XmlElement patientEle = doc.CreateElement("Patient");
                patientEle.SetAttribute("PatientID", id);

                XmlElement nameEle = doc.CreateElement("Name");
                nameEle.InnerText = name;
                patientEle.AppendChild(nameEle);

                XmlElement genderEle = doc.CreateElement("Gender");
                genderEle.InnerText = gender;
                patientEle.AppendChild(genderEle);

                XmlElement ageEle = doc.CreateElement("Age");
                ageEle.InnerText = age.ToString();
                patientEle.AppendChild(ageEle);

                XmlElement diagnosisEle = doc.CreateElement("Diagnosis");
                diagnosisEle.InnerText = diagnosis;
                patientEle.AppendChild(diagnosisEle);

                doc.DocumentElement.AppendChild(patientEle);
            }
        }
    }
}
