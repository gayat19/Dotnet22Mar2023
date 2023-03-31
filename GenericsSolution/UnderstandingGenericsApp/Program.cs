namespace UnderstandingGenericsApp
{
    internal class Program
    {
        void UnderstandingGeneric()
        {
            List<int> numbers = new List<int>();
            numbers.Add(100);
            numbers.Add(90);
            numbers.Add(45);
            int sum = 0;
            foreach (int i in numbers)
            {
                sum+= i;
            }
            numbers.Sort();
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(sum);
            //numbers.Add("Hello");//Any other type not allowed
        }
        void UnderstandingEmployeeList()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id=101,Name="Ramu",Age=22});
            employees.Add(new Employee(102, "Bimu", 32));
            Employee employee = new Employee();
            employee.Id = 103;
            employee.Name = "Somu";
            employee.Age = 23;
            employees.Add(employee);
            employees.Sort(new SortByName());
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The second element in the employees list is ");
            Console.WriteLine(employees[1]);
        }
        void UnderstandingDictionary()
        {
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>()
            {
                {101, new Employee() { Id=101,Name="Ramu",Age=22}},
                {102, new Employee() { Id=102,Name="Somu",Age=67}}
            };
            employees.Add(103, new Employee(103, "Bimu", 41));
            foreach (var item in employees.Keys)
            {
                Console.WriteLine(employees[item]);
            }
        }
        void UnderstandingQueue()
        {
            Queue<Employee> empQueue = new Queue<Employee>();
            empQueue.Enqueue(new Employee(1, "Geeta", 23));
            empQueue.Enqueue(new Employee(2, "Sita", 13));
            empQueue.Enqueue(new Employee(3, "Anita", 21));
            Console.WriteLine(empQueue.Dequeue());
        }
        void UnderstandingSet()
        {
            Queue<Employee> empQueue = new Queue<Employee>();
            empQueue.Enqueue(new Employee(1, "Geeta", 23));
            empQueue.Enqueue(new Employee(2, "Sita", 13));
            empQueue.Enqueue(new Employee(3, "Anita", 21));
            SortedSet<Employee> employees = new SortedSet<Employee>();
            int count = empQueue.Count;
            for (int i = 0; i < count; i++)
            {
                employees.Add(empQueue.Dequeue());
            }
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
        void CheckEqual()
        {
            Employee employee1 = new Employee(1, "Geeta", 23);
            Employee employee2 = new Employee(1, "Geeta", 23);
            if(employee1.Equals( employee2))//comparing the refference
            {
                Console.WriteLine("The same");
            }
            else
                Console.WriteLine("Notthe same");

        }
        void UnderstandingSortedList()
        {
            SortedList<int,string> keyValuePairs = new SortedList<int,string>();
            keyValuePairs.Add(103, "Gomu");
            keyValuePairs.Add(102, "Bimu");
            keyValuePairs.Add(101, "Ramu");
            keyValuePairs.Add(100, "Pomu");
            foreach (var item in keyValuePairs.Keys)
            {
                Console.WriteLine(item+" " + keyValuePairs[item]);
            }
          
            Console.WriteLine(keyValuePairs[100]);
        }
        static void Main(string[] args)
        {
            //new Program().UnderstandingGeneric();
            new Program().UnderstandingEmployeeList();
            //new Program().UnderstandingDictionary();
            //new Program().UnderstandingQueue();
            // new Program().UnderstandingSet();
            //new Program().CheckEqual();
            //new Program().UnderstandingSortedList();
        }
    }
}