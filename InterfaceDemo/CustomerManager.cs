using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer added");
        }

        public void Delete()
        {
            Console.WriteLine("Customer deleted");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated");
        }
    }
}
