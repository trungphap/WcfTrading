using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new ServiceReference1.ShapeClient();
            var s = c.GetCircle();
            Console.WriteLine("diametre =" +s.Diametre +"name= "+ s.Name +" id= " + s.Id);
            Console.ReadLine();
        }
    }
}
