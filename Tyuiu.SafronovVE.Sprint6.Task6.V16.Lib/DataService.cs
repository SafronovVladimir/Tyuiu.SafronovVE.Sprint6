using System.Xml;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SafronovVE.Sprint6.Task6.V16.Lib
{
    public class DataService : ISprint6Task6V16
    {
        public string CollectTextFromFile(string path)
        {
            string file = File.ReadAllText(path);
            string[] strings = file.Split(" ");

            string res = "";
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Contains("b"))
                {
                    res += $"{strings[i]} ";
                }

            }
            return res.Trim();
        }
    }
}
