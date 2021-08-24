using System;

namespace AutoMappingDotnet.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Gender { get; set; }
    }
}
