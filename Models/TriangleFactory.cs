using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TriangleFactory : ShapeFactory
    {
        public async override Task<Shape> CreateShape()
        {
            return await Task.Run( ()=>  new Triangle());           
        }
    }
}
