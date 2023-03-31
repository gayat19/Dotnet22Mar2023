using System.Collections;
using System.Runtime.CompilerServices;

namespace UnderstandingOOPSApp
{
    internal class Program
    {
        static void CompanyProjects(IProjectWorking working)
        {
            working.StartProject();
            working.AssignEmployee(new Employee(101, "Ramu", 34));
            working.CompleteProject();
            //working.StopProject();//will not work- It is not abstracted
        }
        static void ManagerJob(IManageProject manage)
        {
            manage.CheckStatus();
            manage.ChangeScope();
            manage.CheckStatus();
            manage.StopProject();
        }
        void UnderstandingCollection()
        {
            ArrayList scores = new ArrayList();
            scores.Add(98);//boxing - value to reff type
            scores.Add("Eighty");
            scores.Add(77.4f);
            scores.Add(44.5);
            scores.Add(new { Id = 101 });
            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }
            double sum = 0;
            foreach (var item in scores)
            {
                sum += double.Parse(item.ToString());//unboxing - reff to value type
            }
        }
        void UnderstandingArrayList()
        {
            ArrayList scores = new ArrayList();
            scores.Add(98);
            scores.Add("Eighty");
            scores.Add(77.4f);
            scores.Add(44.5);
            scores.Add(new { Id = 101 });
            //Console.WriteLine(scores[2]);
            Console.WriteLine("Number of values in scores "+scores.Count);
            for (int i = 0; i < scores.Count; i++)
            {
                Console.WriteLine(scores[i]);
            }
            scores.Add(100);
            Console.WriteLine("Number of values in scores after adding more " + scores.Count);
            //scores.RemoveAt(2);
            scores.Remove(77.4f);
            Console.WriteLine("After remove");
            for (int i = 0; i < scores.Count; i++)
            {
                Console.WriteLine(scores[i]);
            }
        }
        void UnderstandingSHashTable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(101, "Ramu");
            hashtable.Add(102, "Somu");
            hashtable.Add(103, "Bimu");
            hashtable.Add(104, "Komu");
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(hashtable[item]);
            }
            Console.WriteLine("Is the key 102 present?? "+hashtable.ContainsKey(101));
            Console.WriteLine("Does it have Bimu in the values?? "+hashtable.ContainsValue("Bimu"));
        }
        void UnderstandingStack()
        {
            Stack myStack = new Stack();
            myStack.Push("One");
            myStack.Push(2);
            myStack.Push(3.0);
            Console.WriteLine("The first value to come out is "+myStack.Pop());
        }
        void UnderstandingQueue()
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue("One");
            myQueue.Enqueue(2);
            myQueue.Enqueue(3.0);
            Console.WriteLine("The first value to come out is " + myQueue.Dequeue());
            Console.WriteLine("The count after dequeue is "+myQueue.Count);
        }
        static void Main(string[] args)
        {
            //Project p1 = new Project();//Cannot instantiate an abstract class
            //Project p1 = new ProjectChange();
            ////p1.StopProject();
            //CompanyProjects(p1);
            //ManagerJob(p1);
            //new Program().UnderstandingCollection();
            //new Program().UnderstandingArrayList();
            //new Program().UnderstandingSHashTable();
            //new Program().UnderstandingStack();
            new Program().UnderstandingQueue();
        }
    }
}