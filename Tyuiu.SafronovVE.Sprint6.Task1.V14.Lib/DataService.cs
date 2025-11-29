using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SafronovVE.Sprint6.Task1.V14.Lib;

public class DataService : ISprint6Task1V14
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        int len = stopValue - startValue + 1;
        double[] mas = new double[len];
        int count = 0;
        for (int x = startValue; x <= stopValue; x++)
        {
            mas[count] = Math.Round((2 * x + 6) / (Math.Cos(x) + x) - 3, 2);
            count++;
        }
        return mas;
    }
}
