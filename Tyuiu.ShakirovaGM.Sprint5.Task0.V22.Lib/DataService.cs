using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ShakirovaGM.Sprint5.Task0.V22.Lib
{
    public class DataService : ISprint5Task0V22
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = (Math.Pow((1 - x), 2)) / (-3 * x);
            z = Math.Round(z, 3);
            File.WriteAllText(path,Convert.ToString(z));
            return path;
        }
    }
}
