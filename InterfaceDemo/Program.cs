using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();

            IPersonManager employeeManager = new EmployeeManager();

            IPersonManager ıntermManager = new InternManager();

            customerManager.Add();
            employeeManager.Update();
            ıntermManager.Delete();
        }
    }
}
