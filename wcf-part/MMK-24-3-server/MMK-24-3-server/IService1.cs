using System.Drawing;
using System.ServiceModel;

namespace MMK_24_3_server
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        double[] GetData(float r, float k, float b, float delta, float rectSquare, float square, Point C, Point D, int iterations);
        [OperationContract]
        float GetRealSquare(Point C, Point D);
        [OperationContract]
        float[] GetSomeData(Point C, Point D);
    }
}
