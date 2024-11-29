using Tyuiu.ShakirovaGM.Sprint5.Task0.V22.Lib;
using System.IO;
using System.Diagnostics;
namespace Tyuiu.ShakirovaGM.Sprint5.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Пользователь\source\repos\Tyuiu.ShakirovaGM.Sprint5\Tyuiu.ShakirovaGM.Sprint5.Task0.V22\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}