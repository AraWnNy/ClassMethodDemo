using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager();
            Customer c1 = new Customer {
                name = "Fikret",
                surname = "Gözütok",
                id = "12323222",
                address = "Kütahya"};

            Customer c2 = new Customer
            {
                name = "İsmail",
                surname = "Demir",
                id = "111122233323",
                address = "Tavşanlı"
            };

            manager.deleteCustomer(c1);
            manager.addCustomer(c2);
            manager.getCustomerData(c2);



            Console.Read();

        }
    }
}
