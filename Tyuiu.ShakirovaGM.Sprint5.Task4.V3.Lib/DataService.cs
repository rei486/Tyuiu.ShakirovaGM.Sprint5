using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ShakirovaGM.Sprint5.Task4.V3.Lib
{
    public class DataService : ISprint5Task4V3
    {
        public double LoadFromDataFile(string path)
        {
            string strX=File.ReadAllText(path);
            double res = Math.Round(Math.Pow((Convert.ToDouble(strX) - 1), (3 * Convert.ToDouble(strX) + 1)), 3);
            return res;
        }
    }
}
