using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignmnent
{
    public class Employee
    {

        public Employee() { }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Department_id { get; set; }
        public int Salary { get; set; }
        public string Technology { get; set; }


        public Employee(string Name, int Age, int Department_id, int Salary, string Technology)
        {
      
            this.Name = Name;
            this.Age = Age;
            this.Department_id = Department_id;
            this.Salary = Salary;
            this.Technology = Technology;

        }
    }

}
