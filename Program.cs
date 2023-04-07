using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignmnent
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                int input1;
                Console.WriteLine("Please press " + "\n" +
                 "1-ADD" + "\n" +
                 "2-SHOW" + "\n" +
                 "3-DELETE" + "\n" +
                 "4-UPDATE"
                 );

                while (!int.TryParse(Console.ReadLine(), out input1))
                {
                    Console.WriteLine("NOT The valid ");
                }

                switch (input1)
                {
                    case 1:
                        {
                            Console.WriteLine("Add");
                            Add add = new Add();
                            add.Add_data();
                            break;

                        }
                    case 2:
                        {

                            Console.WriteLine("Show");
                            Show Show = new Show();
                            Show.Show_Details();
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine("Delete");
                            Delete delete = new Delete();
                            delete.Delete_details();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Update");
                            Update update = new Update();
                            update.Update_Details();
                            break;

                        }
                    default:
                        Console.WriteLine("Enter the Valid Input");
                        break;
                }


                Console.ReadLine();
            }
        }
    }
}
