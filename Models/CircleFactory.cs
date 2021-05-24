namespace Models
{
    public class CircleFactory : ShapeFactory
    {
        public override Shape CreateShape()
        {
            //using (var qclient = new QueueServiceReference.QueueServiceClient())
            //{
            //    var circleData = qclient.GetCircle();
            //    return new Circle(circleData.Name,circleData.Diametre,circleData.Id);
            //}
            using (var sClient = new ServiceReferenceShape.ShapeClient())
            {
                var circleData = sClient.GetCircle();
                   return new Circle(circleData.Name,circleData.Diametre,circleData.Id);
               
            }
           // return null;
           
        }
    }
}
