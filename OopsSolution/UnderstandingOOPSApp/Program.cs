namespace UnderstandingOOPSApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int eage = 0;
            //Console.WriteLine("Please enter the new age");
            //eage = Convert.ToInt32(Console.ReadLine());
            Employee employee = new Employee(101, "Ramu", 23);
            //employee.ChangeName();
            //employee.PrintEmployeeDetails();
            //string data;
            //bool res = employee.CheckAge(out data);
            //Console.WriteLine("The employee's age is eligible for work "+res);
            //Console.WriteLine(data);
            ////employee.UpdateAge( ref eage);

            // Console.WriteLine("Age after the method call in t he calling method "+eage);
            //employee.SendRandaomMessage("Hello", 123, "Welcome", 23.4f, true, 90.3, "Bye");
            //employee.ChangeEmployeeAge(23, -1);
            //employee.PrintEmployeeDetails();
            Salary salary = new ExecutiveSalary();
            double netSal = salary.CalculateSalary(basic:10000, 1000);
            Console.WriteLine(DepartmentTypes.depTypes[0]); 
            //Console.WriteLine("YOu are normal category and your salary is "+netSal);
            Console.WriteLine("YOu are executive category and your salary is " + netSal);
        }
    }
}