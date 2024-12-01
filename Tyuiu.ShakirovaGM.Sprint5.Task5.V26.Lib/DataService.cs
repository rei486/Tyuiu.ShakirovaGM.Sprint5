using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShakirovaGM.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX.Replace(".", ","));
            double res = Math.Round(((Math.Sin(x) + 4) / x - 1.25 * x), 3);
            return res;
        }
    }
}
