using Tyuiu.SafronovVE.Sprint6.Task0.V24.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            int x = 3;
            var wait = 1024;
            var res = ds.Calculate(x);
            Assert.AreEqual(res, wait);
        }
    }
}
