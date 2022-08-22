using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPattern
{
    public class Employee
    {
        /// <summary>
        /// Type interfaces or members
        /// </summary>
        public string firstName;
        public string lastName;
        public List<string> tools;

        public Employee()
        {

        }
        public int MyProperty { get; set; }
    }
}
