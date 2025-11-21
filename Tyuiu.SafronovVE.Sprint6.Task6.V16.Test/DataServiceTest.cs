using Tyuiu.SafronovVE.Sprint6.Task6.V16.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = Path.Combine($@"{Directory.GetCurrentDirectory()}", "InPutDataFileTask6V16.txt");
            string res = "brIBPtX bWk";
            string wait = ds.CollectTextFromFile(path);
            Assert.AreEqual(res, wait);
        }
    }
}
