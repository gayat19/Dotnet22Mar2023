using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    internal class Departmnet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void TakeDepatmentDetails()
        {
            Console.WriteLine("Please enter the detaprtment Id");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "Please enter the department name");
            Name = Console.ReadLine();
        }
        public void PrintDetprtmnetDeails()
        {
            Console.WriteLine("Departmnet Id {0}\nDepartmnet Name {1}",Id,Name);
        }
    }
}
