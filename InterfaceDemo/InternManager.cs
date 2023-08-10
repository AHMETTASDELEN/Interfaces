using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern added");
        }

        public void Delete()
        {
            Console.WriteLine("Intern deleted");
        }

        public void Update()
        {
            Console.WriteLine("Intern updated");
        }
    }
}
