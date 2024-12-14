using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShakirovaGM.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            
            double summ = 0;
            double sump = 0;
           using (StreamReader reader= new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double[] x = 
                        double.Parse(line.Replace(".", ","));
                    if (x % 2 == 0)
                        sump += x;
                    else
                        summ += x;
                }
            }
            double res = Math.Round(sump - summ, 3);
            
            return res;
        }
    }
}
