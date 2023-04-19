using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FileAppliaction
{
    [Serializable]
    public class Employee:ISerializable
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public Employee()
        {
            
        }
        public Employee(SerializationInfo info, StreamingContext context)
        {
            this.Id = Convert.ToInt32(info.GetValue("Id", typeof(int)).ToString());
            this.Name = info.GetValue("Name", typeof(int)).ToString();
            this.Age = Convert.ToInt32(info.GetValue("Age", typeof(int)).ToString());
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", this.Id);
            info.AddValue("Name", this.Name);
            info.AddValue("Age", this.Age);
        }
        public override string ToString()
        {
            return "Id " + Id + " Name " + Name + " Age " + Age;
        }
    }
}
