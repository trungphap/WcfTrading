using System.Threading.Tasks;

namespace Models
{
    public class CircleFactory : ShapeFactory
    {
        public override async Task<Shape> CreateShape()
        {
            using (var sClient = new ServiceReferenceShape.ShapeClient())
            {
                var circleData = sClient.GetCircle();
                   return await Task.Run(()=>   new Circle(circleData.Name,circleData.Diametre,circleData.Id));
               
            }           
        }
    }
}
