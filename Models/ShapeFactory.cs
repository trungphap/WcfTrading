using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class ShapeFactory
    {
        public abstract Task<Shape> CreateShape();       
      
    }
}
