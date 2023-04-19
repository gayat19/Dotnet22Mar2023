using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileAppliaction
{
    internal class Program
    {
        string path = @"D:\Data\d drive\Corp\L&TEdu\Mindtree\DotnetApplications\Files";
        void WriteToAFile()
        {
            path += @"\File1.txt";
            //File.WriteAllLines(path, new string[] { "Ramu","Somu", "Bimu", "Komu", "Lomu" });
            string data = "";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter the content to write");
                data += Console.ReadLine() + "\n";
            }
            File.WriteAllText(path, data);
            Console.WriteLine("Done writing");
        }
        void UnderstandFileInfo()
        {
            path += @"\File1.txt";
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.Extension);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.DirectoryName);
        }
        void UndersttandDirectoryData()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            foreach (var item in directoryInfo.GetFiles())
            {
                Console.WriteLine(item.Name);
            }
        }
        void ReadFromTheFile()
        {
            path += @"\File1.txt";
            if(File.Exists(path))
            {
                var fileData  = File.ReadAllLines(path);
                foreach (var item in fileData)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("---------------");
                }
            }
        }
        void WriteObjectToFile()
        {
            path += @"\EmployeeFile.txt";
            Employee emp = new Employee() { Id = 101, Name = "Ramu", Age = 21 };
            IFormatter formater = new BinaryFormatter();
            FileStream stream = File.Create(path); 
            formater.Serialize(stream, emp);
            stream.Close();
        }
        void ReadObjectFromFile()
        {
            //path += @"\EmployeeFile.txt";
            IFormatter formatter = new BinaryFormatter();
            if(File.Exists(path))
            {
                FileStream stream = File.OpenRead(path);
                Employee employee = formatter.Deserialize(stream) as Employee;
                Console.WriteLine(employee.Name);
                stream.Close();
            }
           else
                Console.WriteLine("NO such file");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.WriteObjectToFile();
            program.ReadObjectFromFile();
        }
    }
}