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
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}