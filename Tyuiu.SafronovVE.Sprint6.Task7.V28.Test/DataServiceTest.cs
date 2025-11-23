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

            string[] strings = File.ReadAllLines(path);

            int rows = strings.GetUpperBound(0) + 1;
            int cols = strings[0].Split(';').GetUpperBound(0) + 1;

            int[,] waitMatrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    waitMatrix[i, j] = Int32.Parse(strings[i].Split(";")[j]);
                }
            }

            waitMatrix[6, 0] = 0;
            waitMatrix[6, 1] = 0;
            waitMatrix[6, 2] = 0;
            waitMatrix[6, 3] = 0;
            waitMatrix[6, 4] = 0;
            waitMatrix[6, 5] = 0;
            waitMatrix[6, 7] = 0;
            waitMatrix[6, 8] = 0;
            waitMatrix[6, 9] = 0;
            var resMatrix = ds.GetMatrix(path);
            CollectionAssert.AreEqual(resMatrix, waitMatrix);
        }


    }
}

