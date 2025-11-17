using Tyuiu.SafronovVE.Sprint6.Task3.V20.Lib;
namespace Tyuiu.SafronovVE.Sprint6.Task3.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                {-14, 17, -19, 3, 2 },
                {-4, -14, -19, -9, -1 },
                {1, 0, 13, 14, 8 },
                {13, 7, 8, -3, -15 },
                {2, -20, 12, -14, 4 }
            };
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1;

            int[] values = [-14, 17, -19, 3, 2, -4, -14, -19, -9, -1, 1, 0, 13, 14, 8, 13, 7, 8, -3, -15, 2, -20, 12, -14, 4];

            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = values[index++];
                }
            }

            var resMatrix = ds.Calculate(matrix);
            var waitMatrix = matrix;

            waitMatrix[4, 0] = 0;
            waitMatrix[4, 1] = 0;
            waitMatrix[4, 2] = 0;
            waitMatrix[4, 3] = 0;
            waitMatrix[4, 4] = 0;

            CollectionAssert.AreEqual(resMatrix, waitMatrix);
        }
    }
}
