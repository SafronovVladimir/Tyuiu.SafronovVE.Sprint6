using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SafronovVE.Sprint6.Task4.V6.Lib
{
    public class DataService : ISprint6Task4V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] mas = new double[len];
            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (4 * x - 0.5 == 0)
                {
                    mas[index++] = 0;
                }
                else
                {
                    mas[index++] = Math.Round(3 * Math.Cos(x) / (4 * x - 0.5) + Math.Sin(x) - 5 * x - 2, 2);
                }
            }
            return mas;
        }
    }
}
