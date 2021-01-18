using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void addCustomer(Customer customer)
        {
            Console.WriteLine(String.Format("Müşteri Kaydı Eklendi {0} {1}", customer.name, customer.surname));
        }

        public void deleteCustomer(Customer customer)
        {
            Console.WriteLine(String.Format("Müşteri Kaydı Silindi {0} {1}", customer.name, customer.surname));
        }

        public void getCustomerData(Customer customer)
        {
            Console.WriteLine(String.Format("Müşterinin;\nAdı = {0}\nSoyadı =  {1}\nTC Kimlik No = {2}\nAdres = {3}",customer.name, customer.surname, customer.id, customer.address));
        }
    }
}
