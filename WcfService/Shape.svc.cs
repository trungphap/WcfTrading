using System;
using WcfService.Data;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Shape" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Shape.svc or Shape.svc.cs at the Solution Explorer and start debugging.
    public class Shape : IShape
    {
        public Circle GetCircle()
        {
            Random rnd = new Random();
            return new Circle()
            {
                Diametre = rnd.Next(1, int.MaxValue),
               Name = "Circle",
               Id = rnd.Next(1, 1000)
            };
        }
    }
}
