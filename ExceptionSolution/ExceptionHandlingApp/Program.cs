using System.Net.Cache;

namespace ExceptionHandlingApp
{


    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
       void UnderstadDeconstruction()
        {
            var myData = (Name: "Ramu", Age: 23, Gender: "M", Salary: 2343.5);
            var (username, age,_,_) = myData;
            Console.WriteLine(username);
        }
        static void Main(string[] args)
        {
           new Program().UnderstadDeconstruction();
        }
    }
}
