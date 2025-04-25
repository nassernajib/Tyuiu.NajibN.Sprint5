using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.NajibN.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double LoadFromDataFile(string path)
        {
            int i = 1;
            double res = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string lines = line.Replace('.', ',');
                    string[] linearray = lines.Split(' ');

                    foreach (string number in linearray)
                    {
                        double lineParse = double.Parse(number);

                        if (lineParse % 2 == 0)
                        {
                            if (lineParse > 0)
                            {
                                while (i <= lineParse)
                                {
                                    res = res * i;
                                    i++;
                                }
                            }

                        }

                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}
