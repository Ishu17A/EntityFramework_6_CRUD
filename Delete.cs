using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignmnent
{
    public class Delete
    {
        public void Delete_details()
        {
            Console.WriteLine("Enter the index you want to Delete :");
            var Index_no = int.Parse( Console.ReadLine());

            using ( var Context = new EmployeeContext())
            {
                var itemToRemove = Context.Employees.SingleOrDefault(x => x.Id == Index_no); 

                if (itemToRemove == null)
                {


                    Console.WriteLine("data not found in the database for delete");
                }
                else
                {

                    Context.Employees.Remove(itemToRemove);
                    Context.SaveChanges();
                }

            }
        }
    }
    
}
