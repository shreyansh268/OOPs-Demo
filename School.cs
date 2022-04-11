using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class School
    {
        public School() { 
        
            
        }       

        public void GetToppersOfClass(SchoolClass className)
        {
            Console.WriteLine("Get toppers of class ");
            Array.ForEach(className.GetToppers().ToArray(), Console.WriteLine);
        }
    }
}
