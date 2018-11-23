using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Employee
    {
        [DataMember(Name="id")]
        public int Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "salary")]
        public string Salary { get; set; }
        [DataMember(Name = "department")]
        public string Department { get; set; }
    }
}
