using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SafronovVE.Sprint6.Task5.V19.Lib;

public class DataService : ISprint6Task5V19
{
    public double[] LoadFromDataFile(string path)
    {
        string[] strings = File.ReadAllLines(path);
        var len = strings.Length;

        int k = 0;
        for (int i = 0; i < len; i++)
        {
            double value = Double.Parse(strings[i]);
            if (double.IsInteger(value))
            {
                k++;
            }
        }

        double[] res = new double[k];

        int index = 0;

        for (int i = 0; i < strings.Length; i++)
        {
            double value = Double.Parse(strings[i]);
            if (Double.IsInteger(value))
            {
                res[index++] = value;
            }
        }

        return res;
    }
}
