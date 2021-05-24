using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Circle : Shape
    {
        public Circle(string name, int diametre, int id)
        {           
            Diametre = diametre;
            Name = name;
            Id = id;
        }

        public int Diametre { get; set; }
        public override string ToString() => $"Diametre = {Diametre}";
    }
}
