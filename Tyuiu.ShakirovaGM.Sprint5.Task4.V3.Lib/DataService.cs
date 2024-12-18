﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ShakirovaGM.Sprint5.Task4.V3.Lib
{
    public class DataService : ISprint5Task4V3
    {
        public double LoadFromDataFile(string path)
        {
            string strX=File.ReadAllText(path);
            double x = double.Parse(strX.Replace(".",","));
            double res = Math.Round(((Math.Sin(x)+4)/x-1.25*x),3);
            return res;
        }
    }
}
