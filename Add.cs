using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignmnent
{
    public class Add
    {
        Validation Validation = new Validation();   

        public void Add_data()
        {     
            Console.WriteLine("enter the name :");
            var name = Validation.checkname(Console.ReadLine());
            Console.WriteLine("enter the age :");           
            var age = Validation.Age();
            Console.WriteLine("enter the department id :");
            var Department_id = Validation.Age();
            Console.WriteLine("enter the salary :");
            var salary = Validation.Age();    
            Console.WriteLine("enter the technology :");
            var Technology = Validation.checkname(Console.ReadLine());

            Employee add_to = new Employee( name, age, Department_id, salary, Technology);

        
            using (EmployeeContext EMP = new  EmployeeContext())
            {

               EMP.Employees.Add(add_to);

                EMP.SaveChanges();
            }
        }
    }
}
