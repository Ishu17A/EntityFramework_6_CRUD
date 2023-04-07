using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignmnent
{
    public class Show
    {

        public void Show_Details()
        {
            try
            {
                using (var context = new EmployeeContext())
                {
                    Console.WriteLine("Id" + "\t" + "Name" + "\t" + "Age" + "\t" + "Department_id" + "\t" + "Salary" + "\t" + "Technology");

                    foreach (Employee emp in context.Employees.ToList())
                    {
                        Console.WriteLine($"{emp.Id}    {emp.Name}    {emp.Age}   {emp.Department_id}    {emp.Salary}   {emp.Technology}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
