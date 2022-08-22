using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignPattern
{
    // Concrete class
    public class DatabaseAPP : Generics
    {
        public override void Login(string username, string passwd)
        {
            // Implementations or requests
            try
            {
                Console.WriteLine($"Database app logins: {username},{passwd}");
            }catch (Exception e)
            {
                Console.WriteLine("Expected: " + e.Message);
            }
        
        }
    }
}
