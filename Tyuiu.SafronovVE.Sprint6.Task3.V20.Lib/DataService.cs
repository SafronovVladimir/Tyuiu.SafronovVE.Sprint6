using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SafronovVE.Sprint6.Task3.V20.Lib
{
    public class DataService : ISprint6Task3V20
    {
        public int[,] Calculate(int[,] matrix)
        {
            int col = matrix.GetLength(1);
            for (int i = 0; i < col; i++)
            {
                if (Math.Abs(matrix[4, i]) % 2 == 0)
                {
                    matrix[4, i] = 0;
                }
            }

            return matrix;
        }
    }
}
