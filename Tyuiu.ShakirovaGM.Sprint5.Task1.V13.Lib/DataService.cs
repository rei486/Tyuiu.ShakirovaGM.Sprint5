using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ShakirovaGM.Sprint5.Task1.V13.Lib
{
    public class DataService : ISprint5Task1V13
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            //$@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt"
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
           if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string stry;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) + x == 0)
                    y = 0;
                else
                    y =Math.Round(((2*x-3)/(Math.Cos(x)+x)+5),2);
                stry = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, stry+Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, stry);
                }
            }
            return path;
        }
    }
}
