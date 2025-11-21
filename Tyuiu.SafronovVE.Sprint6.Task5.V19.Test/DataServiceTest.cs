using Tyuiu.SafronovVE.Sprint6.Task5.V19.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task5.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            DataService ds = new DataService();
            
            string path = Path.Combine($@"{Directory.GetCurrentDirectory()}", "InPutDataFileTask5V19.txt");
            var resArray = ds.LoadFromDataFile(path);
            double[] waitArray = new double[resArray.Length];
            
            waitArray[0] = -17.0;
            waitArray[1] = 0.0;
            waitArray[2] = 12.0;
            waitArray[3] = 5.0;
            waitArray[4] = 35.0;
            waitArray[5] = -9.0;
            waitArray[6] = 0.0;
            waitArray[7] = -7.0;

            CollectionAssert.AreEqual(waitArray, resArray);
        }
    }
}
