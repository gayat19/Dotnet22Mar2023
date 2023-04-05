namespace UnderstandingDelegateApp
{
    
    internal class Program
    {
        //delegate void MyDelegate(int num1, int num2);//Reff type to method
        //void Add(int n1,int n2)
        //{
        //    int sum = n1 + n2;
        //    Console.WriteLine("The sum is "+sum);
        //}
        //void Product(int n1, int n2)
        //{
        //    int product = n1 * n2;
        //    Console.WriteLine("The product is "+product);
        //}
        //void AssignDelegate()
        //{
        //    MyDelegate myDelegate = new MyDelegate(Add);//creating reff to the method
        //    myDelegate += Product;
        //    myDelegate -= Add;//unreferencing method
        //    Calculator calculator = new Calculator();
        //    myDelegate += calculator.Subtract;
        //    myDelegate += delegate (int num1, int num2)//Anon method
        //    {
        //        int result = num1 / num2;
        //        Console.WriteLine($"The result of dividing {num1} by {num2} is " + result);
        //    };
        //    myDelegate(100, 20);//Invoke the method
        //}
        //public delegate void CalDel(int n1, int n2);
        //void AddMethods()
        //{
        //    //CalDel calDel = delegate (int n1, int n2)
        //    //{
        //    //    int sum = n1 + n2;
        //    //    Console.WriteLine(sum);
        //    //};
        //    //CalDel calDel = (n1, n2) =>///Lambda expression
        //    //{
        //    //    int sum = n1 + n2;
        //    //   Console.WriteLine(sum);
        //    //};
        //    //CalDel calDel = (n1, n2) =>Console.WriteLine((n1+n2));
        //    Action<int,int> calDel = (n1, n2) => Console.WriteLine((n1 + n2));//Pre defined delegate
        //    Func<int, string> another = (num1) => "The number after increment is " + (++num1);
        //    calDel(10, 20);
        //    string result = another(20);
        //    Console.WriteLine(result);
        //    Predicate<int> check = (num) => num > 18;
        //    Console.WriteLine(check(21));
        //}
        //void ManageEmployee()
        //{
        //    List<Employee> employees = new List<Employee>();
        //    employees.Add(new Employee() { Id = 101, Name = "Ramu" });
        //    employees.Add(new Employee() { Id = 102, Name = "Somu" });
        //    employees.Add(new Employee() { Id = 103, Name = "Bimu" });
        //    Console.WriteLine("Enter the employee Id to check if he is present");
        //    int id;
        //    id = Convert.ToInt32(Console.ReadLine());
        //    //Predicate<Employee> check = (e) => e.Id == id;
        //    //Employee employee = employees.Find(check);
        //    Employee employee = employees.Find((e) => e.Id == id);
        //    if (employee != null)
        //    {
        //        Console.WriteLine(employee.Name);
        //    }
        //    else
        //        Console.WriteLine("No such employee");
        //}
        void OtherThings()
        {
            var num1 = 100;
            //num1 = "Helo";//NOt possible
            Console.WriteLine(num1.GetType());
            dynamic num2 = 200;
            Console.WriteLine(num2.GetType());
            num2 = "Welcome";
            Console.WriteLine(num2.GetType());
        }
        static void Main(string[] args)
        {
            //new Program().OtherThings();
            //new Program().ManageEmployee();
            //new Program().AddMethods();
            //new Program().AssignDelegate();
            //Company company = new Company();
            // Employee employee = new Employee() { Id = 101, Name = "Ramu" };
            // company.AssignFunction(employee);
            // company.EmployeeOperation();
            Employee emp = new Employee() { Id = 1 ,Name="abhsgfksjdfkd"};
            bool result = emp.Name.CheckName();
            Console.WriteLine("The result is "+result);
            int oldAge = 15;
            int newAge = oldAge.AgeWork();
        }
    }
    
    static class UnderstandExtension
    {
        public static bool CheckName(this string name)
        {
            if (name.Length > 8)
                return true;
            return false;
        }
        public static int AgeWork(this int age)
        {
            if (age > 18)
                return age;
            return (++age);
        }
    }
    //class Calculator
    //{
    //    public void Subtract(int num1, int num2)
    //    {
    //        int result = num1 - num2;
    //        Console.WriteLine("The result of subtraction is "+result);
    //    }
    //}
}