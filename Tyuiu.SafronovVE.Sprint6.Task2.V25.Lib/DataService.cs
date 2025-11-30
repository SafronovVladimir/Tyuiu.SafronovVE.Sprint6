using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SafronovVE.Sprint6.Task2.V25.Lib
{
    public class DataService : ISprint6Task2V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;

            double[] mas = new double[len];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y = (5 * x + 2.5) / (Math.Sin(x) - 2) + 2;
                mas[index++] = Math.Round(y, 2);
            }

            return mas;
        }
    }
}
