using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignmnent
{
    public class Update
    {

        Validation Validation = new Validation();
        public void Update_Details()
        {

            using (var Context = new EmployeeContext())
            {

                Console.WriteLine("Enter the index you want to Update :");
                var Update_Index = int.Parse(Console.ReadLine());


                var itemToUpdate = Context.Employees.FirstOrDefault(x => x.Id == Update_Index);

                if (itemToUpdate == null)
                {

                    Console.WriteLine("data not found in the database");
                }
                else
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


                    itemToUpdate.Name = name;
                    itemToUpdate.Age = age;
                    itemToUpdate.Department_id = Department_id;
                    itemToUpdate.Salary = salary;
                    itemToUpdate.Technology = Technology;
                }

                Context.SaveChanges();

            }
        }
    }
}
