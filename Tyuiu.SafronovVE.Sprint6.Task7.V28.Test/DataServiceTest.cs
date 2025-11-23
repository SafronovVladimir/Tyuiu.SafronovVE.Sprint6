using Tyuiu.SafronovVE.Sprint6.Task7.V28.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = "C:\\Users\\safro\\Downloads\\InPutDataFileTask7V28.csv";
            var matrix = ds.GetMatrix(path);
            var waitMass = ds.GetMatrix(path);
            waitMass[6, 0] = 0;
            waitMass[6, 1] = 0;
            waitMass[6, 2] = 0;
            waitMass[6, 3] = 0;
            waitMass[6, 4] = 0;
            waitMass[6, 5] = 0;
            waitMass[6, 7] = 0;
            waitMass[6, 8] = 0;
            waitMass[6, 9] = 0;
            var resMass = ds.TransformMatrix(matrix);
            CollectionAssert.AreEqual(resMass, waitMass);
        }
    }
}
