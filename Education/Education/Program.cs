using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 110,
                Name = "Ken",
                salary = 5500
            };

            Customer customer2 = new Customer()
            {
                ID = 111,
                Name = "Barbie",
                salary = 4500
            };

            Customer customer3 = new Customer()
            {
                ID = 112,
                Name = "Prince",
                salary = 4500
            };

            List<Customer> customers = new List<Customer>(2);
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            Customer c = customers[0];

            Console.WriteLine("ID={0}, Name={1}, Salar]{2}",c.ID,c.Name,c.salary);
        }

        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int salary { get; set; }

            public Customer()
            {

            }
        }
    }
}
