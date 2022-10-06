using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_No7
{
    public class program2
    {
        static void Main(string[] args)
        {
            Department d1 = new Department();
            d1.Id = 1;
            d1.Name = "computer";
            d1.Location = "pune";

            Console.WriteLine($"{d1.Id} {d1.Name} {d1.Location}");

            Department d2 = new Department { Id = 2, Name = "science", Location = "mumbai" };
            Console.WriteLine($"{d2.Id} {d2.Name} {d2.Location}");
        }
    }
}
