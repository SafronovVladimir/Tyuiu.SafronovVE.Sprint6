using System.Data;
using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SafronovVE.Sprint6.Task7.V28.Lib
{
    public class DataService : ISprint6Task7V28
    {
        public int[,] GetMatrix(string path)
        {
            string[] strings = File.ReadAllLines(path);

            int rows = strings.GetUpperBound(0) + 1;
            int cols = strings[0].Split(';').GetUpperBound(0) + 1;

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = Int32.Parse(strings[i].Split(";")[j]);
                }
            }

            for (int j = 0; j < cols; j++)
            {
                if (result[6, j] != 13)
                {
                    result[6, j] = 0;
                }
            }

            return result;
        }


    }
}
