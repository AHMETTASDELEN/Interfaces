using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            IPersonManager ınternManager = new InternManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            
            
        }
    }



    interface IPersonManager 
    {
        void Add();
        void Update();
    }




    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer added");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee added");
        }

        public void Update()
        {
            Console.WriteLine("Employee updated");
        }    
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern added");
        }

        public void Update()
        {
            Console.WriteLine("Intern updated");
        }
    }



    class ProjectManager 
    {
        public void Add(IPersonManager personManager) 
        {
            personManager.Add();
        }
    }
}
