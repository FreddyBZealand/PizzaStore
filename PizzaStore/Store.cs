using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Store

    {
        public void Start()

        {

          

            Pizza firstPizza = new Pizza("Margheritta", 68);
            Pizza secondPizza = new Pizza("Pepperoni", 78);
            Pizza thirdPizza = new Pizza("Ham", 72);

            Customer firstCustomer = new Customer("Anders", "HrHansen@mail.dk", 2040608020);
            Customer secondCustomer = new Customer("Lucas","Lucas@mail.dk", 10305070);
            Customer thirdCustomer = new Customer("Mikki","Mikki@mikki.dk", 12203042);


            Order firstOrder = new Order(firstPizza, firstCustomer);
            Order secondOrder = new Order( secondPizza, secondCustomer);
            Order thirdOrder = new Order(thirdPizza, thirdCustomer);

           

            

            Console.WriteLine($"Første ordre, {firstOrder.ToString()}");
            
            Console.WriteLine($"anden ordre {secondOrder.ToString()}");

            Console.WriteLine($"tredje ordre {thirdOrder.ToString()}");




        }






    }
}
