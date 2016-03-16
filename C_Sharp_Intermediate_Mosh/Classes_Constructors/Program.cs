using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);

            customer.Orders.Add(new Order { Id = 1, Title = "Order 1" });
                                    
            Console.WriteLine(customer.Id);  
            Console.WriteLine(customer.Name);
            
        }
    }
}
