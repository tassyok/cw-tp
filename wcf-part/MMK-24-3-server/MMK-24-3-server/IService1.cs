using System.Drawing;
using System.ServiceModel;

namespace MMK_24_3_server
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        double[] GetData(float r, float k, float b, float delta, float rectSquare, float square, PointF C, PointF D, int iterations);
        [OperationContract]
        float GetRealSquare(PointF C, PointF D);
        [OperationContract]
        float[] GetSomeData(PointF C, PointF D);
    }
}
