namespace FirstApplication
{
    internal class Program
    {
        Employee employee = new Employee();
        void TakeEmployeeDetails()
        {
            Console.WriteLine( "Please enter the employee ID");
            employee.Id = Convert.ToInt32(Console.ReadLine());//This will handle null
            Console.WriteLine("Please enter the employee name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Please enter the employee Age");
            employee.Age = Int32.Parse(Console.ReadLine());//Cannot handle null
            if(employee.Age < 18)
            {
                Console.WriteLine("Invalid age. Will be 0 until updated");
                employee.Age = 0;
            }
            //employee.Salary = float.Parse(Console.ReadLine());
        }
        void PrintEmployeeData()
        {
            //Console.WriteLine("Employee Id "+employee.Id);
            //Console.WriteLine("Employee Name " + employee.Name);
            //Console.WriteLine("Employee Age "+employee.Age);

            //Console.WriteLine("Employee Id {0} \nEmployee Name : {1} \nEmployee Age {2}",employee.Id, employee.Name, employee.Age);

            Console.WriteLine($"Employee Id  {employee.Id}");
            Console.WriteLine($"Employee Name {employee.Name}");
            Console.WriteLine($"Employee Age {employee.Age}");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Hello From G3");
            //Program program = new Program();
            //program.TakeEmployeeDetails();
            //program.PrintEmployeeData();
            Departmnet departmnet = new Departmnet();
            departmnet.TakeDepatmentDetails();
            departmnet.PrintDetprtmnetDeails();
            //Console.ReadKey();
        }
    }
}