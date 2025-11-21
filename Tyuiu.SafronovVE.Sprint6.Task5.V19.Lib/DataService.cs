using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SafronovVE.Sprint6.Task5.V19.Lib
{
    public class DataService : ISprint6Task5V19
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] strings = File.ReadAllLines(path);
            var len = strings.Length;
            double[] doubles = new double[len];

            for (int i = 0; i < len; i++)
            {
                doubles[i] = Double.Parse(strings[i]);
            }
            return doubles;
        }
    }
}
