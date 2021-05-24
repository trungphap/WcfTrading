using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RegtangleFactory : ShapeFactory
    {
        public override async Task<Shape> CreateShape()
        {
            return await Task.Run(() => new Rectangle());          
        }
    }
}
