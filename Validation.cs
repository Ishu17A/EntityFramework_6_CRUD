using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EF_Assignmnent
{
    public class Validation
    {
        public string checkname(string name)
        {
            while (!Regex.Match(name, "^[A-Za-z\\s]+$").Success)
            {
                Console.WriteLine("Invalid input ");
                name = Console.ReadLine();

            }
            return name;
        }


        public int Age()
        {
            int Age;
            while (!int.TryParse(Console.ReadLine(), out Age))
            {
                Console.WriteLine("enter the valid input pls");
            }
            return Age;
        }

    }
}
