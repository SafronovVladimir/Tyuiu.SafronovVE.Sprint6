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
            
            waitArray[0] = -17;
            waitArray[1] = 0;
            waitArray[2] = 12;
            waitArray[3] = -14.32;
            waitArray[4] = 5;
            waitArray[5] = -7.84;
            waitArray[6] = 12.89;
            waitArray[7] = -1.57;
            waitArray[8] = -3.64;
            waitArray[9] = -13.26;
            waitArray[10] = -8.91;
            waitArray[11] = -17.77;
            waitArray[12] = 35;
            waitArray[13] = -9;
            waitArray[14] = 13.83;
            waitArray[15] = 12.76;
            waitArray[16] = 8.86;
            waitArray[17] = 0;
            waitArray[18] = -1.49;
            waitArray[19] = -7;

            CollectionAssert.AreEqual(waitArray, resArray);
        }
    }
}
