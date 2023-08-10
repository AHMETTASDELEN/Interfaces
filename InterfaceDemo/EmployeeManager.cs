using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee added");
        }

        public void Delete()
        {
            Console.WriteLine("Employee deleted");
        }

        public void Update()
        {
            Console.WriteLine("Employee updated");
        }
    }
}
