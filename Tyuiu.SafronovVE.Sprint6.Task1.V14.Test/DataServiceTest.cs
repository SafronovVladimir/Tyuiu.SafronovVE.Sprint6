using Tyuiu.SafronovVE.Sprint6.Task1.V14.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task1.V14.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void CheckGetMassFunction()
    {
        DataService ds = new DataService();
        int startValue = -5;
        int stopValue = 5;
        int len = stopValue - startValue + 1;
        double[] waitMas = new double[len];
        waitMas[0] = -2.15;
        waitMas[1] = -2.57;
        waitMas[2] = -3;
        waitMas[3] = -3.83;
        waitMas[4] = -11.7;
        waitMas[5] = 3;
        waitMas[6] = 2.19;
        waitMas[7] = 3.31;
        waitMas[8] = 2.97;
        waitMas[9] = 1.18;
        waitMas[10] = 0.03;

        var res = ds.GetMassFunction(startValue, stopValue);

        CollectionAssert.AreEqual(waitMas, res);
    }
}
