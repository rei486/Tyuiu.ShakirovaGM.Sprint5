using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.ComponentModel.Design;
namespace Tyuiu.ShakirovaGM.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {

            string pathTransfer = File.ReadAllText(path);
            string stringValues = pathTransfer;

            string strLine = "";
            foreach (char c in stringValues)
            {
                if (!char.IsDigit(c))
                {
                    strLine += c;
                }
            }
           
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V1.txt");
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine(strLine);
            }
            return outputFile;
        }
    }
}
