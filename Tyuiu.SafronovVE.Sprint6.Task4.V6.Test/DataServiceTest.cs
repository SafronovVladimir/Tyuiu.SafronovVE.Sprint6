using Tyuiu.SafronovVE.Sprint6.Task4.V6.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] waitArray = new double[len];

            waitArray[0] = 23.92;
            waitArray[1] = 18.88;
            waitArray[2] = 13.1;
            waitArray[3] = 7.24;
            waitArray[4] = 1.8;
            waitArray[5] = -8;
            waitArray[6] = -5.7;
            waitArray[7] = -11.26;
            waitArray[8] = -17.12;
            waitArray[9] = -22.88;
            waitArray[10] = -27.92;

            var resArray = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(resArray, waitArray);
        }
    }
}
