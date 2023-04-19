namespace ThreadingExampleApp
{
    internal class Program
    {
        void Add()
        {
            Console.WriteLine("Add start");
          
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine(sum);
            
        }
        void Product()
        {
           
            double result = 1;
            Console.WriteLine("Start of Product");
            for (int i = 10; i < 100; i=i+10)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
                result *= i;
            }
            Console.WriteLine(result);
        }

        void PrintData()
        {
            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                }
            }
        }
        async Task<int> GetNumber()
        {
            int number = new Random().Next(0, 100);
            Thread.Sleep(5000);
            return number;
        }
        //int GetNumber()
        //{
        //    int number = new Random().Next(0, 100);
        //    Thread.Sleep(5000);
        //    return number;
        //}
        async void PrintNumber()
        {
            int result = await GetNumber();
            Task<int> myTask = GetNumber();
            myTask.Start();
           // int result = myTask.Result;
            //int result = GetNumber();
            result = (result+5)*2 +100;
            Console.WriteLine("Result ="+result);
        }
        async void PrintHello()
        {
            Console.WriteLine("Hello all");
        }
        void Hello()
        {
            Console.WriteLine("Hey all");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.PrintNumber();
            program.PrintHello();
            program.Hello();    
        }
    }
}